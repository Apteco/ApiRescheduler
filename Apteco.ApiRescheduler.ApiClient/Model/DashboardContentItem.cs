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
    /// Outline for a dashboard item
    /// </summary>
    [DataContract]
        public partial class DashboardContentItem :  IEquatable<DashboardContentItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardContentItem" /> class.
        /// </summary>
        /// <param name="id">The dashboard items id (required).</param>
        /// <param name="title">The dashboard items title (required).</param>
        /// <param name="tileFilter">tileFilter.</param>
        /// <param name="breakpoints">The breakpoint sizing data.</param>
        /// <param name="dashboardItemDetails">The dashboard items details for each breakpoint.</param>
        public DashboardContentItem(string id = default(string), string title = default(string), FilterDefinition tileFilter = default(FilterDefinition), List<Breakpoint> breakpoints = default(List<Breakpoint>), List<DashboardContentItemDetail> dashboardItemDetails = default(List<DashboardContentItemDetail>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for DashboardContentItem and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for DashboardContentItem and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            this.TileFilter = tileFilter;
            this.Breakpoints = breakpoints;
            this.DashboardItemDetails = dashboardItemDetails;
        }
        
        /// <summary>
        /// The dashboard items id
        /// </summary>
        /// <value>The dashboard items id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The dashboard items title
        /// </summary>
        /// <value>The dashboard items title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TileFilter
        /// </summary>
        [DataMember(Name="tileFilter", EmitDefaultValue=false)]
        public FilterDefinition TileFilter { get; set; }

        /// <summary>
        /// The breakpoint sizing data
        /// </summary>
        /// <value>The breakpoint sizing data</value>
        [DataMember(Name="breakpoints", EmitDefaultValue=false)]
        public List<Breakpoint> Breakpoints { get; set; }

        /// <summary>
        /// The dashboard items details for each breakpoint
        /// </summary>
        /// <value>The dashboard items details for each breakpoint</value>
        [DataMember(Name="dashboardItemDetails", EmitDefaultValue=false)]
        public List<DashboardContentItemDetail> DashboardItemDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardContentItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TileFilter: ").Append(TileFilter).Append("\n");
            sb.Append("  Breakpoints: ").Append(Breakpoints).Append("\n");
            sb.Append("  DashboardItemDetails: ").Append(DashboardItemDetails).Append("\n");
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
            return this.Equals(input as DashboardContentItem);
        }

        /// <summary>
        /// Returns true if DashboardContentItem instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardContentItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardContentItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TileFilter == input.TileFilter ||
                    (this.TileFilter != null &&
                    this.TileFilter.Equals(input.TileFilter))
                ) && 
                (
                    this.Breakpoints == input.Breakpoints ||
                    this.Breakpoints != null &&
                    input.Breakpoints != null &&
                    this.Breakpoints.SequenceEqual(input.Breakpoints)
                ) && 
                (
                    this.DashboardItemDetails == input.DashboardItemDetails ||
                    this.DashboardItemDetails != null &&
                    input.DashboardItemDetails != null &&
                    this.DashboardItemDetails.SequenceEqual(input.DashboardItemDetails)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TileFilter != null)
                    hashCode = hashCode * 59 + this.TileFilter.GetHashCode();
                if (this.Breakpoints != null)
                    hashCode = hashCode * 59 + this.Breakpoints.GetHashCode();
                if (this.DashboardItemDetails != null)
                    hashCode = hashCode * 59 + this.DashboardItemDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}