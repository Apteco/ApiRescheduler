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
    /// AnalysisItemCalculateQueryDetails
    /// </summary>
    [DataContract]
        public partial class AnalysisItemCalculateQueryDetails :  IEquatable<AnalysisItemCalculateQueryDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisItemCalculateQueryDetails" /> class.
        /// </summary>
        /// <param name="systemName">The FastStats system that the analysis item has been created against (required).</param>
        /// <param name="excludeQuery">excludeQuery.</param>
        /// <param name="includeQuery">includeQuery.</param>
        /// <param name="bodyQuery">bodyQuery.</param>
        /// <param name="selectionModifiers">selectionModifiers.</param>
        public AnalysisItemCalculateQueryDetails(string systemName = default(string), Query excludeQuery = default(Query), Query includeQuery = default(Query), Query bodyQuery = default(Query), SelectionModifiers selectionModifiers = default(SelectionModifiers))
        {
            // to ensure "systemName" is required (not null)
            if (systemName == null)
            {
                throw new InvalidDataException("systemName is a required property for AnalysisItemCalculateQueryDetails and cannot be null");
            }
            else
            {
                this.SystemName = systemName;
            }
            this.ExcludeQuery = excludeQuery;
            this.IncludeQuery = includeQuery;
            this.BodyQuery = bodyQuery;
            this.SelectionModifiers = selectionModifiers;
        }
        
        /// <summary>
        /// The FastStats system that the analysis item has been created against
        /// </summary>
        /// <value>The FastStats system that the analysis item has been created against</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// Gets or Sets ExcludeQuery
        /// </summary>
        [DataMember(Name="excludeQuery", EmitDefaultValue=false)]
        public Query ExcludeQuery { get; set; }

        /// <summary>
        /// Gets or Sets IncludeQuery
        /// </summary>
        [DataMember(Name="includeQuery", EmitDefaultValue=false)]
        public Query IncludeQuery { get; set; }

        /// <summary>
        /// Gets or Sets BodyQuery
        /// </summary>
        [DataMember(Name="bodyQuery", EmitDefaultValue=false)]
        public Query BodyQuery { get; set; }

        /// <summary>
        /// Gets or Sets SelectionModifiers
        /// </summary>
        [DataMember(Name="selectionModifiers", EmitDefaultValue=false)]
        public SelectionModifiers SelectionModifiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalysisItemCalculateQueryDetails {\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  ExcludeQuery: ").Append(ExcludeQuery).Append("\n");
            sb.Append("  IncludeQuery: ").Append(IncludeQuery).Append("\n");
            sb.Append("  BodyQuery: ").Append(BodyQuery).Append("\n");
            sb.Append("  SelectionModifiers: ").Append(SelectionModifiers).Append("\n");
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
            return this.Equals(input as AnalysisItemCalculateQueryDetails);
        }

        /// <summary>
        /// Returns true if AnalysisItemCalculateQueryDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalysisItemCalculateQueryDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalysisItemCalculateQueryDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.ExcludeQuery == input.ExcludeQuery ||
                    (this.ExcludeQuery != null &&
                    this.ExcludeQuery.Equals(input.ExcludeQuery))
                ) && 
                (
                    this.IncludeQuery == input.IncludeQuery ||
                    (this.IncludeQuery != null &&
                    this.IncludeQuery.Equals(input.IncludeQuery))
                ) && 
                (
                    this.BodyQuery == input.BodyQuery ||
                    (this.BodyQuery != null &&
                    this.BodyQuery.Equals(input.BodyQuery))
                ) && 
                (
                    this.SelectionModifiers == input.SelectionModifiers ||
                    (this.SelectionModifiers != null &&
                    this.SelectionModifiers.Equals(input.SelectionModifiers))
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
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.ExcludeQuery != null)
                    hashCode = hashCode * 59 + this.ExcludeQuery.GetHashCode();
                if (this.IncludeQuery != null)
                    hashCode = hashCode * 59 + this.IncludeQuery.GetHashCode();
                if (this.BodyQuery != null)
                    hashCode = hashCode * 59 + this.BodyQuery.GetHashCode();
                if (this.SelectionModifiers != null)
                    hashCode = hashCode * 59 + this.SelectionModifiers.GetHashCode();
                return hashCode;
            }
        }
    }
}
