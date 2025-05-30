// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// ContainerAppSourceControl.
/// </summary>
public partial class ContainerAppSourceControl : ProvisionableResource
{
    /// <summary>
    /// Name of the Container App SourceControl.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The branch which will trigger the auto deployment.
    /// </summary>
    public BicepValue<string> Branch 
    {
        get { Initialize(); return _branch!; }
        set { Initialize(); _branch!.Assign(value); }
    }
    private BicepValue<string>? _branch;

    /// <summary>
    /// Container App Revision Template with all possible settings and the
    /// defaults if user did not provide them. The defaults are
    /// populated             as they were at the creation time
    /// </summary>
    public ContainerAppGitHubActionConfiguration GitHubActionConfiguration 
    {
        get { Initialize(); return _gitHubActionConfiguration!; }
        set { Initialize(); AssignOrReplace(ref _gitHubActionConfiguration, value); }
    }
    private ContainerAppGitHubActionConfiguration? _gitHubActionConfiguration;

    /// <summary>
    /// The repo url which will be integrated to ContainerApp.
    /// </summary>
    public BicepValue<Uri> RepoUri 
    {
        get { Initialize(); return _repoUri!; }
        set { Initialize(); _repoUri!.Assign(value); }
    }
    private BicepValue<Uri>? _repoUri;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Current provisioning State of the operation.
    /// </summary>
    public BicepValue<ContainerAppSourceControlOperationState> OperationState 
    {
        get { Initialize(); return _operationState!; }
    }
    private BicepValue<ContainerAppSourceControlOperationState>? _operationState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerApp.
    /// </summary>
    public ContainerApp? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<ContainerApp>? _parent;

    /// <summary>
    /// Creates a new ContainerAppSourceControl.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerAppSourceControl
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerAppSourceControl.</param>
    public ContainerAppSourceControl(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.App/containerApps/sourcecontrols", resourceVersion ?? "2025-01-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerAppSourceControl.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _branch = DefineProperty<string>("Branch", ["properties", "branch"]);
        _gitHubActionConfiguration = DefineModelProperty<ContainerAppGitHubActionConfiguration>("GitHubActionConfiguration", ["properties", "githubActionConfiguration"]);
        _repoUri = DefineProperty<Uri>("RepoUri", ["properties", "repoUrl"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _operationState = DefineProperty<ContainerAppSourceControlOperationState>("OperationState", ["properties", "operationState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<ContainerApp>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerAppSourceControl resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2025-01-01.
        /// </summary>
        public static readonly string V2025_01_01 = "2025-01-01";

        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2022-10-01.
        /// </summary>
        public static readonly string V2022_10_01 = "2022-10-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerAppSourceControl.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerAppSourceControl
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerAppSourceControl.</param>
    /// <returns>The existing ContainerAppSourceControl resource.</returns>
    public static ContainerAppSourceControl FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
