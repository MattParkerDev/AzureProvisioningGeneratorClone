// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlServerVirtualNetworkRule.
/// </summary>
public partial class SqlServerVirtualNetworkRule : ProvisionableResource
{
    /// <summary>
    /// The name of the virtual network rule.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Create firewall rule before the virtual network has vnet service
    /// endpoint enabled.
    /// </summary>
    public BicepValue<bool> IgnoreMissingVnetServiceEndpoint 
    {
        get { Initialize(); return _ignoreMissingVnetServiceEndpoint!; }
        set { Initialize(); _ignoreMissingVnetServiceEndpoint!.Assign(value); }
    }
    private BicepValue<bool>? _ignoreMissingVnetServiceEndpoint;

    /// <summary>
    /// The ARM resource id of the virtual network subnet.
    /// </summary>
    public BicepValue<ResourceIdentifier> VirtualNetworkSubnetId 
    {
        get { Initialize(); return _virtualNetworkSubnetId!; }
        set { Initialize(); _virtualNetworkSubnetId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _virtualNetworkSubnetId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Virtual Network Rule State.
    /// </summary>
    public BicepValue<SqlServerVirtualNetworkRuleState> State 
    {
        get { Initialize(); return _state!; }
    }
    private BicepValue<SqlServerVirtualNetworkRuleState>? _state;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlServer.
    /// </summary>
    public SqlServer? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<SqlServer>? _parent;

    /// <summary>
    /// Creates a new SqlServerVirtualNetworkRule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlServerVirtualNetworkRule
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlServerVirtualNetworkRule.</param>
    public SqlServerVirtualNetworkRule(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/virtualNetworkRules", resourceVersion ?? "2023-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SqlServerVirtualNetworkRule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _ignoreMissingVnetServiceEndpoint = DefineProperty<bool>("IgnoreMissingVnetServiceEndpoint", ["properties", "ignoreMissingVnetServiceEndpoint"]);
        _virtualNetworkSubnetId = DefineProperty<ResourceIdentifier>("VirtualNetworkSubnetId", ["properties", "virtualNetworkSubnetId"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _state = DefineProperty<SqlServerVirtualNetworkRuleState>("State", ["properties", "state"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<SqlServer>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlServerVirtualNetworkRule resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-08-01.
        /// </summary>
        public static readonly string V2023_08_01 = "2023-08-01";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlServerVirtualNetworkRule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlServerVirtualNetworkRule
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlServerVirtualNetworkRule.</param>
    /// <returns>The existing SqlServerVirtualNetworkRule resource.</returns>
    public static SqlServerVirtualNetworkRule FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
