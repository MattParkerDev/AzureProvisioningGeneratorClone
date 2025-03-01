// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The ContainerRegistryOverrideTaskStepProperties.
/// </summary>
public partial class ContainerRegistryOverrideTaskStepProperties : ProvisionableConstruct
{
    /// <summary>
    /// The source context against which run has to be queued.
    /// </summary>
    public BicepValue<string> ContextPath 
    {
        get { Initialize(); return _contextPath!; }
        set { Initialize(); _contextPath!.Assign(value); }
    }
    private BicepValue<string>? _contextPath;

    /// <summary>
    /// The file against which run has to be queued.
    /// </summary>
    public BicepValue<string> File 
    {
        get { Initialize(); return _file!; }
        set { Initialize(); _file!.Assign(value); }
    }
    private BicepValue<string>? _file;

    /// <summary>
    /// Gets or sets the collection of override arguments to be used when
    /// executing a build step.
    /// </summary>
    public BicepList<ContainerRegistryRunArgument> Arguments 
    {
        get { Initialize(); return _arguments!; }
        set { Initialize(); _arguments!.Assign(value); }
    }
    private BicepList<ContainerRegistryRunArgument>? _arguments;

    /// <summary>
    /// The name of the target build stage for the docker build.
    /// </summary>
    public BicepValue<string> Target 
    {
        get { Initialize(); return _target!; }
        set { Initialize(); _target!.Assign(value); }
    }
    private BicepValue<string>? _target;

    /// <summary>
    /// The collection of overridable values that can be passed when running a
    /// Task.
    /// </summary>
    public BicepList<ContainerRegistryTaskOverridableValue> Values 
    {
        get { Initialize(); return _values!; }
        set { Initialize(); _values!.Assign(value); }
    }
    private BicepList<ContainerRegistryTaskOverridableValue>? _values;

    /// <summary>
    /// Base64 encoded update trigger token that will be attached with the base
    /// image trigger webhook.
    /// </summary>
    public BicepValue<string> UpdateTriggerToken 
    {
        get { Initialize(); return _updateTriggerToken!; }
        set { Initialize(); _updateTriggerToken!.Assign(value); }
    }
    private BicepValue<string>? _updateTriggerToken;

    /// <summary>
    /// Creates a new ContainerRegistryOverrideTaskStepProperties.
    /// </summary>
    public ContainerRegistryOverrideTaskStepProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerRegistryOverrideTaskStepProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _contextPath = DefineProperty<string>("ContextPath", ["ContextPath"]);
        _file = DefineProperty<string>("File", ["File"]);
        _arguments = DefineListProperty<ContainerRegistryRunArgument>("Arguments", ["Arguments"]);
        _target = DefineProperty<string>("Target", ["Target"]);
        _values = DefineListProperty<ContainerRegistryTaskOverridableValue>("Values", ["Values"]);
        _updateTriggerToken = DefineProperty<string>("UpdateTriggerToken", ["UpdateTriggerToken"]);
    }
}
