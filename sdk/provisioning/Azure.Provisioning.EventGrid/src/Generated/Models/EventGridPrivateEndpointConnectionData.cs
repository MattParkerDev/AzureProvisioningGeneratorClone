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
/// A class representing the EventGridPrivateEndpointConnection data model.
/// </summary>
public partial class EventGridPrivateEndpointConnectionData : ProvisionableConstruct
{
    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId 
    {
        get { Initialize(); return _privateEndpointId!; }
        set { Initialize(); _privateEndpointId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _privateEndpointId;

    /// <summary>
    /// GroupIds from the private link service resource.
    /// </summary>
    public BicepList<string> GroupIds 
    {
        get { Initialize(); return _groupIds!; }
        set { Initialize(); _groupIds!.Assign(value); }
    }
    private BicepList<string>? _groupIds;

    /// <summary>
    /// Details about the state of the connection.
    /// </summary>
    public EventGridPrivateEndpointConnectionState ConnectionState 
    {
        get { Initialize(); return _connectionState!; }
        set { Initialize(); AssignOrReplace(ref _connectionState, value); }
    }
    private EventGridPrivateEndpointConnectionState? _connectionState;

    /// <summary>
    /// Provisioning state of the Private Endpoint Connection.
    /// </summary>
    public BicepValue<EventGridResourceProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
        set { Initialize(); _provisioningState!.Assign(value); }
    }
    private BicepValue<EventGridResourceProvisioningState>? _provisioningState;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new EventGridPrivateEndpointConnectionData.
    /// </summary>
    public EventGridPrivateEndpointConnectionData()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// EventGridPrivateEndpointConnectionData.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _privateEndpointId = DefineProperty<ResourceIdentifier>("PrivateEndpointId", ["PrivateEndpointId"]);
        _groupIds = DefineListProperty<string>("GroupIds", ["GroupIds"]);
        _connectionState = DefineModelProperty<EventGridPrivateEndpointConnectionState>("ConnectionState", ["ConnectionState"]);
        _provisioningState = DefineProperty<EventGridResourceProvisioningState>("ProvisioningState", ["ProvisioningState"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }
}
