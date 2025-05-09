// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// EventHubsConsumerGroup.
/// </summary>
public partial class EventHubsConsumerGroup : ProvisionableResource
{
    /// <summary>
    /// The consumer group name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// User Metadata is a placeholder to store user-defined string data with
    /// maximum length 1024. e.g. it can be used to store descriptive data,
    /// such as list of teams and their contact information also user-defined
    /// configuration settings can be stored.
    /// </summary>
    public BicepValue<string> UserMetadata 
    {
        get { Initialize(); return _userMetadata!; }
        set { Initialize(); _userMetadata!.Assign(value); }
    }
    private BicepValue<string>? _userMetadata;

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
    /// Gets or sets a reference to the parent EventHub.
    /// </summary>
    public EventHub? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<EventHub>? _parent;

    /// <summary>
    /// Creates a new EventHubsConsumerGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHubsConsumerGroup resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHubsConsumerGroup.</param>
    public EventHubsConsumerGroup(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventHub/namespaces/eventhubs/consumergroups", resourceVersion ?? "2024-01-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of EventHubsConsumerGroup.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _userMetadata = DefineProperty<string>("UserMetadata", ["properties", "userMetadata"]);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["properties", "createdAt"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _updatedOn = DefineProperty<DateTimeOffset>("UpdatedOn", ["properties", "updatedAt"], isOutput: true);
        _parent = DefineResource<EventHub>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported EventHubsConsumerGroup resource versions.
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
    /// Creates a reference to an existing EventHubsConsumerGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHubsConsumerGroup resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHubsConsumerGroup.</param>
    /// <returns>The existing EventHubsConsumerGroup resource.</returns>
    public static EventHubsConsumerGroup FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this EventHubsConsumerGroup resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period);
}
