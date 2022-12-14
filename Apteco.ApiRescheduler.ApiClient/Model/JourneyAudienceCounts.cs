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
    /// Counts for an Audience
    /// </summary>
    [DataContract]
        public partial class JourneyAudienceCounts :  IEquatable<JourneyAudienceCounts>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyAudienceCounts" /> class.
        /// </summary>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="audienceId">audienceId.</param>
        /// <param name="grossCount">grossCount.</param>
        /// <param name="nettCount">nettCount.</param>
        public JourneyAudienceCounts(string campaignId = default(string), string audienceId = default(string), long? grossCount = default(long?), long? nettCount = default(long?))
        {
            this.CampaignId = campaignId;
            this.AudienceId = audienceId;
            this.GrossCount = grossCount;
            this.NettCount = nettCount;
        }
        
        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets AudienceId
        /// </summary>
        [DataMember(Name="audienceId", EmitDefaultValue=false)]
        public string AudienceId { get; set; }

        /// <summary>
        /// Gets or Sets GrossCount
        /// </summary>
        [DataMember(Name="grossCount", EmitDefaultValue=false)]
        public long? GrossCount { get; set; }

        /// <summary>
        /// Gets or Sets NettCount
        /// </summary>
        [DataMember(Name="nettCount", EmitDefaultValue=false)]
        public long? NettCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyAudienceCounts {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  AudienceId: ").Append(AudienceId).Append("\n");
            sb.Append("  GrossCount: ").Append(GrossCount).Append("\n");
            sb.Append("  NettCount: ").Append(NettCount).Append("\n");
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
            return this.Equals(input as JourneyAudienceCounts);
        }

        /// <summary>
        /// Returns true if JourneyAudienceCounts instances are equal
        /// </summary>
        /// <param name="input">Instance of JourneyAudienceCounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyAudienceCounts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.AudienceId == input.AudienceId ||
                    (this.AudienceId != null &&
                    this.AudienceId.Equals(input.AudienceId))
                ) && 
                (
                    this.GrossCount == input.GrossCount ||
                    (this.GrossCount != null &&
                    this.GrossCount.Equals(input.GrossCount))
                ) && 
                (
                    this.NettCount == input.NettCount ||
                    (this.NettCount != null &&
                    this.NettCount.Equals(input.NettCount))
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
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.AudienceId != null)
                    hashCode = hashCode * 59 + this.AudienceId.GetHashCode();
                if (this.GrossCount != null)
                    hashCode = hashCode * 59 + this.GrossCount.GetHashCode();
                if (this.NettCount != null)
                    hashCode = hashCode * 59 + this.NettCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
