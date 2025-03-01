// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// Properties of the storage task assignment.
/// </summary>
public partial class StorageTaskAssignmentProperties : ProvisionableConstruct
{
    /// <summary>
    /// Id of the corresponding storage task.
    /// </summary>
    public BicepValue<ResourceIdentifier> TaskId 
    {
        get { Initialize(); return _taskId!; }
        set { Initialize(); _taskId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _taskId;

    /// <summary>
    /// Whether the storage task assignment is enabled or not.
    /// </summary>
    public BicepValue<bool> IsEnabled 
    {
        get { Initialize(); return _isEnabled!; }
        set { Initialize(); _isEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isEnabled;

    /// <summary>
    /// Text that describes the purpose of the storage task assignment.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
        set { Initialize(); _description!.Assign(value); }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// The storage task assignment execution context.
    /// </summary>
    public StorageTaskAssignmentExecutionContext ExecutionContext 
    {
        get { Initialize(); return _executionContext!; }
        set { Initialize(); AssignOrReplace(ref _executionContext, value); }
    }
    private StorageTaskAssignmentExecutionContext? _executionContext;

    /// <summary>
    /// The container prefix for the location of storage task assignment report.
    /// </summary>
    public BicepValue<string> ReportPrefix 
    {
        get { Initialize(); return _reportPrefix!; }
        set { Initialize(); _reportPrefix!.Assign(value); }
    }
    private BicepValue<string>? _reportPrefix;

    /// <summary>
    /// Represents the provisioning state of the storage task assignment.
    /// </summary>
    public BicepValue<StorageProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<StorageProvisioningState>? _provisioningState;

    /// <summary>
    /// Run status of storage task assignment.
    /// </summary>
    public StorageTaskReportProperties RunStatus 
    {
        get { Initialize(); return _runStatus!; }
        set { Initialize(); AssignOrReplace(ref _runStatus, value); }
    }
    private StorageTaskReportProperties? _runStatus;

    /// <summary>
    /// Creates a new StorageTaskAssignmentProperties.
    /// </summary>
    public StorageTaskAssignmentProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// StorageTaskAssignmentProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _taskId = DefineProperty<ResourceIdentifier>("TaskId", ["taskId"]);
        _isEnabled = DefineProperty<bool>("IsEnabled", ["enabled"]);
        _description = DefineProperty<string>("Description", ["description"]);
        _executionContext = DefineModelProperty<StorageTaskAssignmentExecutionContext>("ExecutionContext", ["executionContext"]);
        _reportPrefix = DefineProperty<string>("ReportPrefix", ["report", "prefix"]);
        _provisioningState = DefineProperty<StorageProvisioningState>("ProvisioningState", ["provisioningState"], isOutput: true);
        _runStatus = DefineModelProperty<StorageTaskReportProperties>("RunStatus", ["runStatus"]);
    }
}
