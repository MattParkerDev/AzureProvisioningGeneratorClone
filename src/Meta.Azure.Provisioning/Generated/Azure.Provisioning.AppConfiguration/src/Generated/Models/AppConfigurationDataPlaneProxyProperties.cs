// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.AppConfiguration;

/// <summary>
/// The data plane proxy settings for a configuration store.
/// </summary>
public partial class AppConfigurationDataPlaneProxyProperties : ProvisionableConstruct
{
    /// <summary>
    /// The data plane proxy authentication mode. This property manages the
    /// authentication mode of request to the data plane resources.
    /// </summary>
    public BicepValue<DataPlaneProxyAuthenticationMode> AuthenticationMode 
    {
        get { Initialize(); return _authenticationMode!; }
        set { Initialize(); _authenticationMode!.Assign(value); }
    }
    private BicepValue<DataPlaneProxyAuthenticationMode>? _authenticationMode;

    /// <summary>
    /// The data plane proxy private link delegation. This property manages if
    /// a request from delegated Azure Resource Manager (ARM) private link is
    /// allowed when the data plane resource requires private link.
    /// </summary>
    public BicepValue<DataPlaneProxyPrivateLinkDelegation> PrivateLinkDelegation 
    {
        get { Initialize(); return _privateLinkDelegation!; }
        set { Initialize(); _privateLinkDelegation!.Assign(value); }
    }
    private BicepValue<DataPlaneProxyPrivateLinkDelegation>? _privateLinkDelegation;

    /// <summary>
    /// Creates a new AppConfigurationDataPlaneProxyProperties.
    /// </summary>
    public AppConfigurationDataPlaneProxyProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// AppConfigurationDataPlaneProxyProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _authenticationMode = DefineProperty<DataPlaneProxyAuthenticationMode>("AuthenticationMode", ["authenticationMode"]);
        _privateLinkDelegation = DefineProperty<DataPlaneProxyPrivateLinkDelegation>("PrivateLinkDelegation", ["privateLinkDelegation"]);
    }
}
