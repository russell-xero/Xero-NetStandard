/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model
{
    /// <summary>
    /// Organisation
    /// </summary>
    [DataContract]
    public partial class Organisation :  IEquatable<Organisation>, IValidatableObject
    {
        /// <summary>
        /// See Version Types
        /// </summary>
        /// <value>See Version Types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VersionEnum
        {
            /// <summary>
            /// Enum AU for value: AU
            /// </summary>
            [EnumMember(Value = "AU")]
            AU = 1,

            /// <summary>
            /// Enum NZ for value: NZ
            /// </summary>
            [EnumMember(Value = "NZ")]
            NZ = 2,

            /// <summary>
            /// Enum GLOBAL for value: GLOBAL
            /// </summary>
            [EnumMember(Value = "GLOBAL")]
            GLOBAL = 3,

            /// <summary>
            /// Enum UK for value: UK
            /// </summary>
            [EnumMember(Value = "UK")]
            UK = 4,

            /// <summary>
            /// Enum US for value: US
            /// </summary>
            [EnumMember(Value = "US")]
            US = 5,

            /// <summary>
            /// Enum AUONRAMP for value: AUONRAMP
            /// </summary>
            [EnumMember(Value = "AUONRAMP")]
            AUONRAMP = 6,

            /// <summary>
            /// Enum NZONRAMP for value: NZONRAMP
            /// </summary>
            [EnumMember(Value = "NZONRAMP")]
            NZONRAMP = 7,

            /// <summary>
            /// Enum GLOBALONRAMP for value: GLOBALONRAMP
            /// </summary>
            [EnumMember(Value = "GLOBALONRAMP")]
            GLOBALONRAMP = 8,

            /// <summary>
            /// Enum UKONRAMP for value: UKONRAMP
            /// </summary>
            [EnumMember(Value = "UKONRAMP")]
            UKONRAMP = 9,

            /// <summary>
            /// Enum USONRAMP for value: USONRAMP
            /// </summary>
            [EnumMember(Value = "USONRAMP")]
            USONRAMP = 10

        }

        /// <summary>
        /// See Version Types
        /// </summary>
        /// <value>See Version Types</value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public VersionEnum Version { get; set; }
        /// <summary>
        /// Organisation Type
        /// </summary>
        /// <value>Organisation Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrganisationTypeEnum
        {
            /// <summary>
            /// Enum COMPANY for value: COMPANY
            /// </summary>
            [EnumMember(Value = "COMPANY")]
            COMPANY = 1,

            /// <summary>
            /// Enum CHARITY for value: CHARITY
            /// </summary>
            [EnumMember(Value = "CHARITY")]
            CHARITY = 2,

            /// <summary>
            /// Enum CLUBORSOCIETY for value: CLUB_OR_SOCIETY
            /// </summary>
            [EnumMember(Value = "CLUB_OR_SOCIETY")]
            CLUBORSOCIETY = 3,

            /// <summary>
            /// Enum LOOKTHROUGHCOMPANY for value: LOOK_THROUGH_COMPANY
            /// </summary>
            [EnumMember(Value = "LOOK_THROUGH_COMPANY")]
            LOOKTHROUGHCOMPANY = 4,

            /// <summary>
            /// Enum NOTFORPROFIT for value: NOT_FOR_PROFIT
            /// </summary>
            [EnumMember(Value = "NOT_FOR_PROFIT")]
            NOTFORPROFIT = 5,

            /// <summary>
            /// Enum PARTNERSHIP for value: PARTNERSHIP
            /// </summary>
            [EnumMember(Value = "PARTNERSHIP")]
            PARTNERSHIP = 6,

            /// <summary>
            /// Enum SCORPORATION for value: S_CORPORATION
            /// </summary>
            [EnumMember(Value = "S_CORPORATION")]
            SCORPORATION = 7,

            /// <summary>
            /// Enum SELFMANAGEDSUPERANNUATIONFUND for value: SELF_MANAGED_SUPERANNUATION_FUND
            /// </summary>
            [EnumMember(Value = "SELF_MANAGED_SUPERANNUATION_FUND")]
            SELFMANAGEDSUPERANNUATIONFUND = 8,

            /// <summary>
            /// Enum SOLETRADER for value: SOLE_TRADER
            /// </summary>
            [EnumMember(Value = "SOLE_TRADER")]
            SOLETRADER = 9,

            /// <summary>
            /// Enum SUPERANNUATIONFUND for value: SUPERANNUATION_FUND
            /// </summary>
            [EnumMember(Value = "SUPERANNUATION_FUND")]
            SUPERANNUATIONFUND = 10,

            /// <summary>
            /// Enum TRUST for value: TRUST
            /// </summary>
            [EnumMember(Value = "TRUST")]
            TRUST = 11

        }

        /// <summary>
        /// Organisation Type
        /// </summary>
        /// <value>Organisation Type</value>
        [DataMember(Name="OrganisationType", EmitDefaultValue=false)]
        public OrganisationTypeEnum OrganisationType { get; set; }
        /// <summary>
        /// Gets or Sets BaseCurrency
        /// </summary>
        [DataMember(Name="BaseCurrency", EmitDefaultValue=false)]
        public CurrencyCode BaseCurrency { get; set; }
        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public CountryCode CountryCode { get; set; }
        /// <summary>
        /// The accounting basis used for tax returns. See Sales Tax Basis
        /// </summary>
        /// <value>The accounting basis used for tax returns. See Sales Tax Basis</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SalesTaxBasisEnum
        {
            /// <summary>
            /// Enum PAYMENTS for value: PAYMENTS
            /// </summary>
            [EnumMember(Value = "PAYMENTS")]
            PAYMENTS = 1,

            /// <summary>
            /// Enum INVOICE for value: INVOICE
            /// </summary>
            [EnumMember(Value = "INVOICE")]
            INVOICE = 2,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 3,

            /// <summary>
            /// Enum CASH for value: CASH
            /// </summary>
            [EnumMember(Value = "CASH")]
            CASH = 4,

            /// <summary>
            /// Enum ACCRUAL for value: ACCRUAL
            /// </summary>
            [EnumMember(Value = "ACCRUAL")]
            ACCRUAL = 5,

            /// <summary>
            /// Enum FLATRATECASH for value: FLATRATECASH
            /// </summary>
            [EnumMember(Value = "FLATRATECASH")]
            FLATRATECASH = 6,

            /// <summary>
            /// Enum FLATRATEACCRUAL for value: FLATRATEACCRUAL
            /// </summary>
            [EnumMember(Value = "FLATRATEACCRUAL")]
            FLATRATEACCRUAL = 7,

            /// <summary>
            /// Enum ACCRUALS for value: ACCRUALS
            /// </summary>
            [EnumMember(Value = "ACCRUALS")]
            ACCRUALS = 8

        }

        /// <summary>
        /// The accounting basis used for tax returns. See Sales Tax Basis
        /// </summary>
        /// <value>The accounting basis used for tax returns. See Sales Tax Basis</value>
        [DataMember(Name="SalesTaxBasis", EmitDefaultValue=false)]
        public SalesTaxBasisEnum SalesTaxBasis { get; set; }
        /// <summary>
        /// The frequency with which tax returns are processed. See Sales Tax Period
        /// </summary>
        /// <value>The frequency with which tax returns are processed. See Sales Tax Period</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SalesTaxPeriodEnum
        {
            /// <summary>
            /// Enum MONTHLY for value: MONTHLY
            /// </summary>
            [EnumMember(Value = "MONTHLY")]
            MONTHLY = 1,

            /// <summary>
            /// Enum QUARTERLY1 for value: QUARTERLY1
            /// </summary>
            [EnumMember(Value = "QUARTERLY1")]
            QUARTERLY1 = 2,

            /// <summary>
            /// Enum QUARTERLY2 for value: QUARTERLY2
            /// </summary>
            [EnumMember(Value = "QUARTERLY2")]
            QUARTERLY2 = 3,

            /// <summary>
            /// Enum QUARTERLY3 for value: QUARTERLY3
            /// </summary>
            [EnumMember(Value = "QUARTERLY3")]
            QUARTERLY3 = 4,

            /// <summary>
            /// Enum ANNUALLY for value: ANNUALLY
            /// </summary>
            [EnumMember(Value = "ANNUALLY")]
            ANNUALLY = 5,

            /// <summary>
            /// Enum ONEMONTHS for value: ONEMONTHS
            /// </summary>
            [EnumMember(Value = "ONEMONTHS")]
            ONEMONTHS = 6,

            /// <summary>
            /// Enum TWOMONTHS for value: TWOMONTHS
            /// </summary>
            [EnumMember(Value = "TWOMONTHS")]
            TWOMONTHS = 7,

            /// <summary>
            /// Enum SIXMONTHS for value: SIXMONTHS
            /// </summary>
            [EnumMember(Value = "SIXMONTHS")]
            SIXMONTHS = 8,

            /// <summary>
            /// Enum _1MONTHLY for value: 1MONTHLY
            /// </summary>
            [EnumMember(Value = "1MONTHLY")]
            _1MONTHLY = 9,

            /// <summary>
            /// Enum _2MONTHLY for value: 2MONTHLY
            /// </summary>
            [EnumMember(Value = "2MONTHLY")]
            _2MONTHLY = 10,

            /// <summary>
            /// Enum _3MONTHLY for value: 3MONTHLY
            /// </summary>
            [EnumMember(Value = "3MONTHLY")]
            _3MONTHLY = 11,

            /// <summary>
            /// Enum _6MONTHLY for value: 6MONTHLY
            /// </summary>
            [EnumMember(Value = "6MONTHLY")]
            _6MONTHLY = 12,

            /// <summary>
            /// Enum QUARTERLY for value: QUARTERLY
            /// </summary>
            [EnumMember(Value = "QUARTERLY")]
            QUARTERLY = 13,

            /// <summary>
            /// Enum YEARLY for value: YEARLY
            /// </summary>
            [EnumMember(Value = "YEARLY")]
            YEARLY = 14

        }

        /// <summary>
        /// The frequency with which tax returns are processed. See Sales Tax Period
        /// </summary>
        /// <value>The frequency with which tax returns are processed. See Sales Tax Period</value>
        [DataMember(Name="SalesTaxPeriod", EmitDefaultValue=false)]
        public SalesTaxPeriodEnum SalesTaxPeriod { get; set; }
        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="Timezone", EmitDefaultValue=false)]
        public TimeZone Timezone { get; set; }
        /// <summary>
        /// Organisation Type
        /// </summary>
        /// <value>Organisation Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrganisationEntityTypeEnum
        {
            /// <summary>
            /// Enum COMPANY for value: COMPANY
            /// </summary>
            [EnumMember(Value = "COMPANY")]
            COMPANY = 1,

            /// <summary>
            /// Enum CHARITY for value: CHARITY
            /// </summary>
            [EnumMember(Value = "CHARITY")]
            CHARITY = 2,

            /// <summary>
            /// Enum CLUBORSOCIETY for value: CLUB_OR_SOCIETY
            /// </summary>
            [EnumMember(Value = "CLUB_OR_SOCIETY")]
            CLUBORSOCIETY = 3,

            /// <summary>
            /// Enum LOOKTHROUGHCOMPANY for value: LOOK_THROUGH_COMPANY
            /// </summary>
            [EnumMember(Value = "LOOK_THROUGH_COMPANY")]
            LOOKTHROUGHCOMPANY = 4,

            /// <summary>
            /// Enum NOTFORPROFIT for value: NOT_FOR_PROFIT
            /// </summary>
            [EnumMember(Value = "NOT_FOR_PROFIT")]
            NOTFORPROFIT = 5,

            /// <summary>
            /// Enum PARTNERSHIP for value: PARTNERSHIP
            /// </summary>
            [EnumMember(Value = "PARTNERSHIP")]
            PARTNERSHIP = 6,

            /// <summary>
            /// Enum SCORPORATION for value: S_CORPORATION
            /// </summary>
            [EnumMember(Value = "S_CORPORATION")]
            SCORPORATION = 7,

            /// <summary>
            /// Enum SELFMANAGEDSUPERANNUATIONFUND for value: SELF_MANAGED_SUPERANNUATION_FUND
            /// </summary>
            [EnumMember(Value = "SELF_MANAGED_SUPERANNUATION_FUND")]
            SELFMANAGEDSUPERANNUATIONFUND = 8,

            /// <summary>
            /// Enum SOLETRADER for value: SOLE_TRADER
            /// </summary>
            [EnumMember(Value = "SOLE_TRADER")]
            SOLETRADER = 9,

            /// <summary>
            /// Enum SUPERANNUATIONFUND for value: SUPERANNUATION_FUND
            /// </summary>
            [EnumMember(Value = "SUPERANNUATION_FUND")]
            SUPERANNUATIONFUND = 10,

            /// <summary>
            /// Enum TRUST for value: TRUST
            /// </summary>
            [EnumMember(Value = "TRUST")]
            TRUST = 11

        }

        /// <summary>
        /// Organisation Type
        /// </summary>
        /// <value>Organisation Type</value>
        [DataMember(Name="OrganisationEntityType", EmitDefaultValue=false)]
        public OrganisationEntityTypeEnum OrganisationEntityType { get; set; }
        /// <summary>
        /// Organisation Classes describe which plan the Xero organisation is on (e.g. DEMO, TRIAL, PREMIUM)
        /// </summary>
        /// <value>Organisation Classes describe which plan the Xero organisation is on (e.g. DEMO, TRIAL, PREMIUM)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClassEnum
        {
            /// <summary>
            /// Enum DEMO for value: DEMO
            /// </summary>
            [EnumMember(Value = "DEMO")]
            DEMO = 1,

            /// <summary>
            /// Enum TRIAL for value: TRIAL
            /// </summary>
            [EnumMember(Value = "TRIAL")]
            TRIAL = 2,

            /// <summary>
            /// Enum STARTER for value: STARTER
            /// </summary>
            [EnumMember(Value = "STARTER")]
            STARTER = 3,

            /// <summary>
            /// Enum STANDARD for value: STANDARD
            /// </summary>
            [EnumMember(Value = "STANDARD")]
            STANDARD = 4,

            /// <summary>
            /// Enum PREMIUM for value: PREMIUM
            /// </summary>
            [EnumMember(Value = "PREMIUM")]
            PREMIUM = 5,

            /// <summary>
            /// Enum PREMIUM20 for value: PREMIUM_20
            /// </summary>
            [EnumMember(Value = "PREMIUM_20")]
            PREMIUM20 = 6,

            /// <summary>
            /// Enum PREMIUM50 for value: PREMIUM_50
            /// </summary>
            [EnumMember(Value = "PREMIUM_50")]
            PREMIUM50 = 7,

            /// <summary>
            /// Enum PREMIUM100 for value: PREMIUM_100
            /// </summary>
            [EnumMember(Value = "PREMIUM_100")]
            PREMIUM100 = 8,

            /// <summary>
            /// Enum LEDGER for value: LEDGER
            /// </summary>
            [EnumMember(Value = "LEDGER")]
            LEDGER = 9,

            /// <summary>
            /// Enum GSTCASHBOOK for value: GST_CASHBOOK
            /// </summary>
            [EnumMember(Value = "GST_CASHBOOK")]
            GSTCASHBOOK = 10,

            /// <summary>
            /// Enum NONGSTCASHBOOK for value: NON_GST_CASHBOOK
            /// </summary>
            [EnumMember(Value = "NON_GST_CASHBOOK")]
            NONGSTCASHBOOK = 11

        }

        /// <summary>
        /// Organisation Classes describe which plan the Xero organisation is on (e.g. DEMO, TRIAL, PREMIUM)
        /// </summary>
        /// <value>Organisation Classes describe which plan the Xero organisation is on (e.g. DEMO, TRIAL, PREMIUM)</value>
        [DataMember(Name="Class", EmitDefaultValue=false)]
        public ClassEnum Class { get; set; }
        /// <summary>
        /// BUSINESS or PARTNER. Partner edition organisations are sold exclusively through accounting partners and have restricted functionality (e.g. no access to invoicing)
        /// </summary>
        /// <value>BUSINESS or PARTNER. Partner edition organisations are sold exclusively through accounting partners and have restricted functionality (e.g. no access to invoicing)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EditionEnum
        {
            /// <summary>
            /// Enum BUSINESS for value: BUSINESS
            /// </summary>
            [EnumMember(Value = "BUSINESS")]
            BUSINESS = 1,

            /// <summary>
            /// Enum PARTNER for value: PARTNER
            /// </summary>
            [EnumMember(Value = "PARTNER")]
            PARTNER = 2

        }

        /// <summary>
        /// BUSINESS or PARTNER. Partner edition organisations are sold exclusively through accounting partners and have restricted functionality (e.g. no access to invoicing)
        /// </summary>
        /// <value>BUSINESS or PARTNER. Partner edition organisations are sold exclusively through accounting partners and have restricted functionality (e.g. no access to invoicing)</value>
        [DataMember(Name="Edition", EmitDefaultValue=false)]
        public EditionEnum Edition { get; set; }
        
        /// <summary>
        /// Unique Xero identifier
        /// </summary>
        /// <value>Unique Xero identifier</value>
        [DataMember(Name="OrganisationID", EmitDefaultValue=false)]
        public Guid OrganisationID { get; set; }

        /// <summary>
        /// Display a unique key used for Xero-to-Xero transactions
        /// </summary>
        /// <value>Display a unique key used for Xero-to-Xero transactions</value>
        [DataMember(Name="APIKey", EmitDefaultValue=false)]
        public string APIKey { get; set; }

        /// <summary>
        /// Display name of organisation shown in Xero
        /// </summary>
        /// <value>Display name of organisation shown in Xero</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Organisation name shown on Reports
        /// </summary>
        /// <value>Organisation name shown on Reports</value>
        [DataMember(Name="LegalName", EmitDefaultValue=false)]
        public string LegalName { get; set; }

        /// <summary>
        /// Boolean to describe if organisation is registered with a local tax authority i.e. true, false
        /// </summary>
        /// <value>Boolean to describe if organisation is registered with a local tax authority i.e. true, false</value>
        [DataMember(Name="PaysTax", EmitDefaultValue=false)]
        public bool? PaysTax { get; set; }

        /// <summary>
        /// Boolean to describe if organisation is a demo company.
        /// </summary>
        /// <value>Boolean to describe if organisation is a demo company.</value>
        [DataMember(Name="IsDemoCompany", EmitDefaultValue=false)]
        public bool? IsDemoCompany { get; set; }

        /// <summary>
        /// Will be set to ACTIVE if you can connect to organisation via the Xero API
        /// </summary>
        /// <value>Will be set to ACTIVE if you can connect to organisation via the Xero API</value>
        [DataMember(Name="OrganisationStatus", EmitDefaultValue=false)]
        public string OrganisationStatus { get; set; }

        /// <summary>
        /// Shows for New Zealand, Australian and UK organisations
        /// </summary>
        /// <value>Shows for New Zealand, Australian and UK organisations</value>
        [DataMember(Name="RegistrationNumber", EmitDefaultValue=false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Shown if set. Displays in the Xero UI as Tax File Number (AU), GST Number (NZ), VAT Number (UK) and Tax ID Number (US &amp; Global).
        /// </summary>
        /// <value>Shown if set. Displays in the Xero UI as Tax File Number (AU), GST Number (NZ), VAT Number (UK) and Tax ID Number (US &amp; Global).</value>
        [DataMember(Name="TaxNumber", EmitDefaultValue=false)]
        public string TaxNumber { get; set; }

        /// <summary>
        /// Calendar day e.g. 0-31
        /// </summary>
        /// <value>Calendar day e.g. 0-31</value>
        [DataMember(Name="FinancialYearEndDay", EmitDefaultValue=false)]
        public int? FinancialYearEndDay { get; set; }

        /// <summary>
        /// Calendar Month e.g. 1-12
        /// </summary>
        /// <value>Calendar Month e.g. 1-12</value>
        [DataMember(Name="FinancialYearEndMonth", EmitDefaultValue=false)]
        public int? FinancialYearEndMonth { get; set; }

        /// <summary>
        /// The default for LineAmountTypes on sales transactions
        /// </summary>
        /// <value>The default for LineAmountTypes on sales transactions</value>
        [DataMember(Name="DefaultSalesTax", EmitDefaultValue=false)]
        public string DefaultSalesTax { get; set; }

        /// <summary>
        /// The default for LineAmountTypes on purchase transactions
        /// </summary>
        /// <value>The default for LineAmountTypes on purchase transactions</value>
        [DataMember(Name="DefaultPurchasesTax", EmitDefaultValue=false)]
        public string DefaultPurchasesTax { get; set; }

        /// <summary>
        /// Shown if set. See lock dates
        /// </summary>
        /// <value>Shown if set. See lock dates</value>
        [DataMember(Name="PeriodLockDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PeriodLockDate { get; set; }

        /// <summary>
        /// Shown if set. See lock dates
        /// </summary>
        /// <value>Shown if set. See lock dates</value>
        [DataMember(Name="EndOfYearLockDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndOfYearLockDate { get; set; }

        /// <summary>
        /// Timestamp when the organisation was created in Xero
        /// </summary>
        /// <value>Timestamp when the organisation was created in Xero</value>
        [DataMember(Name="CreatedDateUTC", EmitDefaultValue=false)]
        public DateTime? CreatedDateUTC { get; set; }

        /// <summary>
        /// A unique identifier for the organisation. Potential uses.
        /// </summary>
        /// <value>A unique identifier for the organisation. Potential uses.</value>
        [DataMember(Name="ShortCode", EmitDefaultValue=false)]
        public string ShortCode { get; set; }

        /// <summary>
        /// Description of business type as defined in Organisation settings
        /// </summary>
        /// <value>Description of business type as defined in Organisation settings</value>
        [DataMember(Name="LineOfBusiness", EmitDefaultValue=false)]
        public string LineOfBusiness { get; set; }

        /// <summary>
        /// Address details for organisation – see Addresses
        /// </summary>
        /// <value>Address details for organisation – see Addresses</value>
        [DataMember(Name="Addresses", EmitDefaultValue=false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Phones details for organisation – see Phones
        /// </summary>
        /// <value>Phones details for organisation – see Phones</value>
        [DataMember(Name="Phones", EmitDefaultValue=false)]
        public List<Phone> Phones { get; set; }

        /// <summary>
        /// Organisation profile links for popular services such as Facebook,Twitter, GooglePlus and LinkedIn. You can also add link to your website here. Shown if Organisation settings  is updated in Xero. See ExternalLinks below
        /// </summary>
        /// <value>Organisation profile links for popular services such as Facebook,Twitter, GooglePlus and LinkedIn. You can also add link to your website here. Shown if Organisation settings  is updated in Xero. See ExternalLinks below</value>
        [DataMember(Name="ExternalLinks", EmitDefaultValue=false)]
        public List<ExternalLink> ExternalLinks { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTerms
        /// </summary>
        [DataMember(Name="PaymentTerms", EmitDefaultValue=false)]
        public PaymentTerm PaymentTerms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Organisation {\n");
            sb.Append("  OrganisationID: ").Append(OrganisationID).Append("\n");
            sb.Append("  APIKey: ").Append(APIKey).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LegalName: ").Append(LegalName).Append("\n");
            sb.Append("  PaysTax: ").Append(PaysTax).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  OrganisationType: ").Append(OrganisationType).Append("\n");
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  IsDemoCompany: ").Append(IsDemoCompany).Append("\n");
            sb.Append("  OrganisationStatus: ").Append(OrganisationStatus).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  FinancialYearEndDay: ").Append(FinancialYearEndDay).Append("\n");
            sb.Append("  FinancialYearEndMonth: ").Append(FinancialYearEndMonth).Append("\n");
            sb.Append("  SalesTaxBasis: ").Append(SalesTaxBasis).Append("\n");
            sb.Append("  SalesTaxPeriod: ").Append(SalesTaxPeriod).Append("\n");
            sb.Append("  DefaultSalesTax: ").Append(DefaultSalesTax).Append("\n");
            sb.Append("  DefaultPurchasesTax: ").Append(DefaultPurchasesTax).Append("\n");
            sb.Append("  PeriodLockDate: ").Append(PeriodLockDate).Append("\n");
            sb.Append("  EndOfYearLockDate: ").Append(EndOfYearLockDate).Append("\n");
            sb.Append("  CreatedDateUTC: ").Append(CreatedDateUTC).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  OrganisationEntityType: ").Append(OrganisationEntityType).Append("\n");
            sb.Append("  ShortCode: ").Append(ShortCode).Append("\n");
            sb.Append("  Class: ").Append(Class).Append("\n");
            sb.Append("  Edition: ").Append(Edition).Append("\n");
            sb.Append("  LineOfBusiness: ").Append(LineOfBusiness).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Phones: ").Append(Phones).Append("\n");
            sb.Append("  ExternalLinks: ").Append(ExternalLinks).Append("\n");
            sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Organisation);
        }

        /// <summary>
        /// Returns true if Organisation instances are equal
        /// </summary>
        /// <param name="input">Instance of Organisation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Organisation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganisationID == input.OrganisationID ||
                    (this.OrganisationID != null &&
                    this.OrganisationID.Equals(input.OrganisationID))
                ) && 
                (
                    this.APIKey == input.APIKey ||
                    (this.APIKey != null &&
                    this.APIKey.Equals(input.APIKey))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LegalName == input.LegalName ||
                    (this.LegalName != null &&
                    this.LegalName.Equals(input.LegalName))
                ) && 
                (
                    this.PaysTax == input.PaysTax ||
                    this.PaysTax.Equals(input.PaysTax)
                ) && 
                (
                    this.Version == input.Version ||
                    this.Version.Equals(input.Version)
                ) && 
                (
                    this.OrganisationType == input.OrganisationType ||
                    this.OrganisationType.Equals(input.OrganisationType)
                ) && 
                (
                    this.BaseCurrency == input.BaseCurrency ||
                    this.BaseCurrency.Equals(input.BaseCurrency)
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    this.CountryCode.Equals(input.CountryCode)
                ) && 
                (
                    this.IsDemoCompany == input.IsDemoCompany ||
                    this.IsDemoCompany.Equals(input.IsDemoCompany)
                ) && 
                (
                    this.OrganisationStatus == input.OrganisationStatus ||
                    (this.OrganisationStatus != null &&
                    this.OrganisationStatus.Equals(input.OrganisationStatus))
                ) && 
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) && 
                (
                    this.TaxNumber == input.TaxNumber ||
                    (this.TaxNumber != null &&
                    this.TaxNumber.Equals(input.TaxNumber))
                ) && 
                (
                    this.FinancialYearEndDay == input.FinancialYearEndDay ||
                    this.FinancialYearEndDay.Equals(input.FinancialYearEndDay)
                ) && 
                (
                    this.FinancialYearEndMonth == input.FinancialYearEndMonth ||
                    this.FinancialYearEndMonth.Equals(input.FinancialYearEndMonth)
                ) && 
                (
                    this.SalesTaxBasis == input.SalesTaxBasis ||
                    this.SalesTaxBasis.Equals(input.SalesTaxBasis)
                ) && 
                (
                    this.SalesTaxPeriod == input.SalesTaxPeriod ||
                    this.SalesTaxPeriod.Equals(input.SalesTaxPeriod)
                ) && 
                (
                    this.DefaultSalesTax == input.DefaultSalesTax ||
                    (this.DefaultSalesTax != null &&
                    this.DefaultSalesTax.Equals(input.DefaultSalesTax))
                ) && 
                (
                    this.DefaultPurchasesTax == input.DefaultPurchasesTax ||
                    (this.DefaultPurchasesTax != null &&
                    this.DefaultPurchasesTax.Equals(input.DefaultPurchasesTax))
                ) && 
                (
                    this.PeriodLockDate == input.PeriodLockDate ||
                    (this.PeriodLockDate != null &&
                    this.PeriodLockDate.Equals(input.PeriodLockDate))
                ) && 
                (
                    this.EndOfYearLockDate == input.EndOfYearLockDate ||
                    (this.EndOfYearLockDate != null &&
                    this.EndOfYearLockDate.Equals(input.EndOfYearLockDate))
                ) && 
                (
                    this.CreatedDateUTC == input.CreatedDateUTC ||
                    (this.CreatedDateUTC != null &&
                    this.CreatedDateUTC.Equals(input.CreatedDateUTC))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    this.Timezone.Equals(input.Timezone)
                ) && 
                (
                    this.OrganisationEntityType == input.OrganisationEntityType ||
                    this.OrganisationEntityType.Equals(input.OrganisationEntityType)
                ) && 
                (
                    this.ShortCode == input.ShortCode ||
                    (this.ShortCode != null &&
                    this.ShortCode.Equals(input.ShortCode))
                ) && 
                (
                    this.Class == input.Class ||
                    this.Class.Equals(input.Class)
                ) && 
                (
                    this.Edition == input.Edition ||
                    this.Edition.Equals(input.Edition)
                ) && 
                (
                    this.LineOfBusiness == input.LineOfBusiness ||
                    (this.LineOfBusiness != null &&
                    this.LineOfBusiness.Equals(input.LineOfBusiness))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Phones == input.Phones ||
                    this.Phones != null &&
                    input.Phones != null &&
                    this.Phones.SequenceEqual(input.Phones)
                ) && 
                (
                    this.ExternalLinks == input.ExternalLinks ||
                    this.ExternalLinks != null &&
                    input.ExternalLinks != null &&
                    this.ExternalLinks.SequenceEqual(input.ExternalLinks)
                ) && 
                (
                    this.PaymentTerms == input.PaymentTerms ||
                    (this.PaymentTerms != null &&
                    this.PaymentTerms.Equals(input.PaymentTerms))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.OrganisationID != null)
                    hashCode = hashCode * 59 + this.OrganisationID.GetHashCode();
                if (this.APIKey != null)
                    hashCode = hashCode * 59 + this.APIKey.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LegalName != null)
                    hashCode = hashCode * 59 + this.LegalName.GetHashCode();
                hashCode = hashCode * 59 + this.PaysTax.GetHashCode();
                hashCode = hashCode * 59 + this.Version.GetHashCode();
                hashCode = hashCode * 59 + this.OrganisationType.GetHashCode();
                hashCode = hashCode * 59 + this.BaseCurrency.GetHashCode();
                hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                hashCode = hashCode * 59 + this.IsDemoCompany.GetHashCode();
                if (this.OrganisationStatus != null)
                    hashCode = hashCode * 59 + this.OrganisationStatus.GetHashCode();
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.TaxNumber != null)
                    hashCode = hashCode * 59 + this.TaxNumber.GetHashCode();
                hashCode = hashCode * 59 + this.FinancialYearEndDay.GetHashCode();
                hashCode = hashCode * 59 + this.FinancialYearEndMonth.GetHashCode();
                hashCode = hashCode * 59 + this.SalesTaxBasis.GetHashCode();
                hashCode = hashCode * 59 + this.SalesTaxPeriod.GetHashCode();
                if (this.DefaultSalesTax != null)
                    hashCode = hashCode * 59 + this.DefaultSalesTax.GetHashCode();
                if (this.DefaultPurchasesTax != null)
                    hashCode = hashCode * 59 + this.DefaultPurchasesTax.GetHashCode();
                if (this.PeriodLockDate != null)
                    hashCode = hashCode * 59 + this.PeriodLockDate.GetHashCode();
                if (this.EndOfYearLockDate != null)
                    hashCode = hashCode * 59 + this.EndOfYearLockDate.GetHashCode();
                if (this.CreatedDateUTC != null)
                    hashCode = hashCode * 59 + this.CreatedDateUTC.GetHashCode();
                hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                hashCode = hashCode * 59 + this.OrganisationEntityType.GetHashCode();
                if (this.ShortCode != null)
                    hashCode = hashCode * 59 + this.ShortCode.GetHashCode();
                hashCode = hashCode * 59 + this.Class.GetHashCode();
                hashCode = hashCode * 59 + this.Edition.GetHashCode();
                if (this.LineOfBusiness != null)
                    hashCode = hashCode * 59 + this.LineOfBusiness.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.Phones != null)
                    hashCode = hashCode * 59 + this.Phones.GetHashCode();
                if (this.ExternalLinks != null)
                    hashCode = hashCode * 59 + this.ExternalLinks.GetHashCode();
                if (this.PaymentTerms != null)
                    hashCode = hashCode * 59 + this.PaymentTerms.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
