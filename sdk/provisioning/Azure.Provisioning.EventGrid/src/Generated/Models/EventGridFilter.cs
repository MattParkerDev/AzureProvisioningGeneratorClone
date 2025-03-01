// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// This is the base type that represents a filter. To configure a filter, do
/// not directly instantiate an object of this class. Instead, instantiate
/// an object of a derived class such as BoolEqualsFilter,
/// NumberInFilter, StringEqualsFilter etc depending on the type of the key
/// based on             which you want to filter.             Please note
/// Azure.ResourceManager.EventGrid.Models.EventGridFilter is the base class.
/// According to the scenario, a derived class of the base class might need to
/// be assigned here, or this property needs to be casted to one of the
/// possible derived classes.             The available derived classes
/// include Azure.ResourceManager.EventGrid.Models.BoolEqualsFilter,
/// Azure.ResourceManager.EventGrid.Models.IsNotNullFilter,
/// Azure.ResourceManager.EventGrid.Models.IsNullOrUndefinedFilter,
/// Azure.ResourceManager.EventGrid.Models.NumberGreaterThanFilter,
/// Azure.ResourceManager.EventGrid.Models.NumberGreaterThanOrEqualsFilter,
/// Azure.ResourceManager.EventGrid.Models.NumberInFilter,
/// Azure.ResourceManager.EventGrid.Models.NumberInRangeFilter,
/// Azure.ResourceManager.EventGrid.Models.NumberLessThanFilter,
/// Azure.ResourceManager.EventGrid.Models.NumberLessThanOrEqualsFilter,
/// Azure.ResourceManager.EventGrid.Models.NumberNotInFilter,
/// Azure.ResourceManager.EventGrid.Models.NumberNotInRangeFilter,
/// Azure.ResourceManager.EventGrid.Models.StringBeginsWithFilter,
/// Azure.ResourceManager.EventGrid.Models.StringContainsFilter,
/// Azure.ResourceManager.EventGrid.Models.StringEndsWithFilter,
/// Azure.ResourceManager.EventGrid.Models.StringInFilter,
/// Azure.ResourceManager.EventGrid.Models.StringNotBeginsWithFilter,
/// Azure.ResourceManager.EventGrid.Models.StringNotContainsFilter,
/// Azure.ResourceManager.EventGrid.Models.StringNotEndsWithFilter and
/// Azure.ResourceManager.EventGrid.Models.StringNotInFilter.
/// </summary>
public partial class EventGridFilter : ProvisionableConstruct
{
    /// <summary>
    /// The field/property in the event based on which you want to filter.
    /// </summary>
    public BicepValue<string> Key 
    {
        get { Initialize(); return _key!; }
        set { Initialize(); _key!.Assign(value); }
    }
    private BicepValue<string>? _key;

    /// <summary>
    /// Creates a new EventGridFilter.
    /// </summary>
    public EventGridFilter()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of EventGridFilter.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _key = DefineProperty<string>("Key", ["Key"]);
    }
}
