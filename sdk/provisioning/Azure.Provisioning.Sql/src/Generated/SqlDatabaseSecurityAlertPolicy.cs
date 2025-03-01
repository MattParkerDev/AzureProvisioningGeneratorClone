// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlDatabaseSecurityAlertPolicy.
/// </summary>
public partial class SqlDatabaseSecurityAlertPolicy : ProvisionableResource
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
    /// Specifies an array of alerts that are disabled. Allowed values are:
    /// Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly,
    /// Data_Exfiltration, Unsafe_Action, Brute_Force.
    /// </summary>
    public BicepList<string> DisabledAlerts 
    {
        get { Initialize(); return _disabledAlerts!; }
        set { Initialize(); _disabledAlerts!.Assign(value); }
    }
    private BicepList<string>? _disabledAlerts;

    /// <summary>
    /// Specifies an array of e-mail addresses to which the alert is sent.
    /// </summary>
    public BicepList<string> EmailAddresses 
    {
        get { Initialize(); return _emailAddresses!; }
        set { Initialize(); _emailAddresses!.Assign(value); }
    }
    private BicepList<string>? _emailAddresses;

    /// <summary>
    /// Specifies the number of days to keep in the Threat Detection audit logs.
    /// </summary>
    public BicepValue<int> RetentionDays 
    {
        get { Initialize(); return _retentionDays!; }
        set { Initialize(); _retentionDays!.Assign(value); }
    }
    private BicepValue<int>? _retentionDays;

    /// <summary>
    /// Specifies that the alert is sent to the account administrators.
    /// </summary>
    public BicepValue<bool> SendToEmailAccountAdmins 
    {
        get { Initialize(); return _sendToEmailAccountAdmins!; }
        set { Initialize(); _sendToEmailAccountAdmins!.Assign(value); }
    }
    private BicepValue<bool>? _sendToEmailAccountAdmins;

    /// <summary>
    /// Specifies the state of the policy, whether it is enabled or disabled or
    /// a policy has not been applied yet on the specific database.
    /// </summary>
    public BicepValue<SecurityAlertsPolicyState> State 
    {
        get { Initialize(); return _state!; }
        set { Initialize(); _state!.Assign(value); }
    }
    private BicepValue<SecurityAlertsPolicyState>? _state;

    /// <summary>
    /// Specifies the identifier key of the Threat Detection audit storage
    /// account.
    /// </summary>
    public BicepValue<string> StorageAccountAccessKey 
    {
        get { Initialize(); return _storageAccountAccessKey!; }
        set { Initialize(); _storageAccountAccessKey!.Assign(value); }
    }
    private BicepValue<string>? _storageAccountAccessKey;

    /// <summary>
    /// Specifies the blob storage endpoint (e.g.
    /// https://MyAccount.blob.core.windows.net). This blob storage will hold
    /// all Threat Detection audit logs.
    /// </summary>
    public BicepValue<string> StorageEndpoint 
    {
        get { Initialize(); return _storageEndpoint!; }
        set { Initialize(); _storageEndpoint!.Assign(value); }
    }
    private BicepValue<string>? _storageEndpoint;

    /// <summary>
    /// Specifies the UTC creation time of the policy.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn 
    {
        get { Initialize(); return _createdOn!; }
    }
    private BicepValue<DateTimeOffset>? _createdOn;

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
    /// Gets or sets a reference to the parent SqlDatabase.
    /// </summary>
    public SqlDatabase? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<SqlDatabase>? _parent;

    /// <summary>
    /// Creates a new SqlDatabaseSecurityAlertPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlDatabaseSecurityAlertPolicy
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlDatabaseSecurityAlertPolicy.</param>
    public SqlDatabaseSecurityAlertPolicy(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/securityAlertPolicies", resourceVersion ?? "2023-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// SqlDatabaseSecurityAlertPolicy.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _disabledAlerts = DefineListProperty<string>("DisabledAlerts", ["properties", "disabledAlerts"]);
        _emailAddresses = DefineListProperty<string>("EmailAddresses", ["properties", "emailAddresses"]);
        _retentionDays = DefineProperty<int>("RetentionDays", ["properties", "retentionDays"]);
        _sendToEmailAccountAdmins = DefineProperty<bool>("SendToEmailAccountAdmins", ["properties", "emailAccountAdmins"]);
        _state = DefineProperty<SecurityAlertsPolicyState>("State", ["properties", "state"]);
        _storageAccountAccessKey = DefineProperty<string>("StorageAccountAccessKey", ["properties", "storageAccountAccessKey"]);
        _storageEndpoint = DefineProperty<string>("StorageEndpoint", ["properties", "storageEndpoint"]);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["properties", "creationTime"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<SqlDatabase>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlDatabaseSecurityAlertPolicy resource versions.
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

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";

        /// <summary>
        /// 2014-01-01.
        /// </summary>
        public static readonly string V2014_01_01 = "2014-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlDatabaseSecurityAlertPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlDatabaseSecurityAlertPolicy
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlDatabaseSecurityAlertPolicy.</param>
    /// <returns>The existing SqlDatabaseSecurityAlertPolicy resource.</returns>
    public static SqlDatabaseSecurityAlertPolicy FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
