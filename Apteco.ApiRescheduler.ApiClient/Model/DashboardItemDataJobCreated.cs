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
    /// Details for a created job to get the data for a dashboard item
    /// </summary>
    [DataContract]
        public partial class DashboardItemDataJobCreated :  IEquatable<DashboardItemDataJobCreated>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardItemDataJobCreated" /> class.
        /// </summary>
        /// <param name="dashboardItemId">The id for this dashboard item.</param>
        /// <param name="drillDownLevel">The drill down level for this dashboard item.</param>
        /// <param name="jobId">The id of the created job for this dashboard item.</param>
        public DashboardItemDataJobCreated(string dashboardItemId = default(string), int? drillDownLevel = default(int?), int? jobId = default(int?))
        {
            this.DashboardItemId = dashboardItemId;
            this.DrillDownLevel = drillDownLevel;
            this.JobId = jobId;
        }
        
        /// <summary>
        /// The id for this dashboard item
        /// </summary>
        /// <value>The id for this dashboard item</value>
        [DataMember(Name="dashboardItemId", EmitDefaultValue=false)]
        public string DashboardItemId { get; set; }

        /// <summary>
        /// The drill down level for this dashboard item
        /// </summary>
        /// <value>The drill down level for this dashboard item</value>
        [DataMember(Name="drillDownLevel", EmitDefaultValue=false)]
        public int? DrillDownLevel { get; set; }

        /// <summary>
        /// The id of the created job for this dashboard item
        /// </summary>
        /// <value>The id of the created job for this dashboard item</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public int? JobId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardItemDataJobCreated {\n");
            sb.Append("  DashboardItemId: ").Append(DashboardItemId).Append("\n");
            sb.Append("  DrillDownLevel: ").Append(DrillDownLevel).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
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
            return this.Equals(input as DashboardItemDataJobCreated);
        }

        /// <summary>
        /// Returns true if DashboardItemDataJobCreated instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardItemDataJobCreated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardItemDataJobCreated input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DashboardItemId == input.DashboardItemId ||
                    (this.DashboardItemId != null &&
                    this.DashboardItemId.Equals(input.DashboardItemId))
                ) && 
                (
                    this.DrillDownLevel == input.DrillDownLevel ||
                    (this.DrillDownLevel != null &&
                    this.DrillDownLevel.Equals(input.DrillDownLevel))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
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
                if (this.DashboardItemId != null)
                    hashCode = hashCode * 59 + this.DashboardItemId.GetHashCode();
                if (this.DrillDownLevel != null)
                    hashCode = hashCode * 59 + this.DrillDownLevel.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
