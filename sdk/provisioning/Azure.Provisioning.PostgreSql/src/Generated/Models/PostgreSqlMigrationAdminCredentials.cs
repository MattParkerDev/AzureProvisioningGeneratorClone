// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Server admin credentials.
/// </summary>
public partial class PostgreSqlMigrationAdminCredentials : ProvisionableConstruct
{
    /// <summary>
    /// Password for source server.
    /// </summary>
    public BicepValue<string> SourceServerPassword 
    {
        get { Initialize(); return _sourceServerPassword!; }
        set { Initialize(); _sourceServerPassword!.Assign(value); }
    }
    private BicepValue<string>? _sourceServerPassword;

    /// <summary>
    /// Password for target server.
    /// </summary>
    public BicepValue<string> TargetServerPassword 
    {
        get { Initialize(); return _targetServerPassword!; }
        set { Initialize(); _targetServerPassword!.Assign(value); }
    }
    private BicepValue<string>? _targetServerPassword;

    /// <summary>
    /// Creates a new PostgreSqlMigrationAdminCredentials.
    /// </summary>
    public PostgreSqlMigrationAdminCredentials()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// PostgreSqlMigrationAdminCredentials.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _sourceServerPassword = DefineProperty<string>("SourceServerPassword", ["sourceServerPassword"]);
        _targetServerPassword = DefineProperty<string>("TargetServerPassword", ["targetServerPassword"]);
    }
}
