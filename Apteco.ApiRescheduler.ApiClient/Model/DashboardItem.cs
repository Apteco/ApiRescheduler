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
    /// The definition of one item to show in a dashboard composition
    /// </summary>
    [DataContract]
        public partial class DashboardItem :  IEquatable<DashboardItem>
    {
        /// <summary>
        /// The type of chart to use to display this dashboard item
        /// </summary>
        /// <value>The type of chart to use to display this dashboard item</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ChartTypeEnum
        {
            /// <summary>
            /// Enum Bar for value: Bar
            /// </summary>
            [EnumMember(Value = "Bar")]
            Bar = 1,
            /// <summary>
            /// Enum Column for value: Column
            /// </summary>
            [EnumMember(Value = "Column")]
            Column = 2,
            /// <summary>
            /// Enum Pie for value: Pie
            /// </summary>
            [EnumMember(Value = "Pie")]
            Pie = 3,
            /// <summary>
            /// Enum Donut for value: Donut
            /// </summary>
            [EnumMember(Value = "Donut")]
            Donut = 4,
            /// <summary>
            /// Enum Line for value: Line
            /// </summary>
            [EnumMember(Value = "Line")]
            Line = 5,
            /// <summary>
            /// Enum NumberCard for value: NumberCard
            /// </summary>
            [EnumMember(Value = "NumberCard")]
            NumberCard = 6,
            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 7,
            /// <summary>
            /// Enum BandedPareto for value: BandedPareto
            /// </summary>
            [EnumMember(Value = "BandedPareto")]
            BandedPareto = 8,
            /// <summary>
            /// Enum CategoricalPareto for value: CategoricalPareto
            /// </summary>
            [EnumMember(Value = "CategoricalPareto")]
            CategoricalPareto = 9,
            /// <summary>
            /// Enum Area for value: Area
            /// </summary>
            [EnumMember(Value = "Area")]
            Area = 10,
            /// <summary>
            /// Enum RadarLine for value: RadarLine
            /// </summary>
            [EnumMember(Value = "RadarLine")]
            RadarLine = 11,
            /// <summary>
            /// Enum RadarColumn for value: RadarColumn
            /// </summary>
            [EnumMember(Value = "RadarColumn")]
            RadarColumn = 12,
            /// <summary>
            /// Enum RadarArea for value: RadarArea
            /// </summary>
            [EnumMember(Value = "RadarArea")]
            RadarArea = 13,
            /// <summary>
            /// Enum Funnel for value: Funnel
            /// </summary>
            [EnumMember(Value = "Funnel")]
            Funnel = 14,
            /// <summary>
            /// Enum Combo for value: Combo
            /// </summary>
            [EnumMember(Value = "Combo")]
            Combo = 15,
            /// <summary>
            /// Enum Column2DClustered for value: Column2DClustered
            /// </summary>
            [EnumMember(Value = "Column2DClustered")]
            Column2DClustered = 16,
            /// <summary>
            /// Enum Column2DStacked for value: Column2DStacked
            /// </summary>
            [EnumMember(Value = "Column2DStacked")]
            Column2DStacked = 17,
            /// <summary>
            /// Enum Column2DStacked100 for value: Column2DStacked100
            /// </summary>
            [EnumMember(Value = "Column2DStacked100")]
            Column2DStacked100 = 18,
            /// <summary>
            /// Enum Bar2DClustered for value: Bar2DClustered
            /// </summary>
            [EnumMember(Value = "Bar2DClustered")]
            Bar2DClustered = 19,
            /// <summary>
            /// Enum Bar2DStacked for value: Bar2DStacked
            /// </summary>
            [EnumMember(Value = "Bar2DStacked")]
            Bar2DStacked = 20,
            /// <summary>
            /// Enum Bar2DStacked100 for value: Bar2DStacked100
            /// </summary>
            [EnumMember(Value = "Bar2DStacked100")]
            Bar2DStacked100 = 21,
            /// <summary>
            /// Enum Line2D for value: Line2D
            /// </summary>
            [EnumMember(Value = "Line2D")]
            Line2D = 22,
            /// <summary>
            /// Enum Area2DClustered for value: Area2DClustered
            /// </summary>
            [EnumMember(Value = "Area2DClustered")]
            Area2DClustered = 23,
            /// <summary>
            /// Enum Area2DStacked for value: Area2DStacked
            /// </summary>
            [EnumMember(Value = "Area2DStacked")]
            Area2DStacked = 24,
            /// <summary>
            /// Enum Area2DStacked100 for value: Area2DStacked100
            /// </summary>
            [EnumMember(Value = "Area2DStacked100")]
            Area2DStacked100 = 25,
            /// <summary>
            /// Enum Combo2DClustered for value: Combo2DClustered
            /// </summary>
            [EnumMember(Value = "Combo2DClustered")]
            Combo2DClustered = 26,
            /// <summary>
            /// Enum Combo2DStacked for value: Combo2DStacked
            /// </summary>
            [EnumMember(Value = "Combo2DStacked")]
            Combo2DStacked = 27,
            /// <summary>
            /// Enum Combo2DStacked100 for value: Combo2DStacked100
            /// </summary>
            [EnumMember(Value = "Combo2DStacked100")]
            Combo2DStacked100 = 28,
            /// <summary>
            /// Enum Venn for value: Venn
            /// </summary>
            [EnumMember(Value = "Venn")]
            Venn = 29,
            /// <summary>
            /// Enum SegmentationTwoPointMigrationGeneralVolumeMovement for value: SegmentationTwoPointMigrationGeneralVolumeMovement
            /// </summary>
            [EnumMember(Value = "SegmentationTwoPointMigrationGeneralVolumeMovement")]
            SegmentationTwoPointMigrationGeneralVolumeMovement = 30,
            /// <summary>
            /// Enum DashboardMap for value: DashboardMap
            /// </summary>
            [EnumMember(Value = "DashboardMap")]
            DashboardMap = 31,
            /// <summary>
            /// Enum Table for value: Table
            /// </summary>
            [EnumMember(Value = "Table")]
            Table = 32,
            /// <summary>
            /// Enum Cube for value: Cube
            /// </summary>
            [EnumMember(Value = "Cube")]
            Cube = 33        }
        /// <summary>
        /// The type of chart to use to display this dashboard item
        /// </summary>
        /// <value>The type of chart to use to display this dashboard item</value>
        [DataMember(Name="chartType", EmitDefaultValue=false)]
        public ChartTypeEnum ChartType { get; set; }
        /// <summary>
        /// Whether the chart should be sorted in it&#x27;s natural order, by ascending or descending values
        /// </summary>
        /// <value>Whether the chart should be sorted in it&#x27;s natural order, by ascending or descending values</value>
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
        /// Whether the chart should be sorted in it&#x27;s natural order, by ascending or descending values
        /// </summary>
        /// <value>Whether the chart should be sorted in it&#x27;s natural order, by ascending or descending values</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum SortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardItem" /> class.
        /// </summary>
        /// <param name="variableName">The name of the FastStats variable to use to calculate this dashboard item (required).</param>
        /// <param name="size">size (required).</param>
        /// <param name="chartType">The type of chart to use to display this dashboard item (required).</param>
        /// <param name="mapShapeType">The shape type to use for the dashboard item if it is a map.</param>
        /// <param name="omitZeros">Whether the chart should omit categories with zero counts (required).</param>
        /// <param name="sortOrder">Whether the chart should be sorted in it&#x27;s natural order, by ascending or descending values (required).</param>
        /// <param name="description">The description to use for this item (required).</param>
        public DashboardItem(string variableName = default(string), Size size = default(Size), ChartTypeEnum chartType = default(ChartTypeEnum), string mapShapeType = default(string), bool? omitZeros = default(bool?), SortOrderEnum sortOrder = default(SortOrderEnum), string description = default(string))
        {
            // to ensure "variableName" is required (not null)
            if (variableName == null)
            {
                throw new InvalidDataException("variableName is a required property for DashboardItem and cannot be null");
            }
            else
            {
                this.VariableName = variableName;
            }
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for DashboardItem and cannot be null");
            }
            else
            {
                this.Size = size;
            }
            // to ensure "chartType" is required (not null)
            if (chartType == null)
            {
                throw new InvalidDataException("chartType is a required property for DashboardItem and cannot be null");
            }
            else
            {
                this.ChartType = chartType;
            }
            // to ensure "omitZeros" is required (not null)
            if (omitZeros == null)
            {
                throw new InvalidDataException("omitZeros is a required property for DashboardItem and cannot be null");
            }
            else
            {
                this.OmitZeros = omitZeros;
            }
            // to ensure "sortOrder" is required (not null)
            if (sortOrder == null)
            {
                throw new InvalidDataException("sortOrder is a required property for DashboardItem and cannot be null");
            }
            else
            {
                this.SortOrder = sortOrder;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for DashboardItem and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            this.MapShapeType = mapShapeType;
        }
        
        /// <summary>
        /// The name of the FastStats variable to use to calculate this dashboard item
        /// </summary>
        /// <value>The name of the FastStats variable to use to calculate this dashboard item</value>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public Size Size { get; set; }


        /// <summary>
        /// The shape type to use for the dashboard item if it is a map
        /// </summary>
        /// <value>The shape type to use for the dashboard item if it is a map</value>
        [DataMember(Name="mapShapeType", EmitDefaultValue=false)]
        public string MapShapeType { get; set; }

        /// <summary>
        /// Whether the chart should omit categories with zero counts
        /// </summary>
        /// <value>Whether the chart should omit categories with zero counts</value>
        [DataMember(Name="omitZeros", EmitDefaultValue=false)]
        public bool? OmitZeros { get; set; }


        /// <summary>
        /// The description to use for this item
        /// </summary>
        /// <value>The description to use for this item</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardItem {\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ChartType: ").Append(ChartType).Append("\n");
            sb.Append("  MapShapeType: ").Append(MapShapeType).Append("\n");
            sb.Append("  OmitZeros: ").Append(OmitZeros).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as DashboardItem);
        }

        /// <summary>
        /// Returns true if DashboardItem instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ChartType == input.ChartType ||
                    (this.ChartType != null &&
                    this.ChartType.Equals(input.ChartType))
                ) && 
                (
                    this.MapShapeType == input.MapShapeType ||
                    (this.MapShapeType != null &&
                    this.MapShapeType.Equals(input.MapShapeType))
                ) && 
                (
                    this.OmitZeros == input.OmitZeros ||
                    (this.OmitZeros != null &&
                    this.OmitZeros.Equals(input.OmitZeros))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ChartType != null)
                    hashCode = hashCode * 59 + this.ChartType.GetHashCode();
                if (this.MapShapeType != null)
                    hashCode = hashCode * 59 + this.MapShapeType.GetHashCode();
                if (this.OmitZeros != null)
                    hashCode = hashCode * 59 + this.OmitZeros.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
