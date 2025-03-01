// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Istio components configuration.
/// </summary>
public partial class IstioComponents : ProvisionableConstruct
{
    /// <summary>
    /// Istio ingress gateways.
    /// </summary>
    public BicepList<IstioIngressGateway> IngressGateways 
    {
        get { Initialize(); return _ingressGateways!; }
        set { Initialize(); _ingressGateways!.Assign(value); }
    }
    private BicepList<IstioIngressGateway>? _ingressGateways;

    /// <summary>
    /// Istio egress gateways.
    /// </summary>
    public BicepList<IstioEgressGateway> EgressGateways 
    {
        get { Initialize(); return _egressGateways!; }
        set { Initialize(); _egressGateways!.Assign(value); }
    }
    private BicepList<IstioEgressGateway>? _egressGateways;

    /// <summary>
    /// Creates a new IstioComponents.
    /// </summary>
    public IstioComponents()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of IstioComponents.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _ingressGateways = DefineListProperty<IstioIngressGateway>("IngressGateways", ["IngressGateways"]);
        _egressGateways = DefineListProperty<IstioEgressGateway>("EgressGateways", ["EgressGateways"]);
    }
}
