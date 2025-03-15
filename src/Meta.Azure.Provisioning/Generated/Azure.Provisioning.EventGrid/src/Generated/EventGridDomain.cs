// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// EventGridDomain.
/// </summary>
public partial class EventGridDomain : ProvisionableResource
{
    /// <summary>
    /// Name of the domain.
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
    /// This Boolean is used to specify the creation mechanism for
    /// &apos;all&apos; the Event Grid Domain Topics associated with this
    /// Event Grid Domain resource.             In this context, creation of
    /// domain topic can be auto-managed (when true) or self-managed (when
    /// false). The default value for this property is true.             When
    /// this property is null or set to true, Event Grid is responsible of
    /// automatically creating the domain topic when the first event
    /// subscription is             created at the scope of the domain topic.
    /// If this property is set to false, then creating the first event
    /// subscription will require creating a domain topic             by the
    /// user. The self-management mode can be used if the user wants full
    /// control of when the domain topic is created, while auto-managed mode
    /// provides the             flexibility to perform less operations and
    /// manage fewer resources by the user. Also, note that in auto-managed
    /// creation mode, user is allowed to create the             domain topic
    /// on demand if needed.
    /// </summary>
    public BicepValue<bool> AutoCreateTopicWithFirstSubscription 
    {
        get { Initialize(); return _autoCreateTopicWithFirstSubscription!; }
        set { Initialize(); _autoCreateTopicWithFirstSubscription!.Assign(value); }
    }
    private BicepValue<bool>? _autoCreateTopicWithFirstSubscription;

    /// <summary>
    /// This Boolean is used to specify the deletion mechanism for
    /// &apos;all&apos; the Event Grid Domain Topics associated with this
    /// Event Grid Domain resource.             In this context, deletion of
    /// domain topic can be auto-managed (when true) or self-managed (when
    /// false). The default value for this property is true.             When
    /// this property is set to true, Event Grid is responsible of
    /// automatically deleting the domain topic when the last event
    /// subscription at the scope             of the domain topic is deleted.
    /// If this property is set to false, then the user needs to manually
    /// delete the domain topic when it is no longer needed             (e.g.,
    /// when last event subscription is deleted and the resource needs to be
    /// cleaned up). The self-management mode can be used if the user wants
    /// full             control of when the domain topic needs to be deleted,
    /// while auto-managed mode provides the flexibility to perform less
    /// operations and manage fewer             resources by the user.
    /// </summary>
    public BicepValue<bool> AutoDeleteTopicWithLastSubscription 
    {
        get { Initialize(); return _autoDeleteTopicWithLastSubscription!; }
        set { Initialize(); _autoDeleteTopicWithLastSubscription!.Assign(value); }
    }
    private BicepValue<bool>? _autoDeleteTopicWithLastSubscription;

    /// <summary>
    /// Data Residency Boundary of the resource.
    /// </summary>
    public BicepValue<DataResidencyBoundary> DataResidencyBoundary 
    {
        get { Initialize(); return _dataResidencyBoundary!; }
        set { Initialize(); _dataResidencyBoundary!.Assign(value); }
    }
    private BicepValue<DataResidencyBoundary>? _dataResidencyBoundary;

    /// <summary>
    /// Event Type Information for the domain. This information is provided by
    /// the publisher and can be used by the             subscriber to view
    /// different types of events that are published.
    /// </summary>
    public PartnerTopicEventTypeInfo EventTypeInfo 
    {
        get { Initialize(); return _eventTypeInfo!; }
        set { Initialize(); AssignOrReplace(ref _eventTypeInfo, value); }
    }
    private PartnerTopicEventTypeInfo? _eventTypeInfo;

