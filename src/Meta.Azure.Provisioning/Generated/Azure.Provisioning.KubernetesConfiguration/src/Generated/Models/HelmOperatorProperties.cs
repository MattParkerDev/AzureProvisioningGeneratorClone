// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.KubernetesConfiguration;

/// <summary>
/// Properties for Helm operator.
/// </summary>
public partial class HelmOperatorProperties : ProvisionableConstruct
{
    /// <summary>
    /// Version of the operator Helm chart.
    /// </summary>
    public BicepValue<string> ChartVersion 
    {
        get { Initialize(); return _chartVersion!; }
        set { Initialize(); _chartVersion!.Assign(value); }
    }
    private BicepValue<string>? _chartVersion;

    /// <summary>
    /// Values override for the operator Helm chart.
    /// </summary>
    public BicepValue<string> ChartValues 
    {
        get { Initialize(); return _chartValues!; }
        set { Initialize(); _chartValues!.Assign(value); }
    }
    private BicepValue<string>? _chartValues;

    /// <summary>
    /// Creates a new HelmOperatorProperties.
    /// </summary>
    public HelmOperatorProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of HelmOperatorProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _chartVersion = DefineProperty<string>("ChartVersion", ["ChartVersion"]);
        _chartValues = DefineProperty<string>("ChartValues", ["ChartValues"]);
    }
}
