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
    /// Details for a row filter
    /// </summary>
    [DataContract]
        public partial class RowFilter :  IEquatable<RowFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RowFilter" /> class.
        /// </summary>
        /// <param name="id">The row filter Id.</param>
        /// <param name="name">The row filter name (required).</param>
        /// <param name="filters">The row filter filters (required).</param>
        /// <param name="tags">The row filter tags.</param>
        public RowFilter(int? id = default(int?), string name = default(string), List<RowFilterQuery> filters = default(List<RowFilterQuery>), List<string> tags = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RowFilter and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "filters" is required (not null)
            if (filters == null)
            {
                throw new InvalidDataException("filters is a required property for RowFilter and cannot be null");
            }
            else
            {
                this.Filters = filters;
            }
            this.Id = id;
            this.Tags = tags;
        }
        
        /// <summary>
        /// The row filter Id
        /// </summary>
        /// <value>The row filter Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The row filter name
        /// </summary>
        /// <value>The row filter name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The row filter filters
        /// </summary>
        /// <value>The row filter filters</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<RowFilterQuery> Filters { get; set; }

        /// <summary>
        /// The row filter tags
        /// </summary>
        /// <value>The row filter tags</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RowFilter {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as RowFilter);
        }

        /// <summary>
        /// Returns true if RowFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of RowFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RowFilter input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
