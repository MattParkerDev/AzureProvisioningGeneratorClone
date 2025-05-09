// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// The user owned AML workspace for Cognitive Services account.
/// </summary>
public partial class UserOwnedAmlWorkspace : ProvisionableConstruct
{
    /// <summary>
    /// Full resource id of a AML workspace resource.
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId 
    {
        get { Initialize(); return _resourceId!; }
        set { Initialize(); _resourceId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _resourceId;

    /// <summary>
    /// Identity Client id of a AML workspace resource.
    /// </summary>
    public BicepValue<Guid> IdentityClientId 
    {
        get { Initialize(); return _identityClientId!; }
        set { Initialize(); _identityClientId!.Assign(value); }
    }
    private BicepValue<Guid>? _identityClientId;

    /// <summary>
    /// Creates a new UserOwnedAmlWorkspace.
    /// </summary>
    public UserOwnedAmlWorkspace()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of UserOwnedAmlWorkspace.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _resourceId = DefineProperty<ResourceIdentifier>("ResourceId", ["resourceId"]);
        _identityClientId = DefineProperty<Guid>("IdentityClientId", ["identityClientId"]);
    }
}
