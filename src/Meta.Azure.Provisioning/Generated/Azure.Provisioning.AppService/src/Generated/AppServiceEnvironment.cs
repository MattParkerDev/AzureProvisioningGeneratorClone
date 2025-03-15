// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.Net;

namespace Azure.Provisioning.AppService;

/// <summary>
/// AppServiceEnvironment.
/// </summary>
public partial class AppServiceEnvironment : ProvisionableResource
{
    /// <summary>
    /// Name of the App Service Environment.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
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
    /// Custom settings for changing the behavior of the App Service
    /// Environment.
    /// </summary>
    public BicepList<AppServiceNameValuePair> ClusterSettings 
    {
        get { Initialize(); return _clusterSettings!; }
        set { Initialize(); _clusterSettings!.Assign(value); }
    }
    private BicepList<AppServiceNameValuePair>? _clusterSettings;

    /// <summary>
    /// Full view of the custom domain suffix configuration for ASEv3.
    /// </summary>
    public CustomDnsSuffixConfigurationData CustomDnsSuffixConfiguration 
    {
        get { Initialize(); return _customDnsSuffixConfiguration!; }
        set { Initialize(); AssignOrReplace(ref _customDnsSuffixConfiguration, value); }
    }
    private CustomDnsSuffixConfigurationData? _customDnsSuffixConfiguration;

    /// <summary>
    /// Dedicated Host Count.
    /// </summary>
    public BicepValue<int> DedicatedHostCount 
    {
        get { Initialize(); return _dedicatedHostCount!; }
        set { Initialize(); _dedicatedHostCount!.Assign(value); }
    }
    private BicepValue<int>? _dedicatedHostCount;

    /// <summary>
    /// DNS suffix of the App Service Environment.
    /// </summary>
    public BicepValue<string> DnsSuffix 
    {
        get { Initialize(); return _dnsSuffix!; }
        set { Initialize(); _dnsSuffix!.Assign(value); }
    }
    private BicepValue<string>? _dnsSuffix;

    /// <summary>
    /// Scale factor for front-ends.
    /// </summary>
    public BicepValue<int> FrontEndScaleFactor 
    {
        get { Initialize(); return _frontEndScaleFactor!; }
        set { Initialize(); _frontEndScaleFactor!.Assign(value); }
    }
    private BicepValue<int>? _frontEndScaleFactor;

    /// <summary>
    /// Specifies which endpoints to serve internally in the Virtual Network
    /// for the App Service Environment.
    /// </summary>
    public BicepValue<LoadBalancingMode> InternalLoadBalancingMode 
    {
        get { Initialize(); return _internalLoadBalancingMode!; }
        set { Initialize(); _internalLoadBalancingMode!.Assign(value); }
    }
    private BicepValue<LoadBalancingMode>? _internalLoadBalancingMode;

    /// <summary>
    /// Number of IP SSL addresses reserved for the App Service Environment.
    /// </summary>
    public BicepValue<int> IPSslAddressCount 
    {
        get { Initialize(); return _iPSslAddressCount!; }
        set { Initialize(); _iPSslAddressCount!.Assign(value); }
    }
    private BicepValue<int>? _iPSslAddressCount;

    /// <summary>
    /// Whether or not this App Service Environment is zone-redundant.
    /// </summary>
    public BicepValue<bool> IsZoneRedundant 
    {
        get { Initialize(); return _isZoneRedundant!; }
        set { Initialize(); _isZoneRedundant!.Assign(value); }
    }
    private BicepValue<bool>? _isZoneRedundant;

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
    /// Front-end VM size, e.g. &quot;Medium&quot;, &quot;Large&quot;.
    /// </summary>
    public BicepValue<string> MultiSize 
    {
        get { Initialize(); return _multiSize!; }
        set { Initialize(); _multiSize!.Assign(value); }
    }
    private BicepValue<string>? _multiSize;

    /// <summary>
    /// Full view of networking configuration for an ASE.
    /// </summary>
    public AseV3NetworkingConfigurationData NetworkingConfiguration 
    {
        get { Initialize(); return _networkingConfiguration!; }
        set { Initialize(); AssignOrReplace(ref _networkingConfiguration, value); }
    }
    private AseV3NetworkingConfigurationData? _networkingConfiguration;

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
    /// Upgrade Preference.
    /// </summary>
    public BicepValue<AppServiceEnvironmentUpgradePreference> UpgradePreference 
    {
        get { Initialize(); return _upgradePreference!; }
        set { Initialize(); _upgradePreference!.Assign(value); }
    }
    private BicepValue<AppServiceEnvironmentUpgradePreference>? _upgradePreference;

    /// <summary>
    /// User added ip ranges to whitelist on ASE db.
    /// </summary>
    public BicepList<string> UserWhitelistedIPRanges 
    {
        get { Initialize(); return _userWhitelistedIPRanges!; }
        set { Initialize(); _userWhitelistedIPRanges!.Assign(value); }
    }
    private BicepList<string>? _userWhitelistedIPRanges;

    /// <summary>
    /// Description of the Virtual Network.
    /// </summary>
    public AppServiceVirtualNetworkProfile VirtualNetwork 
    {
        get { Initialize(); return _virtualNetwork!; }
        set { Initialize(); AssignOrReplace(ref _virtualNetwork, value); }
    }
    private AppServiceVirtualNetworkProfile? _virtualNetwork;

