// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Specifies an action for a newly unmanaged resource. Delete will attempt to
/// delete the resource from Azure. Detach will leave the resource in
/// it&apos;s current state.
/// </summary>
public enum DeploymentStacksDeleteDetachEnum
{
    /// <summary>
    /// delete.
    /// </summary>
    [DataMember(Name = "delete")]
    Delete,

    /// <summary>
    /// detach.
    /// </summary>
    [DataMember(Name = "detach")]
    Detach,
}
