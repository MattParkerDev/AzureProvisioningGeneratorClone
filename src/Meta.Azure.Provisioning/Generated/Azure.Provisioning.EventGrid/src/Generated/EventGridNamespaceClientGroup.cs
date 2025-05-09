// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// EventGridNamespaceClientGroup.
/// </summary>
public partial class EventGridNamespaceClientGroup : ProvisionableResource
{
    /// <summary>
    /// The client group name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Description for the Client Group resource.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
        set { Initialize(); _description!.Assign(value); }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// The grouping query for the clients.             Example :
    /// attributes.keyName IN [&apos;a&apos;, &apos;b&apos;, &apos;c&apos;].
    /// </summary>
    public BicepValue<string> Query 
    {
        get { Initialize(); return _query!; }
        set { Initialize(); _query!.Assign(value); }
    }
    private BicepValue<string>? _query;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Provisioning state of the ClientGroup resource.
    /// </summary>
    public BicepValue<ClientGroupProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<ClientGroupProvisioningState>? _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent EventGridNamespace.
    /// </summary>
    public EventGridNamespace? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<EventGridNamespace>? _parent;

    /// <summary>
    /// Creates a new EventGridNamespaceClientGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventGridNamespaceClientGroup
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventGridNamespaceClientGroup.</param>
    public EventGridNamespaceClientGroup(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventGrid/namespaces/clientGroups", resourceVersion ?? "2025-02-15")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// EventGridNamespaceClientGroup.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _description = DefineProperty<string>("Description", ["properties", "description"]);
        _query = DefineProperty<string>("Query", ["properties", "query"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<ClientGroupProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<EventGridNamespace>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported EventGridNamespaceClientGroup resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2025-02-15.
        /// </summary>
        public static readonly string V2025_02_15 = "2025-02-15";
    }

    /// <summary>
    /// Creates a reference to an existing EventGridNamespaceClientGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventGridNamespaceClientGroup
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventGridNamespaceClientGroup.</param>
    /// <returns>The existing EventGridNamespaceClientGroup resource.</returns>
    public static EventGridNamespaceClientGroup FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
