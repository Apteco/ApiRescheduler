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
    /// Details specific for selector variables in the FastStats system
    /// </summary>
    [DataContract]
        public partial class SelectorVariableInfo :  IEquatable<SelectorVariableInfo>
    {
        /// <summary>
        /// The type of selector that this variable is
        /// </summary>
        /// <value>The type of selector that this variable is</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SelectorTypeEnum
        {
            /// <summary>
            /// Enum SingleValue for value: SingleValue
            /// </summary>
            [EnumMember(Value = "SingleValue")]
            SingleValue = 1,
            /// <summary>
            /// Enum OrArray for value: OrArray
            /// </summary>
            [EnumMember(Value = "OrArray")]
            OrArray = 2,
            /// <summary>
            /// Enum AndArray for value: AndArray
            /// </summary>
            [EnumMember(Value = "AndArray")]
            AndArray = 3,
            /// <summary>
            /// Enum OrBitArray for value: OrBitArray
            /// </summary>
            [EnumMember(Value = "OrBitArray")]
            OrBitArray = 4,
            /// <summary>
            /// Enum AndBitArray for value: AndBitArray
            /// </summary>
            [EnumMember(Value = "AndBitArray")]
            AndBitArray = 5        }
        /// <summary>
        /// The type of selector that this variable is
        /// </summary>
        /// <value>The type of selector that this variable is</value>
        [DataMember(Name="selectorType", EmitDefaultValue=false)]
        public SelectorTypeEnum? SelectorType { get; set; }
        /// <summary>
        /// Further type information (such as whether the selector variable is a date or datetime) for this variable
        /// </summary>
        /// <value>Further type information (such as whether the selector variable is a date or datetime) for this variable</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SubTypeEnum
        {
            /// <summary>
            /// Enum Categorical for value: Categorical
            /// </summary>
            [EnumMember(Value = "Categorical")]
            Categorical = 1,
            /// <summary>
            /// Enum Date for value: Date
            /// </summary>
            [EnumMember(Value = "Date")]
            Date = 2,
            /// <summary>
            /// Enum DateTime for value: DateTime
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime = 3        }
        /// <summary>
        /// Further type information (such as whether the selector variable is a date or datetime) for this variable
        /// </summary>
        /// <value>Further type information (such as whether the selector variable is a date or datetime) for this variable</value>
        [DataMember(Name="subType", EmitDefaultValue=false)]
        public SubTypeEnum? SubType { get; set; }
        /// <summary>
        /// How the categories are ordered within this variable
        /// </summary>
        /// <value>How the categories are ordered within this variable</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum VarCodeOrderEnum
        {
            /// <summary>
            /// Enum Nominal for value: Nominal
            /// </summary>
            [EnumMember(Value = "Nominal")]
            Nominal = 1,
            /// <summary>
            /// Enum Ascending for value: Ascending
            /// </summary>
            [EnumMember(Value = "Ascending")]
            Ascending = 2,
            /// <summary>
            /// Enum Descending for value: Descending
            /// </summary>
            [EnumMember(Value = "Descending")]
            Descending = 3        }
        /// <summary>
        /// How the categories are ordered within this variable
        /// </summary>
        /// <value>How the categories are ordered within this variable</value>
        [DataMember(Name="varCodeOrder", EmitDefaultValue=false)]
        public VarCodeOrderEnum? VarCodeOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectorVariableInfo" /> class.
        /// </summary>
        /// <param name="selectorType">The type of selector that this variable is.</param>
        /// <param name="subType">Further type information (such as whether the selector variable is a date or datetime) for this variable.</param>
        /// <param name="varCodeOrder">How the categories are ordered within this variable.</param>
        /// <param name="numberOfCodes">The number of different categories (var codes) that this variable has.</param>
        /// <param name="codeLength">The length of the code for each category (in bytes) for this variable.</param>
        /// <param name="minimumVarCodeCount">The minimum count value in the variable&#x27;s set of categories (var codes).</param>
        /// <param name="maximumVarCodeCount">The maximum count value in the variable&#x27;s set of categories (var codes).</param>
        /// <param name="minimumDate">If this variable is a date variable, The earliest date represented by this variable.</param>
        /// <param name="maximumDate">If this variable is a date variable, The latest date represented by this variable.</param>
        /// <param name="combinedFromVariableName">If this variable is a summary/combined categories variable, then this is the name of the parent variable that this summarises.</param>
        /// <param name="unclassifiedCode">If this variable is a single value selector variable, then this is the code for unclassified values.</param>
        /// <param name="unclassifiedDescription">If this variable is a single value selector variable, then this is the description for unclassified values.</param>
        public SelectorVariableInfo(SelectorTypeEnum? selectorType = default(SelectorTypeEnum?), SubTypeEnum? subType = default(SubTypeEnum?), VarCodeOrderEnum? varCodeOrder = default(VarCodeOrderEnum?), int? numberOfCodes = default(int?), int? codeLength = default(int?), long? minimumVarCodeCount = default(long?), long? maximumVarCodeCount = default(long?), DateTime? minimumDate = default(DateTime?), DateTime? maximumDate = default(DateTime?), string combinedFromVariableName = default(string), string unclassifiedCode = default(string), string unclassifiedDescription = default(string))
        {
            this.SelectorType = selectorType;
            this.SubType = subType;
            this.VarCodeOrder = varCodeOrder;
            this.NumberOfCodes = numberOfCodes;
            this.CodeLength = codeLength;
            this.MinimumVarCodeCount = minimumVarCodeCount;
            this.MaximumVarCodeCount = maximumVarCodeCount;
            this.MinimumDate = minimumDate;
            this.MaximumDate = maximumDate;
            this.CombinedFromVariableName = combinedFromVariableName;
            this.UnclassifiedCode = unclassifiedCode;
            this.UnclassifiedDescription = unclassifiedDescription;
        }
        



        /// <summary>
        /// The number of different categories (var codes) that this variable has
        /// </summary>
        /// <value>The number of different categories (var codes) that this variable has</value>
        [DataMember(Name="numberOfCodes", EmitDefaultValue=false)]
        public int? NumberOfCodes { get; set; }

        /// <summary>
        /// The length of the code for each category (in bytes) for this variable
        /// </summary>
        /// <value>The length of the code for each category (in bytes) for this variable</value>
        [DataMember(Name="codeLength", EmitDefaultValue=false)]
        public int? CodeLength { get; set; }

        /// <summary>
        /// The minimum count value in the variable&#x27;s set of categories (var codes)
        /// </summary>
        /// <value>The minimum count value in the variable&#x27;s set of categories (var codes)</value>
        [DataMember(Name="minimumVarCodeCount", EmitDefaultValue=false)]
        public long? MinimumVarCodeCount { get; set; }

        /// <summary>
        /// The maximum count value in the variable&#x27;s set of categories (var codes)
        /// </summary>
        /// <value>The maximum count value in the variable&#x27;s set of categories (var codes)</value>
        [DataMember(Name="maximumVarCodeCount", EmitDefaultValue=false)]
        public long? MaximumVarCodeCount { get; set; }

        /// <summary>
        /// If this variable is a date variable, The earliest date represented by this variable
        /// </summary>
        /// <value>If this variable is a date variable, The earliest date represented by this variable</value>
        [DataMember(Name="minimumDate", EmitDefaultValue=false)]
        public DateTime? MinimumDate { get; set; }

        /// <summary>
        /// If this variable is a date variable, The latest date represented by this variable
        /// </summary>
        /// <value>If this variable is a date variable, The latest date represented by this variable</value>
        [DataMember(Name="maximumDate", EmitDefaultValue=false)]
        public DateTime? MaximumDate { get; set; }

        /// <summary>
        /// If this variable is a summary/combined categories variable, then this is the name of the parent variable that this summarises
        /// </summary>
        /// <value>If this variable is a summary/combined categories variable, then this is the name of the parent variable that this summarises</value>
        [DataMember(Name="combinedFromVariableName", EmitDefaultValue=false)]
        public string CombinedFromVariableName { get; set; }

        /// <summary>
        /// If this variable is a single value selector variable, then this is the code for unclassified values
        /// </summary>
        /// <value>If this variable is a single value selector variable, then this is the code for unclassified values</value>
        [DataMember(Name="unclassifiedCode", EmitDefaultValue=false)]
        public string UnclassifiedCode { get; set; }

        /// <summary>
        /// If this variable is a single value selector variable, then this is the description for unclassified values
        /// </summary>
        /// <value>If this variable is a single value selector variable, then this is the description for unclassified values</value>
        [DataMember(Name="unclassifiedDescription", EmitDefaultValue=false)]
        public string UnclassifiedDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectorVariableInfo {\n");
            sb.Append("  SelectorType: ").Append(SelectorType).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  VarCodeOrder: ").Append(VarCodeOrder).Append("\n");
            sb.Append("  NumberOfCodes: ").Append(NumberOfCodes).Append("\n");
            sb.Append("  CodeLength: ").Append(CodeLength).Append("\n");
            sb.Append("  MinimumVarCodeCount: ").Append(MinimumVarCodeCount).Append("\n");
            sb.Append("  MaximumVarCodeCount: ").Append(MaximumVarCodeCount).Append("\n");
            sb.Append("  MinimumDate: ").Append(MinimumDate).Append("\n");
            sb.Append("  MaximumDate: ").Append(MaximumDate).Append("\n");
            sb.Append("  CombinedFromVariableName: ").Append(CombinedFromVariableName).Append("\n");
            sb.Append("  UnclassifiedCode: ").Append(UnclassifiedCode).Append("\n");
            sb.Append("  UnclassifiedDescription: ").Append(UnclassifiedDescription).Append("\n");
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
            return this.Equals(input as SelectorVariableInfo);
        }

        /// <summary>
        /// Returns true if SelectorVariableInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectorVariableInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectorVariableInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SelectorType == input.SelectorType ||
                    (this.SelectorType != null &&
                    this.SelectorType.Equals(input.SelectorType))
                ) && 
                (
                    this.SubType == input.SubType ||
                    (this.SubType != null &&
                    this.SubType.Equals(input.SubType))
                ) && 
                (
                    this.VarCodeOrder == input.VarCodeOrder ||
                    (this.VarCodeOrder != null &&
                    this.VarCodeOrder.Equals(input.VarCodeOrder))
                ) && 
                (
                    this.NumberOfCodes == input.NumberOfCodes ||
                    (this.NumberOfCodes != null &&
                    this.NumberOfCodes.Equals(input.NumberOfCodes))
                ) && 
                (
                    this.CodeLength == input.CodeLength ||
                    (this.CodeLength != null &&
                    this.CodeLength.Equals(input.CodeLength))
                ) && 
                (
                    this.MinimumVarCodeCount == input.MinimumVarCodeCount ||
                    (this.MinimumVarCodeCount != null &&
                    this.MinimumVarCodeCount.Equals(input.MinimumVarCodeCount))
                ) && 
                (
                    this.MaximumVarCodeCount == input.MaximumVarCodeCount ||
                    (this.MaximumVarCodeCount != null &&
                    this.MaximumVarCodeCount.Equals(input.MaximumVarCodeCount))
                ) && 
                (
                    this.MinimumDate == input.MinimumDate ||
                    (this.MinimumDate != null &&
                    this.MinimumDate.Equals(input.MinimumDate))
                ) && 
                (
                    this.MaximumDate == input.MaximumDate ||
                    (this.MaximumDate != null &&
                    this.MaximumDate.Equals(input.MaximumDate))
                ) && 
                (
                    this.CombinedFromVariableName == input.CombinedFromVariableName ||
                    (this.CombinedFromVariableName != null &&
                    this.CombinedFromVariableName.Equals(input.CombinedFromVariableName))
                ) && 
                (
                    this.UnclassifiedCode == input.UnclassifiedCode ||
                    (this.UnclassifiedCode != null &&
                    this.UnclassifiedCode.Equals(input.UnclassifiedCode))
                ) && 
                (
                    this.UnclassifiedDescription == input.UnclassifiedDescription ||
                    (this.UnclassifiedDescription != null &&
                    this.UnclassifiedDescription.Equals(input.UnclassifiedDescription))
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
                if (this.SelectorType != null)
                    hashCode = hashCode * 59 + this.SelectorType.GetHashCode();
                if (this.SubType != null)
                    hashCode = hashCode * 59 + this.SubType.GetHashCode();
                if (this.VarCodeOrder != null)
                    hashCode = hashCode * 59 + this.VarCodeOrder.GetHashCode();
                if (this.NumberOfCodes != null)
                    hashCode = hashCode * 59 + this.NumberOfCodes.GetHashCode();
                if (this.CodeLength != null)
                    hashCode = hashCode * 59 + this.CodeLength.GetHashCode();
                if (this.MinimumVarCodeCount != null)
                    hashCode = hashCode * 59 + this.MinimumVarCodeCount.GetHashCode();
                if (this.MaximumVarCodeCount != null)
                    hashCode = hashCode * 59 + this.MaximumVarCodeCount.GetHashCode();
                if (this.MinimumDate != null)
                    hashCode = hashCode * 59 + this.MinimumDate.GetHashCode();
                if (this.MaximumDate != null)
                    hashCode = hashCode * 59 + this.MaximumDate.GetHashCode();
                if (this.CombinedFromVariableName != null)
                    hashCode = hashCode * 59 + this.CombinedFromVariableName.GetHashCode();
                if (this.UnclassifiedCode != null)
                    hashCode = hashCode * 59 + this.UnclassifiedCode.GetHashCode();
                if (this.UnclassifiedDescription != null)
                    hashCode = hashCode * 59 + this.UnclassifiedDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
