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
    /// AbstractAnalysisItemDefinition
    /// </summary>
    [DataContract]
        public partial class AbstractAnalysisItemDefinition :  IEquatable<AbstractAnalysisItemDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractAnalysisItemDefinition" /> class.
        /// </summary>
        /// <param name="resolveTableName">The audience workbook item resolve table name (required).</param>
        public AbstractAnalysisItemDefinition(string resolveTableName = default(string))
        {
            // to ensure "resolveTableName" is required (not null)
            if (resolveTableName == null)
            {
                throw new InvalidDataException("resolveTableName is a required property for AbstractAnalysisItemDefinition and cannot be null");
            }
            else
            {
                this.ResolveTableName = resolveTableName;
            }
        }
        
        /// <summary>
        /// The audience workbook item resolve table name
        /// </summary>
        /// <value>The audience workbook item resolve table name</value>
        [DataMember(Name="resolveTableName", EmitDefaultValue=false)]
        public string ResolveTableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractAnalysisItemDefinition {\n");
            sb.Append("  ResolveTableName: ").Append(ResolveTableName).Append("\n");
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
            return this.Equals(input as AbstractAnalysisItemDefinition);
        }

        /// <summary>
        /// Returns true if AbstractAnalysisItemDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractAnalysisItemDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractAnalysisItemDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResolveTableName == input.ResolveTableName ||
                    (this.ResolveTableName != null &&
                    this.ResolveTableName.Equals(input.ResolveTableName))
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
                if (this.ResolveTableName != null)
                    hashCode = hashCode * 59 + this.ResolveTableName.GetHashCode();
                return hashCode;
            }
        }
    }
}
