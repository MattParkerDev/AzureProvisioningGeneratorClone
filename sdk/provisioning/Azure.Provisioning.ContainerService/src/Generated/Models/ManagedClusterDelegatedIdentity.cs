// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Delegated resource properties - internal use only.
/// </summary>
public partial class ManagedClusterDelegatedIdentity : ProvisionableConstruct
{
    /// <summary>
    /// The ARM resource id of the delegated resource - internal use only.
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId 
    {
        get { Initialize(); return _resourceId!; }
        set { Initialize(); _resourceId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _resourceId;

    /// <summary>
    /// The tenant id of the delegated resource - internal use only.
    /// </summary>
    public BicepValue<Guid> TenantId 
    {
        get { Initialize(); return _tenantId!; }
        set { Initialize(); _tenantId!.Assign(value); }
    }
    private BicepValue<Guid>? _tenantId;

    /// <summary>
    /// The delegation id of the referral delegation (optional) - internal use
    /// only.
    /// </summary>
    public BicepValue<string> ReferralResource 
    {
        get { Initialize(); return _referralResource!; }
        set { Initialize(); _referralResource!.Assign(value); }
    }
    private BicepValue<string>? _referralResource;

    /// <summary>
    /// The source resource location - internal use only.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// Creates a new ManagedClusterDelegatedIdentity.
    /// </summary>
    public ManagedClusterDelegatedIdentity()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedClusterDelegatedIdentity.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _resourceId = DefineProperty<ResourceIdentifier>("ResourceId", ["ResourceId"]);
        _tenantId = DefineProperty<Guid>("TenantId", ["TenantId"]);
        _referralResource = DefineProperty<string>("ReferralResource", ["ReferralResource"]);
        _location = DefineProperty<AzureLocation>("Location", ["location"]);
    }
}
