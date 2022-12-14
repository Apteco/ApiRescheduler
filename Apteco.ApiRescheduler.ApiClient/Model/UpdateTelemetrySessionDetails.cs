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
    /// UpdateTelemetrySessionDetails
    /// </summary>
    [DataContract]
        public partial class UpdateTelemetrySessionDetails :  IEquatable<UpdateTelemetrySessionDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTelemetrySessionDetails" /> class.
        /// </summary>
        /// <param name="sessionAttributes">The details of any session attributes in this telemetry session.</param>
        /// <param name="bugReports">The details of a bug received in this telemetry session.</param>
        /// <param name="sessionEnd">The end time for this telemetry session.</param>
        public UpdateTelemetrySessionDetails(List<TelemetrySessionAttribute> sessionAttributes = default(List<TelemetrySessionAttribute>), List<TelemetryBugReport> bugReports = default(List<TelemetryBugReport>), DateTime? sessionEnd = default(DateTime?))
        {
            this.SessionAttributes = sessionAttributes;
            this.BugReports = bugReports;
            this.SessionEnd = sessionEnd;
        }
        
        /// <summary>
        /// The details of any session attributes in this telemetry session
        /// </summary>
        /// <value>The details of any session attributes in this telemetry session</value>
        [DataMember(Name="sessionAttributes", EmitDefaultValue=false)]
        public List<TelemetrySessionAttribute> SessionAttributes { get; set; }

        /// <summary>
        /// The details of a bug received in this telemetry session
        /// </summary>
        /// <value>The details of a bug received in this telemetry session</value>
        [DataMember(Name="bugReports", EmitDefaultValue=false)]
        public List<TelemetryBugReport> BugReports { get; set; }

        /// <summary>
        /// The end time for this telemetry session
        /// </summary>
        /// <value>The end time for this telemetry session</value>
        [DataMember(Name="sessionEnd", EmitDefaultValue=false)]
        public DateTime? SessionEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTelemetrySessionDetails {\n");
            sb.Append("  SessionAttributes: ").Append(SessionAttributes).Append("\n");
            sb.Append("  BugReports: ").Append(BugReports).Append("\n");
            sb.Append("  SessionEnd: ").Append(SessionEnd).Append("\n");
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
            return this.Equals(input as UpdateTelemetrySessionDetails);
        }

        /// <summary>
        /// Returns true if UpdateTelemetrySessionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTelemetrySessionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTelemetrySessionDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionAttributes == input.SessionAttributes ||
                    this.SessionAttributes != null &&
                    input.SessionAttributes != null &&
                    this.SessionAttributes.SequenceEqual(input.SessionAttributes)
                ) && 
                (
                    this.BugReports == input.BugReports ||
                    this.BugReports != null &&
                    input.BugReports != null &&
                    this.BugReports.SequenceEqual(input.BugReports)
                ) && 
                (
                    this.SessionEnd == input.SessionEnd ||
                    (this.SessionEnd != null &&
                    this.SessionEnd.Equals(input.SessionEnd))
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
                if (this.SessionAttributes != null)
                    hashCode = hashCode * 59 + this.SessionAttributes.GetHashCode();
                if (this.BugReports != null)
                    hashCode = hashCode * 59 + this.BugReports.GetHashCode();
                if (this.SessionEnd != null)
                    hashCode = hashCode * 59 + this.SessionEnd.GetHashCode();
                return hashCode;
            }
        }
    }
}
