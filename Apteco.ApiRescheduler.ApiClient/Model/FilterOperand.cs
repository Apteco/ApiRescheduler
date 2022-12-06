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
    /// FilterOperand
    /// </summary>
    [DataContract]
        public partial class FilterOperand :  IEquatable<FilterOperand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterOperand" /> class.
        /// </summary>
        /// <param name="filterGroup">filterGroup.</param>
        /// <param name="filterId">filterId.</param>
        public FilterOperand(FilterGroup filterGroup = default(FilterGroup), string filterId = default(string))
        {
            this.FilterGroup = filterGroup;
            this.FilterId = filterId;
        }
        
        /// <summary>
        /// Gets or Sets FilterGroup
        /// </summary>
        [DataMember(Name="filterGroup", EmitDefaultValue=false)]
        public FilterGroup FilterGroup { get; set; }

        /// <summary>
        /// Gets or Sets FilterId
        /// </summary>
        [DataMember(Name="filterId", EmitDefaultValue=false)]
        public string FilterId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterOperand {\n");
            sb.Append("  FilterGroup: ").Append(FilterGroup).Append("\n");
            sb.Append("  FilterId: ").Append(FilterId).Append("\n");
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
            return this.Equals(input as FilterOperand);
        }

        /// <summary>
        /// Returns true if FilterOperand instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterOperand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterOperand input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilterGroup == input.FilterGroup ||
                    (this.FilterGroup != null &&
                    this.FilterGroup.Equals(input.FilterGroup))
                ) && 
                (
                    this.FilterId == input.FilterId ||
                    (this.FilterId != null &&
                    this.FilterId.Equals(input.FilterId))
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
                if (this.FilterGroup != null)
                    hashCode = hashCode * 59 + this.FilterGroup.GetHashCode();
                if (this.FilterId != null)
                    hashCode = hashCode * 59 + this.FilterId.GetHashCode();
                return hashCode;
            }
        }
    }
}
