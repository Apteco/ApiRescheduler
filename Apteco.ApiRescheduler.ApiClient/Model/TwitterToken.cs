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
    /// TwitterToken
    /// </summary>
    [DataContract]
        public partial class TwitterToken :  IEquatable<TwitterToken>
    {
        /// <summary>
        /// Defines TwitterEntityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TwitterEntityTypeEnum
        {
            /// <summary>
            /// Enum App for value: App
            /// </summary>
            [EnumMember(Value = "App")]
            App = 1,
            /// <summary>
            /// Enum Handle for value: Handle
            /// </summary>
            [EnumMember(Value = "Handle")]
            Handle = 2        }
        /// <summary>
        /// Gets or Sets TwitterEntityType
        /// </summary>
        [DataMember(Name="twitterEntityType", EmitDefaultValue=false)]
        public TwitterEntityTypeEnum TwitterEntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterToken" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="twitterEntityType">twitterEntityType (required).</param>
        /// <param name="token">token.</param>
        /// <param name="tokenSecret">tokenSecret.</param>
        /// <param name="email">email.</param>
        public TwitterToken(int? id = default(int?), TwitterEntityTypeEnum twitterEntityType = default(TwitterEntityTypeEnum), string token = default(string), string tokenSecret = default(string), string email = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for TwitterToken and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "twitterEntityType" is required (not null)
            if (twitterEntityType == null)
            {
                throw new InvalidDataException("twitterEntityType is a required property for TwitterToken and cannot be null");
            }
            else
            {
                this.TwitterEntityType = twitterEntityType;
            }
            this.Token = token;
            this.TokenSecret = tokenSecret;
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
        /// Gets or Sets TokenSecret
        /// </summary>
        [DataMember(Name="tokenSecret", EmitDefaultValue=false)]
        public string TokenSecret { get; set; }

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
            sb.Append("class TwitterToken {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TwitterEntityType: ").Append(TwitterEntityType).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenSecret: ").Append(TokenSecret).Append("\n");
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
            return this.Equals(input as TwitterToken);
        }

        /// <summary>
        /// Returns true if TwitterToken instances are equal
        /// </summary>
        /// <param name="input">Instance of TwitterToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwitterToken input)
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
                    this.TwitterEntityType == input.TwitterEntityType ||
                    (this.TwitterEntityType != null &&
                    this.TwitterEntityType.Equals(input.TwitterEntityType))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.TokenSecret == input.TokenSecret ||
                    (this.TokenSecret != null &&
                    this.TokenSecret.Equals(input.TokenSecret))
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
                if (this.TwitterEntityType != null)
                    hashCode = hashCode * 59 + this.TwitterEntityType.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.TokenSecret != null)
                    hashCode = hashCode * 59 + this.TokenSecret.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                return hashCode;
            }
        }
    }
}
