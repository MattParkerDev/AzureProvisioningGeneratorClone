// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.ServiceBus;

/// <summary>
/// ServiceBusSubscription.
/// </summary>
public partial class ServiceBusSubscription : ProvisionableResource
{
    /// <summary>
    /// The subscription name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// ISO 8061 timeSpan idle interval after which the topic is automatically
    /// deleted. The minimum duration is 5 minutes.
    /// </summary>
    public BicepValue<TimeSpan> AutoDeleteOnIdle 
    {
        get { Initialize(); return _autoDeleteOnIdle!; }
        set { Initialize(); _autoDeleteOnIdle!.Assign(value); }
    }
    private BicepValue<TimeSpan>? _autoDeleteOnIdle;

    /// <summary>
    /// Properties specific to client affine subscriptions.
    /// </summary>
    public ServiceBusClientAffineProperties ClientAffineProperties 
    {
        get { Initialize(); return _clientAffineProperties!; }
        set { Initialize(); AssignOrReplace(ref _clientAffineProperties, value); }
    }
    private ServiceBusClientAffineProperties? _clientAffineProperties;

    /// <summary>
    /// Value that indicates whether a subscription has dead letter support on
    /// filter evaluation exceptions.
    /// </summary>
    public BicepValue<bool> DeadLetteringOnFilterEvaluationExceptions 
    {
        get { Initialize(); return _deadLetteringOnFilterEvaluationExceptions!; }
        set { Initialize(); _deadLetteringOnFilterEvaluationExceptions!.Assign(value); }
    }
    private BicepValue<bool>? _deadLetteringOnFilterEvaluationExceptions;

    /// <summary>
    /// Value that indicates whether a subscription has dead letter support
    /// when a message expires.
    /// </summary>
    public BicepValue<bool> DeadLetteringOnMessageExpiration 
    {
        get { Initialize(); return _deadLetteringOnMessageExpiration!; }
        set { Initialize(); _deadLetteringOnMessageExpiration!.Assign(value); }
    }
    private BicepValue<bool>? _deadLetteringOnMessageExpiration;

    /// <summary>
    /// ISO 8061 Default message timespan to live value. This is the duration
    /// after which the message expires, starting from when the message is
    /// sent to Service Bus. This is the default value used when TimeToLive is
    /// not set on a message itself.
    /// </summary>
    public BicepValue<TimeSpan> DefaultMessageTimeToLive 
    {
        get { Initialize(); return _defaultMessageTimeToLive!; }
        set { Initialize(); _defaultMessageTimeToLive!.Assign(value); }
    }
    private BicepValue<TimeSpan>? _defaultMessageTimeToLive;

    /// <summary>
    /// ISO 8601 timeSpan structure that defines the duration of the duplicate
    /// detection history. The default value is 10 minutes.
    /// </summary>
    public BicepValue<TimeSpan> DuplicateDetectionHistoryTimeWindow 
    {
        get { Initialize(); return _duplicateDetectionHistoryTimeWindow!; }
        set { Initialize(); _duplicateDetectionHistoryTimeWindow!.Assign(value); }
    }
    private BicepValue<TimeSpan>? _duplicateDetectionHistoryTimeWindow;

    /// <summary>
    /// Value that indicates whether server-side batched operations are enabled.
    /// </summary>
    public BicepValue<bool> EnableBatchedOperations 
    {
        get { Initialize(); return _enableBatchedOperations!; }
        set { Initialize(); _enableBatchedOperations!.Assign(value); }
    }
    private BicepValue<bool>? _enableBatchedOperations;

    /// <summary>
    /// Queue/Topic name to forward the Dead Letter message.
    /// </summary>
    public BicepValue<string> ForwardDeadLetteredMessagesTo 
    {
        get { Initialize(); return _forwardDeadLetteredMessagesTo!; }
        set { Initialize(); _forwardDeadLetteredMessagesTo!.Assign(value); }
    }
    private BicepValue<string>? _forwardDeadLetteredMessagesTo;

    /// <summary>
    /// Queue/Topic name to forward the messages.
    /// </summary>
    public BicepValue<string> ForwardTo 
    {
        get { Initialize(); return _forwardTo!; }
        set { Initialize(); _forwardTo!.Assign(value); }
    }
    private BicepValue<string>? _forwardTo;

    /// <summary>
    /// Value that indicates whether the subscription has an affinity to the
    /// client id.
    /// </summary>
    public BicepValue<bool> IsClientAffine 
    {
        get { Initialize(); return _isClientAffine!; }
        set { Initialize(); _isClientAffine!.Assign(value); }
    }
    private BicepValue<bool>? _isClientAffine;

    /// <summary>
    /// ISO 8061 lock duration timespan for the subscription. The default value
    /// is 1 minute.
    /// </summary>
    public BicepValue<TimeSpan> LockDuration 
    {
        get { Initialize(); return _lockDuration!; }
        set { Initialize(); _lockDuration!.Assign(value); }
    }
    private BicepValue<TimeSpan>? _lockDuration;

    /// <summary>
    /// Number of maximum deliveries.
    /// </summary>
    public BicepValue<int> MaxDeliveryCount 
    {
        get { Initialize(); return _maxDeliveryCount!; }
        set { Initialize(); _maxDeliveryCount!.Assign(value); }
    }
    private BicepValue<int>? _maxDeliveryCount;

