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
    /// SessionsSaltedLoginBody
    /// </summary>
    [DataContract]
        public partial class SessionsSaltedLoginBody :  IEquatable<SessionsSaltedLoginBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsSaltedLoginBody" /> class.
        /// </summary>
        /// <param name="username">The username of the user (required).</param>
        /// <param name="loginSalt">The salt to use when loging in (required).</param>
        /// <param name="passwordHash">The password hash for the user.  Depending on the settings for the user this will be generated in a complicated way (required).</param>
        /// <param name="clientType">If specified, the type of client creating the session.  Otherwise a default value will be used..</param>
        public SessionsSaltedLoginBody(string username = default(string), string loginSalt = default(string), string passwordHash = default(string), string clientType = default(string))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for SessionsSaltedLoginBody and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            // to ensure "loginSalt" is required (not null)
            if (loginSalt == null)
            {
                throw new InvalidDataException("loginSalt is a required property for SessionsSaltedLoginBody and cannot be null");
            }
            else
            {
                this.LoginSalt = loginSalt;
            }
            // to ensure "passwordHash" is required (not null)
            if (passwordHash == null)
            {
                throw new InvalidDataException("passwordHash is a required property for SessionsSaltedLoginBody and cannot be null");
            }
            else
            {
                this.PasswordHash = passwordHash;
            }
            this.ClientType = clientType;
        }
        
        /// <summary>
        /// The username of the user
        /// </summary>
        /// <value>The username of the user</value>
        [DataMember(Name="Username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The salt to use when loging in
        /// </summary>
        /// <value>The salt to use when loging in</value>
        [DataMember(Name="LoginSalt", EmitDefaultValue=false)]
        public string LoginSalt { get; set; }

        /// <summary>
        /// The password hash for the user.  Depending on the settings for the user this will be generated in a complicated way
        /// </summary>
        /// <value>The password hash for the user.  Depending on the settings for the user this will be generated in a complicated way</value>
        [DataMember(Name="PasswordHash", EmitDefaultValue=false)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// If specified, the type of client creating the session.  Otherwise a default value will be used.
        /// </summary>
        /// <value>If specified, the type of client creating the session.  Otherwise a default value will be used.</value>
        [DataMember(Name="ClientType", EmitDefaultValue=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionsSaltedLoginBody {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  LoginSalt: ").Append(LoginSalt).Append("\n");
            sb.Append("  PasswordHash: ").Append(PasswordHash).Append("\n");
            sb.Append("  ClientType: ").Append(ClientType).Append("\n");
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
            return this.Equals(input as SessionsSaltedLoginBody);
        }

        /// <summary>
        /// Returns true if SessionsSaltedLoginBody instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionsSaltedLoginBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionsSaltedLoginBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.LoginSalt == input.LoginSalt ||
                    (this.LoginSalt != null &&
                    this.LoginSalt.Equals(input.LoginSalt))
                ) && 
                (
                    this.PasswordHash == input.PasswordHash ||
                    (this.PasswordHash != null &&
                    this.PasswordHash.Equals(input.PasswordHash))
                ) && 
                (
                    this.ClientType == input.ClientType ||
                    (this.ClientType != null &&
                    this.ClientType.Equals(input.ClientType))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.LoginSalt != null)
                    hashCode = hashCode * 59 + this.LoginSalt.GetHashCode();
                if (this.PasswordHash != null)
                    hashCode = hashCode * 59 + this.PasswordHash.GetHashCode();
                if (this.ClientType != null)
                    hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                return hashCode;
            }
        }
    }
}