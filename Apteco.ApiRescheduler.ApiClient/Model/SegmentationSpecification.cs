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
    /// The details needed for specifying a segmentation dashboard item
    /// </summary>
    [DataContract]
        public partial class SegmentationSpecification :  IEquatable<SegmentationSpecification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentationSpecification" /> class.
        /// </summary>
        /// <param name="segments">The list of segments to do the segmentation.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="migrationStartDateTime">The start date time of the segmentation migration report.</param>
        /// <param name="migrationEndDateTime">The end date time of the segmentation migration report.</param>
        public SegmentationSpecification(List<SegmentationSelection> segments = default(List<SegmentationSelection>), Schedule schedule = default(Schedule), DateTime? migrationStartDateTime = default(DateTime?), DateTime? migrationEndDateTime = default(DateTime?))
        {
            this.Segments = segments;
            this.Schedule = schedule;
            this.MigrationStartDateTime = migrationStartDateTime;
            this.MigrationEndDateTime = migrationEndDateTime;
        }
        
        /// <summary>
        /// The list of segments to do the segmentation
        /// </summary>
        /// <value>The list of segments to do the segmentation</value>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public List<SegmentationSelection> Segments { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// The start date time of the segmentation migration report
        /// </summary>
        /// <value>The start date time of the segmentation migration report</value>
        [DataMember(Name="migrationStartDateTime", EmitDefaultValue=false)]
        public DateTime? MigrationStartDateTime { get; set; }

        /// <summary>
        /// The end date time of the segmentation migration report
        /// </summary>
        /// <value>The end date time of the segmentation migration report</value>
        [DataMember(Name="migrationEndDateTime", EmitDefaultValue=false)]
        public DateTime? MigrationEndDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegmentationSpecification {\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  MigrationStartDateTime: ").Append(MigrationStartDateTime).Append("\n");
            sb.Append("  MigrationEndDateTime: ").Append(MigrationEndDateTime).Append("\n");
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
            return this.Equals(input as SegmentationSpecification);
        }

        /// <summary>
        /// Returns true if SegmentationSpecification instances are equal
        /// </summary>
        /// <param name="input">Instance of SegmentationSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SegmentationSpecification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Segments == input.Segments ||
                    this.Segments != null &&
                    input.Segments != null &&
                    this.Segments.SequenceEqual(input.Segments)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.MigrationStartDateTime == input.MigrationStartDateTime ||
                    (this.MigrationStartDateTime != null &&
                    this.MigrationStartDateTime.Equals(input.MigrationStartDateTime))
                ) && 
                (
                    this.MigrationEndDateTime == input.MigrationEndDateTime ||
                    (this.MigrationEndDateTime != null &&
                    this.MigrationEndDateTime.Equals(input.MigrationEndDateTime))
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
                if (this.Segments != null)
                    hashCode = hashCode * 59 + this.Segments.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.MigrationStartDateTime != null)
                    hashCode = hashCode * 59 + this.MigrationStartDateTime.GetHashCode();
                if (this.MigrationEndDateTime != null)
                    hashCode = hashCode * 59 + this.MigrationEndDateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
