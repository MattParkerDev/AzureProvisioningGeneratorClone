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
/// BackupShortTermRetentionPolicy.
/// </summary>
public partial class BackupShortTermRetentionPolicy : ProvisionableResource
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
    /// The differential backup interval in hours. This is how many interval
    /// hours between each differential backup will be supported. This is only
    /// applicable to live databases but not dropped databases.
    /// </summary>
    public BicepValue<int> DiffBackupIntervalInHours 
    {
        get { Initialize(); return _diffBackupIntervalInHours!; }
        set { Initialize(); _diffBackupIntervalInHours!.Assign(value); }
    }
    private BicepValue<int>? _diffBackupIntervalInHours;

    /// <summary>
    /// The backup retention period in days. This is how many days
    /// Point-in-Time Restore will be supported.
    /// </summary>
    public BicepValue<int> RetentionDays 
    {
        get { Initialize(); return _retentionDays!; }
        set { Initialize(); _retentionDays!.Assign(value); }
    }
    private BicepValue<int>? _retentionDays;

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
    /// Gets or sets a reference to the parent SqlDatabase.
    /// </summary>
    public SqlDatabase? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<SqlDatabase>? _parent;

    /// <summary>
    /// Creates a new BackupShortTermRetentionPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the BackupShortTermRetentionPolicy
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the BackupShortTermRetentionPolicy.</param>
    public BackupShortTermRetentionPolicy(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/backupShortTermRetentionPolicies", resourceVersion ?? "2023-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// BackupShortTermRetentionPolicy.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _diffBackupIntervalInHours = DefineProperty<int>("DiffBackupIntervalInHours", ["properties", "diffBackupIntervalInHours"]);
        _retentionDays = DefineProperty<int>("RetentionDays", ["properties", "retentionDays"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<SqlDatabase>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported BackupShortTermRetentionPolicy resource versions.
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
    /// Creates a reference to an existing BackupShortTermRetentionPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the BackupShortTermRetentionPolicy
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the BackupShortTermRetentionPolicy.</param>
    /// <returns>The existing BackupShortTermRetentionPolicy resource.</returns>
    public static BackupShortTermRetentionPolicy FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
