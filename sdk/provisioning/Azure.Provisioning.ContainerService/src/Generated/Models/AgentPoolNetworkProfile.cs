// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Network settings of an agent pool.
/// </summary>
public partial class AgentPoolNetworkProfile : ProvisionableConstruct
{
    /// <summary>
    /// IPTags of instance-level public IPs.
    /// </summary>
    public BicepList<ContainerServiceIPTag> NodePublicIPTags 
    {
        get { Initialize(); return _nodePublicIPTags!; }
        set { Initialize(); _nodePublicIPTags!.Assign(value); }
    }
    private BicepList<ContainerServiceIPTag>? _nodePublicIPTags;

    /// <summary>
    /// The port ranges that are allowed to access. The specified ranges are
    /// allowed to overlap.
    /// </summary>
    public BicepList<AgentPoolNetworkPortRange> AllowedHostPorts 
    {
        get { Initialize(); return _allowedHostPorts!; }
        set { Initialize(); _allowedHostPorts!.Assign(value); }
    }
    private BicepList<AgentPoolNetworkPortRange>? _allowedHostPorts;

    /// <summary>
    /// The IDs of the application security groups which agent pool will
    /// associate when created.
    /// </summary>
    public BicepList<ResourceIdentifier> ApplicationSecurityGroups 
    {
        get { Initialize(); return _applicationSecurityGroups!; }
        set { Initialize(); _applicationSecurityGroups!.Assign(value); }
    }
    private BicepList<ResourceIdentifier>? _applicationSecurityGroups;

    /// <summary>
    /// Creates a new AgentPoolNetworkProfile.
    /// </summary>
    public AgentPoolNetworkProfile()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AgentPoolNetworkProfile.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _nodePublicIPTags = DefineListProperty<ContainerServiceIPTag>("NodePublicIPTags", ["NodePublicIPTags"]);
        _allowedHostPorts = DefineListProperty<AgentPoolNetworkPortRange>("AllowedHostPorts", ["AllowedHostPorts"]);
        _applicationSecurityGroups = DefineListProperty<ResourceIdentifier>("ApplicationSecurityGroups", ["ApplicationSecurityGroups"]);
    }
}
