// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// This enables publishing to Event Grid using a custom input schema. This can
/// be used to map properties from a custom input JSON schema to the Event
/// Grid event schema.
/// </summary>
public partial class EventGridJsonInputSchemaMapping : EventGridInputSchemaMapping
{
    /// <summary>
    /// Name of a field in the input event schema that&apos;s to be used as the
    /// source of a mapping.
    /// </summary>
    public BicepValue<string> IdSourceField 
    {
        get { Initialize(); return _idSourceField!; }
        set { Initialize(); _idSourceField!.Assign(value); }
    }
    private BicepValue<string>? _idSourceField;

    /// <summary>
    /// Name of a field in the input event schema that&apos;s to be used as the
    /// source of a mapping.
    /// </summary>
    public BicepValue<string> TopicSourceField 
    {
        get { Initialize(); return _topicSourceField!; }
        set { Initialize(); _topicSourceField!.Assign(value); }
    }
    private BicepValue<string>? _topicSourceField;

    /// <summary>
    /// Name of a field in the input event schema that&apos;s to be used as the
    /// source of a mapping.
    /// </summary>
    public BicepValue<string> EventTimeSourceField 
    {
        get { Initialize(); return _eventTimeSourceField!; }
        set { Initialize(); _eventTimeSourceField!.Assign(value); }
    }
    private BicepValue<string>? _eventTimeSourceField;

    /// <summary>
    /// The mapping information for the EventType property of the Event Grid
    /// Event.
    /// </summary>
    public JsonFieldWithDefault EventType 
    {
        get { Initialize(); return _eventType!; }
        set { Initialize(); AssignOrReplace(ref _eventType, value); }
    }
    private JsonFieldWithDefault? _eventType;

    /// <summary>
    /// The mapping information for the Subject property of the Event Grid
    /// Event.
    /// </summary>
    public JsonFieldWithDefault Subject 
    {
        get { Initialize(); return _subject!; }
        set { Initialize(); AssignOrReplace(ref _subject, value); }
    }
    private JsonFieldWithDefault? _subject;

    /// <summary>
    /// The mapping information for the DataVersion property of the Event Grid
    /// Event.
    /// </summary>
    public JsonFieldWithDefault DataVersion 
    {
        get { Initialize(); return _dataVersion!; }
        set { Initialize(); AssignOrReplace(ref _dataVersion, value); }
    }
    private JsonFieldWithDefault? _dataVersion;

    /// <summary>
    /// Creates a new EventGridJsonInputSchemaMapping.
    /// </summary>
    public EventGridJsonInputSchemaMapping() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// EventGridJsonInputSchemaMapping.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _idSourceField = DefineProperty<string>("IdSourceField", ["IdSourceField"]);
        _topicSourceField = DefineProperty<string>("TopicSourceField", ["TopicSourceField"]);
        _eventTimeSourceField = DefineProperty<string>("EventTimeSourceField", ["EventTimeSourceField"]);
        _eventType = DefineModelProperty<JsonFieldWithDefault>("EventType", ["EventType"]);
        _subject = DefineModelProperty<JsonFieldWithDefault>("Subject", ["Subject"]);
        _dataVersion = DefineModelProperty<JsonFieldWithDefault>("DataVersion", ["DataVersion"]);
    }
}
