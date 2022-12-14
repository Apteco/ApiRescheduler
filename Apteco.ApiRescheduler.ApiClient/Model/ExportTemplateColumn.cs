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
    /// An export template column to output for every row in the export
    /// </summary>
    [DataContract]
        public partial class ExportTemplateColumn :  IEquatable<ExportTemplateColumn>
    {
        /// <summary>
        /// The type of the column
        /// </summary>
        /// <value>The type of the column</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ColumnTypeEnum
        {
            /// <summary>
            /// Enum UserCode for value: UserCode
            /// </summary>
            [EnumMember(Value = "UserCode")]
            UserCode = 1,
            /// <summary>
            /// Enum Variable for value: Variable
            /// </summary>
            [EnumMember(Value = "Variable")]
            Variable = 2        }
        /// <summary>
        /// The type of the column
        /// </summary>
        /// <value>The type of the column</value>
        [DataMember(Name="columnType", EmitDefaultValue=false)]
        public ColumnTypeEnum? ColumnType { get; set; }
        /// <summary>
        /// Whether to output the codes or descriptions for this column when data is exported to a file
        /// </summary>
        /// <value>Whether to output the codes or descriptions for this column when data is exported to a file</value>
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
        /// Whether to output the codes or descriptions for this column when data is exported to a file
        /// </summary>
        /// <value>Whether to output the codes or descriptions for this column when data is exported to a file</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public DetailEnum? Detail { get; set; }
        /// <summary>
        /// How to format unclassified values for selector variables
        /// </summary>
        /// <value>How to format unclassified values for selector variables</value>
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
        /// How to format unclassified values for selector variables
        /// </summary>
        /// <value>How to format unclassified values for selector variables</value>
        [DataMember(Name="unclassifiedFormat", EmitDefaultValue=false)]
        public UnclassifiedFormatEnum? UnclassifiedFormat { get; set; }
        /// <summary>
        /// How to format values for variables
        /// </summary>
        /// <value>How to format values for variables</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ValueFormatEnum
        {
            /// <summary>
            /// Enum Unformatted for value: Unformatted
            /// </summary>
            [EnumMember(Value = "Unformatted")]
            Unformatted = 1,
            /// <summary>
            /// Enum UpperCase for value: UpperCase
            /// </summary>
            [EnumMember(Value = "UpperCase")]
            UpperCase = 2,
            /// <summary>
            /// Enum LowerCase for value: LowerCase
            /// </summary>
            [EnumMember(Value = "LowerCase")]
            LowerCase = 3,
            /// <summary>
            /// Enum TitleCase for value: TitleCase
            /// </summary>
            [EnumMember(Value = "TitleCase")]
            TitleCase = 4        }
        /// <summary>
        /// How to format values for variables
        /// </summary>
        /// <value>How to format values for variables</value>
        [DataMember(Name="valueFormat", EmitDefaultValue=false)]
        public ValueFormatEnum? ValueFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTemplateColumn" /> class.
        /// </summary>
        /// <param name="id">The id of the column (required).</param>
        /// <param name="columnType">The type of the column.</param>
        /// <param name="variableName">The variable to output in this column.</param>
        /// <param name="columnHeader">The text to use as the column header (required).</param>
        /// <param name="detail">Whether to output the codes or descriptions for this column when data is exported to a file.</param>
        /// <param name="unclassifiedFormat">How to format unclassified values for selector variables.</param>
        /// <param name="valueFormat">How to format values for variables.</param>
        /// <param name="userCode">Defines the user code for the column.</param>
        /// <param name="userCodeName">Defines the name of the user code for the column.</param>
        public ExportTemplateColumn(string id = default(string), ColumnTypeEnum? columnType = default(ColumnTypeEnum?), string variableName = default(string), string columnHeader = default(string), DetailEnum? detail = default(DetailEnum?), UnclassifiedFormatEnum? unclassifiedFormat = default(UnclassifiedFormatEnum?), ValueFormatEnum? valueFormat = default(ValueFormatEnum?), string userCode = default(string), string userCodeName = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ExportTemplateColumn and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "columnHeader" is required (not null)
            if (columnHeader == null)
            {
                throw new InvalidDataException("columnHeader is a required property for ExportTemplateColumn and cannot be null");
            }
            else
            {
                this.ColumnHeader = columnHeader;
            }
            this.ColumnType = columnType;
            this.VariableName = variableName;
            this.Detail = detail;
            this.UnclassifiedFormat = unclassifiedFormat;
            this.ValueFormat = valueFormat;
            this.UserCode = userCode;
            this.UserCodeName = userCodeName;
        }
        
        /// <summary>
        /// The id of the column
        /// </summary>
        /// <value>The id of the column</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// The variable to output in this column
        /// </summary>
        /// <value>The variable to output in this column</value>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }

        /// <summary>
        /// The text to use as the column header
        /// </summary>
        /// <value>The text to use as the column header</value>
        [DataMember(Name="columnHeader", EmitDefaultValue=false)]
        public string ColumnHeader { get; set; }




        /// <summary>
        /// Defines the user code for the column
        /// </summary>
        /// <value>Defines the user code for the column</value>
        [DataMember(Name="userCode", EmitDefaultValue=false)]
        public string UserCode { get; set; }

        /// <summary>
        /// Defines the name of the user code for the column
        /// </summary>
        /// <value>Defines the name of the user code for the column</value>
        [DataMember(Name="userCodeName", EmitDefaultValue=false)]
        public string UserCodeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportTemplateColumn {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ColumnType: ").Append(ColumnType).Append("\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  ColumnHeader: ").Append(ColumnHeader).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  UnclassifiedFormat: ").Append(UnclassifiedFormat).Append("\n");
            sb.Append("  ValueFormat: ").Append(ValueFormat).Append("\n");
            sb.Append("  UserCode: ").Append(UserCode).Append("\n");
            sb.Append("  UserCodeName: ").Append(UserCodeName).Append("\n");
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
            return this.Equals(input as ExportTemplateColumn);
        }

        /// <summary>
        /// Returns true if ExportTemplateColumn instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportTemplateColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportTemplateColumn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ColumnType == input.ColumnType ||
                    (this.ColumnType != null &&
                    this.ColumnType.Equals(input.ColumnType))
                ) && 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
                ) && 
                (
                    this.ColumnHeader == input.ColumnHeader ||
                    (this.ColumnHeader != null &&
                    this.ColumnHeader.Equals(input.ColumnHeader))
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
                    this.ValueFormat == input.ValueFormat ||
                    (this.ValueFormat != null &&
                    this.ValueFormat.Equals(input.ValueFormat))
                ) && 
                (
                    this.UserCode == input.UserCode ||
                    (this.UserCode != null &&
                    this.UserCode.Equals(input.UserCode))
                ) && 
                (
                    this.UserCodeName == input.UserCodeName ||
                    (this.UserCodeName != null &&
                    this.UserCodeName.Equals(input.UserCodeName))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ColumnType != null)
                    hashCode = hashCode * 59 + this.ColumnType.GetHashCode();
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
                if (this.ColumnHeader != null)
                    hashCode = hashCode * 59 + this.ColumnHeader.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.UnclassifiedFormat != null)
                    hashCode = hashCode * 59 + this.UnclassifiedFormat.GetHashCode();
                if (this.ValueFormat != null)
                    hashCode = hashCode * 59 + this.ValueFormat.GetHashCode();
                if (this.UserCode != null)
                    hashCode = hashCode * 59 + this.UserCode.GetHashCode();
                if (this.UserCodeName != null)
                    hashCode = hashCode * 59 + this.UserCodeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
