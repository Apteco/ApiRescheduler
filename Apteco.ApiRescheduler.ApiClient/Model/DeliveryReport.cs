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
    /// Details for a PeopleStage Action Report
    /// </summary>
    [DataContract]
        public partial class DeliveryReport :  IEquatable<DeliveryReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryReport" /> class.
        /// </summary>
        /// <param name="deliveryId">The id of the delivery that generated this report (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="jobStatus">If available the status of the job in the job queue for this delivery (required).</param>
        /// <param name="numberOfRecipients">If available the number of records contained in this delivery (i.e. the number of lines in the created file or number of records uploaded to the ESP, etc.)..</param>
        /// <param name="messages">If available any messages (such as error messages) created for this delivery.</param>
        /// <param name="description">The action&#x27;s description (required).</param>
        /// <param name="campaignId">The id of the campaign that contains this action (required).</param>
        /// <param name="campaignDescription">The description of the campaign that contains this action (required).</param>
        /// <param name="elementId">If present the id of the element that triggered this action (required).</param>
        /// <param name="elementDescription">If present the description of the element that triggered this action (required).</param>
        /// <param name="timeStarted">The date and time the action started.</param>
        /// <param name="timeFinished">The date and time the action finished.</param>
        /// <param name="numberOfErrors">If available the number of errors reported for this delivery.</param>
        /// <param name="numberOfWarnings">If available the number of warnings reported for this delivery.</param>
        public DeliveryReport(int? deliveryId = default(int?), string type = default(string), string jobStatus = default(string), int? numberOfRecipients = default(int?), string messages = default(string), string description = default(string), string campaignId = default(string), string campaignDescription = default(string), string elementId = default(string), string elementDescription = default(string), DateTime? timeStarted = default(DateTime?), DateTime? timeFinished = default(DateTime?), int? numberOfErrors = default(int?), int? numberOfWarnings = default(int?))
        {
            // to ensure "deliveryId" is required (not null)
            if (deliveryId == null)
            {
                throw new InvalidDataException("deliveryId is a required property for DeliveryReport and cannot be null");
            }
            else
            {
                this.DeliveryId = deliveryId;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for DeliveryReport and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "jobStatus" is required (not null)
            if (jobStatus == null)
            {
                throw new InvalidDataException("jobStatus is a required property for DeliveryReport and cannot be null");
            }
            else
            {
                this.JobStatus = jobStatus;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for DeliveryReport and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new InvalidDataException("campaignId is a required property for DeliveryReport and cannot be null");
            }
            else
            {
                this.CampaignId = campaignId;
            }
            // to ensure "campaignDescription" is required (not null)
            if (campaignDescription == null)
            {
                throw new InvalidDataException("campaignDescription is a required property for DeliveryReport and cannot be null");
            }
            else
            {
                this.CampaignDescription = campaignDescription;
            }
            // to ensure "elementId" is required (not null)
            if (elementId == null)
            {
                throw new InvalidDataException("elementId is a required property for DeliveryReport and cannot be null");
            }
            else
            {
                this.ElementId = elementId;
            }
            // to ensure "elementDescription" is required (not null)
            if (elementDescription == null)
            {
                throw new InvalidDataException("elementDescription is a required property for DeliveryReport and cannot be null");
            }
            else
            {
                this.ElementDescription = elementDescription;
            }
            this.NumberOfRecipients = numberOfRecipients;
            this.Messages = messages;
            this.TimeStarted = timeStarted;
            this.TimeFinished = timeFinished;
            this.NumberOfErrors = numberOfErrors;
            this.NumberOfWarnings = numberOfWarnings;
        }
        
        /// <summary>
        /// The id of the delivery that generated this report
        /// </summary>
        /// <value>The id of the delivery that generated this report</value>
        [DataMember(Name="deliveryId", EmitDefaultValue=false)]
        public int? DeliveryId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// If available the status of the job in the job queue for this delivery
        /// </summary>
        /// <value>If available the status of the job in the job queue for this delivery</value>
        [DataMember(Name="jobStatus", EmitDefaultValue=false)]
        public string JobStatus { get; set; }

        /// <summary>
        /// If available the number of records contained in this delivery (i.e. the number of lines in the created file or number of records uploaded to the ESP, etc.).
        /// </summary>
        /// <value>If available the number of records contained in this delivery (i.e. the number of lines in the created file or number of records uploaded to the ESP, etc.).</value>
        [DataMember(Name="numberOfRecipients", EmitDefaultValue=false)]
        public int? NumberOfRecipients { get; set; }

        /// <summary>
        /// If available any messages (such as error messages) created for this delivery
        /// </summary>
        /// <value>If available any messages (such as error messages) created for this delivery</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public string Messages { get; set; }

        /// <summary>
        /// The action&#x27;s description
        /// </summary>
        /// <value>The action&#x27;s description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The id of the campaign that contains this action
        /// </summary>
        /// <value>The id of the campaign that contains this action</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The description of the campaign that contains this action
        /// </summary>
        /// <value>The description of the campaign that contains this action</value>
        [DataMember(Name="campaignDescription", EmitDefaultValue=false)]
        public string CampaignDescription { get; set; }

        /// <summary>
        /// If present the id of the element that triggered this action
        /// </summary>
        /// <value>If present the id of the element that triggered this action</value>
        [DataMember(Name="elementId", EmitDefaultValue=false)]
        public string ElementId { get; set; }

        /// <summary>
        /// If present the description of the element that triggered this action
        /// </summary>
        /// <value>If present the description of the element that triggered this action</value>
        [DataMember(Name="elementDescription", EmitDefaultValue=false)]
        public string ElementDescription { get; set; }

        /// <summary>
        /// The date and time the action started
        /// </summary>
        /// <value>The date and time the action started</value>
        [DataMember(Name="timeStarted", EmitDefaultValue=false)]
        public DateTime? TimeStarted { get; set; }

        /// <summary>
        /// The date and time the action finished
        /// </summary>
        /// <value>The date and time the action finished</value>
        [DataMember(Name="timeFinished", EmitDefaultValue=false)]
        public DateTime? TimeFinished { get; set; }

        /// <summary>
        /// If available the number of errors reported for this delivery
        /// </summary>
        /// <value>If available the number of errors reported for this delivery</value>
        [DataMember(Name="numberOfErrors", EmitDefaultValue=false)]
        public int? NumberOfErrors { get; set; }

        /// <summary>
        /// If available the number of warnings reported for this delivery
        /// </summary>
        /// <value>If available the number of warnings reported for this delivery</value>
        [DataMember(Name="numberOfWarnings", EmitDefaultValue=false)]
        public int? NumberOfWarnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryReport {\n");
            sb.Append("  DeliveryId: ").Append(DeliveryId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  NumberOfRecipients: ").Append(NumberOfRecipients).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CampaignDescription: ").Append(CampaignDescription).Append("\n");
            sb.Append("  ElementId: ").Append(ElementId).Append("\n");
            sb.Append("  ElementDescription: ").Append(ElementDescription).Append("\n");
            sb.Append("  TimeStarted: ").Append(TimeStarted).Append("\n");
            sb.Append("  TimeFinished: ").Append(TimeFinished).Append("\n");
            sb.Append("  NumberOfErrors: ").Append(NumberOfErrors).Append("\n");
            sb.Append("  NumberOfWarnings: ").Append(NumberOfWarnings).Append("\n");
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
            return this.Equals(input as DeliveryReport);
        }

        /// <summary>
        /// Returns true if DeliveryReport instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeliveryId == input.DeliveryId ||
                    (this.DeliveryId != null &&
                    this.DeliveryId.Equals(input.DeliveryId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.JobStatus == input.JobStatus ||
                    (this.JobStatus != null &&
                    this.JobStatus.Equals(input.JobStatus))
                ) && 
                (
                    this.NumberOfRecipients == input.NumberOfRecipients ||
                    (this.NumberOfRecipients != null &&
                    this.NumberOfRecipients.Equals(input.NumberOfRecipients))
                ) && 
                (
                    this.Messages == input.Messages ||
                    (this.Messages != null &&
                    this.Messages.Equals(input.Messages))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.CampaignDescription == input.CampaignDescription ||
                    (this.CampaignDescription != null &&
                    this.CampaignDescription.Equals(input.CampaignDescription))
                ) && 
                (
                    this.ElementId == input.ElementId ||
                    (this.ElementId != null &&
                    this.ElementId.Equals(input.ElementId))
                ) && 
                (
                    this.ElementDescription == input.ElementDescription ||
                    (this.ElementDescription != null &&
                    this.ElementDescription.Equals(input.ElementDescription))
                ) && 
                (
                    this.TimeStarted == input.TimeStarted ||
                    (this.TimeStarted != null &&
                    this.TimeStarted.Equals(input.TimeStarted))
                ) && 
                (
                    this.TimeFinished == input.TimeFinished ||
                    (this.TimeFinished != null &&
                    this.TimeFinished.Equals(input.TimeFinished))
                ) && 
                (
                    this.NumberOfErrors == input.NumberOfErrors ||
                    (this.NumberOfErrors != null &&
                    this.NumberOfErrors.Equals(input.NumberOfErrors))
                ) && 
                (
                    this.NumberOfWarnings == input.NumberOfWarnings ||
                    (this.NumberOfWarnings != null &&
                    this.NumberOfWarnings.Equals(input.NumberOfWarnings))
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
                if (this.DeliveryId != null)
                    hashCode = hashCode * 59 + this.DeliveryId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.JobStatus != null)
                    hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.NumberOfRecipients != null)
                    hashCode = hashCode * 59 + this.NumberOfRecipients.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.CampaignDescription != null)
                    hashCode = hashCode * 59 + this.CampaignDescription.GetHashCode();
                if (this.ElementId != null)
                    hashCode = hashCode * 59 + this.ElementId.GetHashCode();
                if (this.ElementDescription != null)
                    hashCode = hashCode * 59 + this.ElementDescription.GetHashCode();
                if (this.TimeStarted != null)
                    hashCode = hashCode * 59 + this.TimeStarted.GetHashCode();
                if (this.TimeFinished != null)
                    hashCode = hashCode * 59 + this.TimeFinished.GetHashCode();
                if (this.NumberOfErrors != null)
                    hashCode = hashCode * 59 + this.NumberOfErrors.GetHashCode();
                if (this.NumberOfWarnings != null)
                    hashCode = hashCode * 59 + this.NumberOfWarnings.GetHashCode();
                return hashCode;
            }
        }
    }
}
