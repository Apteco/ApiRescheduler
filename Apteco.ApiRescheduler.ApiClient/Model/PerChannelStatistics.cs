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
    /// Per-channel communication and cost data
    /// </summary>
    [DataContract]
        public partial class PerChannelStatistics :  IEquatable<PerChannelStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerChannelStatistics" /> class.
        /// </summary>
        /// <param name="communicationsCounts">The set of counts representing the number of communications for the corresponding channel.  The first figure is data for the first day in the days list in the parent object, and so on. (required).</param>
        /// <param name="costs">The set of figures representing the total cost for the corresponding channel.  The first figure is data for the first day in the days list in the parent object, and so on. (required).</param>
        /// <param name="totalCommunicationsCount">The total number of communications (required).</param>
        /// <param name="totalCost">The total cost (required).</param>
        public PerChannelStatistics(List<long?> communicationsCounts = default(List<long?>), List<double?> costs = default(List<double?>), long? totalCommunicationsCount = default(long?), double? totalCost = default(double?))
        {
            // to ensure "communicationsCounts" is required (not null)
            if (communicationsCounts == null)
            {
                throw new InvalidDataException("communicationsCounts is a required property for PerChannelStatistics and cannot be null");
            }
            else
            {
                this.CommunicationsCounts = communicationsCounts;
            }
            // to ensure "costs" is required (not null)
            if (costs == null)
            {
                throw new InvalidDataException("costs is a required property for PerChannelStatistics and cannot be null");
            }
            else
            {
                this.Costs = costs;
            }
            // to ensure "totalCommunicationsCount" is required (not null)
            if (totalCommunicationsCount == null)
            {
                throw new InvalidDataException("totalCommunicationsCount is a required property for PerChannelStatistics and cannot be null");
            }
            else
            {
                this.TotalCommunicationsCount = totalCommunicationsCount;
            }
            // to ensure "totalCost" is required (not null)
            if (totalCost == null)
            {
                throw new InvalidDataException("totalCost is a required property for PerChannelStatistics and cannot be null");
            }
            else
            {
                this.TotalCost = totalCost;
            }
        }
        
        /// <summary>
        /// The set of counts representing the number of communications for the corresponding channel.  The first figure is data for the first day in the days list in the parent object, and so on.
        /// </summary>
        /// <value>The set of counts representing the number of communications for the corresponding channel.  The first figure is data for the first day in the days list in the parent object, and so on.</value>
        [DataMember(Name="communicationsCounts", EmitDefaultValue=false)]
        public List<long?> CommunicationsCounts { get; set; }

        /// <summary>
        /// The set of figures representing the total cost for the corresponding channel.  The first figure is data for the first day in the days list in the parent object, and so on.
        /// </summary>
        /// <value>The set of figures representing the total cost for the corresponding channel.  The first figure is data for the first day in the days list in the parent object, and so on.</value>
        [DataMember(Name="costs", EmitDefaultValue=false)]
        public List<double?> Costs { get; set; }

        /// <summary>
        /// The total number of communications
        /// </summary>
        /// <value>The total number of communications</value>
        [DataMember(Name="totalCommunicationsCount", EmitDefaultValue=false)]
        public long? TotalCommunicationsCount { get; set; }

        /// <summary>
        /// The total cost
        /// </summary>
        /// <value>The total cost</value>
        [DataMember(Name="totalCost", EmitDefaultValue=false)]
        public double? TotalCost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerChannelStatistics {\n");
            sb.Append("  CommunicationsCounts: ").Append(CommunicationsCounts).Append("\n");
            sb.Append("  Costs: ").Append(Costs).Append("\n");
            sb.Append("  TotalCommunicationsCount: ").Append(TotalCommunicationsCount).Append("\n");
            sb.Append("  TotalCost: ").Append(TotalCost).Append("\n");
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
            return this.Equals(input as PerChannelStatistics);
        }

        /// <summary>
        /// Returns true if PerChannelStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of PerChannelStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerChannelStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommunicationsCounts == input.CommunicationsCounts ||
                    this.CommunicationsCounts != null &&
                    input.CommunicationsCounts != null &&
                    this.CommunicationsCounts.SequenceEqual(input.CommunicationsCounts)
                ) && 
                (
                    this.Costs == input.Costs ||
                    this.Costs != null &&
                    input.Costs != null &&
                    this.Costs.SequenceEqual(input.Costs)
                ) && 
                (
                    this.TotalCommunicationsCount == input.TotalCommunicationsCount ||
                    (this.TotalCommunicationsCount != null &&
                    this.TotalCommunicationsCount.Equals(input.TotalCommunicationsCount))
                ) && 
                (
                    this.TotalCost == input.TotalCost ||
                    (this.TotalCost != null &&
                    this.TotalCost.Equals(input.TotalCost))
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
                if (this.CommunicationsCounts != null)
                    hashCode = hashCode * 59 + this.CommunicationsCounts.GetHashCode();
                if (this.Costs != null)
                    hashCode = hashCode * 59 + this.Costs.GetHashCode();
                if (this.TotalCommunicationsCount != null)
                    hashCode = hashCode * 59 + this.TotalCommunicationsCount.GetHashCode();
                if (this.TotalCost != null)
                    hashCode = hashCode * 59 + this.TotalCost.GetHashCode();
                return hashCode;
            }
        }
    }
}
