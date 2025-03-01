// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Communication;

/// <summary>
/// EmailService.
/// </summary>
public partial class EmailService : ProvisionableResource
{
    /// <summary>
    /// The name of the EmailService resource.
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
    /// The location where the email service stores its data at rest.
    /// </summary>
    public BicepValue<string> DataLocation 
    {
        get { Initialize(); return _dataLocation!; }
        set { Initialize(); _dataLocation!.Assign(value); }
    }
    private BicepValue<string>? _dataLocation;

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
    /// Provisioning state of the resource.
    /// </summary>
    public BicepValue<EmailServicesProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<EmailServicesProvisioningState>? _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new EmailService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EmailService resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EmailService.</param>
    public EmailService(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Communication/emailServices", resourceVersion ?? "2023-04-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of EmailService.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _dataLocation = DefineProperty<string>("DataLocation", ["DataLocation"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<EmailServicesProvisioningState>("ProvisioningState", ["ProvisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported EmailService resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-03-31.
        /// </summary>
        public static readonly string V2023_03_31 = "2023-03-31";
    }

    /// <summary>
    /// Creates a reference to an existing EmailService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EmailService resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EmailService.</param>
    /// <returns>The existing EmailService resource.</returns>
    public static EmailService FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
