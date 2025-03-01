// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Properties of the Topics Configuration.
/// </summary>
public partial class TopicsConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// The hostname for the topics configuration. This is a read-only property.
    /// </summary>
    public BicepValue<string> Hostname 
    {
        get { Initialize(); return _hostname!; }
    }
    private BicepValue<string>? _hostname;

    /// <summary>
    /// List of custom domain configurations for the namespace.
    /// </summary>
    public BicepList<CustomDomainConfiguration> CustomDomains 
    {
        get { Initialize(); return _customDomains!; }
        set { Initialize(); _customDomains!.Assign(value); }
    }
    private BicepList<CustomDomainConfiguration>? _customDomains;

    /// <summary>
    /// Creates a new TopicsConfiguration.
    /// </summary>
    public TopicsConfiguration()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of TopicsConfiguration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _hostname = DefineProperty<string>("Hostname", ["Hostname"], isOutput: true);
        _customDomains = DefineListProperty<CustomDomainConfiguration>("CustomDomains", ["CustomDomains"]);
    }
}
