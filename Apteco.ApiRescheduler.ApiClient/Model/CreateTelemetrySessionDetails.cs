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
    /// CreateTelemetrySessionDetails
    /// </summary>
    [DataContract]
        public partial class CreateTelemetrySessionDetails :  IEquatable<CreateTelemetrySessionDetails>
    {
        /// <summary>
        /// The client type for this telemetry session
        /// </summary>
        /// <value>The client type for this telemetry session</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ClientTypeEnum
        {
            /// <summary>
            /// Enum Orbit for value: Orbit
            /// </summary>
            [EnumMember(Value = "Orbit")]
            Orbit = 1        }
        /// <summary>
        /// The client type for this telemetry session
        /// </summary>
        /// <value>The client type for this telemetry session</value>
        [DataMember(Name="clientType", EmitDefaultValue=false)]
        public ClientTypeEnum ClientType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTelemetrySessionDetails" /> class.
        /// </summary>
        /// <param name="clientType">The client type for this telemetry session (required).</param>
        /// <param name="clientVersion">The client version for this telemetry session.</param>
        /// <param name="userAgentDetails">The user agent details for this telemetry session.</param>
        public CreateTelemetrySessionDetails(ClientTypeEnum clientType = default(ClientTypeEnum), string clientVersion = default(string), string userAgentDetails = default(string))
        {
            // to ensure "clientType" is required (not null)
            if (clientType == null)
            {
                throw new InvalidDataException("clientType is a required property for CreateTelemetrySessionDetails and cannot be null");
            }
            else
            {
                this.ClientType = clientType;
            }
            this.ClientVersion = clientVersion;
            this.UserAgentDetails = userAgentDetails;
        }
        

        /// <summary>
        /// The client version for this telemetry session
        /// </summary>
        /// <value>The client version for this telemetry session</value>
        [DataMember(Name="clientVersion", EmitDefaultValue=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// The user agent details for this telemetry session
        /// </summary>
        /// <value>The user agent details for this telemetry session</value>
        [DataMember(Name="userAgentDetails", EmitDefaultValue=false)]
        public string UserAgentDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTelemetrySessionDetails {\n");
            sb.Append("  ClientType: ").Append(ClientType).Append("\n");
            sb.Append("  ClientVersion: ").Append(ClientVersion).Append("\n");
            sb.Append("  UserAgentDetails: ").Append(UserAgentDetails).Append("\n");
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
            return this.Equals(input as CreateTelemetrySessionDetails);
        }

        /// <summary>
        /// Returns true if CreateTelemetrySessionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTelemetrySessionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTelemetrySessionDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientType == input.ClientType ||
                    (this.ClientType != null &&
                    this.ClientType.Equals(input.ClientType))
                ) && 
                (
                    this.ClientVersion == input.ClientVersion ||
                    (this.ClientVersion != null &&
                    this.ClientVersion.Equals(input.ClientVersion))
                ) && 
                (
                    this.UserAgentDetails == input.UserAgentDetails ||
                    (this.UserAgentDetails != null &&
                    this.UserAgentDetails.Equals(input.UserAgentDetails))
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
                if (this.ClientType != null)
                    hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                if (this.ClientVersion != null)
                    hashCode = hashCode * 59 + this.ClientVersion.GetHashCode();
                if (this.UserAgentDetails != null)
                    hashCode = hashCode * 59 + this.UserAgentDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
