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
/// CommitmentPlanAccountAssociation.
/// </summary>
public partial class CommitmentPlanAccountAssociation : ProvisionableResource
{
    /// <summary>
    /// The name of the commitment plan association with the Cognitive Services
    /// Account.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The Azure resource id of the account.
    /// </summary>
    public BicepValue<string> AccountId 
    {
        get { Initialize(); return _accountId!; }
        set { Initialize(); _accountId!.Assign(value); }
    }
    private BicepValue<string>? _accountId;

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
    /// Gets or sets a reference to the parent CognitiveServicesCommitmentPlan.
    /// </summary>
    public CognitiveServicesCommitmentPlan? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<CognitiveServicesCommitmentPlan>? _parent;

    /// <summary>
    /// Creates a new CommitmentPlanAccountAssociation.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CommitmentPlanAccountAssociation
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CommitmentPlanAccountAssociation.</param>
    public CommitmentPlanAccountAssociation(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.CognitiveServices/commitmentPlans/accountAssociations", resourceVersion ?? "2024-10-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// CommitmentPlanAccountAssociation.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _accountId = DefineProperty<string>("AccountId", ["properties", "accountId"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _eTag = DefineProperty<ETag>("ETag", ["etag"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<CognitiveServicesCommitmentPlan>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported CommitmentPlanAccountAssociation resource versions.
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
    }

    /// <summary>
    /// Creates a reference to an existing CommitmentPlanAccountAssociation.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CommitmentPlanAccountAssociation
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CommitmentPlanAccountAssociation.</param>
    /// <returns>The existing CommitmentPlanAccountAssociation resource.</returns>
    public static CommitmentPlanAccountAssociation FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
