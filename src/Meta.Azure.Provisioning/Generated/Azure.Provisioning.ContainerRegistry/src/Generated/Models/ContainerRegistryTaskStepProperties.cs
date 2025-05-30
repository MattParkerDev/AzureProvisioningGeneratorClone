// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// Base properties for any task step.             Please note
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTaskStepProperties
/// is the base class. According to the scenario, a derived class of the base
/// class might need to be assigned here, or this property needs to be casted
/// to one of the possible derived classes.             The available derived
/// classes include
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryDockerBuildStep,
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncodedTaskStep
/// and
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryFileTaskStep.
/// </summary>
public partial class ContainerRegistryTaskStepProperties : ProvisionableConstruct
{
    /// <summary>
    /// List of base image dependencies for a step.
    /// </summary>
    public BicepList<ContainerRegistryBaseImageDependency> BaseImageDependencies 
    {
        get { Initialize(); return _baseImageDependencies!; }
    }
    private BicepList<ContainerRegistryBaseImageDependency>? _baseImageDependencies;

    /// <summary>
    /// The URL(absolute or relative) of the source context for the task step.
    /// </summary>
    public BicepValue<string> ContextPath 
    {
        get { Initialize(); return _contextPath!; }
        set { Initialize(); _contextPath!.Assign(value); }
    }
    private BicepValue<string>? _contextPath;

    /// <summary>
    /// The token (git PAT or SAS token of storage account blob) associated
    /// with the context for a step.
    /// </summary>
    public BicepValue<string> ContextAccessToken 
    {
        get { Initialize(); return _contextAccessToken!; }
        set { Initialize(); _contextAccessToken!.Assign(value); }
    }
    private BicepValue<string>? _contextAccessToken;

    /// <summary>
    /// Creates a new ContainerRegistryTaskStepProperties.
    /// </summary>
    public ContainerRegistryTaskStepProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerRegistryTaskStepProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _baseImageDependencies = DefineListProperty<ContainerRegistryBaseImageDependency>("BaseImageDependencies", ["BaseImageDependencies"], isOutput: true);
        _contextPath = DefineProperty<string>("ContextPath", ["ContextPath"]);
        _contextAccessToken = DefineProperty<string>("ContextAccessToken", ["ContextAccessToken"]);
    }
}
