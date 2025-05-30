// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;

namespace Azure.Provisioning.KubernetesConfiguration;

/// <summary>
/// KubernetesFluxConfiguration.
/// </summary>
public partial class KubernetesFluxConfiguration : ProvisionableResource
{
    /// <summary>
    /// Name of the Flux Configuration.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Parameters to reconcile to the AzureBlob source kind type.
    /// </summary>
    public KubernetesAzureBlob AzureBlob 
    {
        get { Initialize(); return _azureBlob!; }
        set { Initialize(); AssignOrReplace(ref _azureBlob, value); }
    }
    private KubernetesAzureBlob? _azureBlob;

    /// <summary>
    /// Parameters to reconcile to the Bucket source kind type.
    /// </summary>
    public KubernetesBucket Bucket 
    {
        get { Initialize(); return _bucket!; }
        set { Initialize(); AssignOrReplace(ref _bucket, value); }
    }
    private KubernetesBucket? _bucket;

    /// <summary>
    /// Key-value pairs of protected configuration settings for the
    /// configuration.
    /// </summary>
    public BicepDictionary<string> ConfigurationProtectedSettings 
    {
        get { Initialize(); return _configurationProtectedSettings!; }
        set { Initialize(); _configurationProtectedSettings!.Assign(value); }
    }
    private BicepDictionary<string>? _configurationProtectedSettings;

    /// <summary>
    /// Parameters to reconcile to the GitRepository source kind type.
    /// </summary>
    public KubernetesGitRepository GitRepository 
    {
        get { Initialize(); return _gitRepository!; }
        set { Initialize(); AssignOrReplace(ref _gitRepository, value); }
    }
    private KubernetesGitRepository? _gitRepository;

    /// <summary>
    /// Whether this configuration should suspend its reconciliation of its
    /// kustomizations and sources.
    /// </summary>
    public BicepValue<bool> IsReconciliationSuspended 
    {
        get { Initialize(); return _isReconciliationSuspended!; }
        set { Initialize(); _isReconciliationSuspended!.Assign(value); }
    }
    private BicepValue<bool>? _isReconciliationSuspended;

    /// <summary>
    /// Array of kustomizations used to reconcile the artifact pulled by the
    /// source type on the cluster.
    /// </summary>
    public BicepDictionary<Kustomization> Kustomizations 
    {
        get { Initialize(); return _kustomizations!; }
        set { Initialize(); _kustomizations!.Assign(value); }
    }
    private BicepDictionary<Kustomization>? _kustomizations;

    /// <summary>
    /// The namespace to which this configuration is installed to. Maximum of
    /// 253 lower case alphanumeric characters, hyphen and period only.
    /// </summary>
    public BicepValue<string> Namespace 
    {
        get { Initialize(); return _namespace!; }
        set { Initialize(); _namespace!.Assign(value); }
    }
    private BicepValue<string>? _namespace;

    /// <summary>
    /// Scope at which the operator will be installed.
    /// </summary>
    public BicepValue<KubernetesConfigurationScope> Scope 
    {
        get { Initialize(); return _scope!; }
        set { Initialize(); _scope!.Assign(value); }
    }
    private BicepValue<KubernetesConfigurationScope>? _scope;

    /// <summary>
    /// Source Kind to pull the configuration data from.
    /// </summary>
    public BicepValue<KubernetesConfigurationSourceKind> SourceKind 
    {
        get { Initialize(); return _sourceKind!; }
        set { Initialize(); _sourceKind!.Assign(value); }
    }
    private BicepValue<KubernetesConfigurationSourceKind>? _sourceKind;

    /// <summary>
    /// Combined status of the Flux Kubernetes resources created by the
    /// fluxConfiguration or created by the managed objects.
    /// </summary>
    public BicepValue<KubernetesFluxComplianceState> ComplianceState 
    {
        get { Initialize(); return _complianceState!; }
    }
    private BicepValue<KubernetesFluxComplianceState>? _complianceState;

    /// <summary>
    /// Error message returned to the user in the case of provisioning failure.
    /// </summary>
    public BicepValue<string> ErrorMessage 
    {
        get { Initialize(); return _errorMessage!; }
    }
    private BicepValue<string>? _errorMessage;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Status of the creation of the fluxConfiguration.
    /// </summary>
    public BicepValue<KubernetesConfigurationProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<KubernetesConfigurationProvisioningState>? _provisioningState;

    /// <summary>
    /// Public Key associated with this fluxConfiguration (either generated
    /// within the cluster or provided by the user).
    /// </summary>
    public BicepValue<string> RepositoryPublicKey 
    {
        get { Initialize(); return _repositoryPublicKey!; }
    }
    private BicepValue<string>? _repositoryPublicKey;

    /// <summary>
    /// Branch and/or SHA of the source commit synced with the cluster.
    /// </summary>
    public BicepValue<string> SourceSyncedCommitId 
    {
        get { Initialize(); return _sourceSyncedCommitId!; }
    }
    private BicepValue<string>? _sourceSyncedCommitId;

