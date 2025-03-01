// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The distance function to use for distance calculation in between vectors.
/// </summary>
public enum VectorDistanceFunction
{
    /// <summary>
    /// euclidean.
    /// </summary>
    [DataMember(Name = "euclidean")]
    Euclidean,

    /// <summary>
    /// cosine.
    /// </summary>
    [DataMember(Name = "cosine")]
    Cosine,

    /// <summary>
    /// dotproduct.
    /// </summary>
    [DataMember(Name = "dotproduct")]
    Dotproduct,
}
