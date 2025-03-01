// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Workload Auto-scaler profile for the managed cluster.
/// </summary>
public partial class ManagedClusterWorkloadAutoScalerProfile : ProvisionableConstruct
{
    /// <summary>
    /// Whether to enable KEDA.
    /// </summary>
    public BicepValue<bool> IsKedaEnabled 
    {
        get { Initialize(); return _isKedaEnabled!; }
        set { Initialize(); _isKedaEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isKedaEnabled;

    /// <summary>
    /// Whether to enable VPA. Default value is false.
    /// </summary>
    public BicepValue<bool> IsVpaEnabled 
    {
        get { Initialize(); return _isVpaEnabled!; }
        set { Initialize(); _isVpaEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isVpaEnabled;

    /// <summary>
    /// Creates a new ManagedClusterWorkloadAutoScalerProfile.
    /// </summary>
    public ManagedClusterWorkloadAutoScalerProfile()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedClusterWorkloadAutoScalerProfile.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _isKedaEnabled = DefineProperty<bool>("IsKedaEnabled", ["IsKedaEnabled"]);
        _isVpaEnabled = DefineProperty<bool>("IsVpaEnabled", ["IsVpaEnabled"]);
    }
}
