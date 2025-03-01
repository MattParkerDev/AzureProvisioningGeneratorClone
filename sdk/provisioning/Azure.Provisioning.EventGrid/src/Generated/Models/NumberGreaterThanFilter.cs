// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// NumberGreaterThan Filter.
/// </summary>
public partial class NumberGreaterThanFilter : EventGridFilter
{
    /// <summary>
    /// The filter value.
    /// </summary>
    public BicepValue<double> Value 
    {
        get { Initialize(); return _value!; }
        set { Initialize(); _value!.Assign(value); }
    }
    private BicepValue<double>? _value;

    /// <summary>
    /// Creates a new NumberGreaterThanFilter.
    /// </summary>
    public NumberGreaterThanFilter() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of NumberGreaterThanFilter.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _value = DefineProperty<double>("Value", ["Value"]);
    }
}
