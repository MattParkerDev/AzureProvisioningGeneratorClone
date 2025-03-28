// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// The resource management error additional info.
/// </summary>
public partial class ErrorAdditionalInfo : ProvisionableConstruct
{
    /// <summary>
    /// The additional info type.
    /// </summary>
    public BicepValue<string> ErrorAdditionalInfoType 
    {
        get { Initialize(); return _errorAdditionalInfoType!; }
    }
    private BicepValue<string>? _errorAdditionalInfoType;

    /// <summary>
    /// The additional info.                          To assign an object to
    /// this property use
    /// System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> Info 
    {
        get { Initialize(); return _info!; }
    }
    private BicepValue<BinaryData>? _info;

    /// <summary>
    /// Creates a new ErrorAdditionalInfo.
    /// </summary>
    public ErrorAdditionalInfo()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ErrorAdditionalInfo.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _errorAdditionalInfoType = DefineProperty<string>("ErrorAdditionalInfoType", ["type"], isOutput: true);
        _info = DefineProperty<BinaryData>("Info", ["info"], isOutput: true);
    }
}
