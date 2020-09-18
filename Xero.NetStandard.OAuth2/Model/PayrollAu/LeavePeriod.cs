/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.3.0
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// LeavePeriod
    /// </summary>
    [DataContract]
    public partial class LeavePeriod :  IEquatable<LeavePeriod>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets LeavePeriodStatus
        /// </summary>
        [DataMember(Name="LeavePeriodStatus", EmitDefaultValue=false)]
        public LeavePeriodStatus LeavePeriodStatus { get; set; }
        
        /// <summary>
        /// The Number of Units for the leave
        /// </summary>
        /// <value>The Number of Units for the leave</value>
        [DataMember(Name="NumberOfUnits", EmitDefaultValue=false)]
        public decimal? NumberOfUnits { get; set; }

        /// <summary>
        /// The Pay Period End Date (YYYY-MM-DD)
        /// </summary>
        /// <value>The Pay Period End Date (YYYY-MM-DD)</value>
        [DataMember(Name="PayPeriodEndDate", EmitDefaultValue=false)]
        public DateTime? PayPeriodEndDate { get; set; }

        /// <summary>
        /// The Pay Period Start Date (YYYY-MM-DD)
        /// </summary>
        /// <value>The Pay Period Start Date (YYYY-MM-DD)</value>
        [DataMember(Name="PayPeriodStartDate", EmitDefaultValue=false)]
        public DateTime? PayPeriodStartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeavePeriod {\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
            sb.Append("  PayPeriodEndDate: ").Append(PayPeriodEndDate).Append("\n");
            sb.Append("  PayPeriodStartDate: ").Append(PayPeriodStartDate).Append("\n");
            sb.Append("  LeavePeriodStatus: ").Append(LeavePeriodStatus).Append("\n");
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
            return this.Equals(input as LeavePeriod);
        }

        /// <summary>
        /// Returns true if LeavePeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of LeavePeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeavePeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumberOfUnits == input.NumberOfUnits ||
                    this.NumberOfUnits.Equals(input.NumberOfUnits)
                ) && 
                (
                    this.PayPeriodEndDate == input.PayPeriodEndDate ||
                    (this.PayPeriodEndDate != null &&
                    this.PayPeriodEndDate.Equals(input.PayPeriodEndDate))
                ) && 
                (
                    this.PayPeriodStartDate == input.PayPeriodStartDate ||
                    (this.PayPeriodStartDate != null &&
                    this.PayPeriodStartDate.Equals(input.PayPeriodStartDate))
                ) && 
                (
                    this.LeavePeriodStatus == input.LeavePeriodStatus ||
                    this.LeavePeriodStatus.Equals(input.LeavePeriodStatus)
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
                hashCode = hashCode * 59 + this.NumberOfUnits.GetHashCode();
                if (this.PayPeriodEndDate != null)
                    hashCode = hashCode * 59 + this.PayPeriodEndDate.GetHashCode();
                if (this.PayPeriodStartDate != null)
                    hashCode = hashCode * 59 + this.PayPeriodStartDate.GetHashCode();
                hashCode = hashCode * 59 + this.LeavePeriodStatus.GetHashCode();
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
