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
        public partial class UserInvitationCompletionDetails :  IEquatable<UserInvitationCompletionDetails>
    {
        /// <summary>
        /// The reason for the completed invitation
        /// </summary>
        /// <value>The reason for the completed invitation</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum InvitationReasonEnum
        {
            /// <summary>
            /// Enum EnterFacebookCredentials for value: EnterFacebookCredentials
            /// </summary>
            [EnumMember(Value = "EnterFacebookCredentials")]
            EnterFacebookCredentials = 1        }
        /// <summary>
        /// The reason for the completed invitation
        /// </summary>
        /// <value>The reason for the completed invitation</value>
        [DataMember(Name="invitationReason", EmitDefaultValue=false)]
        public InvitationReasonEnum InvitationReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationCompletionDetails" /> class.
        /// </summary>
        /// <param name="invitationReason">The reason for the completed invitation (required).</param>
        public UserInvitationCompletionDetails(InvitationReasonEnum invitationReason = default(InvitationReasonEnum))
        {
            // to ensure "invitationReason" is required (not null)
            if (invitationReason == null)
            {
                throw new InvalidDataException("invitationReason is a required property for UserInvitationCompletionDetails and cannot be null");
            }
            else
            {
                this.InvitationReason = invitationReason;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInvitationCompletionDetails {\n");
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
            return this.Equals(input as UserInvitationCompletionDetails);
        }

        /// <summary>
        /// Returns true if UserInvitationCompletionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInvitationCompletionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInvitationCompletionDetails input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.InvitationReason != null)
                    hashCode = hashCode * 59 + this.InvitationReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
