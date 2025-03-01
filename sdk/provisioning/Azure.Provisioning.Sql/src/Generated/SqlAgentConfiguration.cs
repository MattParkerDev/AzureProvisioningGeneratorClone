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
/// SqlAgentConfiguration.
/// </summary>
public partial class SqlAgentConfiguration : ProvisionableResource
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
    /// The state of Sql Agent.
    /// </summary>
    public BicepValue<SqlAgentConfigurationPropertiesState> State 
    {
        get { Initialize(); return _state!; }
        set { Initialize(); _state!.Assign(value); }
    }
    private BicepValue<SqlAgentConfigurationPropertiesState>? _state;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ManagedInstance.
    /// </summary>
    public ManagedInstance? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<ManagedInstance>? _parent;

    /// <summary>
    /// Creates a new SqlAgentConfiguration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlAgentConfiguration resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlAgentConfiguration.</param>
    public SqlAgentConfiguration(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/managedInstances/sqlAgent", resourceVersion ?? "2023-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SqlAgentConfiguration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _state = DefineProperty<SqlAgentConfigurationPropertiesState>("State", ["properties", "state"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<ManagedInstance>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlAgentConfiguration resource versions.
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

        /// <summary>
        /// 2018-06-01.
        /// </summary>
        public static readonly string V2018_06_01 = "2018-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlAgentConfiguration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlAgentConfiguration resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlAgentConfiguration.</param>
    /// <returns>The existing SqlAgentConfiguration resource.</returns>
    public static SqlAgentConfiguration FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
