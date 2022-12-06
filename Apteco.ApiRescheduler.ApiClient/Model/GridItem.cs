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
    /// The definition of one item to show in a grid composition
    /// </summary>
    [DataContract]
        public partial class GridItem :  IEquatable<GridItem>
    {
        /// <summary>
        /// Whether to show codes or descriptions for this grid item
        /// </summary>
        /// <value>Whether to show codes or descriptions for this grid item</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DetailEnum
        {
            /// <summary>
            /// Enum Code for value: Code
            /// </summary>
            [EnumMember(Value = "Code")]
            Code = 1,
            /// <summary>
            /// Enum Description for value: Description
            /// </summary>
            [EnumMember(Value = "Description")]
            Description = 2        }
        /// <summary>
        /// Whether to show codes or descriptions for this grid item
        /// </summary>
        /// <value>Whether to show codes or descriptions for this grid item</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public DetailEnum Detail { get; set; }
        /// <summary>
        /// Whether to output unclassified as empty or taken from the design
        /// </summary>
        /// <value>Whether to output unclassified as empty or taken from the design</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UnclassifiedFormatEnum
        {
            /// <summary>
            /// Enum FromDesign for value: FromDesign
            /// </summary>
            [EnumMember(Value = "FromDesign")]
            FromDesign = 1,
            /// <summary>
            /// Enum Empty for value: Empty
            /// </summary>
            [EnumMember(Value = "Empty")]
            Empty = 2        }
        /// <summary>
        /// Whether to output unclassified as empty or taken from the design
        /// </summary>
        /// <value>Whether to output unclassified as empty or taken from the design</value>
        [DataMember(Name="unclassifiedFormat", EmitDefaultValue=false)]
        public UnclassifiedFormatEnum UnclassifiedFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GridItem" /> class.
        /// </summary>
        /// <param name="variableName">The name of the FastStats variable to display data for in the grid (required).</param>
        /// <param name="detail">Whether to show codes or descriptions for this grid item (required).</param>
        /// <param name="unclassifiedFormat">Whether to output unclassified as empty or taken from the design (required).</param>
        /// <param name="description">The description to use for this item (required).</param>
        public GridItem(string variableName = default(string), DetailEnum detail = default(DetailEnum), UnclassifiedFormatEnum unclassifiedFormat = default(UnclassifiedFormatEnum), string description = default(string))
        {
            // to ensure "variableName" is required (not null)
            if (variableName == null)
            {
                throw new InvalidDataException("variableName is a required property for GridItem and cannot be null");
            }
            else
            {
                this.VariableName = variableName;
            }
            // to ensure "detail" is required (not null)
            if (detail == null)
            {
                throw new InvalidDataException("detail is a required property for GridItem and cannot be null");
            }
            else
            {
                this.Detail = detail;
            }
            // to ensure "unclassifiedFormat" is required (not null)
            if (unclassifiedFormat == null)
            {
                throw new InvalidDataException("unclassifiedFormat is a required property for GridItem and cannot be null");
            }
            else
            {
                this.UnclassifiedFormat = unclassifiedFormat;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for GridItem and cannot be null");
            }
            else
            {
                this.Description = description;
            }
        }
        
        /// <summary>
        /// The name of the FastStats variable to display data for in the grid
        /// </summary>
        /// <value>The name of the FastStats variable to display data for in the grid</value>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }



        /// <summary>
        /// The description to use for this item
        /// </summary>
        /// <value>The description to use for this item</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GridItem {\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  UnclassifiedFormat: ").Append(UnclassifiedFormat).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as GridItem);
        }

        /// <summary>
        /// Returns true if GridItem instances are equal
        /// </summary>
        /// <param name="input">Instance of GridItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GridItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.UnclassifiedFormat == input.UnclassifiedFormat ||
                    (this.UnclassifiedFormat != null &&
                    this.UnclassifiedFormat.Equals(input.UnclassifiedFormat))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.UnclassifiedFormat != null)
                    hashCode = hashCode * 59 + this.UnclassifiedFormat.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
