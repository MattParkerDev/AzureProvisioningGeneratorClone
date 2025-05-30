// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlServerJobAgent.
/// </summary>
public partial class SqlServerJobAgent : ProvisionableResource
{
    /// <summary>
    /// The name of the job agent to be created or updated.
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
    /// Resource ID of the database to store job metadata in.
    /// </summary>
    public BicepValue<ResourceIdentifier> DatabaseId 
    {
        get { Initialize(); return _databaseId!; }
        set { Initialize(); _databaseId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _databaseId;

    /// <summary>
    /// The identity of the job agent.
    /// </summary>
    public JobAgentIdentity Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); AssignOrReplace(ref _identity, value); }
    }
    private JobAgentIdentity? _identity;

    /// <summary>
    /// The name and tier of the SKU.
    /// </summary>
    public SqlSku Sku 
    {
        get { Initialize(); return _sku!; }
        set { Initialize(); AssignOrReplace(ref _sku, value); }
    }
    private SqlSku? _sku;

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
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The state of the job agent.
    /// </summary>
    public BicepValue<JobAgentState> State 
    {
        get { Initialize(); return _state!; }
    }
    private BicepValue<JobAgentState>? _state;

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
    /// Creates a new SqlServerJobAgent.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlServerJobAgent resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlServerJobAgent.</param>
    public SqlServerJobAgent(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/jobAgents", resourceVersion ?? "2023-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SqlServerJobAgent.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _databaseId = DefineProperty<ResourceIdentifier>("DatabaseId", ["properties", "databaseId"]);
        _identity = DefineModelProperty<JobAgentIdentity>("Identity", ["identity"]);
        _sku = DefineModelProperty<SqlSku>("Sku", ["sku"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _state = DefineProperty<JobAgentState>("State", ["properties", "state"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<SqlServer>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlServerJobAgent resource versions.
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
    /// Creates a reference to an existing SqlServerJobAgent.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlServerJobAgent resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlServerJobAgent.</param>
    /// <returns>The existing SqlServerJobAgent resource.</returns>
    public static SqlServerJobAgent FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
