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
    /// The details required to get data licensing information for an audience
    /// </summary>
    [DataContract]
        public partial class DataLicensingDetail :  IEquatable<DataLicensingDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataLicensingDetail" /> class.
        /// </summary>
        /// <param name="licensingSet">The name of the licensing set to get the information for.</param>
        public DataLicensingDetail(string licensingSet = default(string))
        {
            this.LicensingSet = licensingSet;
        }
        
        /// <summary>
        /// The name of the licensing set to get the information for
        /// </summary>
        /// <value>The name of the licensing set to get the information for</value>
        [DataMember(Name="licensingSet", EmitDefaultValue=false)]
        public string LicensingSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataLicensingDetail {\n");
            sb.Append("  LicensingSet: ").Append(LicensingSet).Append("\n");
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
            return this.Equals(input as DataLicensingDetail);
        }

        /// <summary>
        /// Returns true if DataLicensingDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of DataLicensingDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataLicensingDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LicensingSet == input.LicensingSet ||
                    (this.LicensingSet != null &&
                    this.LicensingSet.Equals(input.LicensingSet))
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
                if (this.LicensingSet != null)
                    hashCode = hashCode * 59 + this.LicensingSet.GetHashCode();
                return hashCode;
            }
        }
    }
}
