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
    /// Details for a job to get data licensing sets
    /// </summary>
    [DataContract]
        public partial class LicensingSetsJobDetail :  IEquatable<LicensingSetsJobDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensingSetsJobDetail" /> class.
        /// </summary>
        /// <param name="licensingSets">If present, the end results of this job.</param>
        /// <param name="id">The job&#x27;s id (required).</param>
        /// <param name="isComplete">Whether the job is complete or not (required).</param>
        /// <param name="isCancelled">Whether the job has been cancelled or not.</param>
        /// <param name="queuePosition">If present, the position that the job is in the job queue.  Jobs only start being actively processed once they reach the head of the queue.</param>
        /// <param name="progress">If present, an estimate of how far through its processing this job is.</param>
        /// <param name="serverMessages">If present, any messages from the FastStats service related to this job.</param>
        public LicensingSetsJobDetail(List<LicensingSet> licensingSets = default(List<LicensingSet>), int? id = default(int?), bool? isComplete = default(bool?), bool? isCancelled = default(bool?), int? queuePosition = default(int?), int? progress = default(int?), List<ServerMessage> serverMessages = default(List<ServerMessage>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for LicensingSetsJobDetail and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "isComplete" is required (not null)
            if (isComplete == null)
            {
                throw new InvalidDataException("isComplete is a required property for LicensingSetsJobDetail and cannot be null");
            }
            else
            {
                this.IsComplete = isComplete;
            }
            this.LicensingSets = licensingSets;
            this.IsCancelled = isCancelled;
            this.QueuePosition = queuePosition;
            this.Progress = progress;
            this.ServerMessages = serverMessages;
        }
        
        /// <summary>
        /// If present, the end results of this job
        /// </summary>
        /// <value>If present, the end results of this job</value>
        [DataMember(Name="licensingSets", EmitDefaultValue=false)]
        public List<LicensingSet> LicensingSets { get; set; }

        /// <summary>
        /// The job&#x27;s id
        /// </summary>
        /// <value>The job&#x27;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Whether the job is complete or not
        /// </summary>
        /// <value>Whether the job is complete or not</value>
        [DataMember(Name="isComplete", EmitDefaultValue=false)]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// Whether the job has been cancelled or not
        /// </summary>
        /// <value>Whether the job has been cancelled or not</value>
        [DataMember(Name="isCancelled", EmitDefaultValue=false)]
        public bool? IsCancelled { get; set; }

        /// <summary>
        /// If present, the position that the job is in the job queue.  Jobs only start being actively processed once they reach the head of the queue
        /// </summary>
        /// <value>If present, the position that the job is in the job queue.  Jobs only start being actively processed once they reach the head of the queue</value>
        [DataMember(Name="queuePosition", EmitDefaultValue=false)]
        public int? QueuePosition { get; set; }

        /// <summary>
        /// If present, an estimate of how far through its processing this job is
        /// </summary>
        /// <value>If present, an estimate of how far through its processing this job is</value>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// If present, any messages from the FastStats service related to this job
        /// </summary>
        /// <value>If present, any messages from the FastStats service related to this job</value>
        [DataMember(Name="serverMessages", EmitDefaultValue=false)]
        public List<ServerMessage> ServerMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicensingSetsJobDetail {\n");
            sb.Append("  LicensingSets: ").Append(LicensingSets).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  IsCancelled: ").Append(IsCancelled).Append("\n");
            sb.Append("  QueuePosition: ").Append(QueuePosition).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  ServerMessages: ").Append(ServerMessages).Append("\n");
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
            return this.Equals(input as LicensingSetsJobDetail);
        }

        /// <summary>
        /// Returns true if LicensingSetsJobDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensingSetsJobDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensingSetsJobDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LicensingSets == input.LicensingSets ||
                    this.LicensingSets != null &&
                    input.LicensingSets != null &&
                    this.LicensingSets.SequenceEqual(input.LicensingSets)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsComplete == input.IsComplete ||
                    (this.IsComplete != null &&
                    this.IsComplete.Equals(input.IsComplete))
                ) && 
                (
                    this.IsCancelled == input.IsCancelled ||
                    (this.IsCancelled != null &&
                    this.IsCancelled.Equals(input.IsCancelled))
                ) && 
                (
                    this.QueuePosition == input.QueuePosition ||
                    (this.QueuePosition != null &&
                    this.QueuePosition.Equals(input.QueuePosition))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.ServerMessages == input.ServerMessages ||
                    this.ServerMessages != null &&
                    input.ServerMessages != null &&
                    this.ServerMessages.SequenceEqual(input.ServerMessages)
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
                if (this.LicensingSets != null)
                    hashCode = hashCode * 59 + this.LicensingSets.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsComplete != null)
                    hashCode = hashCode * 59 + this.IsComplete.GetHashCode();
                if (this.IsCancelled != null)
                    hashCode = hashCode * 59 + this.IsCancelled.GetHashCode();
                if (this.QueuePosition != null)
                    hashCode = hashCode * 59 + this.QueuePosition.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.ServerMessages != null)
                    hashCode = hashCode * 59 + this.ServerMessages.GetHashCode();
                return hashCode;
            }
        }
    }
}
