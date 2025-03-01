// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Properties of the destination info for event subscription supporting push.
/// </summary>
public partial class PushInfo : ProvisionableConstruct
{
    /// <summary>
    /// The maximum delivery count of the events.
    /// </summary>
    public BicepValue<int> MaxDeliveryCount 
    {
        get { Initialize(); return _maxDeliveryCount!; }
        set { Initialize(); _maxDeliveryCount!.Assign(value); }
    }
    private BicepValue<int>? _maxDeliveryCount;

    /// <summary>
    /// Time span duration in ISO 8601 format that determines how long messages
    /// are available to the subscription from the time the message was
    /// published.             This duration value is expressed using the
    /// following format: \&apos;P(n)Y(n)M(n)DT(n)H(n)M(n)S\&apos;, where:
    /// - (n) is replaced by the value of each time element
    /// that follows the (n).                 - P is the duration (or Period)
    /// designator and is always placed at the beginning of the duration.
    /// - Y is the year designator, and it follows the value
    /// for the number of years.                 - M is the month designator,
    /// and it follows the value for the number of months.                 - W
    /// is the week designator, and it follows the value for the number of
    /// weeks.                 - D is the day designator, and it follows the
    /// value for the number of days.                 - T is the time
    /// designator, and it precedes the time components.                 - H
    /// is the hour designator, and it follows the value for the number of
    /// hours.                 - M is the minute designator, and it follows
    /// the value for the number of minutes.                 - S is the second
    /// designator, and it follows the value for the number of seconds.
    /// This duration value cannot be set greater than the topic’s
    /// EventRetentionInDays. It is is an optional field where its minimum
    /// value is 1 minute, and its maximum is determined             by
    /// topic’s EventRetentionInDays value. The followings are examples of
    /// valid values:                 - \&apos;P0DT23H12M\&apos; or
    /// \&apos;PT23H12M\&apos;: for duration of 23 hours and 12 minutes.
    /// - \&apos;P1D\&apos; or \&apos;P1DT0H0M0S\&apos;: for
    /// duration of 1 day.
    /// </summary>
    public BicepValue<string> EventTimeToLive 
    {
        get { Initialize(); return _eventTimeToLive!; }
        set { Initialize(); _eventTimeToLive!.Assign(value); }
    }
    private BicepValue<string>? _eventTimeToLive;

    /// <summary>
    /// The dead letter destination of the event subscription. Any event that
    /// cannot be delivered to its&apos; destination is sent to the dead
    /// letter destination.             Uses the managed identity setup on the
    /// parent resource (namely, namespace) to acquire the authentication
    /// tokens being used during dead-lettering.
    /// </summary>
    public DeadLetterWithResourceIdentity DeadLetterDestinationWithResourceIdentity 
    {
        get { Initialize(); return _deadLetterDestinationWithResourceIdentity!; }
        set { Initialize(); AssignOrReplace(ref _deadLetterDestinationWithResourceIdentity, value); }
    }
    private DeadLetterWithResourceIdentity? _deadLetterDestinationWithResourceIdentity;

    /// <summary>
    /// Information about the destination where events have to be delivered for
    /// the event subscription.             Uses the managed identity setup on
    /// the parent resource (namely, topic or domain) to acquire the
    /// authentication tokens being used during delivery.
    /// </summary>
    public DeliveryWithResourceIdentity DeliveryWithResourceIdentity 
    {
        get { Initialize(); return _deliveryWithResourceIdentity!; }
        set { Initialize(); AssignOrReplace(ref _deliveryWithResourceIdentity, value); }
    }
    private DeliveryWithResourceIdentity? _deliveryWithResourceIdentity;

    /// <summary>
    /// Information about the destination where events have to be delivered for
    /// the event subscription.             Uses Azure Event Grid&apos;s
    /// identity to acquire the authentication tokens being used during
    /// delivery.             Please note
    /// Azure.ResourceManager.EventGrid.Models.EventSubscriptionDestination is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.EventGrid.Models.AzureFunctionEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.EventHubEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.HybridConnectionEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.MonitorAlertEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.NamespaceTopicEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.PartnerEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.ServiceBusQueueEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.ServiceBusTopicEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.StorageQueueEventSubscriptionDestination
    /// and
    /// Azure.ResourceManager.EventGrid.Models.WebHookEventSubscriptionDestination.
    /// </summary>
    public EventSubscriptionDestination Destination 
    {
        get { Initialize(); return _destination!; }
        set { Initialize(); AssignOrReplace(ref _destination, value); }
    }
    private EventSubscriptionDestination? _destination;

    /// <summary>
    /// Creates a new PushInfo.
    /// </summary>
    public PushInfo()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of PushInfo.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _maxDeliveryCount = DefineProperty<int>("MaxDeliveryCount", ["MaxDeliveryCount"]);
        _eventTimeToLive = DefineProperty<string>("EventTimeToLive", ["EventTimeToLive"]);
        _deadLetterDestinationWithResourceIdentity = DefineModelProperty<DeadLetterWithResourceIdentity>("DeadLetterDestinationWithResourceIdentity", ["DeadLetterDestinationWithResourceIdentity"]);
        _deliveryWithResourceIdentity = DefineModelProperty<DeliveryWithResourceIdentity>("DeliveryWithResourceIdentity", ["DeliveryWithResourceIdentity"]);
        _destination = DefineModelProperty<EventSubscriptionDestination>("Destination", ["Destination"]);
    }
}
