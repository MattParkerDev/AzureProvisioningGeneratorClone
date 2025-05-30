// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// AppServiceCertificateOrder.
/// </summary>
public partial class AppServiceCertificateOrder : ProvisionableResource
{
    /// <summary>
    /// Name of the certificate order.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// State of the Key Vault secret.
    /// </summary>
    public BicepDictionary<AppServiceCertificateProperties> Certificates 
    {
        get { Initialize(); return _certificates!; }
        set { Initialize(); _certificates!.Assign(value); }
    }
    private BicepDictionary<AppServiceCertificateProperties>? _certificates;

    /// <summary>
    /// Last CSR that was created for this order.
    /// </summary>
    public BicepValue<string> Csr 
    {
        get { Initialize(); return _csr!; }
        set { Initialize(); _csr!.Assign(value); }
    }
    private BicepValue<string>? _csr;

    /// <summary>
    /// Certificate distinguished name.
    /// </summary>
    public BicepValue<string> DistinguishedName 
    {
        get { Initialize(); return _distinguishedName!; }
        set { Initialize(); _distinguishedName!.Assign(value); }
    }
    private BicepValue<string>? _distinguishedName;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if the certificate should be
    /// automatically renewed when it expires; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsAutoRenew 
    {
        get { Initialize(); return _isAutoRenew!; }
        set { Initialize(); _isAutoRenew!.Assign(value); }
    }
    private BicepValue<bool>? _isAutoRenew;

    /// <summary>
    /// Certificate key size.
    /// </summary>
    public BicepValue<int> KeySize 
    {
        get { Initialize(); return _keySize!; }
        set { Initialize(); _keySize!.Assign(value); }
    }
    private BicepValue<int>? _keySize;

    /// <summary>
    /// Kind of resource. If the resource is an app, you can refer to
    /// https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference
    /// for details supported values for kind.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<string>? _kind;

    /// <summary>
    /// Certificate product type.
    /// </summary>
    public BicepValue<CertificateProductType> ProductType 
    {
        get { Initialize(); return _productType!; }
        set { Initialize(); _productType!.Assign(value); }
    }
    private BicepValue<CertificateProductType>? _productType;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// Duration in years (must be 1).
    /// </summary>
    public BicepValue<int> ValidityInYears 
    {
        get { Initialize(); return _validityInYears!; }
        set { Initialize(); _validityInYears!.Assign(value); }
    }
    private BicepValue<int>? _validityInYears;

    /// <summary>
    /// Reasons why App Service Certificate is not renewable at the current
    /// moment.
    /// </summary>
    public BicepList<AppServiceCertificateNotRenewableReason> AppServiceCertificateNotRenewableReasons 
    {
        get { Initialize(); return _appServiceCertificateNotRenewableReasons!; }
    }
    private BicepList<AppServiceCertificateNotRenewableReason>? _appServiceCertificateNotRenewableReasons;

    /// <summary>
    /// Contact info.
    /// </summary>
    public CertificateOrderContact Contact 
    {
        get { Initialize(); return _contact!; }
    }
    private CertificateOrderContact? _contact;

    /// <summary>
    /// Domain verification token.
    /// </summary>
    public BicepValue<string> DomainVerificationToken 
    {
        get { Initialize(); return _domainVerificationToken!; }
    }
    private BicepValue<string>? _domainVerificationToken;

    /// <summary>
    /// Certificate expiration time.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn 
    {
        get { Initialize(); return _expireOn!; }
    }
    private BicepValue<DateTimeOffset>? _expireOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Intermediate certificate.
    /// </summary>
    public AppServiceCertificateDetails Intermediate 
    {
        get { Initialize(); return _intermediate!; }
    }
    private AppServiceCertificateDetails? _intermediate;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsPrivateKeyExternal 
    {
        get { Initialize(); return _isPrivateKeyExternal!; }
    }
    private BicepValue<bool>? _isPrivateKeyExternal;

    /// <summary>
    /// Certificate last issuance time.
    /// </summary>
    public BicepValue<DateTimeOffset> LastCertificateIssuedOn 
    {
        get { Initialize(); return _lastCertificateIssuedOn!; }
    }
    private BicepValue<DateTimeOffset>? _lastCertificateIssuedOn;

    /// <summary>
    /// Time stamp when the certificate would be auto renewed next.
    /// </summary>
    public BicepValue<DateTimeOffset> NextAutoRenewTimeStamp 
    {
        get { Initialize(); return _nextAutoRenewTimeStamp!; }
    }
    private BicepValue<DateTimeOffset>? _nextAutoRenewTimeStamp;

