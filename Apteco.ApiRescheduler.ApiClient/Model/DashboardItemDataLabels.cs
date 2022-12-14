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
    /// The details of dashboard item data labels
    /// </summary>
    [DataContract]
        public partial class DashboardItemDataLabels :  IEquatable<DashboardItemDataLabels>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardItemDataLabels" /> class.
        /// </summary>
        /// <param name="showDataLabels">Setting that determines whether to show data labels (required).</param>
        /// <param name="abbreviateCount">Whether to abbreviate the data label value (required).</param>
        /// <param name="labelStep">Whether to show every nth label.</param>
        /// <param name="showValuesAsPercentages">Whether to show the data label value as a percentage (required).</param>
        public DashboardItemDataLabels(string showDataLabels = default(string), bool? abbreviateCount = default(bool?), int? labelStep = default(int?), bool? showValuesAsPercentages = default(bool?))
        {
            // to ensure "showDataLabels" is required (not null)
            if (showDataLabels == null)
            {
                throw new InvalidDataException("showDataLabels is a required property for DashboardItemDataLabels and cannot be null");
            }
            else
            {
                this.ShowDataLabels = showDataLabels;
            }
            // to ensure "abbreviateCount" is required (not null)
            if (abbreviateCount == null)
            {
                throw new InvalidDataException("abbreviateCount is a required property for DashboardItemDataLabels and cannot be null");
            }
            else
            {
                this.AbbreviateCount = abbreviateCount;
            }
            // to ensure "showValuesAsPercentages" is required (not null)
            if (showValuesAsPercentages == null)
            {
                throw new InvalidDataException("showValuesAsPercentages is a required property for DashboardItemDataLabels and cannot be null");
            }
            else
            {
                this.ShowValuesAsPercentages = showValuesAsPercentages;
            }
            this.LabelStep = labelStep;
        }
        
        /// <summary>
        /// Setting that determines whether to show data labels
        /// </summary>
        /// <value>Setting that determines whether to show data labels</value>
        [DataMember(Name="showDataLabels", EmitDefaultValue=false)]
        public string ShowDataLabels { get; set; }

        /// <summary>
        /// Whether to abbreviate the data label value
        /// </summary>
        /// <value>Whether to abbreviate the data label value</value>
        [DataMember(Name="abbreviateCount", EmitDefaultValue=false)]
        public bool? AbbreviateCount { get; set; }

        /// <summary>
        /// Whether to show every nth label
        /// </summary>
        /// <value>Whether to show every nth label</value>
        [DataMember(Name="labelStep", EmitDefaultValue=false)]
        public int? LabelStep { get; set; }

        /// <summary>
        /// Whether to show the data label value as a percentage
        /// </summary>
        /// <value>Whether to show the data label value as a percentage</value>
        [DataMember(Name="showValuesAsPercentages", EmitDefaultValue=false)]
        public bool? ShowValuesAsPercentages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardItemDataLabels {\n");
            sb.Append("  ShowDataLabels: ").Append(ShowDataLabels).Append("\n");
            sb.Append("  AbbreviateCount: ").Append(AbbreviateCount).Append("\n");
            sb.Append("  LabelStep: ").Append(LabelStep).Append("\n");
            sb.Append("  ShowValuesAsPercentages: ").Append(ShowValuesAsPercentages).Append("\n");
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
            return this.Equals(input as DashboardItemDataLabels);
        }

        /// <summary>
        /// Returns true if DashboardItemDataLabels instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardItemDataLabels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardItemDataLabels input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShowDataLabels == input.ShowDataLabels ||
                    (this.ShowDataLabels != null &&
                    this.ShowDataLabels.Equals(input.ShowDataLabels))
                ) && 
                (
                    this.AbbreviateCount == input.AbbreviateCount ||
                    (this.AbbreviateCount != null &&
                    this.AbbreviateCount.Equals(input.AbbreviateCount))
                ) && 
                (
                    this.LabelStep == input.LabelStep ||
                    (this.LabelStep != null &&
                    this.LabelStep.Equals(input.LabelStep))
                ) && 
                (
                    this.ShowValuesAsPercentages == input.ShowValuesAsPercentages ||
                    (this.ShowValuesAsPercentages != null &&
                    this.ShowValuesAsPercentages.Equals(input.ShowValuesAsPercentages))
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
                if (this.ShowDataLabels != null)
                    hashCode = hashCode * 59 + this.ShowDataLabels.GetHashCode();
                if (this.AbbreviateCount != null)
                    hashCode = hashCode * 59 + this.AbbreviateCount.GetHashCode();
                if (this.LabelStep != null)
                    hashCode = hashCode * 59 + this.LabelStep.GetHashCode();
                if (this.ShowValuesAsPercentages != null)
                    hashCode = hashCode * 59 + this.ShowValuesAsPercentages.GetHashCode();
                return hashCode;
            }
        }
    }
}
