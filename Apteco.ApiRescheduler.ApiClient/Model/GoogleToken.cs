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
    /// GoogleToken
    /// </summary>
    [DataContract]
        public partial class GoogleToken :  IEquatable<GoogleToken>
    {
        /// <summary>
        /// Defines GoogleEntityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum GoogleEntityTypeEnum
        {
            /// <summary>
            /// Enum App for value: App
            /// </summary>
            [EnumMember(Value = "App")]
            App = 1,
            /// <summary>
            /// Enum Account for value: Account
            /// </summary>
            [EnumMember(Value = "Account")]
            Account = 2        }
        /// <summary>
        /// Gets or Sets GoogleEntityType
        /// </summary>
        [DataMember(Name="googleEntityType", EmitDefaultValue=false)]
        public GoogleEntityTypeEnum GoogleEntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleToken" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="googleEntityType">googleEntityType (required).</param>
        /// <param name="token">token.</param>
        /// <param name="email">email.</param>
        public GoogleToken(int? id = default(int?), GoogleEntityTypeEnum googleEntityType = default(GoogleEntityTypeEnum), string token = default(string), string email = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GoogleToken and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "googleEntityType" is required (not null)
            if (googleEntityType == null)
            {
                throw new InvalidDataException("googleEntityType is a required property for GoogleToken and cannot be null");
            }
            else
            {
                this.GoogleEntityType = googleEntityType;
            }
            this.Token = token;
            this.Email = email;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleToken {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GoogleEntityType: ").Append(GoogleEntityType).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as GoogleToken);
        }

        /// <summary>
        /// Returns true if GoogleToken instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleToken input)
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
                    this.GoogleEntityType == input.GoogleEntityType ||
                    (this.GoogleEntityType != null &&
                    this.GoogleEntityType.Equals(input.GoogleEntityType))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.GoogleEntityType != null)
                    hashCode = hashCode * 59 + this.GoogleEntityType.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                return hashCode;
            }
        }
    }
}