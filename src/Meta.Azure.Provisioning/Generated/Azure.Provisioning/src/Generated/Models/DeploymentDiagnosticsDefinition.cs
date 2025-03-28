// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// The DeploymentDiagnosticsDefinition.
/// </summary>
public partial class DeploymentDiagnosticsDefinition : ProvisionableConstruct
{
    /// <summary>
    /// Denotes the additional response level.
    /// </summary>
    public BicepValue<Level> Level 
    {
        get { Initialize(); return _level!; }
    }
    private BicepValue<Level>? _level;

    /// <summary>
    /// The error code.
    /// </summary>
    public BicepValue<string> Code 
    {
        get { Initialize(); return _code!; }
    }
    private BicepValue<string>? _code;

    /// <summary>
    /// The error message.
    /// </summary>
    public BicepValue<string> Message 
    {
        get { Initialize(); return _message!; }
    }
    private BicepValue<string>? _message;

    /// <summary>
    /// The error target.
    /// </summary>
    public BicepValue<string> Target 
    {
        get { Initialize(); return _target!; }
    }
    private BicepValue<string>? _target;

    /// <summary>
    /// The error additional info.
    /// </summary>
    public BicepList<ErrorAdditionalInfo> AdditionalInfo 
    {
        get { Initialize(); return _additionalInfo!; }
    }
    private BicepList<ErrorAdditionalInfo>? _additionalInfo;

    /// <summary>
    /// Creates a new DeploymentDiagnosticsDefinition.
    /// </summary>
    public DeploymentDiagnosticsDefinition()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// DeploymentDiagnosticsDefinition.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _level = DefineProperty<Level>("Level", ["level"], isOutput: true);
        _code = DefineProperty<string>("Code", ["code"], isOutput: true);
        _message = DefineProperty<string>("Message", ["message"], isOutput: true);
        _target = DefineProperty<string>("Target", ["target"], isOutput: true);
        _additionalInfo = DefineListProperty<ErrorAdditionalInfo>("AdditionalInfo", ["additionalInfo"], isOutput: true);
    }
}
