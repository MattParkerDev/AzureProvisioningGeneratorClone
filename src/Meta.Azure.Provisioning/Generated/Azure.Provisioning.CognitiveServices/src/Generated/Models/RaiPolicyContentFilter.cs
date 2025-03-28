// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// Azure OpenAI Content Filter.
/// </summary>
public partial class RaiPolicyContentFilter : ProvisionableConstruct
{
    /// <summary>
    /// Name of ContentFilter.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// If the ContentFilter is enabled.
    /// </summary>
    public BicepValue<bool> Enabled 
    {
        get { Initialize(); return _enabled!; }
        set { Initialize(); _enabled!.Assign(value); }
    }
    private BicepValue<bool>? _enabled;

    /// <summary>
    /// Level at which content is filtered.
    /// </summary>
    public BicepValue<RaiPolicyContentLevel> SeverityThreshold 
    {
        get { Initialize(); return _severityThreshold!; }
        set { Initialize(); _severityThreshold!.Assign(value); }
    }
    private BicepValue<RaiPolicyContentLevel>? _severityThreshold;

    /// <summary>
    /// If blocking would occur.
    /// </summary>
    public BicepValue<bool> Blocking 
    {
        get { Initialize(); return _blocking!; }
        set { Initialize(); _blocking!.Assign(value); }
    }
    private BicepValue<bool>? _blocking;

    /// <summary>
    /// Content source to apply the Content Filters.
    /// </summary>
    public BicepValue<RaiPolicyContentSource> Source 
    {
        get { Initialize(); return _source!; }
        set { Initialize(); _source!.Assign(value); }
    }
    private BicepValue<RaiPolicyContentSource>? _source;

    /// <summary>
    /// Creates a new RaiPolicyContentFilter.
    /// </summary>
    public RaiPolicyContentFilter()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of RaiPolicyContentFilter.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _enabled = DefineProperty<bool>("Enabled", ["enabled"]);
        _severityThreshold = DefineProperty<RaiPolicyContentLevel>("SeverityThreshold", ["severityThreshold"]);
        _blocking = DefineProperty<bool>("Blocking", ["blocking"]);
        _source = DefineProperty<RaiPolicyContentSource>("Source", ["source"]);
    }
}
