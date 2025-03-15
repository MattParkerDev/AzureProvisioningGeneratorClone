// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// File Share Paid Bursting properties.
/// </summary>
public partial class FileSharePropertiesFileSharePaidBursting : ProvisionableConstruct
{
    /// <summary>
    /// Indicates whether paid bursting is enabled for the share. This property
    /// is only for file shares created under Files Provisioned v1 SSD account
    /// type.
    /// </summary>
    public BicepValue<bool> PaidBurstingEnabled 
    {
        get { Initialize(); return _paidBurstingEnabled!; }
        set { Initialize(); _paidBurstingEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _paidBurstingEnabled;

    /// <summary>
    /// The maximum paid bursting IOPS for the share. This property is only for
    /// file shares created under Files Provisioned v1 SSD account type. The
    /// maximum allowed value is 102400 which is the maximum allowed IOPS for
    /// a share.
    /// </summary>
    public BicepValue<int> PaidBurstingMaxIops 
    {
        get { Initialize(); return _paidBurstingMaxIops!; }
        set { Initialize(); _paidBurstingMaxIops!.Assign(value); }
    }
    private BicepValue<int>? _paidBurstingMaxIops;

    /// <summary>
    /// The maximum paid bursting bandwidth for the share, in mebibytes per
    /// second. This property is only for file shares created under Files
    /// Provisioned v1 SSD account type. The maximum allowed value is 10340
    /// which is the maximum allowed bandwidth for a share.
    /// </summary>
    public BicepValue<int> PaidBurstingMaxBandwidthMibps 
    {
        get { Initialize(); return _paidBurstingMaxBandwidthMibps!; }
        set { Initialize(); _paidBurstingMaxBandwidthMibps!.Assign(value); }
    }
    private BicepValue<int>? _paidBurstingMaxBandwidthMibps;

    /// <summary>
    /// Creates a new FileSharePropertiesFileSharePaidBursting.
    /// </summary>
    public FileSharePropertiesFileSharePaidBursting()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// FileSharePropertiesFileSharePaidBursting.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _paidBurstingEnabled = DefineProperty<bool>("PaidBurstingEnabled", ["paidBurstingEnabled"]);
        _paidBurstingMaxIops = DefineProperty<int>("PaidBurstingMaxIops", ["paidBurstingMaxIops"]);
        _paidBurstingMaxBandwidthMibps = DefineProperty<int>("PaidBurstingMaxBandwidthMibps", ["paidBurstingMaxBandwidthMibps"]);
    }
}
