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
    /// ThemeUsageSummary
    /// </summary>
    [DataContract]
        public partial class ThemeUsageSummary :  IEquatable<ThemeUsageSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeUsageSummary" /> class.
        /// </summary>
        /// <param name="themeId">The theme Id the summary information is for.</param>
        /// <param name="numberOfDashboards">The number of dashboards using this theme.</param>
        public ThemeUsageSummary(int? themeId = default(int?), int? numberOfDashboards = default(int?))
        {
            this.ThemeId = themeId;
            this.NumberOfDashboards = numberOfDashboards;
        }
        
        /// <summary>
        /// The theme Id the summary information is for
        /// </summary>
        /// <value>The theme Id the summary information is for</value>
        [DataMember(Name="themeId", EmitDefaultValue=false)]
        public int? ThemeId { get; set; }

        /// <summary>
        /// The number of dashboards using this theme
        /// </summary>
        /// <value>The number of dashboards using this theme</value>
        [DataMember(Name="numberOfDashboards", EmitDefaultValue=false)]
        public int? NumberOfDashboards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThemeUsageSummary {\n");
            sb.Append("  ThemeId: ").Append(ThemeId).Append("\n");
            sb.Append("  NumberOfDashboards: ").Append(NumberOfDashboards).Append("\n");
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
            return this.Equals(input as ThemeUsageSummary);
        }

        /// <summary>
        /// Returns true if ThemeUsageSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ThemeUsageSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThemeUsageSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ThemeId == input.ThemeId ||
                    (this.ThemeId != null &&
                    this.ThemeId.Equals(input.ThemeId))
                ) && 
                (
                    this.NumberOfDashboards == input.NumberOfDashboards ||
                    (this.NumberOfDashboards != null &&
                    this.NumberOfDashboards.Equals(input.NumberOfDashboards))
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
                if (this.ThemeId != null)
                    hashCode = hashCode * 59 + this.ThemeId.GetHashCode();
                if (this.NumberOfDashboards != null)
                    hashCode = hashCode * 59 + this.NumberOfDashboards.GetHashCode();
                return hashCode;
            }
        }
    }
}
