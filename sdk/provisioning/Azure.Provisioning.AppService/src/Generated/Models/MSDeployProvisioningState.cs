// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Provisioning state.
/// </summary>
public enum MSDeployProvisioningState
{
    /// <summary>
    /// accepted.
    /// </summary>
    [DataMember(Name = "accepted")]
    Accepted,

    /// <summary>
    /// running.
    /// </summary>
    [DataMember(Name = "running")]
    Running,

    /// <summary>
    /// succeeded.
    /// </summary>
    [DataMember(Name = "succeeded")]
    Succeeded,

    /// <summary>
    /// failed.
    /// </summary>
    [DataMember(Name = "failed")]
    Failed,

    /// <summary>
    /// canceled.
    /// </summary>
    [DataMember(Name = "canceled")]
    Canceled,
}
