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
    /// FacebookEntity
    /// </summary>
    [DataContract]
        public partial class FacebookEntity :  IEquatable<FacebookEntity>
    {
        /// <summary>
        /// Defines FacebookEntityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FacebookEntityTypeEnum
        {
            /// <summary>
            /// Enum App for value: App
            /// </summary>
            [EnumMember(Value = "App")]
            App = 1,
            /// <summary>
            /// Enum Page for value: Page
            /// </summary>
            [EnumMember(Value = "Page")]
            Page = 2        }
        /// <summary>
        /// Gets or Sets FacebookEntityType
        /// </summary>
        [DataMember(Name="facebookEntityType", EmitDefaultValue=false)]
        public FacebookEntityTypeEnum FacebookEntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookEntity" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="facebookEntityType">facebookEntityType (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="permissions">permissions (required).</param>
        /// <param name="valid">valid (required).</param>
        /// <param name="appId">appId (required).</param>
        /// <param name="email">email.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="scope">scope.</param>
        /// <param name="userId">userId (required).</param>
        public FacebookEntity(int? id = default(int?), FacebookEntityTypeEnum facebookEntityType = default(FacebookEntityTypeEnum), string name = default(string), List<string> permissions = default(List<string>), bool? valid = default(bool?), int? appId = default(int?), string email = default(string), string externalId = default(string), string scope = default(string), int? userId = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for FacebookEntity and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "facebookEntityType" is required (not null)
            if (facebookEntityType == null)
            {
                throw new InvalidDataException("facebookEntityType is a required property for FacebookEntity and cannot be null");
            }
            else
            {
                this.FacebookEntityType = facebookEntityType;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for FacebookEntity and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "permissions" is required (not null)
            if (permissions == null)
            {
                throw new InvalidDataException("permissions is a required property for FacebookEntity and cannot be null");
            }
            else
            {
                this.Permissions = permissions;
            }
            // to ensure "valid" is required (not null)
            if (valid == null)
            {
                throw new InvalidDataException("valid is a required property for FacebookEntity and cannot be null");
            }
            else
            {
                this.Valid = valid;
            }
            // to ensure "appId" is required (not null)
            if (appId == null)
            {
                throw new InvalidDataException("appId is a required property for FacebookEntity and cannot be null");
            }
            else
            {
                this.AppId = appId;
            }
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for FacebookEntity and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            this.Email = email;
            this.ExternalId = externalId;
            this.Scope = scope;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Gets or Sets Valid
        /// </summary>
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public bool? Valid { get; set; }

        /// <summary>
        /// Gets or Sets AppId
        /// </summary>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public int? AppId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacebookEntity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FacebookEntityType: ").Append(FacebookEntityType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as FacebookEntity);
        }

        /// <summary>
        /// Returns true if FacebookEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of FacebookEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacebookEntity input)
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
                    this.FacebookEntityType == input.FacebookEntityType ||
                    (this.FacebookEntityType != null &&
                    this.FacebookEntityType.Equals(input.FacebookEntityType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.Valid == input.Valid ||
                    (this.Valid != null &&
                    this.Valid.Equals(input.Valid))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.FacebookEntityType != null)
                    hashCode = hashCode * 59 + this.FacebookEntityType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Valid != null)
                    hashCode = hashCode * 59 + this.Valid.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }
    }
}