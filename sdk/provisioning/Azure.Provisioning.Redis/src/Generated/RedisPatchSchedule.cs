// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Redis;

/// <summary>
/// RedisPatchSchedule.
/// </summary>
public partial class RedisPatchSchedule : ProvisionableResource
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
    /// List of patch schedules for a Redis cache.
    /// </summary>
    public BicepList<RedisPatchScheduleSetting> ScheduleEntries 
    {
        get { Initialize(); return _scheduleEntries!; }
        set { Initialize(); _scheduleEntries!.Assign(value); }
    }
    private BicepList<RedisPatchScheduleSetting>? _scheduleEntries;

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
    /// Gets or sets a reference to the parent RedisResource.
    /// </summary>
    public RedisResource? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<RedisResource>? _parent;

    /// <summary>
    /// Creates a new RedisPatchSchedule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the RedisPatchSchedule resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the RedisPatchSchedule.</param>
    public RedisPatchSchedule(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Cache/redis/patchSchedules", resourceVersion ?? "2024-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of RedisPatchSchedule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _scheduleEntries = DefineListProperty<RedisPatchScheduleSetting>("ScheduleEntries", ["properties", "scheduleEntries"], isRequired: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<RedisResource>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported RedisPatchSchedule resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-11-01.
        /// </summary>
        public static readonly string V2024_11_01 = "2024-11-01";

        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-08-01.
        /// </summary>
        public static readonly string V2023_08_01 = "2023-08-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2022-06-01.
        /// </summary>
        public static readonly string V2022_06_01 = "2022-06-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-07-01.
        /// </summary>
        public static readonly string V2019_07_01 = "2019-07-01";

        /// <summary>
        /// 2018-03-01.
        /// </summary>
        public static readonly string V2018_03_01 = "2018-03-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-02-01.
        /// </summary>
        public static readonly string V2017_02_01 = "2017-02-01";

        /// <summary>
        /// 2016-04-01.
        /// </summary>
        public static readonly string V2016_04_01 = "2016-04-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2015-03-01.
        /// </summary>
        public static readonly string V2015_03_01 = "2015-03-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing RedisPatchSchedule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the RedisPatchSchedule resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the RedisPatchSchedule.</param>
    /// <returns>The existing RedisPatchSchedule resource.</returns>
    public static RedisPatchSchedule FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
