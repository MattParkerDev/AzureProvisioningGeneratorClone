// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ServiceBus;

/// <summary>
/// ServiceBusRule.
/// </summary>
public partial class ServiceBusRule : ProvisionableResource
{
    /// <summary>
    /// The rule name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Represents the filter actions which are allowed for the transformation
    /// of a message that have been matched by a filter expression.
    /// </summary>
    public ServiceBusFilterAction Action 
    {
        get { Initialize(); return _action!; }
        set { Initialize(); AssignOrReplace(ref _action, value); }
    }
    private ServiceBusFilterAction? _action;

    /// <summary>
    /// Properties of correlationFilter.
    /// </summary>
    public ServiceBusCorrelationFilter CorrelationFilter 
    {
        get { Initialize(); return _correlationFilter!; }
        set { Initialize(); AssignOrReplace(ref _correlationFilter, value); }
    }
    private ServiceBusCorrelationFilter? _correlationFilter;

    /// <summary>
    /// Filter type that is evaluated against a BrokeredMessage.
    /// </summary>
    public BicepValue<ServiceBusFilterType> FilterType 
    {
        get { Initialize(); return _filterType!; }
        set { Initialize(); _filterType!.Assign(value); }
    }
    private BicepValue<ServiceBusFilterType>? _filterType;

    /// <summary>
    /// Properties of sqlFilter.
    /// </summary>
    public ServiceBusSqlFilter SqlFilter 
    {
        get { Initialize(); return _sqlFilter!; }
        set { Initialize(); AssignOrReplace(ref _sqlFilter, value); }
    }
    private ServiceBusSqlFilter? _sqlFilter;

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
    /// Gets or sets a reference to the parent ServiceBusSubscription.
    /// </summary>
    public ServiceBusSubscription? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<ServiceBusSubscription>? _parent;

    /// <summary>
    /// Creates a new ServiceBusRule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ServiceBusRule resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ServiceBusRule.</param>
    public ServiceBusRule(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ServiceBus/namespaces/topics/subscriptions/rules", resourceVersion ?? "2024-01-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ServiceBusRule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _action = DefineModelProperty<ServiceBusFilterAction>("Action", ["properties", "action"]);
        _correlationFilter = DefineModelProperty<ServiceBusCorrelationFilter>("CorrelationFilter", ["properties", "correlationFilter"]);
        _filterType = DefineProperty<ServiceBusFilterType>("FilterType", ["properties", "filterType"]);
        _sqlFilter = DefineModelProperty<ServiceBusSqlFilter>("SqlFilter", ["properties", "sqlFilter"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<ServiceBusSubscription>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ServiceBusRule resource versions.
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
    /// Creates a reference to an existing ServiceBusRule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ServiceBusRule resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ServiceBusRule.</param>
    /// <returns>The existing ServiceBusRule resource.</returns>
    public static ServiceBusRule FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
