// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// StringNotContains Filter.
/// </summary>
public partial class StringNotContainsFilter : EventGridFilter
{
    /// <summary>
    /// The set of filter values.
    /// </summary>
    public BicepList<string> Values 
    {
        get { Initialize(); return _values!; }
        set { Initialize(); _values!.Assign(value); }
    }
    private BicepList<string>? _values;

    /// <summary>
    /// Creates a new StringNotContainsFilter.
    /// </summary>
    public StringNotContainsFilter() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of StringNotContainsFilter.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _values = DefineListProperty<string>("Values", ["Values"]);
    }
}
