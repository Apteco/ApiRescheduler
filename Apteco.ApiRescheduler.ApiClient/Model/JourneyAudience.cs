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
    /// JourneyAudience
    /// </summary>
    [DataContract]
        public partial class JourneyAudience :  IEquatable<JourneyAudience>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyAudience" /> class.
        /// </summary>
        /// <param name="audienceDescription">audienceDescription.</param>
        /// <param name="audienceId">audienceId.</param>
        /// <param name="includeAudiences">includeAudiences.</param>
        /// <param name="excludeAudiences">excludeAudiences.</param>
        /// <param name="limit">limit.</param>
        public JourneyAudience(string audienceDescription = default(string), string audienceId = default(string), List<JourneyAudienceSegment> includeAudiences = default(List<JourneyAudienceSegment>), List<JourneyAudienceSegment> excludeAudiences = default(List<JourneyAudienceSegment>), long? limit = default(long?))
        {
            this.AudienceDescription = audienceDescription;
            this.AudienceId = audienceId;
            this.IncludeAudiences = includeAudiences;
            this.ExcludeAudiences = excludeAudiences;
            this.Limit = limit;
        }
        
        /// <summary>
        /// Gets or Sets AudienceDescription
        /// </summary>
        [DataMember(Name="audienceDescription", EmitDefaultValue=false)]
        public string AudienceDescription { get; set; }

        /// <summary>
        /// Gets or Sets AudienceId
        /// </summary>
        [DataMember(Name="audienceId", EmitDefaultValue=false)]
        public string AudienceId { get; set; }

        /// <summary>
        /// Gets or Sets IncludeAudiences
        /// </summary>
        [DataMember(Name="includeAudiences", EmitDefaultValue=false)]
        public List<JourneyAudienceSegment> IncludeAudiences { get; set; }

        /// <summary>
        /// Gets or Sets ExcludeAudiences
        /// </summary>
        [DataMember(Name="excludeAudiences", EmitDefaultValue=false)]
        public List<JourneyAudienceSegment> ExcludeAudiences { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyAudience {\n");
            sb.Append("  AudienceDescription: ").Append(AudienceDescription).Append("\n");
            sb.Append("  AudienceId: ").Append(AudienceId).Append("\n");
            sb.Append("  IncludeAudiences: ").Append(IncludeAudiences).Append("\n");
            sb.Append("  ExcludeAudiences: ").Append(ExcludeAudiences).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as JourneyAudience);
        }

        /// <summary>
        /// Returns true if JourneyAudience instances are equal
        /// </summary>
        /// <param name="input">Instance of JourneyAudience to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyAudience input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AudienceDescription == input.AudienceDescription ||
                    (this.AudienceDescription != null &&
                    this.AudienceDescription.Equals(input.AudienceDescription))
                ) && 
                (
                    this.AudienceId == input.AudienceId ||
                    (this.AudienceId != null &&
                    this.AudienceId.Equals(input.AudienceId))
                ) && 
                (
                    this.IncludeAudiences == input.IncludeAudiences ||
                    this.IncludeAudiences != null &&
                    input.IncludeAudiences != null &&
                    this.IncludeAudiences.SequenceEqual(input.IncludeAudiences)
                ) && 
                (
                    this.ExcludeAudiences == input.ExcludeAudiences ||
                    this.ExcludeAudiences != null &&
                    input.ExcludeAudiences != null &&
                    this.ExcludeAudiences.SequenceEqual(input.ExcludeAudiences)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.AudienceDescription != null)
                    hashCode = hashCode * 59 + this.AudienceDescription.GetHashCode();
                if (this.AudienceId != null)
                    hashCode = hashCode * 59 + this.AudienceId.GetHashCode();
                if (this.IncludeAudiences != null)
                    hashCode = hashCode * 59 + this.IncludeAudiences.GetHashCode();
                if (this.ExcludeAudiences != null)
                    hashCode = hashCode * 59 + this.ExcludeAudiences.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}