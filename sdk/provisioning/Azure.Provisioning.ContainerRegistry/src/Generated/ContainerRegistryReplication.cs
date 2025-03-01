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

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// ContainerRegistryReplication.
/// </summary>
public partial class ContainerRegistryReplication : ProvisionableResource
{
    /// <summary>
    /// The name of the replication.
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
    /// Specifies whether the replication&apos;s regional endpoint is enabled.
    /// Requests will not be routed to a replication whose regional endpoint
    /// is disabled, however its data will continue to be synced with other
    /// replications.
    /// </summary>
    public BicepValue<bool> IsRegionEndpointEnabled 
    {
        get { Initialize(); return _isRegionEndpointEnabled!; }
        set { Initialize(); _isRegionEndpointEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isRegionEndpointEnabled;

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
    /// Whether or not zone redundancy is enabled for this container registry
    /// replication.
    /// </summary>
    public BicepValue<ContainerRegistryZoneRedundancy> ZoneRedundancy 
    {
        get { Initialize(); return _zoneRedundancy!; }
        set { Initialize(); _zoneRedundancy!.Assign(value); }
    }
    private BicepValue<ContainerRegistryZoneRedundancy>? _zoneRedundancy;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The provisioning state of the replication at the time the operation was
    /// called.
    /// </summary>
    public BicepValue<ContainerRegistryProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<ContainerRegistryProvisioningState>? _provisioningState;

    /// <summary>
    /// The status of the replication at the time the operation was called.
    /// </summary>
    public ContainerRegistryResourceStatus Status 
    {
        get { Initialize(); return _status!; }
    }
    private ContainerRegistryResourceStatus? _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerRegistryService.
    /// </summary>
    public ContainerRegistryService? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<ContainerRegistryService>? _parent;

    /// <summary>
    /// Creates a new ContainerRegistryReplication.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerRegistryReplication
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryReplication.</param>
    public ContainerRegistryReplication(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ContainerRegistry/registries/replications", resourceVersion ?? "2023-07-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerRegistryReplication.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _isRegionEndpointEnabled = DefineProperty<bool>("IsRegionEndpointEnabled", ["IsRegionEndpointEnabled"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _zoneRedundancy = DefineProperty<ContainerRegistryZoneRedundancy>("ZoneRedundancy", ["ZoneRedundancy"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<ContainerRegistryProvisioningState>("ProvisioningState", ["ProvisioningState"], isOutput: true);
        _status = DefineModelProperty<ContainerRegistryResourceStatus>("Status", ["Status"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<ContainerRegistryService>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerRegistryReplication resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2019-05-01.
        /// </summary>
        public static readonly string V2019_05_01 = "2019-05-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerRegistryReplication.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerRegistryReplication
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryReplication.</param>
    /// <returns>The existing ContainerRegistryReplication resource.</returns>
    public static ContainerRegistryReplication FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ContainerRegistryReplication
    /// resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 5, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers);
}
