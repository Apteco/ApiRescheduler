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
    /// Results for processing a cube request
    /// </summary>
    [DataContract]
        public partial class DashboardItemDataResultDetail :  IEquatable<DashboardItemDataResultDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardItemDataResultDetail" /> class.
        /// </summary>
        /// <param name="dimensionResults">The set of dimension results for this cube, containing the category codes and descriptions for each dimension in the cube.</param>
        /// <param name="measureResults">The set of measure results for this cube, containing the values for each measure in the cube.</param>
        /// <param name="messages">The set of measure results for this cube, containing the values for each measure in the cube.</param>
        public DashboardItemDataResultDetail(List<DimensionResult> dimensionResults = default(List<DimensionResult>), List<MeasureResult> measureResults = default(List<MeasureResult>), List<ServerMessage> messages = default(List<ServerMessage>))
        {
            this.DimensionResults = dimensionResults;
            this.MeasureResults = measureResults;
            this.Messages = messages;
        }
        
        /// <summary>
        /// The set of dimension results for this cube, containing the category codes and descriptions for each dimension in the cube
        /// </summary>
        /// <value>The set of dimension results for this cube, containing the category codes and descriptions for each dimension in the cube</value>
        [DataMember(Name="dimensionResults", EmitDefaultValue=false)]
        public List<DimensionResult> DimensionResults { get; set; }

        /// <summary>
        /// The set of measure results for this cube, containing the values for each measure in the cube
        /// </summary>
        /// <value>The set of measure results for this cube, containing the values for each measure in the cube</value>
        [DataMember(Name="measureResults", EmitDefaultValue=false)]
        public List<MeasureResult> MeasureResults { get; set; }

        /// <summary>
        /// The set of measure results for this cube, containing the values for each measure in the cube
        /// </summary>
        /// <value>The set of measure results for this cube, containing the values for each measure in the cube</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<ServerMessage> Messages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardItemDataResultDetail {\n");
            sb.Append("  DimensionResults: ").Append(DimensionResults).Append("\n");
            sb.Append("  MeasureResults: ").Append(MeasureResults).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
            return this.Equals(input as DashboardItemDataResultDetail);
        }

        /// <summary>
        /// Returns true if DashboardItemDataResultDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardItemDataResultDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardItemDataResultDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DimensionResults == input.DimensionResults ||
                    this.DimensionResults != null &&
                    input.DimensionResults != null &&
                    this.DimensionResults.SequenceEqual(input.DimensionResults)
                ) && 
                (
                    this.MeasureResults == input.MeasureResults ||
                    this.MeasureResults != null &&
                    input.MeasureResults != null &&
                    this.MeasureResults.SequenceEqual(input.MeasureResults)
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
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
                if (this.DimensionResults != null)
                    hashCode = hashCode * 59 + this.DimensionResults.GetHashCode();
                if (this.MeasureResults != null)
                    hashCode = hashCode * 59 + this.MeasureResults.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                return hashCode;
            }
        }
    }
}