    /// <summary>
    /// Datetime the fluxConfiguration synced its source on the cluster.
    /// </summary>
    public BicepValue<DateTimeOffset> SourceUpdatedOn 
    {
        get { Initialize(); return _sourceUpdatedOn!; }
    }
    private BicepValue<DateTimeOffset>? _sourceUpdatedOn;

    /// <summary>
    /// Statuses of the Flux Kubernetes resources created by the
    /// fluxConfiguration or created by the managed objects provisioned by the
    /// fluxConfiguration.
    /// </summary>
    public BicepList<KubernetesObjectStatus> Statuses 
    {
        get { Initialize(); return _statuses!; }
    }
    private BicepList<KubernetesObjectStatus>? _statuses;

    /// <summary>
    /// Datetime the fluxConfiguration synced its status on the cluster with
    /// Azure.
    /// </summary>
    public BicepValue<DateTimeOffset> StatusUpdatedOn 
    {
        get { Initialize(); return _statusUpdatedOn!; }
    }
    private BicepValue<DateTimeOffset>? _statusUpdatedOn;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new KubernetesFluxConfiguration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the KubernetesFluxConfiguration
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the KubernetesFluxConfiguration.</param>
    public KubernetesFluxConfiguration(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.KubernetesConfiguration/fluxConfigurations", resourceVersion ?? "2024-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of KubernetesFluxConfiguration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _azureBlob = DefineModelProperty<KubernetesAzureBlob>("AzureBlob", ["AzureBlob"]);
        _bucket = DefineModelProperty<KubernetesBucket>("Bucket", ["Bucket"]);
        _configurationProtectedSettings = DefineDictionaryProperty<string>("ConfigurationProtectedSettings", ["ConfigurationProtectedSettings"]);
        _gitRepository = DefineModelProperty<KubernetesGitRepository>("GitRepository", ["GitRepository"]);
        _isReconciliationSuspended = DefineProperty<bool>("IsReconciliationSuspended", ["IsReconciliationSuspended"]);
        _kustomizations = DefineDictionaryProperty<Kustomization>("Kustomizations", ["Kustomizations"]);
        _namespace = DefineProperty<string>("Namespace", ["Namespace"]);
        _scope = DefineProperty<KubernetesConfigurationScope>("Scope", ["Scope"]);
        _sourceKind = DefineProperty<KubernetesConfigurationSourceKind>("SourceKind", ["SourceKind"]);
        _complianceState = DefineProperty<KubernetesFluxComplianceState>("ComplianceState", ["ComplianceState"], isOutput: true);
        _errorMessage = DefineProperty<string>("ErrorMessage", ["ErrorMessage"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<KubernetesConfigurationProvisioningState>("ProvisioningState", ["ProvisioningState"], isOutput: true);
        _repositoryPublicKey = DefineProperty<string>("RepositoryPublicKey", ["RepositoryPublicKey"], isOutput: true);
        _sourceSyncedCommitId = DefineProperty<string>("SourceSyncedCommitId", ["SourceSyncedCommitId"], isOutput: true);
        _sourceUpdatedOn = DefineProperty<DateTimeOffset>("SourceUpdatedOn", ["SourceUpdatedOn"], isOutput: true);
        _statuses = DefineListProperty<KubernetesObjectStatus>("Statuses", ["Statuses"], isOutput: true);
        _statusUpdatedOn = DefineProperty<DateTimeOffset>("StatusUpdatedOn", ["StatusUpdatedOn"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported KubernetesFluxConfiguration resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-11-01.
        /// </summary>
        public static readonly string V2024_11_01 = "2024-11-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2022-11-01.
        /// </summary>
        public static readonly string V2022_11_01 = "2022-11-01";

        /// <summary>
        /// 2022-07-01.
        /// </summary>
        public static readonly string V2022_07_01 = "2022-07-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";
    }

    /// <summary>
    /// Creates a reference to an existing KubernetesFluxConfiguration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the KubernetesFluxConfiguration
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the KubernetesFluxConfiguration.</param>
    /// <returns>The existing KubernetesFluxConfiguration resource.</returns>
    public static KubernetesFluxConfiguration FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Creates a role assignment for a user-assigned identity that grants
    /// access to this KubernetesFluxConfiguration.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(KubernetesConfigurationBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{BicepIdentifier}_{identity.BicepIdentifier}_{KubernetesConfigurationBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Creates a role assignment for a principal that grants access to this
    /// KubernetesFluxConfiguration.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <param name="bicepIdentifierSuffix">Optional role assignment identifier name suffix.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(KubernetesConfigurationBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId, string? bicepIdentifierSuffix = default) =>
        new($"{BicepIdentifier}_{KubernetesConfigurationBuiltInRole.GetBuiltInRoleName(role)}{(bicepIdentifierSuffix is null ? "" : "_")}{bicepIdentifierSuffix}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
