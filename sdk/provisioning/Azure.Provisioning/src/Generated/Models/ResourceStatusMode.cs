// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Current management state of the resource in the deployment stack.
/// </summary>
public enum ResourceStatusMode
{
    /// <summary>
    /// This resource is managed by the deployment stack.
    /// </summary>
    [DataMember(Name = "managed")]
    Managed,

    /// <summary>
    /// Unable to remove the deny assignment on resource.
    /// </summary>
    [DataMember(Name = "removeDenyFailed")]
    RemoveDenyFailed,

    /// <summary>
    /// Unable to delete the resource from Azure. The delete will be retried on
    /// the next stack deployment, or can be deleted manually.
    /// </summary>
    [DataMember(Name = "deleteFailed")]
    DeleteFailed,
}
