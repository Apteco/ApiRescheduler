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
    /// Details for the definition of an export template for the audience export screen
    /// </summary>
    [DataContract]
        public partial class ExportTemplateDefinition :  IEquatable<ExportTemplateDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTemplateDefinition" /> class.
        /// </summary>
        /// <param name="exportTemplateColumns">The export columns used for this export template definition (required).</param>
        public ExportTemplateDefinition(List<ExportTemplateColumn> exportTemplateColumns = default(List<ExportTemplateColumn>))
        {
            // to ensure "exportTemplateColumns" is required (not null)
            if (exportTemplateColumns == null)
            {
                throw new InvalidDataException("exportTemplateColumns is a required property for ExportTemplateDefinition and cannot be null");
            }
            else
            {
                this.ExportTemplateColumns = exportTemplateColumns;
            }
        }
        
        /// <summary>
        /// The export columns used for this export template definition
        /// </summary>
        /// <value>The export columns used for this export template definition</value>
        [DataMember(Name="exportTemplateColumns", EmitDefaultValue=false)]
        public List<ExportTemplateColumn> ExportTemplateColumns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportTemplateDefinition {\n");
            sb.Append("  ExportTemplateColumns: ").Append(ExportTemplateColumns).Append("\n");
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
            return this.Equals(input as ExportTemplateDefinition);
        }

        /// <summary>
        /// Returns true if ExportTemplateDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportTemplateDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportTemplateDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExportTemplateColumns == input.ExportTemplateColumns ||
                    this.ExportTemplateColumns != null &&
                    input.ExportTemplateColumns != null &&
                    this.ExportTemplateColumns.SequenceEqual(input.ExportTemplateColumns)
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
                if (this.ExportTemplateColumns != null)
                    hashCode = hashCode * 59 + this.ExportTemplateColumns.GetHashCode();
                return hashCode;
            }
        }
    }
}
