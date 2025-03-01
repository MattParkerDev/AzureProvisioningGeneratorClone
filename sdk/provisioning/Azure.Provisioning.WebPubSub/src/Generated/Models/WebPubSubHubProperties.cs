// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.WebPubSub;

/// <summary>
/// Properties of a hub.
/// </summary>
public partial class WebPubSubHubProperties : ProvisionableConstruct
{
    /// <summary>
    /// Event handler of a hub.
    /// </summary>
    public BicepList<WebPubSubEventHandler> EventHandlers 
    {
        get { Initialize(); return _eventHandlers!; }
        set { Initialize(); _eventHandlers!.Assign(value); }
    }
    private BicepList<WebPubSubEventHandler>? _eventHandlers;

    /// <summary>
    /// The settings for configuring if anonymous connections are allowed for
    /// this hub: &quot;allow&quot; or &quot;deny&quot;. Default to
    /// &quot;deny&quot;.
    /// </summary>
    public BicepValue<string> AnonymousConnectPolicy 
    {
        get { Initialize(); return _anonymousConnectPolicy!; }
        set { Initialize(); _anonymousConnectPolicy!.Assign(value); }
    }
    private BicepValue<string>? _anonymousConnectPolicy;

    /// <summary>
    /// Creates a new WebPubSubHubProperties.
    /// </summary>
    public WebPubSubHubProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of WebPubSubHubProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _eventHandlers = DefineListProperty<WebPubSubEventHandler>("EventHandlers", ["EventHandlers"]);
        _anonymousConnectPolicy = DefineProperty<string>("AnonymousConnectPolicy", ["AnonymousConnectPolicy"]);
    }
}
