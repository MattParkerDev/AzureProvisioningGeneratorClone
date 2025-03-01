// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Storage properties of a server.
/// </summary>
public partial class PostgreSqlFlexibleServerStorage : ProvisionableConstruct
{
    /// <summary>
    /// Max storage allowed for a server.
    /// </summary>
    public BicepValue<int> StorageSizeInGB 
    {
        get { Initialize(); return _storageSizeInGB!; }
        set { Initialize(); _storageSizeInGB!.Assign(value); }
    }
    private BicepValue<int>? _storageSizeInGB;

    /// <summary>
    /// Flag to enable / disable Storage Auto grow for flexible server.
    /// </summary>
    public BicepValue<StorageAutoGrow> AutoGrow 
    {
        get { Initialize(); return _autoGrow!; }
        set { Initialize(); _autoGrow!.Assign(value); }
    }
    private BicepValue<StorageAutoGrow>? _autoGrow;

    /// <summary>
    /// Name of storage tier for IOPS.
    /// </summary>
    public BicepValue<PostgreSqlManagedDiskPerformanceTier> Tier 
    {
        get { Initialize(); return _tier!; }
        set { Initialize(); _tier!.Assign(value); }
    }
    private BicepValue<PostgreSqlManagedDiskPerformanceTier>? _tier;

    /// <summary>
    /// Storage tier IOPS quantity. This property is required to be set for
    /// storage Type PremiumV2_LRS.
    /// </summary>
    public BicepValue<int> Iops 
    {
        get { Initialize(); return _iops!; }
        set { Initialize(); _iops!.Assign(value); }
    }
    private BicepValue<int>? _iops;

    /// <summary>
    /// Storage throughput for the server. This is required to be set for
    /// storage Type PremiumV2_LRS.
    /// </summary>
    public BicepValue<int> Throughput 
    {
        get { Initialize(); return _throughput!; }
        set { Initialize(); _throughput!.Assign(value); }
    }
    private BicepValue<int>? _throughput;

    /// <summary>
    /// Storage type for the server. Allowed values are Premium_LRS and
    /// PremiumV2_LRS, and default is Premium_LRS if not specified.
    /// </summary>
    public BicepValue<PostgreSqlFlexibleServersStorageType> StorageType 
    {
        get { Initialize(); return _storageType!; }
        set { Initialize(); _storageType!.Assign(value); }
    }
    private BicepValue<PostgreSqlFlexibleServersStorageType>? _storageType;

    /// <summary>
    /// Creates a new PostgreSqlFlexibleServerStorage.
    /// </summary>
    public PostgreSqlFlexibleServerStorage()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// PostgreSqlFlexibleServerStorage.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _storageSizeInGB = DefineProperty<int>("StorageSizeInGB", ["storageSizeGB"]);
        _autoGrow = DefineProperty<StorageAutoGrow>("AutoGrow", ["autoGrow"]);
        _tier = DefineProperty<PostgreSqlManagedDiskPerformanceTier>("Tier", ["tier"]);
        _iops = DefineProperty<int>("Iops", ["iops"]);
        _throughput = DefineProperty<int>("Throughput", ["throughput"]);
        _storageType = DefineProperty<PostgreSqlFlexibleServersStorageType>("StorageType", ["type"]);
    }
}
