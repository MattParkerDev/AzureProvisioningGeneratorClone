// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

namespace Azure.Provisioning.Redis;

/// <summary>
/// Optional: Specifies how availability zones are allocated to the Redis
/// cache. &apos;Automatic&apos; enables zone redundancy and Azure will
/// automatically select zones based on regional availability and capacity.
/// &apos;UserDefined&apos; will select availability zones passed in by you
/// using the &apos;zones&apos; parameter. &apos;NoZones&apos; will produce a
/// non-zonal cache. If &apos;zonalAllocationPolicy&apos; is not passed, it
/// will be set to &apos;UserDefined&apos; when zones are passed in,
/// otherwise, it will be set to &apos;Automatic&apos; in regions where zones
/// are supported and &apos;NoZones&apos; in regions where zones are not
/// supported.
/// </summary>
public enum ZonalAllocationPolicy
{
    /// <summary>
    /// Automatic.
    /// </summary>
    Automatic,

    /// <summary>
    /// UserDefined.
    /// </summary>
    UserDefined,

    /// <summary>
    /// NoZones.
    /// </summary>
    NoZones,
}
