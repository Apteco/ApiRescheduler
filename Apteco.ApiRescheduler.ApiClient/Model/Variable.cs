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
    /// Details for a variable in the FastStats system
    /// </summary>
    [DataContract]
        public partial class Variable :  IEquatable<Variable>
    {
        /// <summary>
        /// The type of the variable
        /// </summary>
        /// <value>The type of the variable</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Selector for value: Selector
            /// </summary>
            [EnumMember(Value = "Selector")]
            Selector = 1,
            /// <summary>
            /// Enum Reference for value: Reference
            /// </summary>
            [EnumMember(Value = "Reference")]
            Reference = 2,
            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 3,
            /// <summary>
            /// Enum Numeric for value: Numeric
            /// </summary>
            [EnumMember(Value = "Numeric")]
            Numeric = 4        }
        /// <summary>
        /// The type of the variable
        /// </summary>
        /// <value>The type of the variable</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Variable" /> class.
        /// </summary>
        /// <param name="name">The name of the variable (required).</param>
        /// <param name="description">The description of the variable (required).</param>
        /// <param name="path">The path of the variable (required).</param>
        /// <param name="type">The type of the variable (required).</param>
        /// <param name="folderName">The name of the folder that this variable belongs to within the FastStats system.</param>
        /// <param name="tableName">The name of the table that this variable is from (required).</param>
        /// <param name="isSelectable">Whether the variable is allowed to used in selections (required).</param>
        /// <param name="isBrowsable">Whether the variable is allowed to viewed with a client application (but not exported) (required).</param>
        /// <param name="isExportable">Whether the variable is allowed to exported by a client application (required).</param>
        /// <param name="isVirtual">Whether the variable is a virtual variable (i.e. created after the system has been built) or not (required).</param>
        /// <param name="selectorInfo">selectorInfo.</param>
        /// <param name="numericInfo">numericInfo.</param>
        /// <param name="textInfo">textInfo.</param>
        /// <param name="referenceInfo">referenceInfo.</param>
        /// <param name="notes">The notes about this variable.</param>
        public Variable(string name = default(string), string description = default(string), string path = default(string), TypeEnum type = default(TypeEnum), string folderName = default(string), string tableName = default(string), bool? isSelectable = default(bool?), bool? isBrowsable = default(bool?), bool? isExportable = default(bool?), bool? isVirtual = default(bool?), SelectorVariableInfo selectorInfo = default(SelectorVariableInfo), NumericVariableInfo numericInfo = default(NumericVariableInfo), TextVariableInfo textInfo = default(TextVariableInfo), ReferenceVariableInfo referenceInfo = default(ReferenceVariableInfo), string notes = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Variable and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for Variable and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for Variable and cannot be null");
            }
            else
            {
                this.Path = path;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Variable and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "tableName" is required (not null)
            if (tableName == null)
            {
                throw new InvalidDataException("tableName is a required property for Variable and cannot be null");
            }
            else
            {
                this.TableName = tableName;
            }
            // to ensure "isSelectable" is required (not null)
            if (isSelectable == null)
            {
                throw new InvalidDataException("isSelectable is a required property for Variable and cannot be null");
            }
            else
            {
                this.IsSelectable = isSelectable;
            }
            // to ensure "isBrowsable" is required (not null)
            if (isBrowsable == null)
            {
                throw new InvalidDataException("isBrowsable is a required property for Variable and cannot be null");
            }
            else
            {
                this.IsBrowsable = isBrowsable;
            }
            // to ensure "isExportable" is required (not null)
            if (isExportable == null)
            {
                throw new InvalidDataException("isExportable is a required property for Variable and cannot be null");
            }
            else
            {
                this.IsExportable = isExportable;
            }
            // to ensure "isVirtual" is required (not null)
            if (isVirtual == null)
            {
                throw new InvalidDataException("isVirtual is a required property for Variable and cannot be null");
            }
            else
            {
                this.IsVirtual = isVirtual;
            }
            this.FolderName = folderName;
            this.SelectorInfo = selectorInfo;
            this.NumericInfo = numericInfo;
            this.TextInfo = textInfo;
            this.ReferenceInfo = referenceInfo;
            this.Notes = notes;
        }
        
        /// <summary>
        /// The name of the variable
        /// </summary>
        /// <value>The name of the variable</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the variable
        /// </summary>
        /// <value>The description of the variable</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The path of the variable
        /// </summary>
        /// <value>The path of the variable</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }


        /// <summary>
        /// The name of the folder that this variable belongs to within the FastStats system
        /// </summary>
        /// <value>The name of the folder that this variable belongs to within the FastStats system</value>
        [DataMember(Name="folderName", EmitDefaultValue=false)]
        public string FolderName { get; set; }

        /// <summary>
        /// The name of the table that this variable is from
        /// </summary>
        /// <value>The name of the table that this variable is from</value>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Whether the variable is allowed to used in selections
        /// </summary>
        /// <value>Whether the variable is allowed to used in selections</value>
        [DataMember(Name="isSelectable", EmitDefaultValue=false)]
        public bool? IsSelectable { get; set; }

        /// <summary>
        /// Whether the variable is allowed to viewed with a client application (but not exported)
        /// </summary>
        /// <value>Whether the variable is allowed to viewed with a client application (but not exported)</value>
        [DataMember(Name="isBrowsable", EmitDefaultValue=false)]
        public bool? IsBrowsable { get; set; }

        /// <summary>
        /// Whether the variable is allowed to exported by a client application
        /// </summary>
        /// <value>Whether the variable is allowed to exported by a client application</value>
        [DataMember(Name="isExportable", EmitDefaultValue=false)]
        public bool? IsExportable { get; set; }

        /// <summary>
        /// Whether the variable is a virtual variable (i.e. created after the system has been built) or not
        /// </summary>
        /// <value>Whether the variable is a virtual variable (i.e. created after the system has been built) or not</value>
        [DataMember(Name="isVirtual", EmitDefaultValue=false)]
        public bool? IsVirtual { get; set; }

        /// <summary>
        /// Gets or Sets SelectorInfo
        /// </summary>
        [DataMember(Name="selectorInfo", EmitDefaultValue=false)]
        public SelectorVariableInfo SelectorInfo { get; set; }

        /// <summary>
        /// Gets or Sets NumericInfo
        /// </summary>
        [DataMember(Name="numericInfo", EmitDefaultValue=false)]
        public NumericVariableInfo NumericInfo { get; set; }

        /// <summary>
        /// Gets or Sets TextInfo
        /// </summary>
        [DataMember(Name="textInfo", EmitDefaultValue=false)]
        public TextVariableInfo TextInfo { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceInfo
        /// </summary>
        [DataMember(Name="referenceInfo", EmitDefaultValue=false)]
        public ReferenceVariableInfo ReferenceInfo { get; set; }

        /// <summary>
        /// The notes about this variable
        /// </summary>
        /// <value>The notes about this variable</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Variable {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FolderName: ").Append(FolderName).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  IsSelectable: ").Append(IsSelectable).Append("\n");
            sb.Append("  IsBrowsable: ").Append(IsBrowsable).Append("\n");
            sb.Append("  IsExportable: ").Append(IsExportable).Append("\n");
            sb.Append("  IsVirtual: ").Append(IsVirtual).Append("\n");
            sb.Append("  SelectorInfo: ").Append(SelectorInfo).Append("\n");
            sb.Append("  NumericInfo: ").Append(NumericInfo).Append("\n");
            sb.Append("  TextInfo: ").Append(TextInfo).Append("\n");
            sb.Append("  ReferenceInfo: ").Append(ReferenceInfo).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as Variable);
        }

        /// <summary>
        /// Returns true if Variable instances are equal
        /// </summary>
        /// <param name="input">Instance of Variable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Variable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.FolderName == input.FolderName ||
                    (this.FolderName != null &&
                    this.FolderName.Equals(input.FolderName))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.IsSelectable == input.IsSelectable ||
                    (this.IsSelectable != null &&
                    this.IsSelectable.Equals(input.IsSelectable))
                ) && 
                (
                    this.IsBrowsable == input.IsBrowsable ||
                    (this.IsBrowsable != null &&
                    this.IsBrowsable.Equals(input.IsBrowsable))
                ) && 
                (
                    this.IsExportable == input.IsExportable ||
                    (this.IsExportable != null &&
                    this.IsExportable.Equals(input.IsExportable))
                ) && 
                (
                    this.IsVirtual == input.IsVirtual ||
                    (this.IsVirtual != null &&
                    this.IsVirtual.Equals(input.IsVirtual))
                ) && 
                (
                    this.SelectorInfo == input.SelectorInfo ||
                    (this.SelectorInfo != null &&
                    this.SelectorInfo.Equals(input.SelectorInfo))
                ) && 
                (
                    this.NumericInfo == input.NumericInfo ||
                    (this.NumericInfo != null &&
                    this.NumericInfo.Equals(input.NumericInfo))
                ) && 
                (
                    this.TextInfo == input.TextInfo ||
                    (this.TextInfo != null &&
                    this.TextInfo.Equals(input.TextInfo))
                ) && 
                (
                    this.ReferenceInfo == input.ReferenceInfo ||
                    (this.ReferenceInfo != null &&
                    this.ReferenceInfo.Equals(input.ReferenceInfo))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FolderName != null)
                    hashCode = hashCode * 59 + this.FolderName.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.IsSelectable != null)
                    hashCode = hashCode * 59 + this.IsSelectable.GetHashCode();
                if (this.IsBrowsable != null)
                    hashCode = hashCode * 59 + this.IsBrowsable.GetHashCode();
                if (this.IsExportable != null)
                    hashCode = hashCode * 59 + this.IsExportable.GetHashCode();
                if (this.IsVirtual != null)
                    hashCode = hashCode * 59 + this.IsVirtual.GetHashCode();
                if (this.SelectorInfo != null)
                    hashCode = hashCode * 59 + this.SelectorInfo.GetHashCode();
                if (this.NumericInfo != null)
                    hashCode = hashCode * 59 + this.NumericInfo.GetHashCode();
                if (this.TextInfo != null)
                    hashCode = hashCode * 59 + this.TextInfo.GetHashCode();
                if (this.ReferenceInfo != null)
                    hashCode = hashCode * 59 + this.ReferenceInfo.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                return hashCode;
            }
        }
    }
}
