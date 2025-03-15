// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.AppService;

/// <summary>
/// WebSiteSlot.
/// </summary>
public partial class WebSiteSlot : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// Resource ID of the associated App Service plan, formatted as:
    /// &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
    /// </summary>
    public BicepValue<ResourceIdentifier> AppServicePlanId 
    {
        get { Initialize(); return _appServicePlanId!; }
        set { Initialize(); _appServicePlanId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _appServicePlanId;

    /// <summary>
    /// Specifies the scope of uniqueness for the default hostname during
    /// resource creation.
    /// </summary>
    public BicepValue<AutoGeneratedDomainNameLabelScope> AutoGeneratedDomainNameLabelScope 
    {
        get { Initialize(); return _autoGeneratedDomainNameLabelScope!; }
        set { Initialize(); _autoGeneratedDomainNameLabelScope!.Assign(value); }
    }
    private BicepValue<AutoGeneratedDomainNameLabelScope>? _autoGeneratedDomainNameLabelScope;

    /// <summary>
    /// client certificate authentication comma-separated exclusion paths.
    /// </summary>
    public BicepValue<string> ClientCertExclusionPaths 
    {
        get { Initialize(); return _clientCertExclusionPaths!; }
        set { Initialize(); _clientCertExclusionPaths!.Assign(value); }
    }
    private BicepValue<string>? _clientCertExclusionPaths;

    /// <summary>
    /// This composes with ClientCertEnabled setting.             -
    /// ClientCertEnabled: false means ClientCert is ignored.             -
    /// ClientCertEnabled: true and ClientCertMode: Required means ClientCert
    /// is required.             - ClientCertEnabled: true and ClientCertMode:
    /// Optional means ClientCert is optional or accepted.
    /// </summary>
    public BicepValue<ClientCertMode> ClientCertMode 
    {
        get { Initialize(); return _clientCertMode!; }
        set { Initialize(); _clientCertMode!.Assign(value); }
    }
    private BicepValue<ClientCertMode>? _clientCertMode;

    /// <summary>
    /// If specified during app creation, the app is cloned from a source app.
    /// </summary>
    public CloningInfo CloningInfo 
    {
        get { Initialize(); return _cloningInfo!; }
        set { Initialize(); AssignOrReplace(ref _cloningInfo, value); }
    }
    private CloningInfo? _cloningInfo;

    /// <summary>
    /// Size of the function container.
    /// </summary>
    public BicepValue<int> ContainerSize 
    {
        get { Initialize(); return _containerSize!; }
        set { Initialize(); _containerSize!.Assign(value); }
    }
    private BicepValue<int>? _containerSize;

    /// <summary>
    /// Unique identifier that verifies the custom domains assigned to the app.
    /// Customer will add this id to a txt record for verification.
    /// </summary>
    public BicepValue<string> CustomDomainVerificationId 
    {
        get { Initialize(); return _customDomainVerificationId!; }
        set { Initialize(); _customDomainVerificationId!.Assign(value); }
    }
    private BicepValue<string>? _customDomainVerificationId;

    /// <summary>
    /// Maximum allowed daily memory-time quota (applicable on dynamic apps
    /// only).
    /// </summary>
    public BicepValue<int> DailyMemoryTimeQuota 
    {
        get { Initialize(); return _dailyMemoryTimeQuota!; }
        set { Initialize(); _dailyMemoryTimeQuota!.Assign(value); }
    }
    private BicepValue<int>? _dailyMemoryTimeQuota;

    /// <summary>
    /// Dapr configuration of the app.
    /// </summary>
    public AppDaprConfig DaprConfig 
    {
        get { Initialize(); return _daprConfig!; }
        set { Initialize(); AssignOrReplace(ref _daprConfig, value); }
    }
    private AppDaprConfig? _daprConfig;

    /// <summary>
    /// Property to configure various DNS related settings for a site.
    /// </summary>
    public SiteDnsConfig DnsConfiguration 
    {
        get { Initialize(); return _dnsConfiguration!; }
        set { Initialize(); AssignOrReplace(ref _dnsConfiguration, value); }
    }
    private SiteDnsConfig? _dnsConfiguration;

    /// <summary>
    /// Extended Location.
    /// </summary>
    public ExtendedAzureLocation ExtendedLocation 
    {
        get { Initialize(); return _extendedLocation!; }
        set { Initialize(); AssignOrReplace(ref _extendedLocation, value); }
    }
    private ExtendedAzureLocation? _extendedLocation;

    /// <summary>
    /// Configuration specific of the Azure Function app.
    /// </summary>
    public FunctionAppConfig FunctionAppConfig 
    {
        get { Initialize(); return _functionAppConfig!; }
        set { Initialize(); AssignOrReplace(ref _functionAppConfig, value); }
    }
    private FunctionAppConfig? _functionAppConfig;

    /// <summary>
    /// App Service Environment to use for the app.
    /// </summary>
    public HostingEnvironmentProfile HostingEnvironmentProfile 
    {
        get { Initialize(); return _hostingEnvironmentProfile!; }
        set { Initialize(); AssignOrReplace(ref _hostingEnvironmentProfile, value); }
    }
    private HostingEnvironmentProfile? _hostingEnvironmentProfile;

    /// <summary>
    /// Hostname SSL states are used to manage the SSL bindings for app&apos;s
    /// hostnames.
    /// </summary>
    public BicepList<HostNameSslState> HostNameSslStates 
    {
        get { Initialize(); return _hostNameSslStates!; }
        set { Initialize(); _hostNameSslStates!.Assign(value); }
    }
    private BicepList<HostNameSslState>? _hostNameSslStates;

    /// <summary>
    /// Managed service identity.
    /// </summary>
    public ManagedServiceIdentity Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); AssignOrReplace(ref _identity, value); }
    }
    private ManagedServiceIdentity? _identity;

    /// <summary>
    /// Specifies the IP mode of the app.
    /// </summary>
    public BicepValue<AppServiceIPMode> IPMode 
    {
        get { Initialize(); return _iPMode!; }
        set { Initialize(); _iPMode!.Assign(value); }
    }
    private BicepValue<AppServiceIPMode>? _iPMode;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to enable client affinity;
    /// &lt;code&gt;false&lt;/code&gt; to stop sending session affinity
    /// cookies, which route client requests in the same session to the same
    /// instance. Default is &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsClientAffinityEnabled 
    {
        get { Initialize(); return _isClientAffinityEnabled!; }
        set { Initialize(); _isClientAffinityEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isClientAffinityEnabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to enable client certificate
    /// authentication (TLS mutual authentication); otherwise,
    /// &lt;code&gt;false&lt;/code&gt;. Default is
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsClientCertEnabled 
    {
        get { Initialize(); return _isClientCertEnabled!; }
        set { Initialize(); _isClientCertEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isClientCertEnabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if the app is enabled; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;. Setting this value to false disables
    /// the app (takes the app offline).
    /// </summary>
    public BicepValue<bool> IsEnabled 
    {
        get { Initialize(); return _isEnabled!; }
        set { Initialize(); _isEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isEnabled;

    /// <summary>
    /// Whether to use end to end encryption between the FrontEnd and the
    /// Worker.
    /// </summary>
    public BicepValue<bool> IsEndToEndEncryptionEnabled 
    {
        get { Initialize(); return _isEndToEndEncryptionEnabled!; }
        set { Initialize(); _isEndToEndEncryptionEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isEndToEndEncryptionEnabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to disable the public hostnames of the
    /// app; otherwise, &lt;code&gt;false&lt;/code&gt;.              If
    /// &lt;code&gt;true&lt;/code&gt;, the app is only accessible via API
    /// management process.
    /// </summary>
    public BicepValue<bool> IsHostNameDisabled 
    {
        get { Initialize(); return _isHostNameDisabled!; }
        set { Initialize(); _isHostNameDisabled!.Assign(value); }
    }
    private BicepValue<bool>? _isHostNameDisabled;

    /// <summary>
    /// HttpsOnly: configures a web site to accept only https requests. Issues
    /// redirect for             http requests
    /// </summary>
    public BicepValue<bool> IsHttpsOnly 
    {
        get { Initialize(); return _isHttpsOnly!; }
        set { Initialize(); _isHttpsOnly!.Assign(value); }
    }
    private BicepValue<bool>? _isHttpsOnly;

    /// <summary>
    /// Hyper-V sandbox.
    /// </summary>
    public BicepValue<bool> IsHyperV 
    {
        get { Initialize(); return _isHyperV!; }
        set { Initialize(); _isHyperV!.Assign(value); }
    }
    private BicepValue<bool>? _isHyperV;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if reserved; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsReserved 
    {
        get { Initialize(); return _isReserved!; }
        set { Initialize(); _isReserved!.Assign(value); }
    }
    private BicepValue<bool>? _isReserved;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to stop SCM (KUDU) site when the app is
    /// stopped; otherwise, &lt;code&gt;false&lt;/code&gt;. The default is
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsScmSiteAlsoStopped 
    {
        get { Initialize(); return _isScmSiteAlsoStopped!; }
        set { Initialize(); _isScmSiteAlsoStopped!.Assign(value); }
    }
    private BicepValue<bool>? _isScmSiteAlsoStopped;

    /// <summary>
    /// Checks if Customer provided storage account is required.
    /// </summary>
    public BicepValue<bool> IsStorageAccountRequired 
    {
        get { Initialize(); return _isStorageAccountRequired!; }
        set { Initialize(); _isStorageAccountRequired!.Assign(value); }
    }
    private BicepValue<bool>? _isStorageAccountRequired;

    /// <summary>
    /// To enable Backup and Restore operations over virtual network.
    /// </summary>
    public BicepValue<bool> IsVnetBackupRestoreEnabled 
    {
        get { Initialize(); return _isVnetBackupRestoreEnabled!; }
        set { Initialize(); _isVnetBackupRestoreEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isVnetBackupRestoreEnabled;

    /// <summary>
    /// To enable accessing content over virtual network.
    /// </summary>
    public BicepValue<bool> IsVnetContentShareEnabled 
    {
        get { Initialize(); return _isVnetContentShareEnabled!; }
        set { Initialize(); _isVnetContentShareEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isVnetContentShareEnabled;

    /// <summary>
    /// To enable pulling image over Virtual Network.
    /// </summary>
    public BicepValue<bool> IsVnetImagePullEnabled 
    {
        get { Initialize(); return _isVnetImagePullEnabled!; }
        set { Initialize(); _isVnetImagePullEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isVnetImagePullEnabled;

    /// <summary>
    /// Virtual Network Route All enabled. This causes all outbound traffic to
    /// have Virtual Network Security Groups and User Defined Routes applied.
    /// </summary>
    public BicepValue<bool> IsVnetRouteAllEnabled 
    {
        get { Initialize(); return _isVnetRouteAllEnabled!; }
        set { Initialize(); _isVnetRouteAllEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isVnetRouteAllEnabled;

    /// <summary>
    /// Obsolete: Hyper-V sandbox.
    /// </summary>
    public BicepValue<bool> IsXenon 
    {
        get { Initialize(); return _isXenon!; }
        set { Initialize(); _isXenon!.Assign(value); }
    }
    private BicepValue<bool>? _isXenon;

    /// <summary>
    /// Identity to use for Key Vault Reference authentication.
    /// </summary>
    public BicepValue<string> KeyVaultReferenceIdentity 
    {
        get { Initialize(); return _keyVaultReferenceIdentity!; }
        set { Initialize(); _keyVaultReferenceIdentity!.Assign(value); }
    }
    private BicepValue<string>? _keyVaultReferenceIdentity;

    /// <summary>
    /// Kind of resource. If the resource is an app, you can refer to
    /// https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference
    /// for details supported values for kind.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<string>? _kind;

    /// <summary>
    /// Azure Resource Manager ID of the customer&apos;s selected Managed
    /// Environment on which to host this app. This must be of the form
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.App/managedEnvironments/{managedEnvironmentName}.
    /// </summary>
    public BicepValue<string> ManagedEnvironmentId 
    {
        get { Initialize(); return _managedEnvironmentId!; }
        set { Initialize(); _managedEnvironmentId!.Assign(value); }
    }
    private BicepValue<string>? _managedEnvironmentId;

    /// <summary>
    /// Property to allow or block all public traffic. Allowed Values:
    /// &apos;Enabled&apos;, &apos;Disabled&apos; or an empty string.
    /// </summary>
    public BicepValue<string> PublicNetworkAccess 
    {
        get { Initialize(); return _publicNetworkAccess!; }
        set { Initialize(); _publicNetworkAccess!.Assign(value); }
    }
    private BicepValue<string>? _publicNetworkAccess;

    /// <summary>
    /// Site redundancy mode.
    /// </summary>
    public BicepValue<RedundancyMode> RedundancyMode 
    {
        get { Initialize(); return _redundancyMode!; }
        set { Initialize(); _redundancyMode!.Assign(value); }
    }
    private BicepValue<RedundancyMode>? _redundancyMode;

    /// <summary>
    /// Function app resource requirements.
    /// </summary>
    public FunctionAppResourceConfig ResourceConfig 
    {
        get { Initialize(); return _resourceConfig!; }
        set { Initialize(); AssignOrReplace(ref _resourceConfig, value); }
    }
    private FunctionAppResourceConfig? _resourceConfig;

    /// <summary>
    /// Configuration of the app.
    /// </summary>
    public SiteConfigProperties SiteConfig 
    {
        get { Initialize(); return _siteConfig!; }
        set { Initialize(); AssignOrReplace(ref _siteConfig, value); }
    }
    private SiteConfigProperties? _siteConfig;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// Azure Resource Manager ID of the Virtual network and subnet to be
    /// joined by Regional VNET Integration.             This must be of the
    /// form
    /// /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
    /// </summary>
    public BicepValue<ResourceIdentifier> VirtualNetworkSubnetId 
    {
        get { Initialize(); return _virtualNetworkSubnetId!; }
        set { Initialize(); _virtualNetworkSubnetId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _virtualNetworkSubnetId;

    /// <summary>
    /// Workload profile name for function app to execute on.
    /// </summary>
    public BicepValue<string> WorkloadProfileName 
    {
        get { Initialize(); return _workloadProfileName!; }
        set { Initialize(); _workloadProfileName!.Assign(value); }
    }
    private BicepValue<string>? _workloadProfileName;

    /// <summary>
    /// Management information availability state for the app.
    /// </summary>
    public BicepValue<WebSiteAvailabilityState> AvailabilityState 
    {
        get { Initialize(); return _availabilityState!; }
    }
    private BicepValue<WebSiteAvailabilityState>? _availabilityState;

    /// <summary>
    /// Default hostname of the app. Read-only.
    /// </summary>
    public BicepValue<string> DefaultHostName 
    {
        get { Initialize(); return _defaultHostName!; }
    }
    private BicepValue<string>? _defaultHostName;

    /// <summary>
    /// Enabled hostnames for the app.Hostnames need to be assigned (see
    /// HostNames) AND enabled. Otherwise,             the app is not served
    /// on those hostnames.
    /// </summary>
    public BicepList<string> EnabledHostNames 
    {
        get { Initialize(); return _enabledHostNames!; }
    }
    private BicepList<string>? _enabledHostNames;

    /// <summary>
    /// Hostnames associated with the app.
    /// </summary>
    public BicepList<string> HostNames 
    {
        get { Initialize(); return _hostNames!; }
    }
    private BicepList<string>? _hostNames;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Specifies an operation id if this site has a pending operation.
    /// </summary>
    public BicepValue<Guid> InProgressOperationId 
    {
        get { Initialize(); return _inProgressOperationId!; }
    }
    private BicepValue<Guid>? _inProgressOperationId;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if the app is a default container;
    /// otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsDefaultContainer 
    {
        get { Initialize(); return _isDefaultContainer!; }
    }
    private BicepValue<bool>? _isDefaultContainer;

    /// <summary>
    /// Last time the app was modified, in UTC. Read-only.
    /// </summary>
    public BicepValue<DateTimeOffset> LastModifiedTimeUtc 
    {
        get { Initialize(); return _lastModifiedTimeUtc!; }
    }
    private BicepValue<DateTimeOffset>? _lastModifiedTimeUtc;

    /// <summary>
    /// Maximum number of workers.             This only applies to Functions
    /// container.
    /// </summary>
    public BicepValue<int> MaxNumberOfWorkers 
    {
        get { Initialize(); return _maxNumberOfWorkers!; }
    }
    private BicepValue<int>? _maxNumberOfWorkers;

    /// <summary>
    /// List of IP addresses that the app uses for outbound connections (e.g.
    /// database access). Includes VIPs from tenants that site can be hosted
    /// with current settings. Read-only.
    /// </summary>
    public BicepValue<string> OutboundIPAddresses 
    {
        get { Initialize(); return _outboundIPAddresses!; }
    }
    private BicepValue<string>? _outboundIPAddresses;

    /// <summary>
    /// List of IP addresses that the app uses for outbound connections (e.g.
    /// database access). Includes VIPs from all tenants except dataComponent.
    /// Read-only.
    /// </summary>
    public BicepValue<string> PossibleOutboundIPAddresses 
    {
        get { Initialize(); return _possibleOutboundIPAddresses!; }
    }
    private BicepValue<string>? _possibleOutboundIPAddresses;

    /// <summary>
    /// Name of the repository site.
    /// </summary>
    public BicepValue<string> RepositorySiteName 
    {
        get { Initialize(); return _repositorySiteName!; }
    }
    private BicepValue<string>? _repositorySiteName;

    /// <summary>
    /// Name of the resource group the app belongs to. Read-only.
    /// </summary>
    public BicepValue<string> ResourceGroup 
    {
        get { Initialize(); return _resourceGroup!; }
    }
    private BicepValue<string>? _resourceGroup;

    /// <summary>
    /// Current SKU of application based on associated App Service Plan. Some
    /// valid SKU values are Free, Shared, Basic, Dynamic, FlexConsumption,
    /// Standard, Premium, PremiumV2, PremiumV3, Isolated, IsolatedV2.
    /// </summary>
    public BicepValue<string> Sku 
    {
        get { Initialize(); return _sku!; }
    }
    private BicepValue<string>? _sku;

    /// <summary>
    /// Status of the last deployment slot swap operation.
    /// </summary>
    public SlotSwapStatus SlotSwapStatus 
    {
        get { Initialize(); return _slotSwapStatus!; }
    }
    private SlotSwapStatus? _slotSwapStatus;

    /// <summary>
    /// Current state of the app.
    /// </summary>
    public BicepValue<string> State 
    {
        get { Initialize(); return _state!; }
    }
    private BicepValue<string>? _state;

    /// <summary>
    /// App suspended till in case memory-time quota is exceeded.
    /// </summary>
    public BicepValue<DateTimeOffset> SuspendOn 
    {
        get { Initialize(); return _suspendOn!; }
    }
    private BicepValue<DateTimeOffset>? _suspendOn;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Specifies which deployment slot this app will swap into. Read-only.
    /// </summary>
    public BicepValue<string> TargetSwapSlot 
    {
        get { Initialize(); return _targetSwapSlot!; }
    }
    private BicepValue<string>? _targetSwapSlot;

    /// <summary>
    /// Azure Traffic Manager hostnames associated with the app. Read-only.
    /// </summary>
    public BicepList<string> TrafficManagerHostNames 
    {
        get { Initialize(); return _trafficManagerHostNames!; }
    }
    private BicepList<string>? _trafficManagerHostNames;

    /// <summary>
    /// State indicating whether the app has exceeded its quota usage.
    /// Read-only.
    /// </summary>
    public BicepValue<AppServiceUsageState> UsageState 
    {
        get { Initialize(); return _usageState!; }
    }
    private BicepValue<AppServiceUsageState>? _usageState;

    /// <summary>
    /// Gets or sets a reference to the parent WebSite.
    /// </summary>
    public WebSite? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<WebSite>? _parent;

    /// <summary>
    /// Creates a new WebSiteSlot.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WebSiteSlot resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WebSiteSlot.</param>
    public WebSiteSlot(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Web/sites/slots", resourceVersion ?? "2024-04-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of WebSiteSlot.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _appServicePlanId = DefineProperty<ResourceIdentifier>("AppServicePlanId", ["properties", "serverFarmId"]);
        _autoGeneratedDomainNameLabelScope = DefineProperty<AutoGeneratedDomainNameLabelScope>("AutoGeneratedDomainNameLabelScope", ["properties", "autoGeneratedDomainNameLabelScope"]);
        _clientCertExclusionPaths = DefineProperty<string>("ClientCertExclusionPaths", ["properties", "clientCertExclusionPaths"]);
        _clientCertMode = DefineProperty<ClientCertMode>("ClientCertMode", ["properties", "clientCertMode"]);
        _cloningInfo = DefineModelProperty<CloningInfo>("CloningInfo", ["properties", "cloningInfo"]);
        _containerSize = DefineProperty<int>("ContainerSize", ["properties", "containerSize"]);
        _customDomainVerificationId = DefineProperty<string>("CustomDomainVerificationId", ["properties", "customDomainVerificationId"]);
        _dailyMemoryTimeQuota = DefineProperty<int>("DailyMemoryTimeQuota", ["properties", "dailyMemoryTimeQuota"]);
        _daprConfig = DefineModelProperty<AppDaprConfig>("DaprConfig", ["properties", "daprConfig"]);
        _dnsConfiguration = DefineModelProperty<SiteDnsConfig>("DnsConfiguration", ["properties", "dnsConfiguration"]);
        _extendedLocation = DefineModelProperty<ExtendedAzureLocation>("ExtendedLocation", ["extendedLocation"]);
        _functionAppConfig = DefineModelProperty<FunctionAppConfig>("FunctionAppConfig", ["properties", "functionAppConfig"]);
        _hostingEnvironmentProfile = DefineModelProperty<HostingEnvironmentProfile>("HostingEnvironmentProfile", ["properties", "hostingEnvironmentProfile"]);
        _hostNameSslStates = DefineListProperty<HostNameSslState>("HostNameSslStates", ["properties", "hostNameSslStates"]);
        _identity = DefineModelProperty<ManagedServiceIdentity>("Identity", ["identity"]);
        _iPMode = DefineProperty<AppServiceIPMode>("IPMode", ["properties", "ipMode"]);
        _isClientAffinityEnabled = DefineProperty<bool>("IsClientAffinityEnabled", ["properties", "clientAffinityEnabled"]);
        _isClientCertEnabled = DefineProperty<bool>("IsClientCertEnabled", ["properties", "clientCertEnabled"]);
        _isEnabled = DefineProperty<bool>("IsEnabled", ["properties", "enabled"]);
        _isEndToEndEncryptionEnabled = DefineProperty<bool>("IsEndToEndEncryptionEnabled", ["properties", "endToEndEncryptionEnabled"]);
        _isHostNameDisabled = DefineProperty<bool>("IsHostNameDisabled", ["properties", "hostNamesDisabled"]);
        _isHttpsOnly = DefineProperty<bool>("IsHttpsOnly", ["properties", "httpsOnly"]);
        _isHyperV = DefineProperty<bool>("IsHyperV", ["properties", "hyperV"]);
        _isReserved = DefineProperty<bool>("IsReserved", ["properties", "reserved"]);
        _isScmSiteAlsoStopped = DefineProperty<bool>("IsScmSiteAlsoStopped", ["properties", "scmSiteAlsoStopped"]);
        _isStorageAccountRequired = DefineProperty<bool>("IsStorageAccountRequired", ["properties", "storageAccountRequired"]);
        _isVnetBackupRestoreEnabled = DefineProperty<bool>("IsVnetBackupRestoreEnabled", ["properties", "vnetBackupRestoreEnabled"]);
        _isVnetContentShareEnabled = DefineProperty<bool>("IsVnetContentShareEnabled", ["properties", "vnetContentShareEnabled"]);
        _isVnetImagePullEnabled = DefineProperty<bool>("IsVnetImagePullEnabled", ["properties", "vnetImagePullEnabled"]);
        _isVnetRouteAllEnabled = DefineProperty<bool>("IsVnetRouteAllEnabled", ["properties", "vnetRouteAllEnabled"]);
        _isXenon = DefineProperty<bool>("IsXenon", ["properties", "isXenon"]);
        _keyVaultReferenceIdentity = DefineProperty<string>("KeyVaultReferenceIdentity", ["properties", "keyVaultReferenceIdentity"]);
        _kind = DefineProperty<string>("Kind", ["kind"]);
        _managedEnvironmentId = DefineProperty<string>("ManagedEnvironmentId", ["properties", "managedEnvironmentId"]);
        _publicNetworkAccess = DefineProperty<string>("PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _redundancyMode = DefineProperty<RedundancyMode>("RedundancyMode", ["properties", "redundancyMode"]);
        _resourceConfig = DefineModelProperty<FunctionAppResourceConfig>("ResourceConfig", ["properties", "resourceConfig"]);
        _siteConfig = DefineModelProperty<SiteConfigProperties>("SiteConfig", ["properties", "siteConfig"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _virtualNetworkSubnetId = DefineProperty<ResourceIdentifier>("VirtualNetworkSubnetId", ["properties", "virtualNetworkSubnetId"]);
        _workloadProfileName = DefineProperty<string>("WorkloadProfileName", ["properties", "workloadProfileName"]);
        _availabilityState = DefineProperty<WebSiteAvailabilityState>("AvailabilityState", ["properties", "availabilityState"], isOutput: true);
        _defaultHostName = DefineProperty<string>("DefaultHostName", ["properties", "defaultHostName"], isOutput: true);
        _enabledHostNames = DefineListProperty<string>("EnabledHostNames", ["properties", "enabledHostNames"], isOutput: true);
        _hostNames = DefineListProperty<string>("HostNames", ["properties", "hostNames"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _inProgressOperationId = DefineProperty<Guid>("InProgressOperationId", ["properties", "inProgressOperationId"], isOutput: true);
        _isDefaultContainer = DefineProperty<bool>("IsDefaultContainer", ["properties", "isDefaultContainer"], isOutput: true);
        _lastModifiedTimeUtc = DefineProperty<DateTimeOffset>("LastModifiedTimeUtc", ["properties", "lastModifiedTimeUtc"], isOutput: true);
        _maxNumberOfWorkers = DefineProperty<int>("MaxNumberOfWorkers", ["properties", "maxNumberOfWorkers"], isOutput: true);
        _outboundIPAddresses = DefineProperty<string>("OutboundIPAddresses", ["properties", "outboundIpAddresses"], isOutput: true);
        _possibleOutboundIPAddresses = DefineProperty<string>("PossibleOutboundIPAddresses", ["properties", "possibleOutboundIpAddresses"], isOutput: true);
        _repositorySiteName = DefineProperty<string>("RepositorySiteName", ["properties", "repositorySiteName"], isOutput: true);
        _resourceGroup = DefineProperty<string>("ResourceGroup", ["properties", "resourceGroup"], isOutput: true);
        _sku = DefineProperty<string>("Sku", ["properties", "sku"], isOutput: true);
        _slotSwapStatus = DefineModelProperty<SlotSwapStatus>("SlotSwapStatus", ["properties", "slotSwapStatus"], isOutput: true);
        _state = DefineProperty<string>("State", ["properties", "state"], isOutput: true);
        _suspendOn = DefineProperty<DateTimeOffset>("SuspendOn", ["properties", "suspendedTill"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _targetSwapSlot = DefineProperty<string>("TargetSwapSlot", ["properties", "targetSwapSlot"], isOutput: true);
        _trafficManagerHostNames = DefineListProperty<string>("TrafficManagerHostNames", ["properties", "trafficManagerHostNames"], isOutput: true);
        _usageState = DefineProperty<AppServiceUsageState>("UsageState", ["properties", "usageState"], isOutput: true);
        _parent = DefineResource<WebSite>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported WebSiteSlot resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-08-01.
        /// </summary>
        public static readonly string V2017_08_01 = "2017-08-01";

        /// <summary>
        /// 2016-09-01.
        /// </summary>
        public static readonly string V2016_09_01 = "2016-09-01";

        /// <summary>
        /// 2016-08-01.
        /// </summary>
        public static readonly string V2016_08_01 = "2016-08-01";

        /// <summary>
        /// 2016-03-01.
        /// </summary>
        public static readonly string V2016_03_01 = "2016-03-01";

        /// <summary>
        /// 2015-11-01.
        /// </summary>
        public static readonly string V2015_11_01 = "2015-11-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2015-07-01.
        /// </summary>
        public static readonly string V2015_07_01 = "2015-07-01";

        /// <summary>
        /// 2015-06-01.
        /// </summary>
        public static readonly string V2015_06_01 = "2015-06-01";

        /// <summary>
        /// 2015-05-01.
        /// </summary>
        public static readonly string V2015_05_01 = "2015-05-01";

        /// <summary>
        /// 2015-04-01.
        /// </summary>
        public static readonly string V2015_04_01 = "2015-04-01";

        /// <summary>
        /// 2015-02-01.
        /// </summary>
        public static readonly string V2015_02_01 = "2015-02-01";

        /// <summary>
        /// 2015-01-01.
        /// </summary>
        public static readonly string V2015_01_01 = "2015-01-01";

        /// <summary>
        /// 2014-11-01.
        /// </summary>
        public static readonly string V2014_11_01 = "2014-11-01";

        /// <summary>
        /// 2014-06-01.
        /// </summary>
        public static readonly string V2014_06_01 = "2014-06-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing WebSiteSlot.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WebSiteSlot resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WebSiteSlot.</param>
    /// <returns>The existing WebSiteSlot resource.</returns>
    public static WebSiteSlot FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this WebSiteSlot resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 2, maxLength: 59, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);
}
