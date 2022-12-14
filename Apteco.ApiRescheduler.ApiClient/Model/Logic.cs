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
    /// Logic
    /// </summary>
    [DataContract]
        public partial class Logic :  IEquatable<Logic>
    {
        /// <summary>
        /// Defines Operation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OperationEnum
        {
            /// <summary>
            /// Enum INCLUDE for value: INCLUDE
            /// </summary>
            [EnumMember(Value = "INCLUDE")]
            INCLUDE = 1,
            /// <summary>
            /// Enum ANY for value: ANY
            /// </summary>
            [EnumMember(Value = "ANY")]
            ANY = 2,
            /// <summary>
            /// Enum AND for value: AND
            /// </summary>
            [EnumMember(Value = "AND")]
            AND = 3,
            /// <summary>
            /// Enum OR for value: OR
            /// </summary>
            [EnumMember(Value = "OR")]
            OR = 4,
            /// <summary>
            /// Enum NOT for value: NOT
            /// </summary>
            [EnumMember(Value = "NOT")]
            NOT = 5,
            /// <summary>
            /// Enum THE for value: THE
            /// </summary>
            [EnumMember(Value = "THE")]
            THE = 6        }
        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationEnum? Operation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Logic" /> class.
        /// </summary>
        /// <param name="operation">operation.</param>
        /// <param name="operands">operands.</param>
        /// <param name="tableName">tableName (required).</param>
        /// <param name="name">name.</param>
        public Logic(OperationEnum? operation = default(OperationEnum?), List<Clause> operands = default(List<Clause>), string tableName = default(string), string name = default(string))
        {
            // to ensure "tableName" is required (not null)
            if (tableName == null)
            {
                throw new InvalidDataException("tableName is a required property for Logic and cannot be null");
            }
            else
            {
                this.TableName = tableName;
            }
            this.Operation = operation;
            this.Operands = operands;
            this.Name = name;
        }
        

        /// <summary>
        /// Gets or Sets Operands
        /// </summary>
        [DataMember(Name="operands", EmitDefaultValue=false)]
        public List<Clause> Operands { get; set; }

        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Logic {\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Operands: ").Append(Operands).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Logic);
        }

        /// <summary>
        /// Returns true if Logic instances are equal
        /// </summary>
        /// <param name="input">Instance of Logic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Logic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Operands == input.Operands ||
                    this.Operands != null &&
                    input.Operands != null &&
                    this.Operands.SequenceEqual(input.Operands)
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Operands != null)
                    hashCode = hashCode * 59 + this.Operands.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
