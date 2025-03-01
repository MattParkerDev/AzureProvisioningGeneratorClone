// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// Internal use only.
/// </summary>
public partial class DeploymentCapacitySettings : ProvisionableConstruct
{
    /// <summary>
    /// The designated capacity.
    /// </summary>
    public BicepValue<int> DesignatedCapacity 
    {
        get { Initialize(); return _designatedCapacity!; }
        set { Initialize(); _designatedCapacity!.Assign(value); }
    }
    private BicepValue<int>? _designatedCapacity;

    /// <summary>
    /// The priority of this capacity setting.
    /// </summary>
    public BicepValue<int> Priority 
    {
        get { Initialize(); return _priority!; }
        set { Initialize(); _priority!.Assign(value); }
    }
    private BicepValue<int>? _priority;

    /// <summary>
    /// Creates a new DeploymentCapacitySettings.
    /// </summary>
    public DeploymentCapacitySettings()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of DeploymentCapacitySettings.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _designatedCapacity = DefineProperty<int>("DesignatedCapacity", ["designatedCapacity"]);
        _priority = DefineProperty<int>("Priority", ["priority"]);
    }
}
