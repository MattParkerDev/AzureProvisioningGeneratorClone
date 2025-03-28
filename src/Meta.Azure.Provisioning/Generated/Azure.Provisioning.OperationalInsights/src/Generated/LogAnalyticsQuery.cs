// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// LogAnalyticsQuery.
/// </summary>
public partial class LogAnalyticsQuery : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Body of the query.
    /// </summary>
    public BicepValue<string> Body 
    {
        get { Initialize(); return _body!; }
        set { Initialize(); _body!.Assign(value); }
    }
    private BicepValue<string>? _body;

    /// <summary>
    /// Description of the query.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
        set { Initialize(); _description!.Assign(value); }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// Unique display name for your query within the Query Pack.
    /// </summary>
    public BicepValue<string> DisplayName 
    {
        get { Initialize(); return _displayName!; }
        set { Initialize(); _displayName!.Assign(value); }
    }
    private BicepValue<string>? _displayName;

    /// <summary>
    /// Additional properties that can be set for the query.
    /// To assign an object to this property use
    /// System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> Properties 
    {
        get { Initialize(); return _properties!; }
        set { Initialize(); _properties!.Assign(value); }
    }
    private BicepValue<BinaryData>? _properties;

    /// <summary>
    /// The related metadata items for the function.
    /// </summary>
    public LogAnalyticsQueryRelatedMetadata Related 
    {
        get { Initialize(); return _related!; }
        set { Initialize(); AssignOrReplace(ref _related, value); }
    }
    private LogAnalyticsQueryRelatedMetadata? _related;

    /// <summary>
    /// Tags associated with the query.
    /// </summary>
    public BicepDictionary<BicepList<string>> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<BicepList<string>>? _tags;

    /// <summary>
    /// The unique ID of your application. This field cannot be changed.
    /// </summary>
    public BicepValue<Guid> ApplicationId 
    {
        get { Initialize(); return _applicationId!; }
    }
    private BicepValue<Guid>? _applicationId;

    /// <summary>
    /// Object Id of user creating the query.
    /// </summary>
    public BicepValue<string> Author 
    {
        get { Initialize(); return _author!; }
    }
    private BicepValue<string>? _author;

    /// <summary>
    /// Creation Date for the Log Analytics Query, in ISO 8601 format.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn 
    {
        get { Initialize(); return _createdOn!; }
    }
    private BicepValue<DateTimeOffset>? _createdOn;

    /// <summary>
    /// Last modified date of the Log Analytics Query, in ISO 8601 format.
    /// </summary>
    public BicepValue<DateTimeOffset> ModifiedOn 
    {
        get { Initialize(); return _modifiedOn!; }
    }
    private BicepValue<DateTimeOffset>? _modifiedOn;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent LogAnalyticsQueryPack.
    /// </summary>
    public LogAnalyticsQueryPack? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<LogAnalyticsQueryPack>? _parent;

    /// <summary>
    /// Creates a new LogAnalyticsQuery.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the LogAnalyticsQuery resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the LogAnalyticsQuery.</param>
    public LogAnalyticsQuery(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.OperationalInsights/queryPacks/queries", resourceVersion ?? "2025-02-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of LogAnalyticsQuery.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _body = DefineProperty<string>("Body", ["properties", "body"]);
        _description = DefineProperty<string>("Description", ["properties", "description"]);
        _displayName = DefineProperty<string>("DisplayName", ["properties", "displayName"]);
        _properties = DefineProperty<BinaryData>("Properties", ["properties", "properties"]);
        _related = DefineModelProperty<LogAnalyticsQueryRelatedMetadata>("Related", ["properties", "related"]);
        _tags = DefineDictionaryProperty<BicepList<string>>("Tags", ["properties", "tags"]);
        _applicationId = DefineProperty<Guid>("ApplicationId", ["properties", "id"], isOutput: true);
        _author = DefineProperty<string>("Author", ["properties", "author"], isOutput: true);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["properties", "timeCreated"], isOutput: true);
        _modifiedOn = DefineProperty<DateTimeOffset>("ModifiedOn", ["properties", "timeModified"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<LogAnalyticsQueryPack>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported LogAnalyticsQuery resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2025-02-01.
        /// </summary>
        public static readonly string V2025_02_01 = "2025-02-01";

        /// <summary>
        /// 2023-09-01.
        /// </summary>
        public static readonly string V2023_09_01 = "2023-09-01";

        /// <summary>
        /// 2019-09-01.
        /// </summary>
        public static readonly string V2019_09_01 = "2019-09-01";
    }

    /// <summary>
    /// Creates a reference to an existing LogAnalyticsQuery.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the LogAnalyticsQuery resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the LogAnalyticsQuery.</param>
    /// <returns>The existing LogAnalyticsQuery resource.</returns>
    public static LogAnalyticsQuery FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
