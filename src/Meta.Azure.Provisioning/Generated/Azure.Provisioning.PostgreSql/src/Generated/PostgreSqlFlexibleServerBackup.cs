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
/// PostgreSqlFlexibleServerBackup.
/// </summary>
public partial class PostgreSqlFlexibleServerBackup : ProvisionableResource
{
    /// <summary>
    /// The name of the backup.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Backup type.
    /// </summary>
    public BicepValue<PostgreSqlFlexibleServerBackupOrigin> BackupType 
    {
        get { Initialize(); return _backupType!; }
    }
    private BicepValue<PostgreSqlFlexibleServerBackupOrigin>? _backupType;

    /// <summary>
    /// Backup completed time (ISO8601 format).
    /// </summary>
    public BicepValue<DateTimeOffset> CompletedOn 
    {
        get { Initialize(); return _completedOn!; }
    }
    private BicepValue<DateTimeOffset>? _completedOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Backup source.
    /// </summary>
    public BicepValue<string> Source 
    {
        get { Initialize(); return _source!; }
    }
    private BicepValue<string>? _source;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

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
    /// Creates a new PostgreSqlFlexibleServerBackup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PostgreSqlFlexibleServerBackup
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlFlexibleServerBackup.</param>
    public PostgreSqlFlexibleServerBackup(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DBforPostgreSQL/flexibleServers/backups", resourceVersion ?? "2024-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// PostgreSqlFlexibleServerBackup.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _backupType = DefineProperty<PostgreSqlFlexibleServerBackupOrigin>("BackupType", ["properties", "backupType"], isOutput: true);
        _completedOn = DefineProperty<DateTimeOffset>("CompletedOn", ["properties", "completedTime"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _source = DefineProperty<string>("Source", ["properties", "source"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<PostgreSqlFlexibleServer>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported PostgreSqlFlexibleServerBackup resource versions.
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
    /// Creates a reference to an existing PostgreSqlFlexibleServerBackup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PostgreSqlFlexibleServerBackup
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlFlexibleServerBackup.</param>
    /// <returns>The existing PostgreSqlFlexibleServerBackup resource.</returns>
    public static PostgreSqlFlexibleServerBackup FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