    /// <summary>
    /// Status of certificate order.
    /// </summary>
    public BicepValue<ProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<ProvisioningState>? _provisioningState;

    /// <summary>
    /// Root certificate.
    /// </summary>
    public AppServiceCertificateDetails Root 
    {
        get { Initialize(); return _root!; }
    }
    private AppServiceCertificateDetails? _root;

    /// <summary>
    /// Current serial number of the certificate.
    /// </summary>
    public BicepValue<string> SerialNumber 
    {
        get { Initialize(); return _serialNumber!; }
    }
    private BicepValue<string>? _serialNumber;

    /// <summary>
    /// Signed certificate.
    /// </summary>
    public AppServiceCertificateDetails SignedCertificate 
    {
        get { Initialize(); return _signedCertificate!; }
    }
    private AppServiceCertificateDetails? _signedCertificate;

    /// <summary>
    /// Current order status.
    /// </summary>
    public BicepValue<CertificateOrderStatus> Status 
    {
        get { Initialize(); return _status!; }
    }
    private BicepValue<CertificateOrderStatus>? _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new AppServiceCertificateOrder.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppServiceCertificateOrder
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppServiceCertificateOrder.</param>
    public AppServiceCertificateOrder(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.CertificateRegistration/certificateOrders", resourceVersion ?? "2024-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AppServiceCertificateOrder.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _certificates = DefineDictionaryProperty<AppServiceCertificateProperties>("Certificates", ["properties", "certificates"]);
        _csr = DefineProperty<string>("Csr", ["properties", "csr"]);
        _distinguishedName = DefineProperty<string>("DistinguishedName", ["properties", "distinguishedName"]);
        _isAutoRenew = DefineProperty<bool>("IsAutoRenew", ["properties", "autoRenew"]);
        _keySize = DefineProperty<int>("KeySize", ["properties", "keySize"]);
        _kind = DefineProperty<string>("Kind", ["kind"]);
        _productType = DefineProperty<CertificateProductType>("ProductType", ["properties", "productType"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _validityInYears = DefineProperty<int>("ValidityInYears", ["properties", "validityInYears"]);
        _appServiceCertificateNotRenewableReasons = DefineListProperty<AppServiceCertificateNotRenewableReason>("AppServiceCertificateNotRenewableReasons", ["properties", "appServiceCertificateNotRenewableReasons"], isOutput: true);
        _contact = DefineModelProperty<CertificateOrderContact>("Contact", ["properties", "contact"], isOutput: true);
        _domainVerificationToken = DefineProperty<string>("DomainVerificationToken", ["properties", "domainVerificationToken"], isOutput: true);
        _expireOn = DefineProperty<DateTimeOffset>("ExpireOn", ["properties", "expirationTime"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _intermediate = DefineModelProperty<AppServiceCertificateDetails>("Intermediate", ["properties", "intermediate"], isOutput: true);
        _isPrivateKeyExternal = DefineProperty<bool>("IsPrivateKeyExternal", ["properties", "isPrivateKeyExternal"], isOutput: true);
        _lastCertificateIssuedOn = DefineProperty<DateTimeOffset>("LastCertificateIssuedOn", ["properties", "lastCertificateIssuanceTime"], isOutput: true);
        _nextAutoRenewTimeStamp = DefineProperty<DateTimeOffset>("NextAutoRenewTimeStamp", ["properties", "nextAutoRenewalTimeStamp"], isOutput: true);
        _provisioningState = DefineProperty<ProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _root = DefineModelProperty<AppServiceCertificateDetails>("Root", ["properties", "root"], isOutput: true);
        _serialNumber = DefineProperty<string>("SerialNumber", ["properties", "serialNumber"], isOutput: true);
        _signedCertificate = DefineModelProperty<AppServiceCertificateDetails>("SignedCertificate", ["properties", "signedCertificate"], isOutput: true);
        _status = DefineProperty<CertificateOrderStatus>("Status", ["properties", "status"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported AppServiceCertificateOrder resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-11-01.
        /// </summary>
        public static readonly string V2024_11_01 = "2024-11-01";

        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";
    }

    /// <summary>
    /// Creates a reference to an existing AppServiceCertificateOrder.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppServiceCertificateOrder
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppServiceCertificateOrder.</param>
    /// <returns>The existing AppServiceCertificateOrder resource.</returns>
    public static AppServiceCertificateOrder FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
