// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Indicates the data type of vector.
/// </summary>
public enum CosmosDBVectorDataType
{
    /// <summary>
    /// float32.
    /// </summary>
    [DataMember(Name = "float32")]
    Float32,

    /// <summary>
    /// uint8.
    /// </summary>
    [DataMember(Name = "uint8")]
    Uint8,

    /// <summary>
    /// int8.
    /// </summary>
    [DataMember(Name = "int8")]
    Int8,
}
