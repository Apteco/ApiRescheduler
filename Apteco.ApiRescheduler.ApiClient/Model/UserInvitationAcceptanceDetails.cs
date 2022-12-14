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
    /// Information
    /// </summary>
    [DataContract]
        public partial class UserInvitationAcceptanceDetails :  IEquatable<UserInvitationAcceptanceDetails>
    {
        /// <summary>
        /// The reason for the accepted invitation
        /// </summary>
        /// <value>The reason for the accepted invitation</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum InvitationReasonEnum
        {
            /// <summary>
            /// Enum EnterFacebookCredentials for value: EnterFacebookCredentials
            /// </summary>
            [EnumMember(Value = "EnterFacebookCredentials")]
            EnterFacebookCredentials = 1        }
        /// <summary>
        /// The reason for the accepted invitation
        /// </summary>
        /// <value>The reason for the accepted invitation</value>
        [DataMember(Name="invitationReason", EmitDefaultValue=false)]
        public InvitationReasonEnum InvitationReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationAcceptanceDetails" /> class.
        /// </summary>
        /// <param name="userExists">The invited user already exists in the given DataView (required).</param>
        /// <param name="invitationReason">The reason for the accepted invitation (required).</param>
        public UserInvitationAcceptanceDetails(bool? userExists = default(bool?), InvitationReasonEnum invitationReason = default(InvitationReasonEnum))
        {
            // to ensure "userExists" is required (not null)
            if (userExists == null)
            {
                throw new InvalidDataException("userExists is a required property for UserInvitationAcceptanceDetails and cannot be null");
            }
            else
            {
                this.UserExists = userExists;
            }
            // to ensure "invitationReason" is required (not null)
            if (invitationReason == null)
            {
                throw new InvalidDataException("invitationReason is a required property for UserInvitationAcceptanceDetails and cannot be null");
            }
            else
            {
                this.InvitationReason = invitationReason;
            }
        }
        
        /// <summary>
        /// The invited user already exists in the given DataView
        /// </summary>
        /// <value>The invited user already exists in the given DataView</value>
        [DataMember(Name="userExists", EmitDefaultValue=false)]
        public bool? UserExists { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInvitationAcceptanceDetails {\n");
            sb.Append("  UserExists: ").Append(UserExists).Append("\n");
            sb.Append("  InvitationReason: ").Append(InvitationReason).Append("\n");
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
            return this.Equals(input as UserInvitationAcceptanceDetails);
        }

        /// <summary>
        /// Returns true if UserInvitationAcceptanceDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInvitationAcceptanceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInvitationAcceptanceDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserExists == input.UserExists ||
                    (this.UserExists != null &&
                    this.UserExists.Equals(input.UserExists))
                ) && 
                (
                    this.InvitationReason == input.InvitationReason ||
                    (this.InvitationReason != null &&
                    this.InvitationReason.Equals(input.InvitationReason))
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
                if (this.UserExists != null)
                    hashCode = hashCode * 59 + this.UserExists.GetHashCode();
                if (this.InvitationReason != null)
                    hashCode = hashCode * 59 + this.InvitationReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
