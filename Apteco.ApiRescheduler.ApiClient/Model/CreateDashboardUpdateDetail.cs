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
    /// Details for updating a dashboard
    /// </summary>
    [DataContract]
        public partial class CreateDashboardUpdateDetail :  IEquatable<CreateDashboardUpdateDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDashboardUpdateDetail" /> class.
        /// </summary>
        /// <param name="id">The dashboard&#x27;s id (required).</param>
        /// <param name="title">The title of the dashboard (required).</param>
        /// <param name="description">The description of the dashboard.</param>
        /// <param name="themeId">The dashboard theme id.</param>
        /// <param name="logoId">The dashboard logo id.</param>
        /// <param name="baseQuery">baseQuery.</param>
        /// <param name="predefinedUserFilters">predefinedUserFilters.</param>
        /// <param name="dashboardItems">The items that are contained within the dashboard.</param>
        /// <param name="systemName">The connected system of the dashboard.</param>
        public CreateDashboardUpdateDetail(int? id = default(int?), string title = default(string), string description = default(string), int? themeId = default(int?), int? logoId = default(int?), Query baseQuery = default(Query), FilterDefinition predefinedUserFilters = default(FilterDefinition), List<DashboardContentItem> dashboardItems = default(List<DashboardContentItem>), string systemName = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CreateDashboardUpdateDetail and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for CreateDashboardUpdateDetail and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            this.Description = description;
            this.ThemeId = themeId;
            this.LogoId = logoId;
            this.BaseQuery = baseQuery;
            this.PredefinedUserFilters = predefinedUserFilters;
            this.DashboardItems = dashboardItems;
            this.SystemName = systemName;
        }
        
        /// <summary>
        /// The dashboard&#x27;s id
        /// </summary>
        /// <value>The dashboard&#x27;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The title of the dashboard
        /// </summary>
        /// <value>The title of the dashboard</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the dashboard
        /// </summary>
        /// <value>The description of the dashboard</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The dashboard theme id
        /// </summary>
        /// <value>The dashboard theme id</value>
        [DataMember(Name="themeId", EmitDefaultValue=false)]
        public int? ThemeId { get; set; }

        /// <summary>
        /// The dashboard logo id
        /// </summary>
        /// <value>The dashboard logo id</value>
        [DataMember(Name="logoId", EmitDefaultValue=false)]
        public int? LogoId { get; set; }

        /// <summary>
        /// Gets or Sets BaseQuery
        /// </summary>
        [DataMember(Name="baseQuery", EmitDefaultValue=false)]
        public Query BaseQuery { get; set; }

        /// <summary>
        /// Gets or Sets PredefinedUserFilters
        /// </summary>
        [DataMember(Name="predefinedUserFilters", EmitDefaultValue=false)]
        public FilterDefinition PredefinedUserFilters { get; set; }

        /// <summary>
        /// The items that are contained within the dashboard
        /// </summary>
        /// <value>The items that are contained within the dashboard</value>
        [DataMember(Name="dashboardItems", EmitDefaultValue=false)]
        public List<DashboardContentItem> DashboardItems { get; set; }

        /// <summary>
        /// The connected system of the dashboard
        /// </summary>
        /// <value>The connected system of the dashboard</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDashboardUpdateDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ThemeId: ").Append(ThemeId).Append("\n");
            sb.Append("  LogoId: ").Append(LogoId).Append("\n");
            sb.Append("  BaseQuery: ").Append(BaseQuery).Append("\n");
            sb.Append("  PredefinedUserFilters: ").Append(PredefinedUserFilters).Append("\n");
            sb.Append("  DashboardItems: ").Append(DashboardItems).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
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
            return this.Equals(input as CreateDashboardUpdateDetail);
        }

        /// <summary>
        /// Returns true if CreateDashboardUpdateDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDashboardUpdateDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDashboardUpdateDetail input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ThemeId == input.ThemeId ||
                    (this.ThemeId != null &&
                    this.ThemeId.Equals(input.ThemeId))
                ) && 
                (
                    this.LogoId == input.LogoId ||
                    (this.LogoId != null &&
                    this.LogoId.Equals(input.LogoId))
                ) && 
                (
                    this.BaseQuery == input.BaseQuery ||
                    (this.BaseQuery != null &&
                    this.BaseQuery.Equals(input.BaseQuery))
                ) && 
                (
                    this.PredefinedUserFilters == input.PredefinedUserFilters ||
                    (this.PredefinedUserFilters != null &&
                    this.PredefinedUserFilters.Equals(input.PredefinedUserFilters))
                ) && 
                (
                    this.DashboardItems == input.DashboardItems ||
                    this.DashboardItems != null &&
                    input.DashboardItems != null &&
                    this.DashboardItems.SequenceEqual(input.DashboardItems)
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ThemeId != null)
                    hashCode = hashCode * 59 + this.ThemeId.GetHashCode();
                if (this.LogoId != null)
                    hashCode = hashCode * 59 + this.LogoId.GetHashCode();
                if (this.BaseQuery != null)
                    hashCode = hashCode * 59 + this.BaseQuery.GetHashCode();
                if (this.PredefinedUserFilters != null)
                    hashCode = hashCode * 59 + this.PredefinedUserFilters.GetHashCode();
                if (this.DashboardItems != null)
                    hashCode = hashCode * 59 + this.DashboardItems.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                return hashCode;
            }
        }
    }
}
