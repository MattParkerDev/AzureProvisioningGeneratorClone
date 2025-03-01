// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Sets the promote options for a replica server. This is a write only
/// property.
/// </summary>
public enum ReplicationPromoteOption
{
    /// <summary>
    /// planned.
    /// </summary>
    [DataMember(Name = "planned")]
    Planned,

    /// <summary>
    /// forced.
    /// </summary>
    [DataMember(Name = "forced")]
    Forced,
}
