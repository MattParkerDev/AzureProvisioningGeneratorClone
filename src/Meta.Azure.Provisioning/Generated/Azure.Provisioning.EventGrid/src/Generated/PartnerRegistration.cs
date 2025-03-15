// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// PartnerRegistration.
/// </summary>
public partial class PartnerRegistration : ProvisionableResource
{
    /// <summary>
    /// Name of the partner registration.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// The immutableId of the corresponding partner registration.
    /// Note: This property is marked for deprecation and is not
    /// supported in any future GA API version
    /// </summary>
    public BicepValue<Guid> PartnerRegistrationImmutableId 
    {
        get { Initialize(); return _partnerRegistrationImmutableId!; }
        set { Initialize(); _partnerRegistrationImmutableId!.Assign(value); }
    }
    private BicepValue<Guid>? _partnerRegistrationImmutableId;

    /// <summary>
    /// Gets or sets the Tags.
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
    /// Provisioning state of the partner registration.
    /// </summary>
    public BicepValue<PartnerRegistrationProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<PartnerRegistrationProvisioningState>? _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new PartnerRegistration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PartnerRegistration resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PartnerRegistration.</param>
    public PartnerRegistration(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventGrid/partnerRegistrations", resourceVersion ?? "2025-02-15")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of PartnerRegistration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _partnerRegistrationImmutableId = DefineProperty<Guid>("PartnerRegistrationImmutableId", ["properties", "partnerRegistrationImmutableId"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<PartnerRegistrationProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported PartnerRegistration resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2025-02-15.
        /// </summary>
        public static readonly string V2025_02_15 = "2025-02-15";

        /// <summary>
        /// 2022-06-15.
        /// </summary>
        public static readonly string V2022_06_15 = "2022-06-15";
    }

    /// <summary>
    /// Creates a reference to an existing PartnerRegistration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PartnerRegistration resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PartnerRegistration.</param>
    /// <returns>The existing PartnerRegistration resource.</returns>
    public static PartnerRegistration FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