    /// <summary>
    /// Value indicating if a subscription supports the concept of sessions.
    /// </summary>
    public BicepValue<bool> RequiresSession 
    {
        get { Initialize(); return _requiresSession!; }
        set { Initialize(); _requiresSession!.Assign(value); }
    }
    private BicepValue<bool>? _requiresSession;

    /// <summary>
    /// Enumerates the possible values for the status of a messaging entity.
    /// </summary>
    public BicepValue<ServiceBusMessagingEntityStatus> Status 
    {
        get { Initialize(); return _status!; }
        set { Initialize(); _status!.Assign(value); }
    }
    private BicepValue<ServiceBusMessagingEntityStatus>? _status;

    /// <summary>
    /// Last time there was a receive request to this subscription.
    /// </summary>
    public BicepValue<DateTimeOffset> AccessedOn 
    {
        get { Initialize(); return _accessedOn!; }
    }
    private BicepValue<DateTimeOffset>? _accessedOn;

    /// <summary>
    /// Message count details.
    /// </summary>
    public MessageCountDetails CountDetails 
    {
        get { Initialize(); return _countDetails!; }
    }
    private MessageCountDetails? _countDetails;

    /// <summary>
    /// Exact time the message was created.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn 
    {
        get { Initialize(); return _createdOn!; }
    }
    private BicepValue<DateTimeOffset>? _createdOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// Number of messages.
    /// </summary>
    public BicepValue<long> MessageCount 
    {
        get { Initialize(); return _messageCount!; }
    }
    private BicepValue<long>? _messageCount;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// The exact time the message was updated.
    /// </summary>
    public BicepValue<DateTimeOffset> UpdatedOn 
    {
        get { Initialize(); return _updatedOn!; }
    }
    private BicepValue<DateTimeOffset>? _updatedOn;

    /// <summary>
    /// Gets or sets a reference to the parent ServiceBusTopic.
    /// </summary>
    public ServiceBusTopic? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<ServiceBusTopic>? _parent;

    /// <summary>
    /// Creates a new ServiceBusSubscription.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ServiceBusSubscription resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ServiceBusSubscription.</param>
    public ServiceBusSubscription(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ServiceBus/namespaces/topics/subscriptions", resourceVersion ?? "2024-01-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ServiceBusSubscription.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _autoDeleteOnIdle = DefineProperty<TimeSpan>("AutoDeleteOnIdle", ["properties", "autoDeleteOnIdle"], format: "P");
        _clientAffineProperties = DefineModelProperty<ServiceBusClientAffineProperties>("ClientAffineProperties", ["properties", "clientAffineProperties"]);
        _deadLetteringOnFilterEvaluationExceptions = DefineProperty<bool>("DeadLetteringOnFilterEvaluationExceptions", ["properties", "deadLetteringOnFilterEvaluationExceptions"]);
        _deadLetteringOnMessageExpiration = DefineProperty<bool>("DeadLetteringOnMessageExpiration", ["properties", "deadLetteringOnMessageExpiration"]);
        _defaultMessageTimeToLive = DefineProperty<TimeSpan>("DefaultMessageTimeToLive", ["properties", "defaultMessageTimeToLive"], format: "P");
        _duplicateDetectionHistoryTimeWindow = DefineProperty<TimeSpan>("DuplicateDetectionHistoryTimeWindow", ["properties", "duplicateDetectionHistoryTimeWindow"], format: "P");
        _enableBatchedOperations = DefineProperty<bool>("EnableBatchedOperations", ["properties", "enableBatchedOperations"]);
        _forwardDeadLetteredMessagesTo = DefineProperty<string>("ForwardDeadLetteredMessagesTo", ["properties", "forwardDeadLetteredMessagesTo"]);
        _forwardTo = DefineProperty<string>("ForwardTo", ["properties", "forwardTo"]);
        _isClientAffine = DefineProperty<bool>("IsClientAffine", ["properties", "isClientAffine"]);
        _lockDuration = DefineProperty<TimeSpan>("LockDuration", ["properties", "lockDuration"], format: "P");
        _maxDeliveryCount = DefineProperty<int>("MaxDeliveryCount", ["properties", "maxDeliveryCount"]);
        _requiresSession = DefineProperty<bool>("RequiresSession", ["properties", "requiresSession"]);
        _status = DefineProperty<ServiceBusMessagingEntityStatus>("Status", ["properties", "status"]);
        _accessedOn = DefineProperty<DateTimeOffset>("AccessedOn", ["properties", "accessedAt"], isOutput: true);
        _countDetails = DefineModelProperty<MessageCountDetails>("CountDetails", ["properties", "countDetails"], isOutput: true);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["properties", "createdAt"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isOutput: true);
        _messageCount = DefineProperty<long>("MessageCount", ["properties", "messageCount"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _updatedOn = DefineProperty<DateTimeOffset>("UpdatedOn", ["properties", "updatedAt"], isOutput: true);
        _parent = DefineResource<ServiceBusTopic>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ServiceBusSubscription resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2017-04-01.
        /// </summary>
        public static readonly string V2017_04_01 = "2017-04-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2014-09-01.
        /// </summary>
        public static readonly string V2014_09_01 = "2014-09-01";
    }

    /// <summary>
    /// Creates a reference to an existing ServiceBusSubscription.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ServiceBusSubscription resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ServiceBusSubscription.</param>
    /// <returns>The existing ServiceBusSubscription resource.</returns>
    public static ServiceBusSubscription FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ServiceBusSubscription resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period);
}
