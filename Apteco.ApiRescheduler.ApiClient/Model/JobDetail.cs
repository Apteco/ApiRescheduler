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
    /// Details for a job in FastStats
    /// </summary>
    [DataContract]
        public partial class JobDetail :  IEquatable<JobDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobDetail" /> class.
        /// </summary>
        /// <param name="request">The request XML for the job (required).</param>
        /// <param name="results">The results XML for the job (required).</param>
        /// <param name="id">The id of the job (required).</param>
        /// <param name="priority">The priority of the job.  The lower the number the more important the job (required).</param>
        /// <param name="state">The state of the job.  Valid values can include &#x27;cancel&#x27;, &#x27;done&#x27;, &#x27;incomplete&#x27;, &#x27;inserting&#x27; and &#x27;unassigned&#x27; (required).</param>
        /// <param name="cancelRequested">Whether this job has been asked to cancel.  If it has then acted on this request and been cancelled then the state will be set to &#x27;cancel&#x27; (required).</param>
        /// <param name="timeAdded">The date and time that the job was added to the job queue.</param>
        /// <param name="timeSent">The date and time that the job was sent from the queue to be processed.</param>
        /// <param name="timeFinished">The date and time that the job finished processing.</param>
        /// <param name="server">The hostname of the server that is processing/processed this job (required).</param>
        /// <param name="systemName">The name of the FastStats system that this job is running against (required).</param>
        /// <param name="threadNumber">The number of the thread within the FastStats Service that is running this job (required).</param>
        /// <param name="username">The name of the user that submitted this job (required).</param>
        /// <param name="jobType">The type of the job (required).</param>
        public JobDetail(string request = default(string), string results = default(string), int? id = default(int?), int? priority = default(int?), string state = default(string), bool? cancelRequested = default(bool?), DateTime? timeAdded = default(DateTime?), DateTime? timeSent = default(DateTime?), DateTime? timeFinished = default(DateTime?), string server = default(string), string systemName = default(string), int? threadNumber = default(int?), string username = default(string), string jobType = default(string))
        {
            // to ensure "request" is required (not null)
            if (request == null)
            {
                throw new InvalidDataException("request is a required property for JobDetail and cannot be null");
            }
            else
            {
                this.Request = request;
            }
            // to ensure "results" is required (not null)
            if (results == null)
            {
                throw new InvalidDataException("results is a required property for JobDetail and cannot be null");
            }
            else
            {
                this.Results = results;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for JobDetail and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "priority" is required (not null)
            if (priority == null)
            {
                throw new InvalidDataException("priority is a required property for JobDetail and cannot be null");
            }
            else
            {
                this.Priority = priority;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for JobDetail and cannot be null");
            }
            else
            {
                this.State = state;
            }
            // to ensure "cancelRequested" is required (not null)
            if (cancelRequested == null)
            {
                throw new InvalidDataException("cancelRequested is a required property for JobDetail and cannot be null");
            }
            else
            {
                this.CancelRequested = cancelRequested;
            }
            // to ensure "server" is required (not null)
            if (server == null)
            {
                throw new InvalidDataException("server is a required property for JobDetail and cannot be null");
            }
            else
            {
                this.Server = server;
            }
            // to ensure "systemName" is required (not null)
            if (systemName == null)
            {
                throw new InvalidDataException("systemName is a required property for JobDetail and cannot be null");
            }
            else
            {
                this.SystemName = systemName;
            }
            // to ensure "threadNumber" is required (not null)
            if (threadNumber == null)
            {
                throw new InvalidDataException("threadNumber is a required property for JobDetail and cannot be null");
            }
            else
            {
                this.ThreadNumber = threadNumber;
            }
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for JobDetail and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            // to ensure "jobType" is required (not null)
            if (jobType == null)
            {
                throw new InvalidDataException("jobType is a required property for JobDetail and cannot be null");
            }
            else
            {
                this.JobType = jobType;
            }
            this.TimeAdded = timeAdded;
            this.TimeSent = timeSent;
            this.TimeFinished = timeFinished;
        }
        
        /// <summary>
        /// The request XML for the job
        /// </summary>
        /// <value>The request XML for the job</value>
        [DataMember(Name="request", EmitDefaultValue=false)]
        public string Request { get; set; }

        /// <summary>
        /// The results XML for the job
        /// </summary>
        /// <value>The results XML for the job</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public string Results { get; set; }

        /// <summary>
        /// The id of the job
        /// </summary>
        /// <value>The id of the job</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The priority of the job.  The lower the number the more important the job
        /// </summary>
        /// <value>The priority of the job.  The lower the number the more important the job</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The state of the job.  Valid values can include &#x27;cancel&#x27;, &#x27;done&#x27;, &#x27;incomplete&#x27;, &#x27;inserting&#x27; and &#x27;unassigned&#x27;
        /// </summary>
        /// <value>The state of the job.  Valid values can include &#x27;cancel&#x27;, &#x27;done&#x27;, &#x27;incomplete&#x27;, &#x27;inserting&#x27; and &#x27;unassigned&#x27;</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Whether this job has been asked to cancel.  If it has then acted on this request and been cancelled then the state will be set to &#x27;cancel&#x27;
        /// </summary>
        /// <value>Whether this job has been asked to cancel.  If it has then acted on this request and been cancelled then the state will be set to &#x27;cancel&#x27;</value>
        [DataMember(Name="cancelRequested", EmitDefaultValue=false)]
        public bool? CancelRequested { get; set; }

        /// <summary>
        /// The date and time that the job was added to the job queue
        /// </summary>
        /// <value>The date and time that the job was added to the job queue</value>
        [DataMember(Name="timeAdded", EmitDefaultValue=false)]
        public DateTime? TimeAdded { get; set; }

        /// <summary>
        /// The date and time that the job was sent from the queue to be processed
        /// </summary>
        /// <value>The date and time that the job was sent from the queue to be processed</value>
        [DataMember(Name="timeSent", EmitDefaultValue=false)]
        public DateTime? TimeSent { get; set; }

        /// <summary>
        /// The date and time that the job finished processing
        /// </summary>
        /// <value>The date and time that the job finished processing</value>
        [DataMember(Name="timeFinished", EmitDefaultValue=false)]
        public DateTime? TimeFinished { get; set; }

        /// <summary>
        /// The hostname of the server that is processing/processed this job
        /// </summary>
        /// <value>The hostname of the server that is processing/processed this job</value>
        [DataMember(Name="server", EmitDefaultValue=false)]
        public string Server { get; set; }

        /// <summary>
        /// The name of the FastStats system that this job is running against
        /// </summary>
        /// <value>The name of the FastStats system that this job is running against</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// The number of the thread within the FastStats Service that is running this job
        /// </summary>
        /// <value>The number of the thread within the FastStats Service that is running this job</value>
        [DataMember(Name="threadNumber", EmitDefaultValue=false)]
        public int? ThreadNumber { get; set; }

        /// <summary>
        /// The name of the user that submitted this job
        /// </summary>
        /// <value>The name of the user that submitted this job</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The type of the job
        /// </summary>
        /// <value>The type of the job</value>
        [DataMember(Name="jobType", EmitDefaultValue=false)]
        public string JobType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobDetail {\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CancelRequested: ").Append(CancelRequested).Append("\n");
            sb.Append("  TimeAdded: ").Append(TimeAdded).Append("\n");
            sb.Append("  TimeSent: ").Append(TimeSent).Append("\n");
            sb.Append("  TimeFinished: ").Append(TimeFinished).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  ThreadNumber: ").Append(ThreadNumber).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  JobType: ").Append(JobType).Append("\n");
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
            return this.Equals(input as JobDetail);
        }

        /// <summary>
        /// Returns true if JobDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of JobDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.Results == input.Results ||
                    (this.Results != null &&
                    this.Results.Equals(input.Results))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.CancelRequested == input.CancelRequested ||
                    (this.CancelRequested != null &&
                    this.CancelRequested.Equals(input.CancelRequested))
                ) && 
                (
                    this.TimeAdded == input.TimeAdded ||
                    (this.TimeAdded != null &&
                    this.TimeAdded.Equals(input.TimeAdded))
                ) && 
                (
                    this.TimeSent == input.TimeSent ||
                    (this.TimeSent != null &&
                    this.TimeSent.Equals(input.TimeSent))
                ) && 
                (
                    this.TimeFinished == input.TimeFinished ||
                    (this.TimeFinished != null &&
                    this.TimeFinished.Equals(input.TimeFinished))
                ) && 
                (
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.ThreadNumber == input.ThreadNumber ||
                    (this.ThreadNumber != null &&
                    this.ThreadNumber.Equals(input.ThreadNumber))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.JobType == input.JobType ||
                    (this.JobType != null &&
                    this.JobType.Equals(input.JobType))
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
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CancelRequested != null)
                    hashCode = hashCode * 59 + this.CancelRequested.GetHashCode();
                if (this.TimeAdded != null)
                    hashCode = hashCode * 59 + this.TimeAdded.GetHashCode();
                if (this.TimeSent != null)
                    hashCode = hashCode * 59 + this.TimeSent.GetHashCode();
                if (this.TimeFinished != null)
                    hashCode = hashCode * 59 + this.TimeFinished.GetHashCode();
                if (this.Server != null)
                    hashCode = hashCode * 59 + this.Server.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.ThreadNumber != null)
                    hashCode = hashCode * 59 + this.ThreadNumber.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.JobType != null)
                    hashCode = hashCode * 59 + this.JobType.GetHashCode();
                return hashCode;
            }
        }
    }
}
