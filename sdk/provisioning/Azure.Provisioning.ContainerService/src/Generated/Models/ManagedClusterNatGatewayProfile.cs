// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Profile of the managed cluster NAT gateway.
/// </summary>
public partial class ManagedClusterNatGatewayProfile : ProvisionableConstruct
{
    /// <summary>
    /// The desired number of outbound IPs created/managed by Azure. Allowed
    /// values must be in the range of 1 to 16 (inclusive). The default value
    /// is 1.
    /// </summary>
    public BicepValue<int> ManagedOutboundIPCount 
    {
        get { Initialize(); return _managedOutboundIPCount!; }
        set { Initialize(); _managedOutboundIPCount!.Assign(value); }
    }
    private BicepValue<int>? _managedOutboundIPCount;

    /// <summary>
    /// The effective outbound IP resources of the cluster NAT gateway.
    /// </summary>
    public BicepList<WritableSubResource> EffectiveOutboundIPs 
    {
        get { Initialize(); return _effectiveOutboundIPs!; }
        set { Initialize(); _effectiveOutboundIPs!.Assign(value); }
    }
    private BicepList<WritableSubResource>? _effectiveOutboundIPs;

    /// <summary>
    /// Desired outbound flow idle timeout in minutes. Allowed values are in
    /// the range of 4 to 120 (inclusive). The default value is 4 minutes.
    /// </summary>
    public BicepValue<int> IdleTimeoutInMinutes 
    {
        get { Initialize(); return _idleTimeoutInMinutes!; }
        set { Initialize(); _idleTimeoutInMinutes!.Assign(value); }
    }
    private BicepValue<int>? _idleTimeoutInMinutes;

    /// <summary>
    /// Creates a new ManagedClusterNatGatewayProfile.
    /// </summary>
    public ManagedClusterNatGatewayProfile()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedClusterNatGatewayProfile.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _managedOutboundIPCount = DefineProperty<int>("ManagedOutboundIPCount", ["ManagedOutboundIPCount"]);
        _effectiveOutboundIPs = DefineListProperty<WritableSubResource>("EffectiveOutboundIPs", ["EffectiveOutboundIPs"]);
        _idleTimeoutInMinutes = DefineProperty<int>("IdleTimeoutInMinutes", ["IdleTimeoutInMinutes"]);
    }
}
