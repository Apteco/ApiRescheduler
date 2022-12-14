/* 
 * Apteco API
 *
 * An API to allow access to Apteco Marketing Suite resources
 *
 * OpenAPI spec version: v2
 * Contact: support@apteco.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Apteco.ApiRescheduler.ApiClient.Client.SwaggerDateConverter;

namespace Apteco.ApiRescheduler.ApiClient.Model
{
    /// <summary>
    /// The details for licensing a given query
    /// </summary>
    [DataContract]
        public partial class LicensingInfo :  IEquatable<LicensingInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensingInfo" /> class.
        /// </summary>
        /// <param name="creditRemaining">The remaining money available to license records (required).</param>
        /// <param name="grandTotalCost">The total cost to license the records (required).</param>
        /// <param name="numberOfRecordsToLicense">The number of records from the given query that have not yet been licensed (required).</param>
        /// <param name="queryId">The unique id of an audience data licensing query (required).</param>
        public LicensingInfo(double? creditRemaining = default(double?), double? grandTotalCost = default(double?), int? numberOfRecordsToLicense = default(int?), string queryId = default(string))
        {
            // to ensure "creditRemaining" is required (not null)
            if (creditRemaining == null)
            {
                throw new InvalidDataException("creditRemaining is a required property for LicensingInfo and cannot be null");
            }
            else
            {
                this.CreditRemaining = creditRemaining;
            }
            // to ensure "grandTotalCost" is required (not null)
            if (grandTotalCost == null)
            {
                throw new InvalidDataException("grandTotalCost is a required property for LicensingInfo and cannot be null");
            }
            else
            {
                this.GrandTotalCost = grandTotalCost;
            }
            // to ensure "numberOfRecordsToLicense" is required (not null)
            if (numberOfRecordsToLicense == null)
            {
                throw new InvalidDataException("numberOfRecordsToLicense is a required property for LicensingInfo and cannot be null");
            }
            else
            {
                this.NumberOfRecordsToLicense = numberOfRecordsToLicense;
            }
            // to ensure "queryId" is required (not null)
            if (queryId == null)
            {
                throw new InvalidDataException("queryId is a required property for LicensingInfo and cannot be null");
            }
            else
            {
                this.QueryId = queryId;
            }
        }
        
        /// <summary>
        /// The remaining money available to license records
        /// </summary>
        /// <value>The remaining money available to license records</value>
        [DataMember(Name="creditRemaining", EmitDefaultValue=false)]
        public double? CreditRemaining { get; set; }

        /// <summary>
        /// The total cost to license the records
        /// </summary>
        /// <value>The total cost to license the records</value>
        [DataMember(Name="grandTotalCost", EmitDefaultValue=false)]
        public double? GrandTotalCost { get; set; }

        /// <summary>
        /// The number of records from the given query that have not yet been licensed
        /// </summary>
        /// <value>The number of records from the given query that have not yet been licensed</value>
        [DataMember(Name="numberOfRecordsToLicense", EmitDefaultValue=false)]
        public int? NumberOfRecordsToLicense { get; set; }

        /// <summary>
        /// The unique id of an audience data licensing query
        /// </summary>
        /// <value>The unique id of an audience data licensing query</value>
        [DataMember(Name="queryId", EmitDefaultValue=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicensingInfo {\n");
            sb.Append("  CreditRemaining: ").Append(CreditRemaining).Append("\n");
            sb.Append("  GrandTotalCost: ").Append(GrandTotalCost).Append("\n");
            sb.Append("  NumberOfRecordsToLicense: ").Append(NumberOfRecordsToLicense).Append("\n");
            sb.Append("  QueryId: ").Append(QueryId).Append("\n");
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
            return this.Equals(input as LicensingInfo);
        }

        /// <summary>
        /// Returns true if LicensingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensingInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreditRemaining == input.CreditRemaining ||
                    (this.CreditRemaining != null &&
                    this.CreditRemaining.Equals(input.CreditRemaining))
                ) && 
                (
                    this.GrandTotalCost == input.GrandTotalCost ||
                    (this.GrandTotalCost != null &&
                    this.GrandTotalCost.Equals(input.GrandTotalCost))
                ) && 
                (
                    this.NumberOfRecordsToLicense == input.NumberOfRecordsToLicense ||
                    (this.NumberOfRecordsToLicense != null &&
                    this.NumberOfRecordsToLicense.Equals(input.NumberOfRecordsToLicense))
                ) && 
                (
                    this.QueryId == input.QueryId ||
                    (this.QueryId != null &&
                    this.QueryId.Equals(input.QueryId))
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
                if (this.CreditRemaining != null)
                    hashCode = hashCode * 59 + this.CreditRemaining.GetHashCode();
                if (this.GrandTotalCost != null)
                    hashCode = hashCode * 59 + this.GrandTotalCost.GetHashCode();
                if (this.NumberOfRecordsToLicense != null)
                    hashCode = hashCode * 59 + this.NumberOfRecordsToLicense.GetHashCode();
                if (this.QueryId != null)
                    hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                return hashCode;
            }
        }
    }
}
