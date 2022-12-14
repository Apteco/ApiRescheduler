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
    /// More detailed information on how a licence has been applied to a particular user
    /// </summary>
    [DataContract]
        public partial class LicensedUserDetail :  IEquatable<LicensedUserDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensedUserDetail" /> class.
        /// </summary>
        /// <param name="bundles">The list of bundles applied to the user (required).</param>
        /// <param name="id">The id of the user (required).</param>
        /// <param name="username">The name of the user (required).</param>
        /// <param name="licenceId">The id of the licence that this user is applied to (required).</param>
        public LicensedUserDetail(List<UserBundleDetail> bundles = default(List<UserBundleDetail>), int? id = default(int?), string username = default(string), int? licenceId = default(int?))
        {
            // to ensure "bundles" is required (not null)
            if (bundles == null)
            {
                throw new InvalidDataException("bundles is a required property for LicensedUserDetail and cannot be null");
            }
            else
            {
                this.Bundles = bundles;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for LicensedUserDetail and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for LicensedUserDetail and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            // to ensure "licenceId" is required (not null)
            if (licenceId == null)
            {
                throw new InvalidDataException("licenceId is a required property for LicensedUserDetail and cannot be null");
            }
            else
            {
                this.LicenceId = licenceId;
            }
        }
        
        /// <summary>
        /// The list of bundles applied to the user
        /// </summary>
        /// <value>The list of bundles applied to the user</value>
        [DataMember(Name="bundles", EmitDefaultValue=false)]
        public List<UserBundleDetail> Bundles { get; set; }

        /// <summary>
        /// The id of the user
        /// </summary>
        /// <value>The id of the user</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the user
        /// </summary>
        /// <value>The name of the user</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The id of the licence that this user is applied to
        /// </summary>
        /// <value>The id of the licence that this user is applied to</value>
        [DataMember(Name="licenceId", EmitDefaultValue=false)]
        public int? LicenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicensedUserDetail {\n");
            sb.Append("  Bundles: ").Append(Bundles).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  LicenceId: ").Append(LicenceId).Append("\n");
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
            return this.Equals(input as LicensedUserDetail);
        }

        /// <summary>
        /// Returns true if LicensedUserDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensedUserDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensedUserDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bundles == input.Bundles ||
                    this.Bundles != null &&
                    input.Bundles != null &&
                    this.Bundles.SequenceEqual(input.Bundles)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.LicenceId == input.LicenceId ||
                    (this.LicenceId != null &&
                    this.LicenceId.Equals(input.LicenceId))
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
                if (this.Bundles != null)
                    hashCode = hashCode * 59 + this.Bundles.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.LicenceId != null)
                    hashCode = hashCode * 59 + this.LicenceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
