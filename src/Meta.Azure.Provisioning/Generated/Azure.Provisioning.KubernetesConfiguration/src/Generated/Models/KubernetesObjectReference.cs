// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.KubernetesConfiguration;

/// <summary>
/// Object reference to a Kubernetes object on a cluster.
/// </summary>
public partial class KubernetesObjectReference : ProvisionableConstruct
{
    /// <summary>
    /// Name of the object.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Namespace of the object.
    /// </summary>
    public BicepValue<string> Namespace 
    {
        get { Initialize(); return _namespace!; }
    }
    private BicepValue<string>? _namespace;

    /// <summary>
    /// Creates a new KubernetesObjectReference.
    /// </summary>
    public KubernetesObjectReference()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of KubernetesObjectReference.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _namespace = DefineProperty<string>("Namespace", ["Namespace"], isOutput: true);
    }
}
