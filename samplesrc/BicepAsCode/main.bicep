resource appServicePlan 'Microsoft.Web/serverfarms@2024-04-01' = {
  name: 'plan-exampleapplication-prod'
  location: 'australiaeast'
  properties: {
    reserved: true
  }
  kind: 'linux'
  sku: {
    name: 'B1'
  }
}

resource appService 'Microsoft.Web/sites@2024-04-01' = {
  name: 'app-exampleapplication-prod'
  location: 'australiaeast'
  properties: {
    serverFarmId: appServicePlan.id
    siteConfig: {
      linuxFxVersion: 'DOTNETCORE|9.0'
      appSettings: [
        {
          name: 'WEBSITE_RUN_FROM_PACKAGE'
          value: '1'
        }
        {
          name: 'ApplicationInsights__ConnectionString'
          value: applicationInsights.properties.ConnectionString
        }
        {
          name: 'DatabaseConfig__ConnectionString'
          value: 'Host=psql-exampleapplication-prod.postgres.database.azure.com;Port=5432;Database=ExampleDatabaseName;Username=postgres-entra-admin-group;Ssl Mode=Require;Include Error Detail=true'
        }
      ]
      alwaysOn: true
    }
  }
  identity: {
    type: 'SystemAssigned'
  }
}

resource frontendStaticWebApp 'Microsoft.Web/staticSites@2024-04-01' = {
  name: 'stapp-exampleapplication-prod'
  location: 'eastasia'
  properties: {
    repositoryToken: ''
  }
  sku: {
    name: 'Free'
    size: 'Free'
  }
}

resource logAnalyticsWorkspace 'Microsoft.OperationalInsights/workspaces@2025-02-01' = {
  name: 'log-exampleapplication-prod'
  location: 'australiaeast'
  identity: {
    type: 'SystemAssigned'
  }
  properties: {
    sku: {
      name: 'PerGB2018'
    }
    workspaceCapping: {
      dailyQuotaGb: 1
    }
  }
}

resource applicationInsights 'Microsoft.Insights/components@2020-02-02' = {
  name: 'appi-exampleapplication-prod'
  kind: 'web'
  location: 'australiaeast'
  properties: {
    Application_Type: 'web'
    WorkspaceResourceId: logAnalyticsWorkspace.id
  }
}

resource postgresFlexibleServer 'Microsoft.DBforPostgreSQL/flexibleServers@2024-08-01' = {
  name: 'psql-exampleapplication-prod'
  location: 'australiaeast'
  properties: {
    authConfig: {
      activeDirectoryAuth: 'Enabled'
      passwordAuth: 'Disabled'
    }
    backup: {
      backupRetentionDays: 7
      geoRedundantBackup: 'Disabled'
    }
    createMode: 'Default'
    highAvailability: {
      mode: 'Disabled'
    }
    network: {
      publicNetworkAccess: 'Enabled'
    }
    storage: {
      storageSizeGB: 32
      autoGrow: 'Disabled'
      iops: 3000
      throughput: 125
      type: 'PremiumV2_LRS'
    }
    version: '16'
  }
  identity: {
    type: 'SystemAssigned'
  }
  sku: {
    name: 'Standard_B1ms'
    tier: 'Burstable'
  }
}

resource postgresFlexibleServerEntraAdministrator 'Microsoft.DBforPostgreSQL/flexibleServers/administrators@2024-08-01' = {
  name: '86347bed-76ce-4c45-a6f0-6eb2e9e6a5a3'
  properties: {
    principalName: 'postgres-entra-admin-group'
    principalType: 'Group'
    tenantId: '2fd74995-d27a-4021-b909-56d4939c4f38'
  }
  parent: postgresFlexibleServer
}

resource postgresAllAzureServicesFirewallRule 'Microsoft.DBforPostgreSQL/flexibleServers/firewallRules@2024-08-01' = {
  name: 'AllowAllAzureServicesAndResourcesWithinAzureIps'
  properties: {
    endIpAddress: '0.0.0.0'
    startIpAddress: '0.0.0.0'
  }
  parent: postgresFlexibleServer
  dependsOn: [
    postgresFlexibleServerEntraAdministrator
  ]
}