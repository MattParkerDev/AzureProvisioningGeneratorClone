// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Defines the behavior of resources that are no longer managed after the
/// stack is updated or deleted.
/// </summary>
public partial class ActionOnUnmanage : ProvisionableConstruct
{
    /// <summary>
    /// Specifies an action for a newly unmanaged resource. Delete will attempt
    /// to delete the resource from Azure. Detach will leave the resource in
    /// it&apos;s current state.
    /// </summary>
    public BicepValue<DeploymentStacksDeleteDetachEnum> Resources 
    {
        get { Initialize(); return _resources!; }
        set { Initialize(); _resources!.Assign(value); }
    }
    private BicepValue<DeploymentStacksDeleteDetachEnum>? _resources;

    /// <summary>
    /// Specifies an action for a newly unmanaged resource. Delete will attempt
    /// to delete the resource from Azure. Detach will leave the resource in
    /// it&apos;s current state.
    /// </summary>
    public BicepValue<DeploymentStacksDeleteDetachEnum> ResourceGroups 
    {
        get { Initialize(); return _resourceGroups!; }
        set { Initialize(); _resourceGroups!.Assign(value); }
    }
    private BicepValue<DeploymentStacksDeleteDetachEnum>? _resourceGroups;

    /// <summary>
    /// Specifies an action for a newly unmanaged resource. Delete will attempt
    /// to delete the resource from Azure. Detach will leave the resource in
    /// it&apos;s current state.
    /// </summary>
    public BicepValue<DeploymentStacksDeleteDetachEnum> ManagementGroups 
    {
        get { Initialize(); return _managementGroups!; }
        set { Initialize(); _managementGroups!.Assign(value); }
    }
    private BicepValue<DeploymentStacksDeleteDetachEnum>? _managementGroups;

    /// <summary>
    /// Creates a new ActionOnUnmanage.
    /// </summary>
    public ActionOnUnmanage()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ActionOnUnmanage.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _resources = DefineProperty<DeploymentStacksDeleteDetachEnum>("Resources", ["resources"]);
        _resourceGroups = DefineProperty<DeploymentStacksDeleteDetachEnum>("ResourceGroups", ["resourceGroups"]);
        _managementGroups = DefineProperty<DeploymentStacksDeleteDetachEnum>("ManagementGroups", ["managementGroups"]);
    }
}
