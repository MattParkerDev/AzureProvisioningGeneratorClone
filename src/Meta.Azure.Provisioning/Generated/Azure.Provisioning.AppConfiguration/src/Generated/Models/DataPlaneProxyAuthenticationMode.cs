// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.AppConfiguration;

/// <summary>
/// The data plane proxy authentication mode. This property manages the
/// authentication mode of request to the data plane resources.
/// </summary>
public enum DataPlaneProxyAuthenticationMode
{
    /// <summary>
    /// The local authentication mode. Users are not required to have data
    /// plane permissions if local authentication is not disabled.
    /// </summary>
    Local,

    /// <summary>
    /// The pass-through authentication mode. User identity will be passed
    /// through from Azure Resource Manager (ARM), requiring user to have data
    /// plane action permissions (Available via App Configuration Data Owner/
    /// App Configuration Data Reader).
    /// </summary>
    [DataMember(Name = "Pass-through")]
    PassThrough,
}