    /// <summary>
    /// Flag that displays whether an ASE has linux workers or not.
    /// </summary>
    public BicepValue<bool> HasLinuxWorkers 
    {
        get { Initialize(); return _hasLinuxWorkers!; }
    }
    private BicepValue<bool>? _hasLinuxWorkers;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if the App Service Environment is
    /// suspended; otherwise, &lt;code&gt;false&lt;/code&gt;. The environment
    /// can be suspended, e.g. when the management endpoint is no longer
    /// available              (most likely because NSG blocked the incoming
    /// traffic).
    /// </summary>
    public BicepValue<bool> IsSuspended 
    {
        get { Initialize(); return _isSuspended!; }
    }
    private BicepValue<bool>? _isSuspended;

    /// <summary>
    /// Maximum number of VMs in the App Service Environment.
    /// </summary>
    public BicepValue<int> MaximumNumberOfMachines 
    {
        get { Initialize(); return _maximumNumberOfMachines!; }
    }
    private BicepValue<int>? _maximumNumberOfMachines;

    /// <summary>
    /// Number of front-end instances.
    /// </summary>
    public BicepValue<int> MultiRoleCount 
    {
        get { Initialize(); return _multiRoleCount!; }
    }
    private BicepValue<int>? _multiRoleCount;

    /// <summary>
    /// Provisioning state of the App Service Environment.
    /// </summary>
    public BicepValue<ProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<ProvisioningState>? _provisioningState;

    /// <summary>
    /// Current status of the App Service Environment.
    /// </summary>
    public BicepValue<HostingEnvironmentStatus> Status 
    {
        get { Initialize(); return _status!; }
    }
    private BicepValue<HostingEnvironmentStatus>? _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Whether an upgrade is available for this App Service Environment.
    /// </summary>
    public BicepValue<AppServiceEnvironmentUpgradeAvailability> UpgradeAvailability 
    {
        get { Initialize(); return _upgradeAvailability!; }
    }
    private BicepValue<AppServiceEnvironmentUpgradeAvailability>? _upgradeAvailability;

    /// <summary>
    /// Creates a new AppServiceEnvironment.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppServiceEnvironment resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppServiceEnvironment.</param>
    public AppServiceEnvironment(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Web/hostingEnvironments", resourceVersion ?? "2024-04-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AppServiceEnvironment.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _clusterSettings = DefineListProperty<AppServiceNameValuePair>("ClusterSettings", ["properties", "clusterSettings"]);
        _customDnsSuffixConfiguration = DefineModelProperty<CustomDnsSuffixConfigurationData>("CustomDnsSuffixConfiguration", ["properties", "customDnsSuffixConfiguration"]);
        _dedicatedHostCount = DefineProperty<int>("DedicatedHostCount", ["properties", "dedicatedHostCount"]);
        _dnsSuffix = DefineProperty<string>("DnsSuffix", ["properties", "dnsSuffix"]);
        _frontEndScaleFactor = DefineProperty<int>("FrontEndScaleFactor", ["properties", "frontEndScaleFactor"]);
        _internalLoadBalancingMode = DefineProperty<LoadBalancingMode>("InternalLoadBalancingMode", ["properties", "internalLoadBalancingMode"]);
        _iPSslAddressCount = DefineProperty<int>("IPSslAddressCount", ["properties", "ipsslAddressCount"]);
        _isZoneRedundant = DefineProperty<bool>("IsZoneRedundant", ["properties", "zoneRedundant"]);
        _kind = DefineProperty<string>("Kind", ["kind"]);
        _multiSize = DefineProperty<string>("MultiSize", ["properties", "multiSize"]);
        _networkingConfiguration = DefineModelProperty<AseV3NetworkingConfigurationData>("NetworkingConfiguration", ["properties", "networkingConfiguration"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _upgradePreference = DefineProperty<AppServiceEnvironmentUpgradePreference>("UpgradePreference", ["properties", "upgradePreference"]);
        _userWhitelistedIPRanges = DefineListProperty<string>("UserWhitelistedIPRanges", ["properties", "userWhitelistedIpRanges"]);
        _virtualNetwork = DefineModelProperty<AppServiceVirtualNetworkProfile>("VirtualNetwork", ["properties", "virtualNetwork"]);
        _hasLinuxWorkers = DefineProperty<bool>("HasLinuxWorkers", ["properties", "hasLinuxWorkers"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _isSuspended = DefineProperty<bool>("IsSuspended", ["properties", "suspended"], isOutput: true);
        _maximumNumberOfMachines = DefineProperty<int>("MaximumNumberOfMachines", ["properties", "maximumNumberOfMachines"], isOutput: true);
        _multiRoleCount = DefineProperty<int>("MultiRoleCount", ["properties", "multiRoleCount"], isOutput: true);
        _provisioningState = DefineProperty<ProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _status = DefineProperty<HostingEnvironmentStatus>("Status", ["properties", "status"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _upgradeAvailability = DefineProperty<AppServiceEnvironmentUpgradeAvailability>("UpgradeAvailability", ["properties", "upgradeAvailability"], isOutput: true);
    }

    /// <summary>
    /// Supported AppServiceEnvironment resource versions.
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
        /// 2019-02-01.
        /// </summary>
        public static readonly string V2019_02_01 = "2019-02-01";

        /// <summary>
        /// 2019-01-01.
        /// </summary>
        public static readonly string V2019_01_01 = "2019-01-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-08-01.
        /// </summary>
        public static readonly string V2018_08_01 = "2018-08-01";

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
        /// 2016-03-01.
        /// </summary>
        public static readonly string V2016_03_01 = "2016-03-01";

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
    /// Creates a reference to an existing AppServiceEnvironment.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppServiceEnvironment resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppServiceEnvironment.</param>
    /// <returns>The existing AppServiceEnvironment resource.</returns>
    public static AppServiceEnvironment FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
