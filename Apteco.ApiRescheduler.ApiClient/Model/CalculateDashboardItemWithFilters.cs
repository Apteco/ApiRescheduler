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
    /// CalculateDashboardItemWithFilters
    /// </summary>
    [DataContract]
        public partial class CalculateDashboardItemWithFilters :  IEquatable<CalculateDashboardItemWithFilters>
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
        /// Initializes a new instance of the <see cref="CalculateDashboardItemWithFilters" /> class.
        /// </summary>
        /// <param name="dashboardItemId">dashboardItemId.</param>
        /// <param name="drillDownLevel">drillDownLevel.</param>
        /// <param name="resolveTableName">resolveTableName.</param>
        /// <param name="userFilterDefinition">userFilterDefinition.</param>
        /// <param name="dimensionFilterDefinition">dimensionFilterDefinition.</param>
        /// <param name="sortOrder">The different types of sort that can be applied to a dashboard composition item.</param>
        public CalculateDashboardItemWithFilters(string dashboardItemId = default(string), int? drillDownLevel = default(int?), string resolveTableName = default(string), FilterDefinition userFilterDefinition = default(FilterDefinition), FilterDefinition dimensionFilterDefinition = default(FilterDefinition), SortOrderEnum? sortOrder = default(SortOrderEnum?))
        {
            this.DashboardItemId = dashboardItemId;
            this.DrillDownLevel = drillDownLevel;
            this.ResolveTableName = resolveTableName;
            this.UserFilterDefinition = userFilterDefinition;
            this.DimensionFilterDefinition = dimensionFilterDefinition;
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
        /// Gets or Sets ResolveTableName
        /// </summary>
        [DataMember(Name="resolveTableName", EmitDefaultValue=false)]
        public string ResolveTableName { get; set; }

        /// <summary>
        /// Gets or Sets UserFilterDefinition
        /// </summary>
        [DataMember(Name="userFilterDefinition", EmitDefaultValue=false)]
        public FilterDefinition UserFilterDefinition { get; set; }

        /// <summary>
        /// Gets or Sets DimensionFilterDefinition
        /// </summary>
        [DataMember(Name="dimensionFilterDefinition", EmitDefaultValue=false)]
        public FilterDefinition DimensionFilterDefinition { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculateDashboardItemWithFilters {\n");
            sb.Append("  DashboardItemId: ").Append(DashboardItemId).Append("\n");
            sb.Append("  DrillDownLevel: ").Append(DrillDownLevel).Append("\n");
            sb.Append("  ResolveTableName: ").Append(ResolveTableName).Append("\n");
            sb.Append("  UserFilterDefinition: ").Append(UserFilterDefinition).Append("\n");
            sb.Append("  DimensionFilterDefinition: ").Append(DimensionFilterDefinition).Append("\n");
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
            return this.Equals(input as CalculateDashboardItemWithFilters);
        }

        /// <summary>
        /// Returns true if CalculateDashboardItemWithFilters instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculateDashboardItemWithFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculateDashboardItemWithFilters input)
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
                    this.ResolveTableName == input.ResolveTableName ||
                    (this.ResolveTableName != null &&
                    this.ResolveTableName.Equals(input.ResolveTableName))
                ) && 
                (
                    this.UserFilterDefinition == input.UserFilterDefinition ||
                    (this.UserFilterDefinition != null &&
                    this.UserFilterDefinition.Equals(input.UserFilterDefinition))
                ) && 
                (
                    this.DimensionFilterDefinition == input.DimensionFilterDefinition ||
                    (this.DimensionFilterDefinition != null &&
                    this.DimensionFilterDefinition.Equals(input.DimensionFilterDefinition))
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
                if (this.ResolveTableName != null)
                    hashCode = hashCode * 59 + this.ResolveTableName.GetHashCode();
                if (this.UserFilterDefinition != null)
                    hashCode = hashCode * 59 + this.UserFilterDefinition.GetHashCode();
                if (this.DimensionFilterDefinition != null)
                    hashCode = hashCode * 59 + this.DimensionFilterDefinition.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                return hashCode;
            }
        }
    }
}
