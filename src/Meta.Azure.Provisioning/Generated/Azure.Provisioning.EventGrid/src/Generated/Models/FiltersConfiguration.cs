// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Filters configuration for the Event Subscription.
/// </summary>
public partial class FiltersConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// A list of applicable event types that need to be part of the event
    /// subscription. If it is desired to subscribe to all default event
    /// types, set the IncludedEventTypes to null.
    /// </summary>
    public BicepList<string> IncludedEventTypes 
    {
        get { Initialize(); return _includedEventTypes!; }
        set { Initialize(); _includedEventTypes!.Assign(value); }
    }
    private BicepList<string>? _includedEventTypes;

    /// <summary>
    /// An array of filters that are used for filtering event subscriptions.
    /// Please note
    /// Azure.ResourceManager.EventGrid.Models.EventGridFilter is the base
    /// class. According to the scenario, a derived class of the base class
    /// might need to be assigned here, or this property needs to be casted to
    /// one of the possible derived classes.             The available derived
    /// classes include
    /// Azure.ResourceManager.EventGrid.Models.BoolEqualsFilter,
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
    public BicepList<EventGridFilter> Filters 
    {
        get { Initialize(); return _filters!; }
        set { Initialize(); _filters!.Assign(value); }
    }
    private BicepList<EventGridFilter>? _filters;

    /// <summary>
    /// Creates a new FiltersConfiguration.
    /// </summary>
    public FiltersConfiguration()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of FiltersConfiguration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _includedEventTypes = DefineListProperty<string>("IncludedEventTypes", ["includedEventTypes"]);
        _filters = DefineListProperty<EventGridFilter>("Filters", ["filters"]);
    }
}
