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
/// ContainerRegistryToken.
/// </summary>
public partial class ContainerRegistryToken : ProvisionableResource
{
    /// <summary>
    /// The name of the token.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The credentials that can be used for authenticating the token.
    /// </summary>
    public ContainerRegistryTokenCredentials Credentials 
    {
        get { Initialize(); return _credentials!; }
        set { Initialize(); AssignOrReplace(ref _credentials, value); }
    }
    private ContainerRegistryTokenCredentials? _credentials;

    /// <summary>
    /// The resource ID of the scope map to which the token will be associated
    /// with.
    /// </summary>
    public BicepValue<ResourceIdentifier> ScopeMapId 
    {
        get { Initialize(); return _scopeMapId!; }
        set { Initialize(); _scopeMapId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _scopeMapId;

    /// <summary>
    /// The status of the token example enabled or disabled.
    /// </summary>
    public BicepValue<ContainerRegistryTokenStatus> Status 
    {
        get { Initialize(); return _status!; }
        set { Initialize(); _status!.Assign(value); }
    }
    private BicepValue<ContainerRegistryTokenStatus>? _status;

    /// <summary>
    /// The creation date of scope map.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn 
    {
        get { Initialize(); return _createdOn!; }
    }
    private BicepValue<DateTimeOffset>? _createdOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Provisioning state of the resource.
    /// </summary>
    public BicepValue<ContainerRegistryProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<ContainerRegistryProvisioningState>? _provisioningState;

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
    /// Creates a new ContainerRegistryToken.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerRegistryToken resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryToken.</param>
    public ContainerRegistryToken(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ContainerRegistry/registries/tokens", resourceVersion ?? "2023-07-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerRegistryToken.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _credentials = DefineModelProperty<ContainerRegistryTokenCredentials>("Credentials", ["Credentials"]);
        _scopeMapId = DefineProperty<ResourceIdentifier>("ScopeMapId", ["ScopeMapId"]);
        _status = DefineProperty<ContainerRegistryTokenStatus>("Status", ["Status"]);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["CreatedOn"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<ContainerRegistryProvisioningState>("ProvisioningState", ["ProvisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<ContainerRegistryService>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerRegistryToken resource versions.
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
    }

    /// <summary>
    /// Creates a reference to an existing ContainerRegistryToken.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerRegistryToken resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryToken.</param>
    /// <returns>The existing ContainerRegistryToken resource.</returns>
    public static ContainerRegistryToken FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ContainerRegistryToken resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 5, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore);
}
