// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Resources;

/// <summary>
/// ManagementGroupPolicySetDefinition.
/// </summary>
public partial class ManagementGroupPolicySetDefinition : ProvisionableResource
{
    /// <summary>
    /// The name of the policy set definition to create.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The policy set definition description.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
        set { Initialize(); _description!.Assign(value); }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// The display name of the policy set definition.
    /// </summary>
    public BicepValue<string> DisplayName 
    {
        get { Initialize(); return _displayName!; }
        set { Initialize(); _displayName!.Assign(value); }
    }
    private BicepValue<string>? _displayName;

    /// <summary>
    /// The policy set definition metadata.  Metadata is an open ended object
    /// and is typically a collection of key value pairs.
    /// To assign an object to this property use
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
    public BicepValue<BinaryData> Metadata 
    {
        get { Initialize(); return _metadata!; }
        set { Initialize(); _metadata!.Assign(value); }
    }
    private BicepValue<BinaryData>? _metadata;

    /// <summary>
    /// The policy set definition parameters that can be used in policy
    /// definition references.
    /// </summary>
    public BicepDictionary<ArmPolicyParameter> Parameters 
    {
        get { Initialize(); return _parameters!; }
        set { Initialize(); _parameters!.Assign(value); }
    }
    private BicepDictionary<ArmPolicyParameter>? _parameters;

    /// <summary>
    /// The metadata describing groups of policy definition references within
    /// the policy set definition.
    /// </summary>
    public BicepList<PolicyDefinitionGroup> PolicyDefinitionGroups 
    {
        get { Initialize(); return _policyDefinitionGroups!; }
        set { Initialize(); _policyDefinitionGroups!.Assign(value); }
    }
    private BicepList<PolicyDefinitionGroup>? _policyDefinitionGroups;

    /// <summary>
    /// An array of policy definition references.
    /// </summary>
    public BicepList<PolicyDefinitionReference> PolicyDefinitions 
    {
        get { Initialize(); return _policyDefinitions!; }
        set { Initialize(); _policyDefinitions!.Assign(value); }
    }
    private BicepList<PolicyDefinitionReference>? _policyDefinitions;

    /// <summary>
    /// The type of policy definition. Possible values are NotSpecified,
    /// BuiltIn, Custom, and Static.
    /// </summary>
    public BicepValue<PolicyType> PolicyType 
    {
        get { Initialize(); return _policyType!; }
        set { Initialize(); _policyType!.Assign(value); }
    }
    private BicepValue<PolicyType>? _policyType;

    /// <summary>
    /// Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Azure Resource Manager metadata containing createdBy and modifiedBy
    /// information.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new ManagementGroupPolicySetDefinition.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ManagementGroupPolicySetDefinition
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagementGroupPolicySetDefinition.</param>
    public ManagementGroupPolicySetDefinition(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Authorization/policySetDefinitions", resourceVersion ?? "2025-01-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagementGroupPolicySetDefinition.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _description = DefineProperty<string>("Description", ["properties", "description"]);
        _displayName = DefineProperty<string>("DisplayName", ["properties", "displayName"]);
        _metadata = DefineProperty<BinaryData>("Metadata", ["properties", "metadata"]);
        _parameters = DefineDictionaryProperty<ArmPolicyParameter>("Parameters", ["properties", "parameters"]);
        _policyDefinitionGroups = DefineListProperty<PolicyDefinitionGroup>("PolicyDefinitionGroups", ["properties", "policyDefinitionGroups"]);
        _policyDefinitions = DefineListProperty<PolicyDefinitionReference>("PolicyDefinitions", ["properties", "policyDefinitions"]);
        _policyType = DefineProperty<PolicyType>("PolicyType", ["properties", "policyType"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ManagementGroupPolicySetDefinition resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2025-01-01.
        /// </summary>
        public static readonly string V2025_01_01 = "2025-01-01";

        /// <summary>
        /// 2024-05-01.
        /// </summary>
        public static readonly string V2024_05_01 = "2024-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-08-01.
        /// </summary>
        public static readonly string V2020_08_01 = "2020-08-01";

        /// <summary>
        /// 2020-03-01.
        /// </summary>
        public static readonly string V2020_03_01 = "2020-03-01";

        /// <summary>
        /// 2019-09-01.
        /// </summary>
        public static readonly string V2019_09_01 = "2019-09-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-01-01.
        /// </summary>
        public static readonly string V2019_01_01 = "2019-01-01";

        /// <summary>
        /// 2018-05-01.
        /// </summary>
        public static readonly string V2018_05_01 = "2018-05-01";

        /// <summary>
        /// 2018-03-01.
        /// </summary>
        public static readonly string V2018_03_01 = "2018-03-01";
    }

    /// <summary>
    /// Creates a reference to an existing ManagementGroupPolicySetDefinition.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ManagementGroupPolicySetDefinition
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagementGroupPolicySetDefinition.</param>
    /// <returns>The existing ManagementGroupPolicySetDefinition resource.</returns>
    public static ManagementGroupPolicySetDefinition FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ManagementGroupPolicySetDefinition
    /// resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 128, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period | ResourceNameCharacters.Parentheses);
}
