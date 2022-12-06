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
    /// Summary for a collection part
    /// </summary>
    [DataContract]
        public partial class CollectionPartSummary :  IEquatable<CollectionPartSummary>
    {
        /// <summary>
        /// The collection part&#x27;s visualisation type
        /// </summary>
        /// <value>The collection part&#x27;s visualisation type</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum VisualisationTypeEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            /// <summary>
            /// Enum Cube for value: Cube
            /// </summary>
            [EnumMember(Value = "Cube")]
            Cube = 2,
            /// <summary>
            /// Enum Venn for value: Venn
            /// </summary>
            [EnumMember(Value = "Venn")]
            Venn = 3,
            /// <summary>
            /// Enum Chart for value: Chart
            /// </summary>
            [EnumMember(Value = "Chart")]
            Chart = 4,
            /// <summary>
            /// Enum DataGrid for value: DataGrid
            /// </summary>
            [EnumMember(Value = "DataGrid")]
            DataGrid = 5        }
        /// <summary>
        /// The collection part&#x27;s visualisation type
        /// </summary>
        /// <value>The collection part&#x27;s visualisation type</value>
        [DataMember(Name="visualisationType", EmitDefaultValue=false)]
        public VisualisationTypeEnum VisualisationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionPartSummary" /> class.
        /// </summary>
        /// <param name="title">The collection part&#x27;s title (required).</param>
        /// <param name="index">The part&#x27;s index within the collection (required).</param>
        /// <param name="visualisationType">The collection part&#x27;s visualisation type (required).</param>
        /// <param name="visualisationId">The id of the visualisation for this part (required).</param>
        public CollectionPartSummary(string title = default(string), int? index = default(int?), VisualisationTypeEnum visualisationType = default(VisualisationTypeEnum), string visualisationId = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for CollectionPartSummary and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new InvalidDataException("index is a required property for CollectionPartSummary and cannot be null");
            }
            else
            {
                this.Index = index;
            }
            // to ensure "visualisationType" is required (not null)
            if (visualisationType == null)
            {
                throw new InvalidDataException("visualisationType is a required property for CollectionPartSummary and cannot be null");
            }
            else
            {
                this.VisualisationType = visualisationType;
            }
            // to ensure "visualisationId" is required (not null)
            if (visualisationId == null)
            {
                throw new InvalidDataException("visualisationId is a required property for CollectionPartSummary and cannot be null");
            }
            else
            {
                this.VisualisationId = visualisationId;
            }
        }
        
        /// <summary>
        /// The collection part&#x27;s title
        /// </summary>
        /// <value>The collection part&#x27;s title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The part&#x27;s index within the collection
        /// </summary>
        /// <value>The part&#x27;s index within the collection</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }


        /// <summary>
        /// The id of the visualisation for this part
        /// </summary>
        /// <value>The id of the visualisation for this part</value>
        [DataMember(Name="visualisationId", EmitDefaultValue=false)]
        public string VisualisationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionPartSummary {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  VisualisationType: ").Append(VisualisationType).Append("\n");
            sb.Append("  VisualisationId: ").Append(VisualisationId).Append("\n");
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
            return this.Equals(input as CollectionPartSummary);
        }

        /// <summary>
        /// Returns true if CollectionPartSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionPartSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionPartSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.VisualisationType == input.VisualisationType ||
                    (this.VisualisationType != null &&
                    this.VisualisationType.Equals(input.VisualisationType))
                ) && 
                (
                    this.VisualisationId == input.VisualisationId ||
                    (this.VisualisationId != null &&
                    this.VisualisationId.Equals(input.VisualisationId))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.VisualisationType != null)
                    hashCode = hashCode * 59 + this.VisualisationType.GetHashCode();
                if (this.VisualisationId != null)
                    hashCode = hashCode * 59 + this.VisualisationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
