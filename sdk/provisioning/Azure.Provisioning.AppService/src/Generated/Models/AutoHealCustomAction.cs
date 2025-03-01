// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Custom action to be executed             when an auto heal rule is
/// triggered.
/// </summary>
public partial class AutoHealCustomAction : ProvisionableConstruct
{
    /// <summary>
    /// Executable to be run.
    /// </summary>
    public BicepValue<string> Exe 
    {
        get { Initialize(); return _exe!; }
        set { Initialize(); _exe!.Assign(value); }
    }
    private BicepValue<string>? _exe;

    /// <summary>
    /// Parameters for the executable.
    /// </summary>
    public BicepValue<string> Parameters 
    {
        get { Initialize(); return _parameters!; }
        set { Initialize(); _parameters!.Assign(value); }
    }
    private BicepValue<string>? _parameters;

    /// <summary>
    /// Creates a new AutoHealCustomAction.
    /// </summary>
    public AutoHealCustomAction()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AutoHealCustomAction.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _exe = DefineProperty<string>("Exe", ["exe"]);
        _parameters = DefineProperty<string>("Parameters", ["parameters"]);
    }
}
