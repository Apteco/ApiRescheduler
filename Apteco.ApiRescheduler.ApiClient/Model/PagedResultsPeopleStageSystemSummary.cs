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
    /// Summary details for a user
    /// </summary>
    [DataContract]
        public partial class PagedResultsPeopleStageSystemSummary :  IEquatable<PagedResultsPeopleStageSystemSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagedResultsPeopleStageSystemSummary" /> class.
        /// </summary>
        /// <param name="offset">The number of items that were skipped over from the (potentially filtered) result set (required).</param>
        /// <param name="count">The number of items returned in this page of the result set (required).</param>
        /// <param name="totalCount">The total number of items available in the (potentially filtered) result set (required).</param>
        /// <param name="_list">The list of results (required).</param>
        public PagedResultsPeopleStageSystemSummary(int? offset = default(int?), int? count = default(int?), int? totalCount = default(int?), List<PeopleStageSystemSummary> _list = default(List<PeopleStageSystemSummary>))
        {
            // to ensure "offset" is required (not null)
            if (offset == null)
            {
                throw new InvalidDataException("offset is a required property for PagedResultsPeopleStageSystemSummary and cannot be null");
            }
            else
            {
                this.Offset = offset;
            }
            // to ensure "count" is required (not null)
            if (count == null)
            {
                throw new InvalidDataException("count is a required property for PagedResultsPeopleStageSystemSummary and cannot be null");
            }
            else
            {
                this.Count = count;
            }
            // to ensure "totalCount" is required (not null)
            if (totalCount == null)
            {
                throw new InvalidDataException("totalCount is a required property for PagedResultsPeopleStageSystemSummary and cannot be null");
            }
            else
            {
                this.TotalCount = totalCount;
            }
            // to ensure "_list" is required (not null)
            if (_list == null)
            {
                throw new InvalidDataException("_list is a required property for PagedResultsPeopleStageSystemSummary and cannot be null");
            }
            else
            {
                this._List = _list;
            }
        }
        
        /// <summary>
        /// The number of items that were skipped over from the (potentially filtered) result set
        /// </summary>
        /// <value>The number of items that were skipped over from the (potentially filtered) result set</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// The number of items returned in this page of the result set
        /// </summary>
        /// <value>The number of items returned in this page of the result set</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The total number of items available in the (potentially filtered) result set
        /// </summary>
        /// <value>The total number of items available in the (potentially filtered) result set</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of results
        /// </summary>
        /// <value>The list of results</value>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public List<PeopleStageSystemSummary> _List { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PagedResultsPeopleStageSystemSummary {\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  _List: ").Append(_List).Append("\n");
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
            return this.Equals(input as PagedResultsPeopleStageSystemSummary);
        }

        /// <summary>
        /// Returns true if PagedResultsPeopleStageSystemSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of PagedResultsPeopleStageSystemSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PagedResultsPeopleStageSystemSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this._List == input._List ||
                    this._List != null &&
                    input._List != null &&
                    this._List.SequenceEqual(input._List)
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this._List != null)
                    hashCode = hashCode * 59 + this._List.GetHashCode();
                return hashCode;
            }
        }
    }
}