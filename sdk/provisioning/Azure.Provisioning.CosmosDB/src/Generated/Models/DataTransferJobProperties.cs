// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The properties of a DataTransfer Job.
/// </summary>
public partial class DataTransferJobProperties : ProvisionableConstruct
{
    /// <summary>
    /// Job Name.
    /// </summary>
    public BicepValue<string> JobName 
    {
        get { Initialize(); return _jobName!; }
    }
    private BicepValue<string>? _jobName;

    /// <summary>
    /// Source DataStore details             Please note
    /// Azure.ResourceManager.CosmosDB.Models.DataTransferDataSourceSink is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.CosmosDB.Models.AzureBlobDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.BaseCosmosDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosCassandraDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosMongoDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosMongoVCoreDataTransferDataSourceSink
    /// and
    /// Azure.ResourceManager.CosmosDB.Models.CosmosSqlDataTransferDataSourceSink.
    /// </summary>
    public DataTransferDataSourceSink Source 
    {
        get { Initialize(); return _source!; }
        set { Initialize(); AssignOrReplace(ref _source, value); }
    }
    private DataTransferDataSourceSink? _source;

    /// <summary>
    /// Destination DataStore details             Please note
    /// Azure.ResourceManager.CosmosDB.Models.DataTransferDataSourceSink is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.CosmosDB.Models.AzureBlobDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.BaseCosmosDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosCassandraDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosMongoDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosMongoVCoreDataTransferDataSourceSink
    /// and
    /// Azure.ResourceManager.CosmosDB.Models.CosmosSqlDataTransferDataSourceSink.
    /// </summary>
    public DataTransferDataSourceSink Destination 
    {
        get { Initialize(); return _destination!; }
        set { Initialize(); AssignOrReplace(ref _destination, value); }
    }
    private DataTransferDataSourceSink? _destination;

    /// <summary>
    /// Job Status.
    /// </summary>
    public BicepValue<string> Status 
    {
        get { Initialize(); return _status!; }
    }
    private BicepValue<string>? _status;

    /// <summary>
    /// Processed Count.
    /// </summary>
    public BicepValue<long> ProcessedCount 
    {
        get { Initialize(); return _processedCount!; }
    }
    private BicepValue<long>? _processedCount;

    /// <summary>
    /// Total Count.
    /// </summary>
    public BicepValue<long> TotalCount 
    {
        get { Initialize(); return _totalCount!; }
    }
    private BicepValue<long>? _totalCount;

    /// <summary>
    /// Last Updated Time (ISO-8601 format).
    /// </summary>
    public BicepValue<DateTimeOffset> LastUpdatedUtcOn 
    {
        get { Initialize(); return _lastUpdatedUtcOn!; }
    }
    private BicepValue<DateTimeOffset>? _lastUpdatedUtcOn;

    /// <summary>
    /// Worker count.
    /// </summary>
    public BicepValue<int> WorkerCount 
    {
        get { Initialize(); return _workerCount!; }
        set { Initialize(); _workerCount!.Assign(value); }
    }
    private BicepValue<int>? _workerCount;

    /// <summary>
    /// Error response for Faulted job.
    /// </summary>
    public CosmosDBErrorResult Error 
    {
        get { Initialize(); return _error!; }
    }
    private CosmosDBErrorResult? _error;

    /// <summary>
    /// Total Duration of Job.
    /// </summary>
    public BicepValue<TimeSpan> Duration 
    {
        get { Initialize(); return _duration!; }
    }
    private BicepValue<TimeSpan>? _duration;

    /// <summary>
    /// Mode of job execution.
    /// </summary>
    public BicepValue<DataTransferJobMode> Mode 
    {
        get { Initialize(); return _mode!; }
        set { Initialize(); _mode!.Assign(value); }
    }
    private BicepValue<DataTransferJobMode>? _mode;

    /// <summary>
    /// Creates a new DataTransferJobProperties.
    /// </summary>
    public DataTransferJobProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of DataTransferJobProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _jobName = DefineProperty<string>("JobName", ["jobName"], isOutput: true);
        _source = DefineModelProperty<DataTransferDataSourceSink>("Source", ["source"]);
        _destination = DefineModelProperty<DataTransferDataSourceSink>("Destination", ["destination"]);
        _status = DefineProperty<string>("Status", ["status"], isOutput: true);
        _processedCount = DefineProperty<long>("ProcessedCount", ["processedCount"], isOutput: true);
        _totalCount = DefineProperty<long>("TotalCount", ["totalCount"], isOutput: true);
        _lastUpdatedUtcOn = DefineProperty<DateTimeOffset>("LastUpdatedUtcOn", ["lastUpdatedUtcTime"], isOutput: true);
        _workerCount = DefineProperty<int>("WorkerCount", ["workerCount"]);
        _error = DefineModelProperty<CosmosDBErrorResult>("Error", ["error"], isOutput: true);
        _duration = DefineProperty<TimeSpan>("Duration", ["duration"], isOutput: true);
        _mode = DefineProperty<DataTransferJobMode>("Mode", ["mode"]);
    }
}
