// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// ManagedInstanceServerTrustCertificate.
/// </summary>
public partial class ManagedInstanceServerTrustCertificate : ProvisionableResource
{
    /// <summary>
    /// Name of of the certificate to upload.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The certificate public blob.
    /// </summary>
    public BicepValue<string> PublicBlob 
    {
        get { Initialize(); return _publicBlob!; }
        set { Initialize(); _publicBlob!.Assign(value); }
    }
    private BicepValue<string>? _publicBlob;

    /// <summary>
    /// The certificate name.
    /// </summary>
    public BicepValue<string> CertificateName 
    {
        get { Initialize(); return _certificateName!; }
    }
    private BicepValue<string>? _certificateName;

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
    /// The certificate thumbprint.
    /// </summary>
    public BicepValue<string> Thumbprint 
    {
        get { Initialize(); return _thumbprint!; }
    }
    private BicepValue<string>? _thumbprint;

    /// <summary>
    /// Gets or sets a reference to the parent ManagedInstance.
    /// </summary>
    public ManagedInstance? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<ManagedInstance>? _parent;

    /// <summary>
    /// Creates a new ManagedInstanceServerTrustCertificate.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ManagedInstanceServerTrustCertificate resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedInstanceServerTrustCertificate.</param>
    public ManagedInstanceServerTrustCertificate(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/managedInstances/serverTrustCertificates", resourceVersion ?? "2023-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedInstanceServerTrustCertificate.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _publicBlob = DefineProperty<string>("PublicBlob", ["properties", "publicBlob"]);
        _certificateName = DefineProperty<string>("CertificateName", ["properties", "certificateName"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _thumbprint = DefineProperty<string>("Thumbprint", ["properties", "thumbprint"], isOutput: true);
        _parent = DefineResource<ManagedInstance>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ManagedInstanceServerTrustCertificate resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-08-01.
        /// </summary>
        public static readonly string V2023_08_01 = "2023-08-01";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing
    /// ManagedInstanceServerTrustCertificate.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ManagedInstanceServerTrustCertificate resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedInstanceServerTrustCertificate.</param>
    /// <returns>The existing ManagedInstanceServerTrustCertificate resource.</returns>
    public static ManagedInstanceServerTrustCertificate FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
