// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Migration source server type : OnPremises, AWS, GCP, AzureVM,
/// PostgreSQLSingleServer, AWS_RDS, AWS_AURORA, AWS_EC2, GCP_CloudSQL,
/// GCP_AlloyDB, GCP_Compute, or EDB.
/// </summary>
public enum PostgreSqlFlexibleServersSourceType
{
    /// <summary>
    /// OnPremises.
    /// </summary>
    OnPremises,

    /// <summary>
    /// AWS.
    /// </summary>
    AWS,

    /// <summary>
    /// GCP.
    /// </summary>
    GCP,

    /// <summary>
    /// AzureVM.
    /// </summary>
    [DataMember(Name = "AzureVM")]
    AzureVm,

    /// <summary>
    /// PostgreSQLSingleServer.
    /// </summary>
    PostgreSQLSingleServer,

    /// <summary>
    /// AWS_RDS.
    /// </summary>
    [DataMember(Name = "AWS_RDS")]
    AWSRDS,

    /// <summary>
    /// AWS_AURORA.
    /// </summary>
    [DataMember(Name = "AWS_AURORA")]
    AWSAurora,

    /// <summary>
    /// AWS_EC2.
    /// </summary>
    [DataMember(Name = "AWS_EC2")]
    AWSEC2,

    /// <summary>
    /// GCP_CloudSQL.
    /// </summary>
    [DataMember(Name = "GCP_CloudSQL")]
    GCPCloudSQL,

    /// <summary>
    /// GCP_AlloyDB.
    /// </summary>
    [DataMember(Name = "GCP_AlloyDB")]
    GCPAlloyDB,

    /// <summary>
    /// GCP_Compute.
    /// </summary>
    [DataMember(Name = "GCP_Compute")]
    GCPCompute,

    /// <summary>
    /// EDB.
    /// </summary>
    EDB,
}
