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
        public partial class DashboardMapSettings :  IEquatable<DashboardMapSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardMapSettings" /> class.
        /// </summary>
        /// <param name="id">The dashboard map type id (required).</param>
        /// <param name="mapShapeType">The dashboard map shape type (required).</param>
        /// <param name="matchCode">The dashboard map match code.</param>
        /// <param name="dataFile">The dashboard data file path.</param>
        /// <param name="imageFile">The dashboard image file path.</param>
        /// <param name="projectionType">The dashboard map projection type.</param>
        public DashboardMapSettings(int? id = default(int?), string mapShapeType = default(string), string matchCode = default(string), string dataFile = default(string), string imageFile = default(string), string projectionType = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for DashboardMapSettings and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "mapShapeType" is required (not null)
            if (mapShapeType == null)
            {
                throw new InvalidDataException("mapShapeType is a required property for DashboardMapSettings and cannot be null");
            }
            else
            {
                this.MapShapeType = mapShapeType;
            }
            this.MatchCode = matchCode;
            this.DataFile = dataFile;
            this.ImageFile = imageFile;
            this.ProjectionType = projectionType;
        }
        
        /// <summary>
        /// The dashboard map type id
        /// </summary>
        /// <value>The dashboard map type id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The dashboard map shape type
        /// </summary>
        /// <value>The dashboard map shape type</value>
        [DataMember(Name="mapShapeType", EmitDefaultValue=false)]
        public string MapShapeType { get; set; }

        /// <summary>
        /// The dashboard map match code
        /// </summary>
        /// <value>The dashboard map match code</value>
        [DataMember(Name="matchCode", EmitDefaultValue=false)]
        public string MatchCode { get; set; }

        /// <summary>
        /// The dashboard data file path
        /// </summary>
        /// <value>The dashboard data file path</value>
        [DataMember(Name="dataFile", EmitDefaultValue=false)]
        public string DataFile { get; set; }

        /// <summary>
        /// The dashboard image file path
        /// </summary>
        /// <value>The dashboard image file path</value>
        [DataMember(Name="imageFile", EmitDefaultValue=false)]
        public string ImageFile { get; set; }

        /// <summary>
        /// The dashboard map projection type
        /// </summary>
        /// <value>The dashboard map projection type</value>
        [DataMember(Name="projectionType", EmitDefaultValue=false)]
        public string ProjectionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardMapSettings {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MapShapeType: ").Append(MapShapeType).Append("\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
            sb.Append("  DataFile: ").Append(DataFile).Append("\n");
            sb.Append("  ImageFile: ").Append(ImageFile).Append("\n");
            sb.Append("  ProjectionType: ").Append(ProjectionType).Append("\n");
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
            return this.Equals(input as DashboardMapSettings);
        }

        /// <summary>
        /// Returns true if DashboardMapSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardMapSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardMapSettings input)
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
                    this.MapShapeType == input.MapShapeType ||
                    (this.MapShapeType != null &&
                    this.MapShapeType.Equals(input.MapShapeType))
                ) && 
                (
                    this.MatchCode == input.MatchCode ||
                    (this.MatchCode != null &&
                    this.MatchCode.Equals(input.MatchCode))
                ) && 
                (
                    this.DataFile == input.DataFile ||
                    (this.DataFile != null &&
                    this.DataFile.Equals(input.DataFile))
                ) && 
                (
                    this.ImageFile == input.ImageFile ||
                    (this.ImageFile != null &&
                    this.ImageFile.Equals(input.ImageFile))
                ) && 
                (
                    this.ProjectionType == input.ProjectionType ||
                    (this.ProjectionType != null &&
                    this.ProjectionType.Equals(input.ProjectionType))
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
                if (this.MapShapeType != null)
                    hashCode = hashCode * 59 + this.MapShapeType.GetHashCode();
                if (this.MatchCode != null)
                    hashCode = hashCode * 59 + this.MatchCode.GetHashCode();
                if (this.DataFile != null)
                    hashCode = hashCode * 59 + this.DataFile.GetHashCode();
                if (this.ImageFile != null)
                    hashCode = hashCode * 59 + this.ImageFile.GetHashCode();
                if (this.ProjectionType != null)
                    hashCode = hashCode * 59 + this.ProjectionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
