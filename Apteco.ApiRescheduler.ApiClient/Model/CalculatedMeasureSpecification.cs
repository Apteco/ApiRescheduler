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
    /// The specification for a measure calculated from other measures
    /// </summary>
    [DataContract]
        public partial class CalculatedMeasureSpecification :  IEquatable<CalculatedMeasureSpecification>
    {
        /// <summary>
        /// The operator for the calculation
        /// </summary>
        /// <value>The operator for the calculation</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OperatorEnum
        {
            /// <summary>
            /// Enum Add for value: Add
            /// </summary>
            [EnumMember(Value = "Add")]
            Add = 1,
            /// <summary>
            /// Enum Subtract for value: Subtract
            /// </summary>
            [EnumMember(Value = "Subtract")]
            Subtract = 2,
            /// <summary>
            /// Enum Multiply for value: Multiply
            /// </summary>
            [EnumMember(Value = "Multiply")]
            Multiply = 3,
            /// <summary>
            /// Enum Divide for value: Divide
            /// </summary>
            [EnumMember(Value = "Divide")]
            Divide = 4,
            /// <summary>
            /// Enum PercentageOf for value: PercentageOf
            /// </summary>
            [EnumMember(Value = "PercentageOf")]
            PercentageOf = 5        }
        /// <summary>
        /// The operator for the calculation
        /// </summary>
        /// <value>The operator for the calculation</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum _Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatedMeasureSpecification" /> class.
        /// </summary>
        /// <param name="leftOperand">leftOperand (required).</param>
        /// <param name="rightOperand">rightOperand (required).</param>
        /// <param name="_operator">The operator for the calculation (required).</param>
        public CalculatedMeasureSpecification(CalculatedMeasureOperand leftOperand = default(CalculatedMeasureOperand), CalculatedMeasureOperand rightOperand = default(CalculatedMeasureOperand), OperatorEnum _operator = default(OperatorEnum))
        {
            // to ensure "leftOperand" is required (not null)
            if (leftOperand == null)
            {
                throw new InvalidDataException("leftOperand is a required property for CalculatedMeasureSpecification and cannot be null");
            }
            else
            {
                this.LeftOperand = leftOperand;
            }
            // to ensure "rightOperand" is required (not null)
            if (rightOperand == null)
            {
                throw new InvalidDataException("rightOperand is a required property for CalculatedMeasureSpecification and cannot be null");
            }
            else
            {
                this.RightOperand = rightOperand;
            }
            // to ensure "_operator" is required (not null)
            if (_operator == null)
            {
                throw new InvalidDataException("_operator is a required property for CalculatedMeasureSpecification and cannot be null");
            }
            else
            {
                this._Operator = _operator;
            }
        }
        
        /// <summary>
        /// Gets or Sets LeftOperand
        /// </summary>
        [DataMember(Name="leftOperand", EmitDefaultValue=false)]
        public CalculatedMeasureOperand LeftOperand { get; set; }

        /// <summary>
        /// Gets or Sets RightOperand
        /// </summary>
        [DataMember(Name="rightOperand", EmitDefaultValue=false)]
        public CalculatedMeasureOperand RightOperand { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculatedMeasureSpecification {\n");
            sb.Append("  LeftOperand: ").Append(LeftOperand).Append("\n");
            sb.Append("  RightOperand: ").Append(RightOperand).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
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
            return this.Equals(input as CalculatedMeasureSpecification);
        }

        /// <summary>
        /// Returns true if CalculatedMeasureSpecification instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculatedMeasureSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculatedMeasureSpecification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeftOperand == input.LeftOperand ||
                    (this.LeftOperand != null &&
                    this.LeftOperand.Equals(input.LeftOperand))
                ) && 
                (
                    this.RightOperand == input.RightOperand ||
                    (this.RightOperand != null &&
                    this.RightOperand.Equals(input.RightOperand))
                ) && 
                (
                    this._Operator == input._Operator ||
                    (this._Operator != null &&
                    this._Operator.Equals(input._Operator))
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
                if (this.LeftOperand != null)
                    hashCode = hashCode * 59 + this.LeftOperand.GetHashCode();
                if (this.RightOperand != null)
                    hashCode = hashCode * 59 + this.RightOperand.GetHashCode();
                if (this._Operator != null)
                    hashCode = hashCode * 59 + this._Operator.GetHashCode();
                return hashCode;
            }
        }
    }
}