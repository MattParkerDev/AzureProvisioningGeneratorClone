// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// KeyVaultService.
/// </summary>
public partial class KeyVaultService : ProvisionableResource
{
    /// <summary>
    /// Name of the vault.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The supported Azure location where the key vault should be created.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// Properties of the vault.
    /// </summary>
    public KeyVaultProperties Properties 
    {
        get { Initialize(); return _properties!; }
        set { Initialize(); AssignOrReplace(ref _properties, value); }
    }
    private KeyVaultProperties? _properties;

    /// <summary>
    /// The tags that will be assigned to the key vault.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new KeyVaultService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the KeyVaultService resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the KeyVaultService.</param>
    public KeyVaultService(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.KeyVault/vaults", resourceVersion ?? "2024-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of KeyVaultService.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _properties = DefineModelProperty<KeyVaultProperties>("Properties", ["properties"], isRequired: true);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported KeyVaultService resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-11-01.
        /// </summary>
        public static readonly string V2024_11_01 = "2024-11-01";

        /// <summary>
        /// 2023-08-01-PREVIEW.
        /// </summary>
        public static readonly string V2023_08_01_PREVIEW = "2023-08-01-PREVIEW";

        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2023-02-01.
        /// </summary>
        public static readonly string V2023_02_01 = "2023-02-01";

        /// <summary>
        /// 2022-11-01.
        /// </summary>
        public static readonly string V2022_11_01 = "2022-11-01";

        /// <summary>
        /// 2022-07-01.
        /// </summary>
        public static readonly string V2022_07_01 = "2022-07-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";

        /// <summary>
        /// 2019-09-01.
        /// </summary>
        public static readonly string V2019_09_01 = "2019-09-01";

        /// <summary>
        /// 2018-02-14.
        /// </summary>
        public static readonly string V2018_02_14 = "2018-02-14";

        /// <summary>
        /// 2016-10-01.
        /// </summary>
        public static readonly string V2016_10_01 = "2016-10-01";

        /// <summary>
        /// 2015-06-01.
        /// </summary>
        public static readonly string V2015_06_01 = "2015-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing KeyVaultService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the KeyVaultService resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the KeyVaultService.</param>
    /// <returns>The existing KeyVaultService resource.</returns>
    public static KeyVaultService FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this KeyVaultService resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 3, maxLength: 24, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);

    /// <summary>
    /// Creates a role assignment for a user-assigned identity that grants
    /// access to this KeyVaultService.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(KeyVaultBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{BicepIdentifier}_{identity.BicepIdentifier}_{KeyVaultBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Creates a role assignment for a principal that grants access to this
    /// KeyVaultService.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <param name="bicepIdentifierSuffix">Optional role assignment identifier name suffix.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(KeyVaultBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId, string? bicepIdentifierSuffix = default) =>
        new($"{BicepIdentifier}_{KeyVaultBuiltInRole.GetBuiltInRoleName(role)}{(bicepIdentifierSuffix is null ? "" : "_")}{bicepIdentifierSuffix}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
