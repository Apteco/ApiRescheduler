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
    /// CalculateDashboardItem
    /// </summary>
    [DataContract]
        public partial class CalculateDashboardItem :  IEquatable<CalculateDashboardItem>
    {
        /// <summary>
        /// The different types of sort that can be applied to a dashboard composition item
        /// </summary>
        /// <value>The different types of sort that can be applied to a dashboard composition item</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SortOrderEnum
        {
            /// <summary>
            /// Enum Natural for value: Natural
            /// </summary>
            [EnumMember(Value = "Natural")]
            Natural = 1,
            /// <summary>
            /// Enum AscendingByValue for value: AscendingByValue
            /// </summary>
            [EnumMember(Value = "AscendingByValue")]
            AscendingByValue = 2,
            /// <summary>
            /// Enum DescendingByValue for value: DescendingByValue
            /// </summary>
            [EnumMember(Value = "DescendingByValue")]
            DescendingByValue = 3        }
        /// <summary>
        /// The different types of sort that can be applied to a dashboard composition item
        /// </summary>
        /// <value>The different types of sort that can be applied to a dashboard composition item</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateDashboardItem" /> class.
        /// </summary>
        /// <param name="dashboardItemId">dashboardItemId.</param>
        /// <param name="drillDownLevel">drillDownLevel.</param>
        /// <param name="dashboardItemQuery">dashboardItemQuery.</param>
        /// <param name="dimensionFilter">dimensionFilter.</param>
        /// <param name="sortOrder">The different types of sort that can be applied to a dashboard composition item.</param>
        public CalculateDashboardItem(string dashboardItemId = default(string), int? drillDownLevel = default(int?), Query dashboardItemQuery = default(Query), Query dimensionFilter = default(Query), SortOrderEnum? sortOrder = default(SortOrderEnum?))
        {
            this.DashboardItemId = dashboardItemId;
            this.DrillDownLevel = drillDownLevel;
            this.DashboardItemQuery = dashboardItemQuery;
            this.DimensionFilter = dimensionFilter;
            this.SortOrder = sortOrder;
        }
        
        /// <summary>
        /// Gets or Sets DashboardItemId
        /// </summary>
        [DataMember(Name="dashboardItemId", EmitDefaultValue=false)]
        public string DashboardItemId { get; set; }

        /// <summary>
        /// Gets or Sets DrillDownLevel
        /// </summary>
        [DataMember(Name="drillDownLevel", EmitDefaultValue=false)]
        public int? DrillDownLevel { get; set; }

        /// <summary>
        /// Gets or Sets DashboardItemQuery
        /// </summary>
        [DataMember(Name="dashboardItemQuery", EmitDefaultValue=false)]
        public Query DashboardItemQuery { get; set; }

        /// <summary>
        /// Gets or Sets DimensionFilter
        /// </summary>
        [DataMember(Name="dimensionFilter", EmitDefaultValue=false)]
        public Query DimensionFilter { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculateDashboardItem {\n");
            sb.Append("  DashboardItemId: ").Append(DashboardItemId).Append("\n");
            sb.Append("  DrillDownLevel: ").Append(DrillDownLevel).Append("\n");
            sb.Append("  DashboardItemQuery: ").Append(DashboardItemQuery).Append("\n");
            sb.Append("  DimensionFilter: ").Append(DimensionFilter).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as CalculateDashboardItem);
        }

        /// <summary>
        /// Returns true if CalculateDashboardItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculateDashboardItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculateDashboardItem input)
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
                    this.DashboardItemQuery == input.DashboardItemQuery ||
                    (this.DashboardItemQuery != null &&
                    this.DashboardItemQuery.Equals(input.DashboardItemQuery))
                ) && 
                (
                    this.DimensionFilter == input.DimensionFilter ||
                    (this.DimensionFilter != null &&
                    this.DimensionFilter.Equals(input.DimensionFilter))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
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
                if (this.DashboardItemQuery != null)
                    hashCode = hashCode * 59 + this.DashboardItemQuery.GetHashCode();
                if (this.DimensionFilter != null)
                    hashCode = hashCode * 59 + this.DimensionFilter.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                return hashCode;
            }
        }
    }
}
