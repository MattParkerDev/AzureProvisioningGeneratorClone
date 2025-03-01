// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// EventHub.
/// </summary>
public partial class EventHub : ProvisionableResource
{
    /// <summary>
    /// The Event Hub name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Properties of capture description.
    /// </summary>
    public CaptureDescription CaptureDescription 
    {
        get { Initialize(); return _captureDescription!; }
        set { Initialize(); AssignOrReplace(ref _captureDescription, value); }
    }
    private CaptureDescription? _captureDescription;

    /// <summary>
    /// Number of partitions created for the Event Hub, allowed values are from
    /// 1 to 32 partitions.
    /// </summary>
    public BicepValue<long> PartitionCount 
    {
        get { Initialize(); return _partitionCount!; }
        set { Initialize(); _partitionCount!.Assign(value); }
    }
    private BicepValue<long>? _partitionCount;

    /// <summary>
    /// Event Hub retention settings.
    /// </summary>
    public RetentionDescription RetentionDescription 
    {
        get { Initialize(); return _retentionDescription!; }
        set { Initialize(); AssignOrReplace(ref _retentionDescription, value); }
    }
    private RetentionDescription? _retentionDescription;

    /// <summary>
    /// Enumerates the possible values for the status of the Event Hub.
    /// </summary>
    public BicepValue<EventHubEntityStatus> Status 
    {
        get { Initialize(); return _status!; }
        set { Initialize(); _status!.Assign(value); }
    }
    private BicepValue<EventHubEntityStatus>? _status;

    /// <summary>
    /// Gets and Sets Metadata of User.
    /// </summary>
    public BicepValue<string> UserMetadata 
    {
        get { Initialize(); return _userMetadata!; }
        set { Initialize(); _userMetadata!.Assign(value); }
    }
    private BicepValue<string>? _userMetadata;

    /// <summary>
    /// Exact time the Event Hub was created.
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
    /// Current number of shards on the Event Hub.
    /// </summary>
    public BicepList<string> PartitionIds 
    {
        get { Initialize(); return _partitionIds!; }
    }
    private BicepList<string>? _partitionIds;

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
    /// Gets or sets a reference to the parent EventHubsNamespace.
    /// </summary>
    public EventHubsNamespace? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<EventHubsNamespace>? _parent;

    /// <summary>
    /// Creates a new EventHub.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHub resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHub.</param>
    public EventHub(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventHub/namespaces/eventhubs", resourceVersion ?? "2024-01-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of EventHub.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _captureDescription = DefineModelProperty<CaptureDescription>("CaptureDescription", ["properties", "captureDescription"]);
        _partitionCount = DefineProperty<long>("PartitionCount", ["properties", "partitionCount"]);
        _retentionDescription = DefineModelProperty<RetentionDescription>("RetentionDescription", ["properties", "retentionDescription"]);
        _status = DefineProperty<EventHubEntityStatus>("Status", ["properties", "status"]);
        _userMetadata = DefineProperty<string>("UserMetadata", ["properties", "userMetadata"]);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["properties", "createdAt"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isOutput: true);
        _partitionIds = DefineListProperty<string>("PartitionIds", ["properties", "partitionIds"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _updatedOn = DefineProperty<DateTimeOffset>("UpdatedOn", ["properties", "updatedAt"], isOutput: true);
        _parent = DefineResource<EventHubsNamespace>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported EventHub resource versions.
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
    /// Creates a reference to an existing EventHub.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHub resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHub.</param>
    /// <returns>The existing EventHub resource.</returns>
    public static EventHub FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
