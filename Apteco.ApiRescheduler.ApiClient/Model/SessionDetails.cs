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
    /// The details for a newly created session
    /// </summary>
    [DataContract]
        public partial class SessionDetails :  IEquatable<SessionDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionDetails" /> class.
        /// </summary>
        /// <param name="accessToken">The access token that needs to be included when making requests that require authentication (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="sessionId">The id for this current session (required).</param>
        /// <param name="lastLogin">The last login for the user.</param>
        /// <param name="licence">licence (required).</param>
        /// <param name="passwordExpiry">Where the password is expired for the current session (required).</param>
        /// <param name="passwordManuallyExpired">Where the password is manually expired for the current session (required).</param>
        public SessionDetails(string accessToken = default(string), UserDisplayDetails user = default(UserDisplayDetails), string sessionId = default(string), DateTime? lastLogin = default(DateTime?), Licence licence = default(Licence), string passwordExpiry = default(string), bool? passwordManuallyExpired = default(bool?))
        {
            // to ensure "accessToken" is required (not null)
            if (accessToken == null)
            {
                throw new InvalidDataException("accessToken is a required property for SessionDetails and cannot be null");
            }
            else
            {
                this.AccessToken = accessToken;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for SessionDetails and cannot be null");
            }
            else
            {
                this.User = user;
            }
            // to ensure "sessionId" is required (not null)
            if (sessionId == null)
            {
                throw new InvalidDataException("sessionId is a required property for SessionDetails and cannot be null");
            }
            else
            {
                this.SessionId = sessionId;
            }
            // to ensure "licence" is required (not null)
            if (licence == null)
            {
                throw new InvalidDataException("licence is a required property for SessionDetails and cannot be null");
            }
            else
            {
                this.Licence = licence;
            }
            // to ensure "passwordExpiry" is required (not null)
            if (passwordExpiry == null)
            {
                throw new InvalidDataException("passwordExpiry is a required property for SessionDetails and cannot be null");
            }
            else
            {
                this.PasswordExpiry = passwordExpiry;
            }
            // to ensure "passwordManuallyExpired" is required (not null)
            if (passwordManuallyExpired == null)
            {
                throw new InvalidDataException("passwordManuallyExpired is a required property for SessionDetails and cannot be null");
            }
            else
            {
                this.PasswordManuallyExpired = passwordManuallyExpired;
            }
            this.LastLogin = lastLogin;
        }
        
        /// <summary>
        /// The access token that needs to be included when making requests that require authentication
        /// </summary>
        /// <value>The access token that needs to be included when making requests that require authentication</value>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserDisplayDetails User { get; set; }

        /// <summary>
        /// The id for this current session
        /// </summary>
        /// <value>The id for this current session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// The last login for the user
        /// </summary>
        /// <value>The last login for the user</value>
        [DataMember(Name="lastLogin", EmitDefaultValue=false)]
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// Gets or Sets Licence
        /// </summary>
        [DataMember(Name="licence", EmitDefaultValue=false)]
        public Licence Licence { get; set; }

        /// <summary>
        /// Where the password is expired for the current session
        /// </summary>
        /// <value>Where the password is expired for the current session</value>
        [DataMember(Name="passwordExpiry", EmitDefaultValue=false)]
        public string PasswordExpiry { get; set; }

        /// <summary>
        /// Where the password is manually expired for the current session
        /// </summary>
        /// <value>Where the password is manually expired for the current session</value>
        [DataMember(Name="passwordManuallyExpired", EmitDefaultValue=false)]
        public bool? PasswordManuallyExpired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionDetails {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  Licence: ").Append(Licence).Append("\n");
            sb.Append("  PasswordExpiry: ").Append(PasswordExpiry).Append("\n");
            sb.Append("  PasswordManuallyExpired: ").Append(PasswordManuallyExpired).Append("\n");
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
            return this.Equals(input as SessionDetails);
        }

        /// <summary>
        /// Returns true if SessionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.Licence == input.Licence ||
                    (this.Licence != null &&
                    this.Licence.Equals(input.Licence))
                ) && 
                (
                    this.PasswordExpiry == input.PasswordExpiry ||
                    (this.PasswordExpiry != null &&
                    this.PasswordExpiry.Equals(input.PasswordExpiry))
                ) && 
                (
                    this.PasswordManuallyExpired == input.PasswordManuallyExpired ||
                    (this.PasswordManuallyExpired != null &&
                    this.PasswordManuallyExpired.Equals(input.PasswordManuallyExpired))
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.LastLogin != null)
                    hashCode = hashCode * 59 + this.LastLogin.GetHashCode();
                if (this.Licence != null)
                    hashCode = hashCode * 59 + this.Licence.GetHashCode();
                if (this.PasswordExpiry != null)
                    hashCode = hashCode * 59 + this.PasswordExpiry.GetHashCode();
                if (this.PasswordManuallyExpired != null)
                    hashCode = hashCode * 59 + this.PasswordManuallyExpired.GetHashCode();
                return hashCode;
            }
        }
    }
}