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
/// Service mesh profile for a managed cluster.
/// </summary>
public partial class ServiceMeshProfile : ProvisionableConstruct
{
    /// <summary>
    /// Mode of the service mesh.
    /// </summary>
    public BicepValue<ServiceMeshMode> Mode 
    {
        get { Initialize(); return _mode!; }
        set { Initialize(); _mode!.Assign(value); }
    }
    private BicepValue<ServiceMeshMode>? _mode;

    /// <summary>
    /// Istio service mesh configuration.
    /// </summary>
    public IstioServiceMesh Istio 
    {
        get { Initialize(); return _istio!; }
        set { Initialize(); AssignOrReplace(ref _istio, value); }
    }
    private IstioServiceMesh? _istio;

    /// <summary>
    /// Creates a new ServiceMeshProfile.
    /// </summary>
    public ServiceMeshProfile()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ServiceMeshProfile.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _mode = DefineProperty<ServiceMeshMode>("Mode", ["mode"]);
        _istio = DefineModelProperty<IstioServiceMesh>("Istio", ["istio"]);
    }
}
