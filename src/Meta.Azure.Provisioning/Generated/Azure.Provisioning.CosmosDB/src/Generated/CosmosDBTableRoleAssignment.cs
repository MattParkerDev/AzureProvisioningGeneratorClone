// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// CosmosDBTableRoleAssignment.
/// </summary>
public partial class CosmosDBTableRoleAssignment : ProvisionableResource
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
    /// The GUID for the Role Assignment.
    /// </summary>
    public BicepValue<string> RoleAssignmentId 
    {
        get { Initialize(); return _roleAssignmentId!; }
        set { Initialize(); _roleAssignmentId!.Assign(value); }
    }
    private BicepValue<string>? _roleAssignmentId;

    /// <summary>
    /// The unique identifier for the associated AAD principal in the AAD graph
    /// to which access is being granted through this Table Role Assignment.
    /// Tenant ID for the principal is inferred using the tenant associated
    /// with the subscription.
    /// </summary>
    public BicepValue<Guid> PrincipalId 
    {
        get { Initialize(); return _principalId!; }
        set { Initialize(); _principalId!.Assign(value); }
    }
    private BicepValue<Guid>? _principalId;

    /// <summary>
    /// The unique identifier for the associated Role Definition.
    /// </summary>
    public BicepValue<ResourceIdentifier> RoleDefinitionId 
    {
        get { Initialize(); return _roleDefinitionId!; }
        set { Initialize(); _roleDefinitionId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _roleDefinitionId;

    /// <summary>
    /// The data plane resource path for which access is being granted through
    /// this Table Role Assignment.
    /// </summary>
    public BicepValue<ResourceIdentifier> Scope 
    {
        get { Initialize(); return _scope!; }
        set { Initialize(); _scope!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _scope;

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
    public BicepValue<string> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<string>? _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent CosmosDBAccount.
    /// </summary>
    public CosmosDBAccount? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<CosmosDBAccount>? _parent;

    /// <summary>
    /// Creates a new CosmosDBTableRoleAssignment.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CosmosDBTableRoleAssignment
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CosmosDBTableRoleAssignment.</param>
    public CosmosDBTableRoleAssignment(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DocumentDB/databaseAccounts/tableRoleAssignments", resourceVersion ?? "2025-04-15")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of CosmosDBTableRoleAssignment.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _roleAssignmentId = DefineProperty<string>("RoleAssignmentId", ["RoleAssignmentId"], isRequired: true);
        _principalId = DefineProperty<Guid>("PrincipalId", ["properties", "principalId"]);
        _roleDefinitionId = DefineProperty<ResourceIdentifier>("RoleDefinitionId", ["properties", "roleDefinitionId"]);
        _scope = DefineProperty<ResourceIdentifier>("Scope", ["properties", "scope"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<string>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<CosmosDBAccount>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported CosmosDBTableRoleAssignment resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2025-04-15.
        /// </summary>
        public static readonly string V2025_04_15 = "2025-04-15";

        /// <summary>
        /// 2024-11-15.
        /// </summary>
        public static readonly string V2024_11_15 = "2024-11-15";

        /// <summary>
        /// 2024-08-15.
        /// </summary>
        public static readonly string V2024_08_15 = "2024-08-15";

        /// <summary>
        /// 2024-05-15.
        /// </summary>
        public static readonly string V2024_05_15 = "2024-05-15";

        /// <summary>
        /// 2023-11-15.
        /// </summary>
        public static readonly string V2023_11_15 = "2023-11-15";

        /// <summary>
        /// 2023-09-15.
        /// </summary>
        public static readonly string V2023_09_15 = "2023-09-15";

        /// <summary>
        /// 2023-04-15.
        /// </summary>
        public static readonly string V2023_04_15 = "2023-04-15";

        /// <summary>
        /// 2023-03-15.
        /// </summary>
        public static readonly string V2023_03_15 = "2023-03-15";

        /// <summary>
        /// 2022-11-15.
        /// </summary>
        public static readonly string V2022_11_15 = "2022-11-15";

        /// <summary>
        /// 2022-08-15.
        /// </summary>
        public static readonly string V2022_08_15 = "2022-08-15";

        /// <summary>
        /// 2022-05-15.
        /// </summary>
        public static readonly string V2022_05_15 = "2022-05-15";

        /// <summary>
        /// 2021-10-15.
        /// </summary>
        public static readonly string V2021_10_15 = "2021-10-15";

        /// <summary>
        /// 2021-06-15.
        /// </summary>
        public static readonly string V2021_06_15 = "2021-06-15";

        /// <summary>
        /// 2021-05-15.
        /// </summary>
        public static readonly string V2021_05_15 = "2021-05-15";

        /// <summary>
        /// 2021-04-15.
        /// </summary>
        public static readonly string V2021_04_15 = "2021-04-15";

        /// <summary>
        /// 2021-03-15.
        /// </summary>
        public static readonly string V2021_03_15 = "2021-03-15";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-04-01.
        /// </summary>
        public static readonly string V2020_04_01 = "2020-04-01";

        /// <summary>
        /// 2020-03-01.
        /// </summary>
        public static readonly string V2020_03_01 = "2020-03-01";

        /// <summary>
        /// 2019-12-12.
        /// </summary>
        public static readonly string V2019_12_12 = "2019-12-12";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2016-03-31.
        /// </summary>
        public static readonly string V2016_03_31 = "2016-03-31";

        /// <summary>
        /// 2016-03-19.
        /// </summary>
        public static readonly string V2016_03_19 = "2016-03-19";

        /// <summary>
        /// 2015-11-06.
        /// </summary>
        public static readonly string V2015_11_06 = "2015-11-06";

        /// <summary>
        /// 2015-04-08.
        /// </summary>
        public static readonly string V2015_04_08 = "2015-04-08";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing CosmosDBTableRoleAssignment.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CosmosDBTableRoleAssignment
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CosmosDBTableRoleAssignment.</param>
    /// <returns>The existing CosmosDBTableRoleAssignment resource.</returns>
    public static CosmosDBTableRoleAssignment FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