    /// <summary>
    /// Identity information for the Event Grid Domain resource.
    /// </summary>
    public ManagedServiceIdentity Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); AssignOrReplace(ref _identity, value); }
    }
    private ManagedServiceIdentity? _identity;

    /// <summary>
    /// This can be used to restrict traffic from specific IPs instead of all
    /// IPs. Note: These are considered only if PublicNetworkAccess is enabled.
    /// </summary>
    public BicepList<EventGridInboundIPRule> InboundIPRules 
    {
        get { Initialize(); return _inboundIPRules!; }
        set { Initialize(); _inboundIPRules!.Assign(value); }
    }
    private BicepList<EventGridInboundIPRule>? _inboundIPRules;

    /// <summary>
    /// This determines the format that Event Grid should expect for incoming
    /// events published to the Event Grid Domain Resource.
    /// </summary>
    public BicepValue<EventGridInputSchema> InputSchema 
    {
        get { Initialize(); return _inputSchema!; }
        set { Initialize(); _inputSchema!.Assign(value); }
    }
    private BicepValue<EventGridInputSchema>? _inputSchema;

    /// <summary>
    /// Information about the InputSchemaMapping which specified the info about
    /// mapping event payload.             Please note
    /// Azure.ResourceManager.EventGrid.Models.EventGridInputSchemaMapping is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.EventGrid.Models.EventGridJsonInputSchemaMapping.
    /// </summary>
    public EventGridInputSchemaMapping InputSchemaMapping 
    {
        get { Initialize(); return _inputSchemaMapping!; }
        set { Initialize(); AssignOrReplace(ref _inputSchemaMapping, value); }
    }
    private EventGridInputSchemaMapping? _inputSchemaMapping;

    /// <summary>
    /// This boolean is used to enable or disable local auth. Default value is
    /// false. When the property is set to true, only AAD token will be used
    /// to authenticate if user is allowed to publish to the domain.
    /// </summary>
    public BicepValue<bool> IsLocalAuthDisabled 
    {
        get { Initialize(); return _isLocalAuthDisabled!; }
        set { Initialize(); _isLocalAuthDisabled!.Assign(value); }
    }
    private BicepValue<bool>? _isLocalAuthDisabled;

    /// <summary>
    /// Minimum TLS version of the publisher allowed to publish to this domain.
    /// </summary>
    public BicepValue<TlsVersion> MinimumTlsVersionAllowed 
    {
        get { Initialize(); return _minimumTlsVersionAllowed!; }
        set { Initialize(); _minimumTlsVersionAllowed!.Assign(value); }
    }
    private BicepValue<TlsVersion>? _minimumTlsVersionAllowed;

    /// <summary>
    /// This determines if traffic is allowed over public network. By default
    /// it is enabled.             You can further restrict to specific IPs by
    /// configuring &lt;seealso
    /// cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.DomainProperties.InboundIpRules&quot;
    /// /&gt;
    /// </summary>
    public BicepValue<EventGridPublicNetworkAccess> PublicNetworkAccess 
    {
        get { Initialize(); return _publicNetworkAccess!; }
        set { Initialize(); _publicNetworkAccess!.Assign(value); }
    }
    private BicepValue<EventGridPublicNetworkAccess>? _publicNetworkAccess;

    /// <summary>
    /// The Sku name of the resource. The possible values are: Basic or Premium.
    /// </summary>
    public BicepValue<EventGridSku> SkuName 
    {
        get { Initialize(); return _skuName!; }
        set { Initialize(); _skuName!.Assign(value); }
    }
    private BicepValue<EventGridSku>? _skuName;

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
    /// Endpoint for the Event Grid Domain Resource which is used for
    /// publishing the events.
    /// </summary>
    public BicepValue<Uri> Endpoint 
    {
        get { Initialize(); return _endpoint!; }
    }
    private BicepValue<Uri>? _endpoint;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Metric resource id for the Event Grid Domain Resource.
    /// </summary>
    public BicepValue<string> MetricResourceId 
    {
        get { Initialize(); return _metricResourceId!; }
    }
    private BicepValue<string>? _metricResourceId;

    /// <summary>
    /// List of private endpoint connections.
    /// </summary>
    public BicepList<EventGridPrivateEndpointConnectionData> PrivateEndpointConnections 
    {
        get { Initialize(); return _privateEndpointConnections!; }
    }
    private BicepList<EventGridPrivateEndpointConnectionData>? _privateEndpointConnections;

    /// <summary>
    /// Provisioning state of the Event Grid Domain Resource.
    /// </summary>
    public BicepValue<EventGridDomainProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<EventGridDomainProvisioningState>? _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new EventGridDomain.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventGridDomain resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventGridDomain.</param>
    public EventGridDomain(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventGrid/domains", resourceVersion ?? "2025-02-15")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of EventGridDomain.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _autoCreateTopicWithFirstSubscription = DefineProperty<bool>("AutoCreateTopicWithFirstSubscription", ["properties", "autoCreateTopicWithFirstSubscription"]);
        _autoDeleteTopicWithLastSubscription = DefineProperty<bool>("AutoDeleteTopicWithLastSubscription", ["properties", "autoDeleteTopicWithLastSubscription"]);
        _dataResidencyBoundary = DefineProperty<DataResidencyBoundary>("DataResidencyBoundary", ["properties", "dataResidencyBoundary"]);
        _eventTypeInfo = DefineModelProperty<PartnerTopicEventTypeInfo>("EventTypeInfo", ["properties", "eventTypeInfo"]);
        _identity = DefineModelProperty<ManagedServiceIdentity>("Identity", ["identity"]);
        _inboundIPRules = DefineListProperty<EventGridInboundIPRule>("InboundIPRules", ["properties", "inboundIpRules"]);
        _inputSchema = DefineProperty<EventGridInputSchema>("InputSchema", ["properties", "inputSchema"]);
        _inputSchemaMapping = DefineModelProperty<EventGridInputSchemaMapping>("InputSchemaMapping", ["properties", "inputSchemaMapping"]);
        _isLocalAuthDisabled = DefineProperty<bool>("IsLocalAuthDisabled", ["properties", "disableLocalAuth"]);
        _minimumTlsVersionAllowed = DefineProperty<TlsVersion>("MinimumTlsVersionAllowed", ["properties", "minimumTlsVersionAllowed"]);
        _publicNetworkAccess = DefineProperty<EventGridPublicNetworkAccess>("PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _skuName = DefineProperty<EventGridSku>("SkuName", ["sku", "name"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _endpoint = DefineProperty<Uri>("Endpoint", ["properties", "endpoint"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _metricResourceId = DefineProperty<string>("MetricResourceId", ["properties", "metricResourceId"], isOutput: true);
        _privateEndpointConnections = DefineListProperty<EventGridPrivateEndpointConnectionData>("PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _provisioningState = DefineProperty<EventGridDomainProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported EventGridDomain resource versions.
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

        /// <summary>
        /// 2021-12-01.
        /// </summary>
        public static readonly string V2021_12_01 = "2021-12-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing EventGridDomain.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventGridDomain resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventGridDomain.</param>
    /// <returns>The existing EventGridDomain resource.</returns>
    public static EventGridDomain FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this EventGridDomain resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 3, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);
}
