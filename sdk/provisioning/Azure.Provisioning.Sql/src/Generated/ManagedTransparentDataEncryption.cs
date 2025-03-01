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
/// ManagedTransparentDataEncryption.
/// </summary>
public partial class ManagedTransparentDataEncryption : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Specifies the state of the transparent data encryption.
    /// </summary>
    public BicepValue<TransparentDataEncryptionState> State 
    {
        get { Initialize(); return _state!; }
        set { Initialize(); _state!.Assign(value); }
    }
    private BicepValue<TransparentDataEncryptionState>? _state;

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
    /// Gets or sets a reference to the parent ManagedDatabase.
    /// </summary>
    public ManagedDatabase? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<ManagedDatabase>? _parent;

    /// <summary>
    /// Creates a new ManagedTransparentDataEncryption.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ManagedTransparentDataEncryption
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedTransparentDataEncryption.</param>
    public ManagedTransparentDataEncryption(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/managedInstances/databases/transparentDataEncryption", resourceVersion ?? "2023-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedTransparentDataEncryption.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _state = DefineProperty<TransparentDataEncryptionState>("State", ["properties", "state"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<ManagedDatabase>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ManagedTransparentDataEncryption resource versions.
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
    /// Creates a reference to an existing ManagedTransparentDataEncryption.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ManagedTransparentDataEncryption
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedTransparentDataEncryption.</param>
    /// <returns>The existing ManagedTransparentDataEncryption resource.</returns>
    public static ManagedTransparentDataEncryption FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
