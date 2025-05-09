// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// IP rule with specific IP or IP range in CIDR format.
/// </summary>
public partial class ContainerRegistryIPRule : ProvisionableConstruct
{
    /// <summary>
    /// The action of IP ACL rule.
    /// </summary>
    public BicepValue<ContainerRegistryIPRuleAction> Action 
    {
        get { Initialize(); return _action!; }
        set { Initialize(); _action!.Assign(value); }
    }
    private BicepValue<ContainerRegistryIPRuleAction>? _action;

    /// <summary>
    /// Specifies the IP or IP range in CIDR format. Only IPV4 address is
    /// allowed.
    /// </summary>
    public BicepValue<string> IPAddressOrRange 
    {
        get { Initialize(); return _iPAddressOrRange!; }
        set { Initialize(); _iPAddressOrRange!.Assign(value); }
    }
    private BicepValue<string>? _iPAddressOrRange;

    /// <summary>
    /// Creates a new ContainerRegistryIPRule.
    /// </summary>
    public ContainerRegistryIPRule()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerRegistryIPRule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _action = DefineProperty<ContainerRegistryIPRuleAction>("Action", ["Action"]);
        _iPAddressOrRange = DefineProperty<string>("IPAddressOrRange", ["IPAddressOrRange"]);
    }
}
