// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// The PostgreSqlPrivateLinkServiceConnectionStateProperty.
/// </summary>
public partial class PostgreSqlPrivateLinkServiceConnectionStateProperty : ProvisionableConstruct
{
    /// <summary>
    /// The private link service connection status.
    /// </summary>
    public BicepValue<string> Status 
    {
        get { Initialize(); return _status!; }
        set { Initialize(); _status!.Assign(value); }
    }
    private BicepValue<string>? _status;

    /// <summary>
    /// The private link service connection description.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
        set { Initialize(); _description!.Assign(value); }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// The actions required for private link service connection.
    /// </summary>
    public BicepValue<string> ActionsRequired 
    {
        get { Initialize(); return _actionsRequired!; }
    }
    private BicepValue<string>? _actionsRequired;

    /// <summary>
    /// Creates a new PostgreSqlPrivateLinkServiceConnectionStateProperty.
    /// </summary>
    public PostgreSqlPrivateLinkServiceConnectionStateProperty()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// PostgreSqlPrivateLinkServiceConnectionStateProperty.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _status = DefineProperty<string>("Status", ["status"]);
        _description = DefineProperty<string>("Description", ["description"]);
        _actionsRequired = DefineProperty<string>("ActionsRequired", ["actionsRequired"], isOutput: true);
    }
}
