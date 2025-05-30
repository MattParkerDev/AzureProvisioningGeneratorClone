// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// PostgreSqlFlexibleServerConfiguration.
/// </summary>
public partial class PostgreSqlFlexibleServerConfiguration : ProvisionableResource
{
    /// <summary>
    /// The name of the server configuration.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Source of the configuration. Required to update the configuration.
    /// </summary>
    public BicepValue<string> Source 
    {
        get { Initialize(); return _source!; }
        set { Initialize(); _source!.Assign(value); }
    }
    private BicepValue<string>? _source;

    /// <summary>
    /// Value of the configuration. Required to update the configuration.
    /// </summary>
    public BicepValue<string> Value 
    {
        get { Initialize(); return _value!; }
        set { Initialize(); _value!.Assign(value); }
    }
    private BicepValue<string>? _value;

    /// <summary>
    /// Allowed values of the configuration.
    /// </summary>
    public BicepValue<string> AllowedValues 
    {
        get { Initialize(); return _allowedValues!; }
    }
    private BicepValue<string>? _allowedValues;

    /// <summary>
    /// Data type of the configuration.
    /// </summary>
    public BicepValue<PostgreSqlFlexibleServerConfigurationDataType> DataType 
    {
        get { Initialize(); return _dataType!; }
    }
    private BicepValue<PostgreSqlFlexibleServerConfigurationDataType>? _dataType;

    /// <summary>
    /// Default value of the configuration.
    /// </summary>
    public BicepValue<string> DefaultValue 
    {
        get { Initialize(); return _defaultValue!; }
    }
    private BicepValue<string>? _defaultValue;

    /// <summary>
    /// Description of the configuration.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// Configuration documentation link.
    /// </summary>
    public BicepValue<string> DocumentationLink 
    {
        get { Initialize(); return _documentationLink!; }
    }
    private BicepValue<string>? _documentationLink;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Configuration is pending restart or not.
    /// </summary>
    public BicepValue<bool> IsConfigPendingRestart 
    {
        get { Initialize(); return _isConfigPendingRestart!; }
    }
    private BicepValue<bool>? _isConfigPendingRestart;

    /// <summary>
    /// Configuration dynamic or static.
    /// </summary>
    public BicepValue<bool> IsDynamicConfig 
    {
        get { Initialize(); return _isDynamicConfig!; }
    }
    private BicepValue<bool>? _isDynamicConfig;

    /// <summary>
    /// Configuration read-only or not.
    /// </summary>
    public BicepValue<bool> IsReadOnly 
    {
        get { Initialize(); return _isReadOnly!; }
    }
    private BicepValue<bool>? _isReadOnly;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Configuration unit.
    /// </summary>
    public BicepValue<string> Unit 
    {
        get { Initialize(); return _unit!; }
    }
    private BicepValue<string>? _unit;

    /// <summary>
    /// Gets or sets a reference to the parent PostgreSqlFlexibleServer.
    /// </summary>
    public PostgreSqlFlexibleServer? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<PostgreSqlFlexibleServer>? _parent;

    /// <summary>
    /// Creates a new PostgreSqlFlexibleServerConfiguration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// PostgreSqlFlexibleServerConfiguration resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlFlexibleServerConfiguration.</param>
    public PostgreSqlFlexibleServerConfiguration(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DBforPostgreSQL/flexibleServers/configurations", resourceVersion ?? "2024-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// PostgreSqlFlexibleServerConfiguration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _source = DefineProperty<string>("Source", ["properties", "source"]);
        _value = DefineProperty<string>("Value", ["properties", "value"]);
        _allowedValues = DefineProperty<string>("AllowedValues", ["properties", "allowedValues"], isOutput: true);
        _dataType = DefineProperty<PostgreSqlFlexibleServerConfigurationDataType>("DataType", ["properties", "dataType"], isOutput: true);
        _defaultValue = DefineProperty<string>("DefaultValue", ["properties", "defaultValue"], isOutput: true);
        _description = DefineProperty<string>("Description", ["properties", "description"], isOutput: true);
        _documentationLink = DefineProperty<string>("DocumentationLink", ["properties", "documentationLink"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _isConfigPendingRestart = DefineProperty<bool>("IsConfigPendingRestart", ["properties", "isConfigPendingRestart"], isOutput: true);
        _isDynamicConfig = DefineProperty<bool>("IsDynamicConfig", ["properties", "isDynamicConfig"], isOutput: true);
        _isReadOnly = DefineProperty<bool>("IsReadOnly", ["properties", "isReadOnly"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _unit = DefineProperty<string>("Unit", ["properties", "unit"], isOutput: true);
        _parent = DefineResource<PostgreSqlFlexibleServer>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported PostgreSqlFlexibleServerConfiguration resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-01.
        /// </summary>
        public static readonly string V2024_08_01 = "2024-08-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing
    /// PostgreSqlFlexibleServerConfiguration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// PostgreSqlFlexibleServerConfiguration resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlFlexibleServerConfiguration.</param>
    /// <returns>The existing PostgreSqlFlexibleServerConfiguration resource.</returns>
    public static PostgreSqlFlexibleServerConfiguration FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
