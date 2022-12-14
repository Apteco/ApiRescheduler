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
    /// JourneyAudienceSegment
    /// </summary>
    [DataContract]
        public partial class JourneyAudienceSegment :  IEquatable<JourneyAudienceSegment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyAudienceSegment" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="orbitAudienceId">orbitAudienceId.</param>
        /// <param name="tableName">tableName.</param>
        public JourneyAudienceSegment(string id = default(string), string description = default(string), int? orbitAudienceId = default(int?), string tableName = default(string))
        {
            this.Id = id;
            this.Description = description;
            this.OrbitAudienceId = orbitAudienceId;
            this.TableName = tableName;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets OrbitAudienceId
        /// </summary>
        [DataMember(Name="orbitAudienceId", EmitDefaultValue=false)]
        public int? OrbitAudienceId { get; set; }

        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyAudienceSegment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OrbitAudienceId: ").Append(OrbitAudienceId).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
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
            return this.Equals(input as JourneyAudienceSegment);
        }

        /// <summary>
        /// Returns true if JourneyAudienceSegment instances are equal
        /// </summary>
        /// <param name="input">Instance of JourneyAudienceSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyAudienceSegment input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.OrbitAudienceId == input.OrbitAudienceId ||
                    (this.OrbitAudienceId != null &&
                    this.OrbitAudienceId.Equals(input.OrbitAudienceId))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.OrbitAudienceId != null)
                    hashCode = hashCode * 59 + this.OrbitAudienceId.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                return hashCode;
            }
        }
    }
}
