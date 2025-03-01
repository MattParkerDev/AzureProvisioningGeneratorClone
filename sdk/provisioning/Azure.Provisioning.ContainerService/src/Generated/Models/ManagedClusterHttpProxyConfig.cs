// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Cluster HTTP proxy configuration.
/// </summary>
public partial class ManagedClusterHttpProxyConfig : ProvisionableConstruct
{
    /// <summary>
    /// The HTTP proxy server endpoint to use.
    /// </summary>
    public BicepValue<string> HttpProxy 
    {
        get { Initialize(); return _httpProxy!; }
        set { Initialize(); _httpProxy!.Assign(value); }
    }
    private BicepValue<string>? _httpProxy;

    /// <summary>
    /// The HTTPS proxy server endpoint to use.
    /// </summary>
    public BicepValue<string> HttpsProxy 
    {
        get { Initialize(); return _httpsProxy!; }
        set { Initialize(); _httpsProxy!.Assign(value); }
    }
    private BicepValue<string>? _httpsProxy;

    /// <summary>
    /// The endpoints that should not go through proxy.
    /// </summary>
    public BicepList<string> NoProxy 
    {
        get { Initialize(); return _noProxy!; }
        set { Initialize(); _noProxy!.Assign(value); }
    }
    private BicepList<string>? _noProxy;

    /// <summary>
    /// Alternative CA cert to use for connecting to proxy servers.
    /// </summary>
    public BicepValue<string> TrustedCA 
    {
        get { Initialize(); return _trustedCA!; }
        set { Initialize(); _trustedCA!.Assign(value); }
    }
    private BicepValue<string>? _trustedCA;

    /// <summary>
    /// Creates a new ManagedClusterHttpProxyConfig.
    /// </summary>
    public ManagedClusterHttpProxyConfig()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedClusterHttpProxyConfig.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _httpProxy = DefineProperty<string>("HttpProxy", ["HttpProxy"]);
        _httpsProxy = DefineProperty<string>("HttpsProxy", ["HttpsProxy"]);
        _noProxy = DefineListProperty<string>("NoProxy", ["NoProxy"]);
        _trustedCA = DefineProperty<string>("TrustedCA", ["TrustedCA"]);
    }
}
