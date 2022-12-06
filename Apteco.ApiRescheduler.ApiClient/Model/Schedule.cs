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
    /// Details for a schedule
    /// </summary>
    [DataContract]
        public partial class Schedule :  IEquatable<Schedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Schedule" /> class.
        /// </summary>
        /// <param name="nullSchedule">nullSchedule.</param>
        /// <param name="scheduleInDays">scheduleInDays.</param>
        /// <param name="scheduleInEvent">scheduleInEvent.</param>
        /// <param name="scheduleInEventAsSoonAsPossible">scheduleInEventAsSoonAsPossible.</param>
        /// <param name="scheduleInEventResponsesAttributed">scheduleInEventResponsesAttributed.</param>
        /// <param name="scheduleInEventWhenIdle">scheduleInEventWhenIdle.</param>
        /// <param name="scheduleInEventWhenReady">scheduleInEventWhenReady.</param>
        /// <param name="scheduleInMinutes">scheduleInMinutes.</param>
        /// <param name="scheduleInMonths">scheduleInMonths.</param>
        /// <param name="scheduleInSingleInstance">scheduleInSingleInstance.</param>
        /// <param name="scheduleInWeeks">scheduleInWeeks.</param>
        /// <param name="scheduleInYears">scheduleInYears.</param>
        public Schedule(NullSchedule nullSchedule = default(NullSchedule), ScheduleInDays scheduleInDays = default(ScheduleInDays), ScheduleInEvent scheduleInEvent = default(ScheduleInEvent), ScheduleInEventAsSoonAsPossible scheduleInEventAsSoonAsPossible = default(ScheduleInEventAsSoonAsPossible), ScheduleInEventResponsesAttributed scheduleInEventResponsesAttributed = default(ScheduleInEventResponsesAttributed), ScheduleInEventWhenIdle scheduleInEventWhenIdle = default(ScheduleInEventWhenIdle), ScheduleInEventWhenReady scheduleInEventWhenReady = default(ScheduleInEventWhenReady), ScheduleInMinutes scheduleInMinutes = default(ScheduleInMinutes), ScheduleInMonths scheduleInMonths = default(ScheduleInMonths), ScheduleInSingleInstance scheduleInSingleInstance = default(ScheduleInSingleInstance), ScheduleInWeeks scheduleInWeeks = default(ScheduleInWeeks), ScheduleInYears scheduleInYears = default(ScheduleInYears))
        {
            this.NullSchedule = nullSchedule;
            this.ScheduleInDays = scheduleInDays;
            this.ScheduleInEvent = scheduleInEvent;
            this.ScheduleInEventAsSoonAsPossible = scheduleInEventAsSoonAsPossible;
            this.ScheduleInEventResponsesAttributed = scheduleInEventResponsesAttributed;
            this.ScheduleInEventWhenIdle = scheduleInEventWhenIdle;
            this.ScheduleInEventWhenReady = scheduleInEventWhenReady;
            this.ScheduleInMinutes = scheduleInMinutes;
            this.ScheduleInMonths = scheduleInMonths;
            this.ScheduleInSingleInstance = scheduleInSingleInstance;
            this.ScheduleInWeeks = scheduleInWeeks;
            this.ScheduleInYears = scheduleInYears;
        }
        
        /// <summary>
        /// Gets or Sets NullSchedule
        /// </summary>
        [DataMember(Name="nullSchedule", EmitDefaultValue=false)]
        public NullSchedule NullSchedule { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleInDays
        /// </summary>
        [DataMember(Name="scheduleInDays", EmitDefaultValue=false)]
        public ScheduleInDays ScheduleInDays { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleInEvent
        /// </summary>
        [DataMember(Name="scheduleInEvent", EmitDefaultValue=false)]
        public ScheduleInEvent ScheduleInEvent { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleInEventAsSoonAsPossible
        /// </summary>
        [DataMember(Name="scheduleInEventAsSoonAsPossible", EmitDefaultValue=false)]
        public ScheduleInEventAsSoonAsPossible ScheduleInEventAsSoonAsPossible { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleInEventResponsesAttributed
        /// </summary>
        [DataMember(Name="scheduleInEventResponsesAttributed", EmitDefaultValue=false)]
        public ScheduleInEventResponsesAttributed ScheduleInEventResponsesAttributed { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleInEventWhenIdle
        /// </summary>
        [DataMember(Name="scheduleInEventWhenIdle", EmitDefaultValue=false)]
        public ScheduleInEventWhenIdle ScheduleInEventWhenIdle { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleInEventWhenReady
        /// </summary>
        [DataMember(Name="scheduleInEventWhenReady", EmitDefaultValue=false)]
        public ScheduleInEventWhenReady ScheduleInEventWhenReady { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleInMinutes
        /// </summary>
        [DataMember(Name="scheduleInMinutes", EmitDefaultValue=false)]
        public ScheduleInMinutes ScheduleInMinutes { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleInMonths
        /// </summary>
        [DataMember(Name="scheduleInMonths", EmitDefaultValue=false)]
        public ScheduleInMonths ScheduleInMonths { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleInSingleInstance
        /// </summary>
        [DataMember(Name="scheduleInSingleInstance", EmitDefaultValue=false)]
        public ScheduleInSingleInstance ScheduleInSingleInstance { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleInWeeks
        /// </summary>
        [DataMember(Name="scheduleInWeeks", EmitDefaultValue=false)]
        public ScheduleInWeeks ScheduleInWeeks { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleInYears
        /// </summary>
        [DataMember(Name="scheduleInYears", EmitDefaultValue=false)]
        public ScheduleInYears ScheduleInYears { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Schedule {\n");
            sb.Append("  NullSchedule: ").Append(NullSchedule).Append("\n");
            sb.Append("  ScheduleInDays: ").Append(ScheduleInDays).Append("\n");
            sb.Append("  ScheduleInEvent: ").Append(ScheduleInEvent).Append("\n");
            sb.Append("  ScheduleInEventAsSoonAsPossible: ").Append(ScheduleInEventAsSoonAsPossible).Append("\n");
            sb.Append("  ScheduleInEventResponsesAttributed: ").Append(ScheduleInEventResponsesAttributed).Append("\n");
            sb.Append("  ScheduleInEventWhenIdle: ").Append(ScheduleInEventWhenIdle).Append("\n");
            sb.Append("  ScheduleInEventWhenReady: ").Append(ScheduleInEventWhenReady).Append("\n");
            sb.Append("  ScheduleInMinutes: ").Append(ScheduleInMinutes).Append("\n");
            sb.Append("  ScheduleInMonths: ").Append(ScheduleInMonths).Append("\n");
            sb.Append("  ScheduleInSingleInstance: ").Append(ScheduleInSingleInstance).Append("\n");
            sb.Append("  ScheduleInWeeks: ").Append(ScheduleInWeeks).Append("\n");
            sb.Append("  ScheduleInYears: ").Append(ScheduleInYears).Append("\n");
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
            return this.Equals(input as Schedule);
        }

        /// <summary>
        /// Returns true if Schedule instances are equal
        /// </summary>
        /// <param name="input">Instance of Schedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Schedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NullSchedule == input.NullSchedule ||
                    (this.NullSchedule != null &&
                    this.NullSchedule.Equals(input.NullSchedule))
                ) && 
                (
                    this.ScheduleInDays == input.ScheduleInDays ||
                    (this.ScheduleInDays != null &&
                    this.ScheduleInDays.Equals(input.ScheduleInDays))
                ) && 
                (
                    this.ScheduleInEvent == input.ScheduleInEvent ||
                    (this.ScheduleInEvent != null &&
                    this.ScheduleInEvent.Equals(input.ScheduleInEvent))
                ) && 
                (
                    this.ScheduleInEventAsSoonAsPossible == input.ScheduleInEventAsSoonAsPossible ||
                    (this.ScheduleInEventAsSoonAsPossible != null &&
                    this.ScheduleInEventAsSoonAsPossible.Equals(input.ScheduleInEventAsSoonAsPossible))
                ) && 
                (
                    this.ScheduleInEventResponsesAttributed == input.ScheduleInEventResponsesAttributed ||
                    (this.ScheduleInEventResponsesAttributed != null &&
                    this.ScheduleInEventResponsesAttributed.Equals(input.ScheduleInEventResponsesAttributed))
                ) && 
                (
                    this.ScheduleInEventWhenIdle == input.ScheduleInEventWhenIdle ||
                    (this.ScheduleInEventWhenIdle != null &&
                    this.ScheduleInEventWhenIdle.Equals(input.ScheduleInEventWhenIdle))
                ) && 
                (
                    this.ScheduleInEventWhenReady == input.ScheduleInEventWhenReady ||
                    (this.ScheduleInEventWhenReady != null &&
                    this.ScheduleInEventWhenReady.Equals(input.ScheduleInEventWhenReady))
                ) && 
                (
                    this.ScheduleInMinutes == input.ScheduleInMinutes ||
                    (this.ScheduleInMinutes != null &&
                    this.ScheduleInMinutes.Equals(input.ScheduleInMinutes))
                ) && 
                (
                    this.ScheduleInMonths == input.ScheduleInMonths ||
                    (this.ScheduleInMonths != null &&
                    this.ScheduleInMonths.Equals(input.ScheduleInMonths))
                ) && 
                (
                    this.ScheduleInSingleInstance == input.ScheduleInSingleInstance ||
                    (this.ScheduleInSingleInstance != null &&
                    this.ScheduleInSingleInstance.Equals(input.ScheduleInSingleInstance))
                ) && 
                (
                    this.ScheduleInWeeks == input.ScheduleInWeeks ||
                    (this.ScheduleInWeeks != null &&
                    this.ScheduleInWeeks.Equals(input.ScheduleInWeeks))
                ) && 
                (
                    this.ScheduleInYears == input.ScheduleInYears ||
                    (this.ScheduleInYears != null &&
                    this.ScheduleInYears.Equals(input.ScheduleInYears))
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
                if (this.NullSchedule != null)
                    hashCode = hashCode * 59 + this.NullSchedule.GetHashCode();
                if (this.ScheduleInDays != null)
                    hashCode = hashCode * 59 + this.ScheduleInDays.GetHashCode();
                if (this.ScheduleInEvent != null)
                    hashCode = hashCode * 59 + this.ScheduleInEvent.GetHashCode();
                if (this.ScheduleInEventAsSoonAsPossible != null)
                    hashCode = hashCode * 59 + this.ScheduleInEventAsSoonAsPossible.GetHashCode();
                if (this.ScheduleInEventResponsesAttributed != null)
                    hashCode = hashCode * 59 + this.ScheduleInEventResponsesAttributed.GetHashCode();
                if (this.ScheduleInEventWhenIdle != null)
                    hashCode = hashCode * 59 + this.ScheduleInEventWhenIdle.GetHashCode();
                if (this.ScheduleInEventWhenReady != null)
                    hashCode = hashCode * 59 + this.ScheduleInEventWhenReady.GetHashCode();
                if (this.ScheduleInMinutes != null)
                    hashCode = hashCode * 59 + this.ScheduleInMinutes.GetHashCode();
                if (this.ScheduleInMonths != null)
                    hashCode = hashCode * 59 + this.ScheduleInMonths.GetHashCode();
                if (this.ScheduleInSingleInstance != null)
                    hashCode = hashCode * 59 + this.ScheduleInSingleInstance.GetHashCode();
                if (this.ScheduleInWeeks != null)
                    hashCode = hashCode * 59 + this.ScheduleInWeeks.GetHashCode();
                if (this.ScheduleInYears != null)
                    hashCode = hashCode * 59 + this.ScheduleInYears.GetHashCode();
                return hashCode;
            }
        }
    }
}
