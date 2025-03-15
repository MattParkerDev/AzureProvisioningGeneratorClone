// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// OperationalInsightsTable.
/// </summary>
public partial class OperationalInsightsTable : ProvisionableResource
{
    /// <summary>
    /// The name of the table.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Instruct the system how to handle and charge the logs ingested to this
    /// table.
    /// </summary>
    public BicepValue<OperationalInsightsTablePlan> Plan 
    {
        get { Initialize(); return _plan!; }
        set { Initialize(); _plan!.Assign(value); }
    }
    private BicepValue<OperationalInsightsTablePlan>? _plan;

    /// <summary>
    /// Parameters of the restore operation that initiated this table.
    /// </summary>
    public OperationalInsightsTableRestoredLogs RestoredLogs 
    {
        get { Initialize(); return _restoredLogs!; }
        set { Initialize(); AssignOrReplace(ref _restoredLogs, value); }
    }
    private OperationalInsightsTableRestoredLogs? _restoredLogs;

    /// <summary>
    /// The table retention in days, between 4 and 730. Setting this property
    /// to -1 will default to the workspace retention.
    /// </summary>
    public BicepValue<int> RetentionInDays 
    {
        get { Initialize(); return _retentionInDays!; }
        set { Initialize(); _retentionInDays!.Assign(value); }
    }
    private BicepValue<int>? _retentionInDays;

    /// <summary>
    /// Table schema.
    /// </summary>
    public OperationalInsightsSchema Schema 
    {
        get { Initialize(); return _schema!; }
        set { Initialize(); AssignOrReplace(ref _schema, value); }
    }
    private OperationalInsightsSchema? _schema;

    /// <summary>
    /// Parameters of the search job that initiated this table.
    /// </summary>
    public OperationalInsightsTableSearchResults SearchResults 
    {
        get { Initialize(); return _searchResults!; }
        set { Initialize(); AssignOrReplace(ref _searchResults, value); }
    }
    private OperationalInsightsTableSearchResults? _searchResults;

    /// <summary>
    /// The table total retention in days, between 4 and 2556. Setting this
    /// property to -1 will default to table retention.
    /// </summary>
    public BicepValue<int> TotalRetentionInDays 
    {
        get { Initialize(); return _totalRetentionInDays!; }
        set { Initialize(); _totalRetentionInDays!.Assign(value); }
    }
    private BicepValue<int>? _totalRetentionInDays;

    /// <summary>
    /// The table data archive retention in days. Calculated as
    /// (totalRetentionInDays-retentionInDays).
    /// </summary>
    public BicepValue<int> ArchiveRetentionInDays 
    {
        get { Initialize(); return _archiveRetentionInDays!; }
    }
    private BicepValue<int>? _archiveRetentionInDays;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// True - Value originates from workspace retention in days, False -
    /// Customer specific.
    /// </summary>
    public BicepValue<bool> IsRetentionInDaysAsDefault 
    {
        get { Initialize(); return _isRetentionInDaysAsDefault!; }
    }
    private BicepValue<bool>? _isRetentionInDaysAsDefault;

    /// <summary>
    /// True - Value originates from retention in days, False - Customer
    /// specific.
    /// </summary>
    public BicepValue<bool> IsTotalRetentionInDaysAsDefault 
    {
        get { Initialize(); return _isTotalRetentionInDaysAsDefault!; }
    }
    private BicepValue<bool>? _isTotalRetentionInDaysAsDefault;

    /// <summary>
    /// The timestamp that table plan was last modified (UTC).
    /// </summary>
    public BicepValue<string> LastPlanModifiedDate 
    {
        get { Initialize(); return _lastPlanModifiedDate!; }
    }
    private BicepValue<string>? _lastPlanModifiedDate;

    /// <summary>
    /// Table&apos;s current provisioning state. If set to
    /// &apos;updating&apos;, indicates a resource lock due to ongoing
    /// operation, forbidding any update to the table until the ongoing
    /// operation is concluded.
    /// </summary>
    public BicepValue<OperationalInsightsTableProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<OperationalInsightsTableProvisioningState>? _provisioningState;

    /// <summary>
    /// Search job execution statistics.
    /// </summary>
    public OperationalInsightsTableResultStatistics ResultStatistics 
    {
        get { Initialize(); return _resultStatistics!; }
    }
    private OperationalInsightsTableResultStatistics? _resultStatistics;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent OperationalInsightsWorkspace.
    /// </summary>
    public OperationalInsightsWorkspace? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<OperationalInsightsWorkspace>? _parent;

    /// <summary>
    /// Creates a new OperationalInsightsTable.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the OperationalInsightsTable resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the OperationalInsightsTable.</param>
    public OperationalInsightsTable(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.OperationalInsights/workspaces/tables", resourceVersion ?? "2025-02-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of OperationalInsightsTable.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _plan = DefineProperty<OperationalInsightsTablePlan>("Plan", ["properties", "plan"]);
        _restoredLogs = DefineModelProperty<OperationalInsightsTableRestoredLogs>("RestoredLogs", ["properties", "restoredLogs"]);
        _retentionInDays = DefineProperty<int>("RetentionInDays", ["properties", "retentionInDays"]);
        _schema = DefineModelProperty<OperationalInsightsSchema>("Schema", ["properties", "schema"]);
        _searchResults = DefineModelProperty<OperationalInsightsTableSearchResults>("SearchResults", ["properties", "searchResults"]);
        _totalRetentionInDays = DefineProperty<int>("TotalRetentionInDays", ["properties", "totalRetentionInDays"]);
        _archiveRetentionInDays = DefineProperty<int>("ArchiveRetentionInDays", ["properties", "archiveRetentionInDays"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _isRetentionInDaysAsDefault = DefineProperty<bool>("IsRetentionInDaysAsDefault", ["properties", "retentionInDaysAsDefault"], isOutput: true);
        _isTotalRetentionInDaysAsDefault = DefineProperty<bool>("IsTotalRetentionInDaysAsDefault", ["properties", "totalRetentionInDaysAsDefault"], isOutput: true);
        _lastPlanModifiedDate = DefineProperty<string>("LastPlanModifiedDate", ["properties", "lastPlanModifiedDate"], isOutput: true);
        _provisioningState = DefineProperty<OperationalInsightsTableProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _resultStatistics = DefineModelProperty<OperationalInsightsTableResultStatistics>("ResultStatistics", ["properties", "resultStatistics"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<OperationalInsightsWorkspace>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported OperationalInsightsTable resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2025-02-01.
        /// </summary>
        public static readonly string V2025_02_01 = "2025-02-01";

        /// <summary>
        /// 2023-09-01.
        /// </summary>
        public static readonly string V2023_09_01 = "2023-09-01";

        /// <summary>
        /// 2022-10-01.
        /// </summary>
        public static readonly string V2022_10_01 = "2022-10-01";

        /// <summary>
        /// 2020-08-01.
        /// </summary>
        public static readonly string V2020_08_01 = "2020-08-01";
    }

    /// <summary>
    /// Creates a reference to an existing OperationalInsightsTable.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the OperationalInsightsTable resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the OperationalInsightsTable.</param>
    /// <returns>The existing OperationalInsightsTable resource.</returns>
    public static OperationalInsightsTable FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
