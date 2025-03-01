// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// CognitiveServicesEncryptionScope.
/// </summary>
public partial class CognitiveServicesEncryptionScope : ProvisionableResource
{
    /// <summary>
    /// The name of the encryptionScope associated with the Cognitive Services
    /// Account.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Properties of Cognitive Services EncryptionScope.
    /// </summary>
    public CognitiveServicesEncryptionScopeProperties Properties 
    {
        get { Initialize(); return _properties!; }
        set { Initialize(); AssignOrReplace(ref _properties, value); }
    }
    private CognitiveServicesEncryptionScopeProperties? _properties;

    /// <summary>
    /// Resource tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// Resource Etag.
    /// </summary>
    public BicepValue<ETag> ETag 
    {
        get { Initialize(); return _eTag!; }
    }
    private BicepValue<ETag>? _eTag;

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
    /// Gets or sets a reference to the parent CognitiveServicesAccount.
    /// </summary>
    public CognitiveServicesAccount? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<CognitiveServicesAccount>? _parent;

    /// <summary>
    /// Creates a new CognitiveServicesEncryptionScope.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CognitiveServicesEncryptionScope
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CognitiveServicesEncryptionScope.</param>
    public CognitiveServicesEncryptionScope(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.CognitiveServices/accounts/encryptionScopes", resourceVersion ?? "2024-10-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// CognitiveServicesEncryptionScope.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _properties = DefineModelProperty<CognitiveServicesEncryptionScopeProperties>("Properties", ["properties"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _eTag = DefineProperty<ETag>("ETag", ["etag"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<CognitiveServicesAccount>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported CognitiveServicesEncryptionScope resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-10-01.
        /// </summary>
        public static readonly string V2024_10_01 = "2024-10-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

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
    /// Creates a reference to an existing CognitiveServicesEncryptionScope.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CognitiveServicesEncryptionScope
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CognitiveServicesEncryptionScope.</param>
    /// <returns>The existing CognitiveServicesEncryptionScope resource.</returns>
    public static CognitiveServicesEncryptionScope FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
