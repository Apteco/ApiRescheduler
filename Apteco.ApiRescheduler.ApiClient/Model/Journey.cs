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
    /// Journey
    /// </summary>
    [DataContract]
        public partial class Journey :  IEquatable<Journey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Journey" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="unsupportedJourney">unsupportedJourney.</param>
        /// <param name="audience">audience.</param>
        /// <param name="message">message.</param>
        /// <param name="schedule">schedule.</param>
        public Journey(string description = default(string), bool? unsupportedJourney = default(bool?), JourneyAudience audience = default(JourneyAudience), JourneyMessage message = default(JourneyMessage), Schedule schedule = default(Schedule))
        {
            this.Description = description;
            this.UnsupportedJourney = unsupportedJourney;
            this.Audience = audience;
            this.Message = message;
            this.Schedule = schedule;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets UnsupportedJourney
        /// </summary>
        [DataMember(Name="unsupportedJourney", EmitDefaultValue=false)]
        public bool? UnsupportedJourney { get; set; }

        /// <summary>
        /// Gets or Sets Audience
        /// </summary>
        [DataMember(Name="audience", EmitDefaultValue=false)]
        public JourneyAudience Audience { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public JourneyMessage Message { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Journey {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnsupportedJourney: ").Append(UnsupportedJourney).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(input as Journey);
        }

        /// <summary>
        /// Returns true if Journey instances are equal
        /// </summary>
        /// <param name="input">Instance of Journey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Journey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UnsupportedJourney == input.UnsupportedJourney ||
                    (this.UnsupportedJourney != null &&
                    this.UnsupportedJourney.Equals(input.UnsupportedJourney))
                ) && 
                (
                    this.Audience == input.Audience ||
                    (this.Audience != null &&
                    this.Audience.Equals(input.Audience))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UnsupportedJourney != null)
                    hashCode = hashCode * 59 + this.UnsupportedJourney.GetHashCode();
                if (this.Audience != null)
                    hashCode = hashCode * 59 + this.Audience.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                return hashCode;
            }
        }
    }
}
