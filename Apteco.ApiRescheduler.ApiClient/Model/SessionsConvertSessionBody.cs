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
    /// SessionsConvertSessionBody
    /// </summary>
    [DataContract]
        public partial class SessionsConvertSessionBody :  IEquatable<SessionsConvertSessionBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsConvertSessionBody" /> class.
        /// </summary>
        /// <param name="sessionId">An existing valid session id (required).</param>
        public SessionsConvertSessionBody(string sessionId = default(string))
        {
            // to ensure "sessionId" is required (not null)
            if (sessionId == null)
            {
                throw new InvalidDataException("sessionId is a required property for SessionsConvertSessionBody and cannot be null");
            }
            else
            {
                this.SessionId = sessionId;
            }
        }
        
        /// <summary>
        /// An existing valid session id
        /// </summary>
        /// <value>An existing valid session id</value>
        [DataMember(Name="SessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionsConvertSessionBody {\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
            return this.Equals(input as SessionsConvertSessionBody);
        }

        /// <summary>
        /// Returns true if SessionsConvertSessionBody instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionsConvertSessionBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionsConvertSessionBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
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
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
