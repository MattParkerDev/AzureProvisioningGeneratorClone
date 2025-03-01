// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Data boundary properties.
/// </summary>
public partial class DataBoundaryProperties : ProvisionableConstruct
{
    /// <summary>
    /// The data boundary definition.
    /// </summary>
    public BicepValue<DataBoundaryRegion> DataBoundary 
    {
        get { Initialize(); return _dataBoundary!; }
        set { Initialize(); _dataBoundary!.Assign(value); }
    }
    private BicepValue<DataBoundaryRegion>? _dataBoundary;

    /// <summary>
    /// Denotes the state of provisioning.
    /// </summary>
    public BicepValue<DataBoundaryProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<DataBoundaryProvisioningState>? _provisioningState;

    /// <summary>
    /// Creates a new DataBoundaryProperties.
    /// </summary>
    public DataBoundaryProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of DataBoundaryProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _dataBoundary = DefineProperty<DataBoundaryRegion>("DataBoundary", ["dataBoundary"]);
        _provisioningState = DefineProperty<DataBoundaryProvisioningState>("ProvisioningState", ["provisioningState"], isOutput: true);
    }
}
