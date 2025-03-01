// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.Resources;

/// <summary>
/// denyAssignment settings applied to the resource.
/// </summary>
public enum DenyStatusMode
{
    /// <summary>
    /// Authorized users are able to read and modify the resources, but cannot
    /// delete.
    /// </summary>
    [DataMember(Name = "denyDelete")]
    DenyDelete,

    /// <summary>
    /// Resource type does not support denyAssignments.
    /// </summary>
    [DataMember(Name = "notSupported")]
    NotSupported,

    /// <summary>
    /// denyAssignments are not supported on resources outside the scope of the
    /// deployment stack.
    /// </summary>
    [DataMember(Name = "inapplicable")]
    Inapplicable,

    /// <summary>
    /// Authorized users can only read from a resource, but cannot modify or
    /// delete it.
    /// </summary>
    [DataMember(Name = "denyWriteAndDelete")]
    DenyWriteAndDelete,

    /// <summary>
    /// Deny assignment has been removed by Azure due to a resource management
    /// change (management group move, etc.).
    /// </summary>
    [DataMember(Name = "removedBySystem")]
    RemovedBySystem,

    /// <summary>
    /// No denyAssignments have been applied.
    /// </summary>
    [DataMember(Name = "none")]
    None,
}
