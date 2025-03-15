// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// PartnerTopic.
/// </summary>
public partial class PartnerTopic : ProvisionableResource
{
    /// <summary>
    /// Name of the partner topic.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// Activation state of the partner topic.
    /// </summary>
    public BicepValue<PartnerTopicActivationState> ActivationState 
    {
        get { Initialize(); return _activationState!; }
        set { Initialize(); _activationState!.Assign(value); }
    }
    private BicepValue<PartnerTopicActivationState>? _activationState;

    /// <summary>
    /// Event Type information from the corresponding event channel.
    /// </summary>
    public PartnerTopicEventTypeInfo EventTypeInfo 
    {
        get { Initialize(); return _eventTypeInfo!; }
        set { Initialize(); AssignOrReplace(ref _eventTypeInfo, value); }
    }
    private PartnerTopicEventTypeInfo? _eventTypeInfo;

    /// <summary>
    /// Expiration time of the partner topic. If this timer expires while the
    /// partner topic is still never activated,             the partner topic
    /// and corresponding event channel are deleted.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOnIfNotActivated 
    {
        get { Initialize(); return _expireOnIfNotActivated!; }
        set { Initialize(); _expireOnIfNotActivated!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _expireOnIfNotActivated;

    /// <summary>
    /// Identity information for the Partner Topic resource.
    /// </summary>
    public ManagedServiceIdentity Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); AssignOrReplace(ref _identity, value); }
    }
    private ManagedServiceIdentity? _identity;

    /// <summary>
    /// Context or helpful message that can be used during the approval process
    /// by the subscriber.
    /// </summary>
    public BicepValue<string> MessageForActivation 
    {
        get { Initialize(); return _messageForActivation!; }
        set { Initialize(); _messageForActivation!.Assign(value); }
    }
    private BicepValue<string>? _messageForActivation;

    /// <summary>
    /// The immutableId of the corresponding partner registration.
    /// </summary>
    public BicepValue<Guid> PartnerRegistrationImmutableId 
    {
        get { Initialize(); return _partnerRegistrationImmutableId!; }
        set { Initialize(); _partnerRegistrationImmutableId!.Assign(value); }
    }
    private BicepValue<Guid>? _partnerRegistrationImmutableId;

    /// <summary>
    /// Friendly description about the topic. This can be set by the
    /// publisher/partner to show custom description for the customer partner
    /// topic.             This will be helpful to remove any ambiguity of the
    /// origin of creation of the partner topic for the customer.
    /// </summary>
    public BicepValue<string> PartnerTopicFriendlyDescription 
    {
        get { Initialize(); return _partnerTopicFriendlyDescription!; }
        set { Initialize(); _partnerTopicFriendlyDescription!.Assign(value); }
    }
    private BicepValue<string>? _partnerTopicFriendlyDescription;

    /// <summary>
    /// Source associated with this partner topic. This represents a unique
    /// partner resource.
    /// </summary>
    public BicepValue<string> Source 
    {
        get { Initialize(); return _source!; }
        set { Initialize(); _source!.Assign(value); }
    }
    private BicepValue<string>? _source;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Provisioning state of the partner topic.
    /// </summary>
    public BicepValue<PartnerTopicProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<PartnerTopicProvisioningState>? _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new PartnerTopic.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PartnerTopic resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PartnerTopic.</param>
    public PartnerTopic(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventGrid/partnerTopics", resourceVersion ?? "2025-02-15")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of PartnerTopic.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _activationState = DefineProperty<PartnerTopicActivationState>("ActivationState", ["properties", "activationState"]);
        _eventTypeInfo = DefineModelProperty<PartnerTopicEventTypeInfo>("EventTypeInfo", ["properties", "eventTypeInfo"]);
        _expireOnIfNotActivated = DefineProperty<DateTimeOffset>("ExpireOnIfNotActivated", ["properties", "expirationTimeIfNotActivatedUtc"]);
        _identity = DefineModelProperty<ManagedServiceIdentity>("Identity", ["identity"]);
        _messageForActivation = DefineProperty<string>("MessageForActivation", ["properties", "messageForActivation"]);
        _partnerRegistrationImmutableId = DefineProperty<Guid>("PartnerRegistrationImmutableId", ["properties", "partnerRegistrationImmutableId"]);
        _partnerTopicFriendlyDescription = DefineProperty<string>("PartnerTopicFriendlyDescription", ["properties", "partnerTopicFriendlyDescription"]);
        _source = DefineProperty<string>("Source", ["properties", "source"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<PartnerTopicProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported PartnerTopic resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2025-02-15.
        /// </summary>
        public static readonly string V2025_02_15 = "2025-02-15";

        /// <summary>
        /// 2022-06-15.
        /// </summary>
        public static readonly string V2022_06_15 = "2022-06-15";
    }

    /// <summary>
    /// Creates a reference to an existing PartnerTopic.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PartnerTopic resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PartnerTopic.</param>
    /// <returns>The existing PartnerTopic resource.</returns>
    public static PartnerTopic FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
