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
    /// Id
    /// </summary>
    [DataContract]
        public partial class Id :  IEquatable<Id>
    {
        /// <summary>
        /// Defines IdType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum IdTypeEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 2,
            /// <summary>
            /// Enum Group for value: Group
            /// </summary>
            [EnumMember(Value = "Group")]
            Group = 3,
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 4        }
        /// <summary>
        /// Gets or Sets IdType
        /// </summary>
        [DataMember(Name="idType", EmitDefaultValue=false)]
        public IdTypeEnum IdType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Id" /> class.
        /// </summary>
        /// <param name="idType">idType (required).</param>
        /// <param name="idValue">idValue (required).</param>
        public Id(IdTypeEnum idType = default(IdTypeEnum), int? idValue = default(int?))
        {
            // to ensure "idType" is required (not null)
            if (idType == null)
            {
                throw new InvalidDataException("idType is a required property for Id and cannot be null");
            }
            else
            {
                this.IdType = idType;
            }
            // to ensure "idValue" is required (not null)
            if (idValue == null)
            {
                throw new InvalidDataException("idValue is a required property for Id and cannot be null");
            }
            else
            {
                this.IdValue = idValue;
            }
        }
        

        /// <summary>
        /// Gets or Sets IdValue
        /// </summary>
        [DataMember(Name="idValue", EmitDefaultValue=false)]
        public int? IdValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Id {\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
            sb.Append("  IdValue: ").Append(IdValue).Append("\n");
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
            return this.Equals(input as Id);
        }

        /// <summary>
        /// Returns true if Id instances are equal
        /// </summary>
        /// <param name="input">Instance of Id to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Id input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdType == input.IdType ||
                    (this.IdType != null &&
                    this.IdType.Equals(input.IdType))
                ) && 
                (
                    this.IdValue == input.IdValue ||
                    (this.IdValue != null &&
                    this.IdValue.Equals(input.IdValue))
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
                if (this.IdType != null)
                    hashCode = hashCode * 59 + this.IdType.GetHashCode();
                if (this.IdValue != null)
                    hashCode = hashCode * 59 + this.IdValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
