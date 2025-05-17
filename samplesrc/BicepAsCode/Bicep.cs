using System.Net;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.ApplicationInsights;
using Azure.Provisioning.AppService;
using Azure.Provisioning.OperationalInsights;
using Azure.Provisioning.PostgreSql;
using Azure.Provisioning.Resources;

namespace BicepAsCode;

public static class Bicep
{
	public static Infrastructure GetInfrastructureWithResources(string deploymentEnvironment)
	{
		const string applicationName = "exampleapplication";
		const string databaseName = "ExampleDatabaseName";
		const string postgresFlexibleServerEntraAdminGroupName = "postgres-entra-admin-group";
		var postgresFlexibleServerEntraAdminGroupId = Guid.Parse("86347bed-76ce-4c45-a6f0-6eb2e9e6a5a3");

		var azureTenantId = Guid.Parse("2fd74995-d27a-4021-b909-56d4939c4f38");

		var resourceLocation = AzureLocation.AustraliaEast;

		var resourceGroup = new ResourceGroup("resourceGroup")
		{
			Name = $"rg-{applicationName}-{deploymentEnvironment}",
			Location = AzureLocation.AustraliaEast
		};

		var logAnalyticsWorkspace = new OperationalInsightsWorkspace("logAnalyticsWorkspace")
		{
			Name = $"log-{applicationName}-{deploymentEnvironment}",
			Location = resourceLocation,
			Identity = new ManagedServiceIdentity { ManagedServiceIdentityType = ManagedServiceIdentityType.SystemAssigned },
			Sku = new OperationalInsightsWorkspaceSku { Name = OperationalInsightsWorkspaceSkuName.PerGB2018 },
			WorkspaceCapping = new OperationalInsightsWorkspaceCapping { DailyQuotaInGB = 1 }
		};

		var applicationInsights = new ApplicationInsightsComponent("applicationInsights")
		{
			Name = $"appi-{applicationName}-{deploymentEnvironment}",
			Location = resourceLocation,
			Kind = "web",
			ApplicationType = ApplicationInsightsApplicationType.Web,
			WorkspaceResourceId = logAnalyticsWorkspace.Id
		};

		var appServicePlan = new AppServicePlan("appServicePlan")
		{
			Name = $"plan-{applicationName}-{deploymentEnvironment}",
			Location = resourceLocation,
			Kind = "linux",
			IsReserved = true,
			Sku = new AppServiceSkuDescription { Name = "B1" }
		};

		var appService = new WebSite("appService")
		{
			Name = $"app-{applicationName}-{deploymentEnvironment}",
			Location = resourceLocation,
			Identity = new ManagedServiceIdentity { ManagedServiceIdentityType = ManagedServiceIdentityType.SystemAssigned },
			AppServicePlanId = appServicePlan.Id,
			SiteConfig = new SiteConfigProperties
			{
				IsAlwaysOn = true,
				LinuxFxVersion = "DOTNETCORE|9.0", AppSettings =
				[
					new AppServiceNameValuePair { Name = "WEBSITE_RUN_FROM_PACKAGE", Value = "1" },
					new AppServiceNameValuePair { Name = "ApplicationInsights__ConnectionString", Value = applicationInsights.ConnectionString },
					new AppServiceNameValuePair { Name = "DatabaseConfig__ConnectionString", Value = $"Host=psql-{applicationName}-{deploymentEnvironment}.postgres.database.azure.com;Port=5432;Database={databaseName};Username={postgresFlexibleServerEntraAdminGroupName};Ssl Mode=Require;Include Error Detail=true" }
				]
			}
		};

		var frontendStaticWebApp = new StaticSite("frontendStaticWebApp")
		{
			Name = $"stapp-{applicationName}-{deploymentEnvironment}",
			Location = AzureLocation.EastAsia,
			Sku = new AppServiceSkuDescription { Name = "Free", Size = "Free" },
			RepositoryToken = string.Empty // required otherwise the deploy blows up! yay // https://github.com/Azure/azure-powershell/issues/16594
		};

		var postgresFlexibleServer = new PostgreSqlFlexibleServer("postgresFlexibleServer")
		{
			Name = $"psql-{applicationName}-{deploymentEnvironment}",
			Location = resourceLocation,
			Sku = new PostgreSqlFlexibleServerSku { Name = "Standard_B1ms", Tier = PostgreSqlFlexibleServerSkuTier.Burstable},
			Identity = new PostgreSqlFlexibleServerUserAssignedIdentity { IdentityType = PostgreSqlFlexibleServerIdentityType.SystemAssigned },
			CreateMode = PostgreSqlFlexibleServerCreateMode.Default,
			Version = PostgreSqlFlexibleServerVersion.Sixteen,
			Network = new PostgreSqlFlexibleServerNetwork { PublicNetworkAccess = PostgreSqlFlexibleServerPublicNetworkAccessState.Enabled },
			HighAvailability = new PostgreSqlFlexibleServerHighAvailability { Mode = PostgreSqlFlexibleServerHighAvailabilityMode.Disabled },
			Backup = new PostgreSqlFlexibleServerBackupProperties { BackupRetentionDays = 7, GeoRedundantBackup = PostgreSqlFlexibleServerGeoRedundantBackupEnum.Disabled },
			AuthConfig = new PostgreSqlFlexibleServerAuthConfig { ActiveDirectoryAuth = PostgreSqlFlexibleServerActiveDirectoryAuthEnum.Enabled, PasswordAuth = PostgreSqlFlexibleServerPasswordAuthEnum.Disabled},
			Storage = new PostgreSqlFlexibleServerStorage
			{
				StorageSizeInGB = 32,
				AutoGrow = StorageAutoGrow.Disabled,
				StorageType = PostgreSqlFlexibleServersStorageType.PremiumV2LRS,
				Iops = 3000,
				Throughput = 125
			}
		};


		var postgresFlexibleServerEntraAdministrator = new PostgreSqlFlexibleServerActiveDirectoryAdministrator("postgresFlexibleServerEntraAdministrator")
		{
			Parent = postgresFlexibleServer,
			Name = postgresFlexibleServerEntraAdminGroupId.ToString(), // The id of the entra group
			PrincipalName = postgresFlexibleServerEntraAdminGroupName,
			PrincipalType = PostgreSqlFlexibleServerPrincipalType.Group,
			TenantId = azureTenantId
		};

		var postgresAllAzureServicesFirewallRule = new PostgreSqlFlexibleServerFirewallRule("postgresAllAzureServicesFirewallRule")
		{
			Parent = postgresFlexibleServer,
			DependsOn = { postgresFlexibleServerEntraAdministrator }, // Mitigates https://github.com/Azure/azure-postgresql/issues/127
			Name = "AllowAllAzureServicesAndResourcesWithinAzureIps", // This specific name maps to the "Allow public access from any Azure service within Azure to this server" toggle in the Azure portal
			StartIPAddress = IPAddress.Parse("0.0.0.0"),
			EndIPAddress = IPAddress.Parse("0.0.0.0")
		};

		var infrastructure = new Infrastructure();
		infrastructure.Add(appServicePlan);
		infrastructure.Add(appService);
		infrastructure.Add(frontendStaticWebApp);
		infrastructure.Add(logAnalyticsWorkspace);
		infrastructure.Add(applicationInsights);
		infrastructure.Add(postgresFlexibleServer);
		infrastructure.Add(postgresFlexibleServerEntraAdministrator);
		infrastructure.Add(postgresAllAzureServicesFirewallRule);

		return infrastructure;
	}
}
