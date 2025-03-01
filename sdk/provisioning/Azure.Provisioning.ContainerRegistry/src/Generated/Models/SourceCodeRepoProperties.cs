// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The properties of the source code repository.
/// </summary>
public partial class SourceCodeRepoProperties : ProvisionableConstruct
{
    /// <summary>
    /// The type of source control service.
    /// </summary>
    public BicepValue<SourceControlType> SourceControlType 
    {
        get { Initialize(); return _sourceControlType!; }
        set { Initialize(); _sourceControlType!.Assign(value); }
    }
    private BicepValue<SourceControlType>? _sourceControlType;

    /// <summary>
    /// The full URL to the source code repository.
    /// </summary>
    public BicepValue<Uri> RepositoryUri 
    {
        get { Initialize(); return _repositoryUri!; }
        set { Initialize(); _repositoryUri!.Assign(value); }
    }
    private BicepValue<Uri>? _repositoryUri;

    /// <summary>
    /// The branch name of the source code.
    /// </summary>
    public BicepValue<string> Branch 
    {
        get { Initialize(); return _branch!; }
        set { Initialize(); _branch!.Assign(value); }
    }
    private BicepValue<string>? _branch;

    /// <summary>
    /// The authorization properties for accessing the source code repository
    /// and to set up             webhooks for notifications.
    /// </summary>
    public SourceCodeRepoAuthInfo SourceControlAuthProperties 
    {
        get { Initialize(); return _sourceControlAuthProperties!; }
        set { Initialize(); AssignOrReplace(ref _sourceControlAuthProperties, value); }
    }
    private SourceCodeRepoAuthInfo? _sourceControlAuthProperties;

    /// <summary>
    /// Creates a new SourceCodeRepoProperties.
    /// </summary>
    public SourceCodeRepoProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SourceCodeRepoProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _sourceControlType = DefineProperty<SourceControlType>("SourceControlType", ["SourceControlType"]);
        _repositoryUri = DefineProperty<Uri>("RepositoryUri", ["RepositoryUri"]);
        _branch = DefineProperty<string>("Branch", ["Branch"]);
        _sourceControlAuthProperties = DefineModelProperty<SourceCodeRepoAuthInfo>("SourceControlAuthProperties", ["SourceControlAuthProperties"]);
    }
}
