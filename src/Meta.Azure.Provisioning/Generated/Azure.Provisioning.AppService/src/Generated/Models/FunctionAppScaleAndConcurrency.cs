// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Scale and concurrency settings for the function app.
/// </summary>
public partial class FunctionAppScaleAndConcurrency : ProvisionableConstruct
{
    /// <summary>
    /// The maximum number of instances for the function app.
    /// </summary>
    public BicepValue<float> MaximumInstanceCount 
    {
        get { Initialize(); return _maximumInstanceCount!; }
        set { Initialize(); _maximumInstanceCount!.Assign(value); }
    }
    private BicepValue<float>? _maximumInstanceCount;

    /// <summary>
    /// Set the amount of memory allocated to each instance of the function app
    /// in MB. CPU and network bandwidth are allocated proportionally.
    /// </summary>
    public BicepValue<float> InstanceMemoryMB 
    {
        get { Initialize(); return _instanceMemoryMB!; }
        set { Initialize(); _instanceMemoryMB!.Assign(value); }
    }
    private BicepValue<float>? _instanceMemoryMB;

    /// <summary>
    /// The maximum number of concurrent HTTP trigger invocations per instance.
    /// </summary>
    public BicepValue<float> HttpPerInstanceConcurrency 
    {
        get { Initialize(); return _httpPerInstanceConcurrency!; }
        set { Initialize(); _httpPerInstanceConcurrency!.Assign(value); }
    }
    private BicepValue<float>? _httpPerInstanceConcurrency;

    /// <summary>
    /// &apos;Always Ready&apos; configuration for the function app.
    /// </summary>
    public BicepList<FunctionAppAlwaysReadyConfig> AlwaysReady 
    {
        get { Initialize(); return _alwaysReady!; }
        set { Initialize(); _alwaysReady!.Assign(value); }
    }
    private BicepList<FunctionAppAlwaysReadyConfig>? _alwaysReady;

    /// <summary>
    /// The maximum number of instances for the function app.
    /// </summary>
    public BicepValue<int> FunctionAppMaximumInstanceCount 
    {
        get { Initialize(); return _functionAppMaximumInstanceCount!; }
        set { Initialize(); _functionAppMaximumInstanceCount!.Assign(value); }
    }
    private BicepValue<int>? _functionAppMaximumInstanceCount;

    /// <summary>
    /// Set the amount of memory allocated to each instance of the function app
    /// in MB. CPU and network bandwidth are allocated proportionally.
    /// </summary>
    public BicepValue<int> FunctionAppInstanceMemoryMB 
    {
        get { Initialize(); return _functionAppInstanceMemoryMB!; }
        set { Initialize(); _functionAppInstanceMemoryMB!.Assign(value); }
    }
    private BicepValue<int>? _functionAppInstanceMemoryMB;

    /// <summary>
    /// The maximum number of concurrent HTTP trigger invocations per instance.
    /// </summary>
    public BicepValue<int> ConcurrentHttpPerInstanceConcurrency 
    {
        get { Initialize(); return _concurrentHttpPerInstanceConcurrency!; }
        set { Initialize(); _concurrentHttpPerInstanceConcurrency!.Assign(value); }
    }
    private BicepValue<int>? _concurrentHttpPerInstanceConcurrency;

    /// <summary>
    /// Creates a new FunctionAppScaleAndConcurrency.
    /// </summary>
    public FunctionAppScaleAndConcurrency()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// FunctionAppScaleAndConcurrency.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _maximumInstanceCount = DefineProperty<float>("MaximumInstanceCount", ["maximumInstanceCount"]);
        _instanceMemoryMB = DefineProperty<float>("InstanceMemoryMB", ["instanceMemoryMB"]);
        _httpPerInstanceConcurrency = DefineProperty<float>("HttpPerInstanceConcurrency", ["triggers", "http", "perInstanceConcurrency"]);
        _alwaysReady = DefineListProperty<FunctionAppAlwaysReadyConfig>("AlwaysReady", ["alwaysReady"]);
        _functionAppMaximumInstanceCount = DefineProperty<int>("FunctionAppMaximumInstanceCount", ["maximumInstanceCount"]);
        _functionAppInstanceMemoryMB = DefineProperty<int>("FunctionAppInstanceMemoryMB", ["instanceMemoryMB"]);
        _concurrentHttpPerInstanceConcurrency = DefineProperty<int>("ConcurrentHttpPerInstanceConcurrency", ["triggers", "http", "perInstanceConcurrency"]);
    }
}
