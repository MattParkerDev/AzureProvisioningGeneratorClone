// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// MongoDBUserDefinition.
/// </summary>
public partial class MongoDBUserDefinition : ProvisionableResource
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
    /// A custom definition for the USer Definition.
    /// </summary>
    public BicepValue<string> CustomData 
    {
        get { Initialize(); return _customData!; }
        set { Initialize(); _customData!.Assign(value); }
    }
    private BicepValue<string>? _customData;

    /// <summary>
    /// The database name for which access is being granted for this User
    /// Definition.
    /// </summary>
    public BicepValue<string> DatabaseName 
    {
        get { Initialize(); return _databaseName!; }
        set { Initialize(); _databaseName!.Assign(value); }
    }
    private BicepValue<string>? _databaseName;

    /// <summary>
    /// The Mongo Auth mechanism. For now, we only support auth mechanism
    /// SCRAM-SHA-256.
    /// </summary>
    public BicepValue<string> Mechanisms 
    {
        get { Initialize(); return _mechanisms!; }
        set { Initialize(); _mechanisms!.Assign(value); }
    }
    private BicepValue<string>? _mechanisms;

    /// <summary>
    /// The password for User Definition. Response does not contain user
    /// password.
    /// </summary>
    public BicepValue<string> Password 
    {
        get { Initialize(); return _password!; }
        set { Initialize(); _password!.Assign(value); }
    }
    private BicepValue<string>? _password;

    /// <summary>
    /// The set of roles inherited by the User Definition.
    /// </summary>
    public BicepList<MongoDBRole> Roles 
    {
        get { Initialize(); return _roles!; }
        set { Initialize(); _roles!.Assign(value); }
    }
    private BicepList<MongoDBRole>? _roles;

    /// <summary>
    /// The user name for User Definition.
    /// </summary>
    public BicepValue<string> UserName 
    {
        get { Initialize(); return _userName!; }
        set { Initialize(); _userName!.Assign(value); }
    }
    private BicepValue<string>? _userName;

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
    /// Gets or sets a reference to the parent CosmosDBAccount.
    /// </summary>
    public CosmosDBAccount? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<CosmosDBAccount>? _parent;

    /// <summary>
    /// Creates a new MongoDBUserDefinition.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the MongoDBUserDefinition resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the MongoDBUserDefinition.</param>
    public MongoDBUserDefinition(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DocumentDB/databaseAccounts/mongodbUserDefinitions", resourceVersion ?? "2025-04-15")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of MongoDBUserDefinition.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _customData = DefineProperty<string>("CustomData", ["properties", "customData"]);
        _databaseName = DefineProperty<string>("DatabaseName", ["properties", "databaseName"]);
        _mechanisms = DefineProperty<string>("Mechanisms", ["properties", "mechanisms"]);
        _password = DefineProperty<string>("Password", ["properties", "password"]);
        _roles = DefineListProperty<MongoDBRole>("Roles", ["properties", "roles"]);
        _userName = DefineProperty<string>("UserName", ["properties", "userName"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<CosmosDBAccount>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported MongoDBUserDefinition resource versions.
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
    /// Creates a reference to an existing MongoDBUserDefinition.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the MongoDBUserDefinition resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the MongoDBUserDefinition.</param>
    /// <returns>The existing MongoDBUserDefinition resource.</returns>
    public static MongoDBUserDefinition FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
