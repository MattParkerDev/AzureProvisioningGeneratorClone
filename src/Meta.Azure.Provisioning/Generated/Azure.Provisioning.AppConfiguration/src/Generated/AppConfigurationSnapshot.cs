// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppConfiguration;

/// <summary>
/// AppConfigurationSnapshot.
/// </summary>
public partial class AppConfigurationSnapshot : ProvisionableResource
{
    /// <summary>
    /// The name of the snapshot.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The composition type describes how the key-values within the snapshot
    /// are composed. The &apos;key&apos; composition type ensures there are
    /// no two key-values containing the same key. The &apos;key_label&apos;
    /// composition type ensures there are no two key-values containing the
    /// same key and label.
    /// </summary>
    public BicepValue<SnapshotCompositionType> CompositionType 
    {
        get { Initialize(); return _compositionType!; }
        set { Initialize(); _compositionType!.Assign(value); }
    }
    private BicepValue<SnapshotCompositionType>? _compositionType;

    /// <summary>
    /// A list of filters used to filter the key-values included in the
    /// snapshot.
    /// </summary>
    public BicepList<SnapshotKeyValueFilter> Filters 
    {
        get { Initialize(); return _filters!; }
        set { Initialize(); _filters!.Assign(value); }
    }
    private BicepList<SnapshotKeyValueFilter>? _filters;

    /// <summary>
    /// The amount of time, in seconds, that a snapshot will remain in the
    /// archived state before expiring. This property is only writable during
    /// the creation of a snapshot. If not specified, the default lifetime of
    /// key-value revisions will be used.
    /// </summary>
    public BicepValue<long> RetentionPeriod 
    {
        get { Initialize(); return _retentionPeriod!; }
        set { Initialize(); _retentionPeriod!.Assign(value); }
    }
    private BicepValue<long>? _retentionPeriod;

    /// <summary>
    /// The tags of the snapshot. NOTE: These are data plane tags, not Azure
    /// Resource Manager (ARM) tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// The time that the snapshot was created.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn 
    {
        get { Initialize(); return _createdOn!; }
    }
    private BicepValue<DateTimeOffset>? _createdOn;

    /// <summary>
    /// A value representing the current state of the snapshot.
    /// </summary>
    public BicepValue<ETag> ETag 
    {
        get { Initialize(); return _eTag!; }
    }
    private BicepValue<ETag>? _eTag;

    /// <summary>
    /// The time that the snapshot will expire.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn 
    {
        get { Initialize(); return _expireOn!; }
    }
    private BicepValue<DateTimeOffset>? _expireOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The amount of key-values in the snapshot.
    /// </summary>
    public BicepValue<long> ItemsCount 
    {
        get { Initialize(); return _itemsCount!; }
    }
    private BicepValue<long>? _itemsCount;

    /// <summary>
    /// The provisioning state of the snapshot.
    /// </summary>
    public BicepValue<AppConfigurationProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<AppConfigurationProvisioningState>? _provisioningState;

    /// <summary>
    /// The size in bytes of the snapshot.
    /// </summary>
    public BicepValue<long> Size 
    {
        get { Initialize(); return _size!; }
    }
    private BicepValue<long>? _size;

    /// <summary>
    /// The type of the resource.
    /// </summary>
    public BicepValue<string> SnapshotType 
    {
        get { Initialize(); return _snapshotType!; }
    }
    private BicepValue<string>? _snapshotType;

    /// <summary>
    /// The current status of the snapshot.
    /// </summary>
    public BicepValue<AppConfigurationSnapshotStatus> Status 
    {
        get { Initialize(); return _status!; }
    }
    private BicepValue<AppConfigurationSnapshotStatus>? _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent AppConfigurationStore.
    /// </summary>
    public AppConfigurationStore? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<AppConfigurationStore>? _parent;

    /// <summary>
    /// Creates a new AppConfigurationSnapshot.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppConfigurationSnapshot resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppConfigurationSnapshot.</param>
    public AppConfigurationSnapshot(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.AppConfiguration/configurationStores/snapshots", resourceVersion ?? "2024-06-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AppConfigurationSnapshot.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _compositionType = DefineProperty<SnapshotCompositionType>("CompositionType", ["properties", "compositionType"]);
        _filters = DefineListProperty<SnapshotKeyValueFilter>("Filters", ["properties", "filters"]);
        _retentionPeriod = DefineProperty<long>("RetentionPeriod", ["properties", "retentionPeriod"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["properties", "tags"]);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["properties", "created"], isOutput: true);
        _eTag = DefineProperty<ETag>("ETag", ["properties", "etag"], isOutput: true);
        _expireOn = DefineProperty<DateTimeOffset>("ExpireOn", ["properties", "expires"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _itemsCount = DefineProperty<long>("ItemsCount", ["properties", "itemsCount"], isOutput: true);
        _provisioningState = DefineProperty<AppConfigurationProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _size = DefineProperty<long>("Size", ["properties", "size"], isOutput: true);
        _snapshotType = DefineProperty<string>("SnapshotType", ["type"], isOutput: true);
        _status = DefineProperty<AppConfigurationSnapshotStatus>("Status", ["properties", "status"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<AppConfigurationStore>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported AppConfigurationSnapshot resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-06-01.
        /// </summary>
        public static readonly string V2024_06_01 = "2024-06-01";

        /// <summary>
        /// 2024-05-01.
        /// </summary>
        public static readonly string V2024_05_01 = "2024-05-01";
    }

    /// <summary>
    /// Creates a reference to an existing AppConfigurationSnapshot.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppConfigurationSnapshot resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppConfigurationSnapshot.</param>
    /// <returns>The existing AppConfigurationSnapshot resource.</returns>
    public static AppConfigurationSnapshot FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
