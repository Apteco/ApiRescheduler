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
    /// Information to request the calculating of a cube from FastStats based upon a query
    /// </summary>
    [DataContract]
        public partial class Cube :  IEquatable<Cube>
    {
        /// <summary>
        /// How the results of the cube will be returned
        /// </summary>
        /// <value>How the results of the cube will be returned</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StorageEnum
        {
            /// <summary>
            /// Enum Full for value: Full
            /// </summary>
            [EnumMember(Value = "Full")]
            Full = 1,
            /// <summary>
            /// Enum Sparse for value: Sparse
            /// </summary>
            [EnumMember(Value = "Sparse")]
            Sparse = 2        }
        /// <summary>
        /// How the results of the cube will be returned
        /// </summary>
        /// <value>How the results of the cube will be returned</value>
        [DataMember(Name="storage", EmitDefaultValue=false)]
        public StorageEnum Storage { get; set; }
        /// <summary>
        /// Whether to calculate subtotals
        /// </summary>
        /// <value>Whether to calculate subtotals</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SubTotalsEnum
        {
            /// <summary>
            /// Enum All for value: All
            /// </summary>
            [EnumMember(Value = "All")]
            All = 1,
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 2        }
        /// <summary>
        /// Whether to calculate subtotals
        /// </summary>
        /// <value>Whether to calculate subtotals</value>
        [DataMember(Name="subTotals", EmitDefaultValue=false)]
        public SubTotalsEnum SubTotals { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cube" /> class.
        /// </summary>
        /// <param name="baseQuery">baseQuery (required).</param>
        /// <param name="resolveTableName">The name of the table to resolve this cube to.  I.e. all the counts in the cube will be counts of entities from this table (required).</param>
        /// <param name="filterQuery">filterQuery.</param>
        /// <param name="storage">How the results of the cube will be returned (required).</param>
        /// <param name="leftJoin">If this is set to true and there are dimensions on a table descended from the cube&#x27;s resolve table then a  \&quot;No [Tablename]\&quot; cell will be included in the cube results.  This shows how many records are included in the  base query but don&#x27;t match to the dimension&#x27;s table.  Similar to a relational database outer join. (required).</param>
        /// <param name="dimensions">The dimensions to build the cube with.  This can be one or more variables, queries, etc. (required).</param>
        /// <param name="measures">The measures to build the cube with.  This can be one or more aggregations to calculate for the specified dimensions such as counts, sums, means, etc. (required).</param>
        /// <param name="subTotals">Whether to calculate subtotals (required).</param>
        public Cube(Query baseQuery = default(Query), string resolveTableName = default(string), Query filterQuery = default(Query), StorageEnum storage = default(StorageEnum), bool? leftJoin = default(bool?), List<Dimension> dimensions = default(List<Dimension>), List<Measure> measures = default(List<Measure>), SubTotalsEnum subTotals = default(SubTotalsEnum))
        {
            // to ensure "baseQuery" is required (not null)
            if (baseQuery == null)
            {
                throw new InvalidDataException("baseQuery is a required property for Cube and cannot be null");
            }
            else
            {
                this.BaseQuery = baseQuery;
            }
            // to ensure "resolveTableName" is required (not null)
            if (resolveTableName == null)
            {
                throw new InvalidDataException("resolveTableName is a required property for Cube and cannot be null");
            }
            else
            {
                this.ResolveTableName = resolveTableName;
            }
            // to ensure "storage" is required (not null)
            if (storage == null)
            {
                throw new InvalidDataException("storage is a required property for Cube and cannot be null");
            }
            else
            {
                this.Storage = storage;
            }
            // to ensure "leftJoin" is required (not null)
            if (leftJoin == null)
            {
                throw new InvalidDataException("leftJoin is a required property for Cube and cannot be null");
            }
            else
            {
                this.LeftJoin = leftJoin;
            }
            // to ensure "dimensions" is required (not null)
            if (dimensions == null)
            {
                throw new InvalidDataException("dimensions is a required property for Cube and cannot be null");
            }
            else
            {
                this.Dimensions = dimensions;
            }
            // to ensure "measures" is required (not null)
            if (measures == null)
            {
                throw new InvalidDataException("measures is a required property for Cube and cannot be null");
            }
            else
            {
                this.Measures = measures;
            }
            // to ensure "subTotals" is required (not null)
            if (subTotals == null)
            {
                throw new InvalidDataException("subTotals is a required property for Cube and cannot be null");
            }
            else
            {
                this.SubTotals = subTotals;
            }
            this.FilterQuery = filterQuery;
        }
        
        /// <summary>
        /// Gets or Sets BaseQuery
        /// </summary>
        [DataMember(Name="baseQuery", EmitDefaultValue=false)]
        public Query BaseQuery { get; set; }

        /// <summary>
        /// The name of the table to resolve this cube to.  I.e. all the counts in the cube will be counts of entities from this table
        /// </summary>
        /// <value>The name of the table to resolve this cube to.  I.e. all the counts in the cube will be counts of entities from this table</value>
        [DataMember(Name="resolveTableName", EmitDefaultValue=false)]
        public string ResolveTableName { get; set; }

        /// <summary>
        /// Gets or Sets FilterQuery
        /// </summary>
        [DataMember(Name="filterQuery", EmitDefaultValue=false)]
        public Query FilterQuery { get; set; }


        /// <summary>
        /// If this is set to true and there are dimensions on a table descended from the cube&#x27;s resolve table then a  \&quot;No [Tablename]\&quot; cell will be included in the cube results.  This shows how many records are included in the  base query but don&#x27;t match to the dimension&#x27;s table.  Similar to a relational database outer join.
        /// </summary>
        /// <value>If this is set to true and there are dimensions on a table descended from the cube&#x27;s resolve table then a  \&quot;No [Tablename]\&quot; cell will be included in the cube results.  This shows how many records are included in the  base query but don&#x27;t match to the dimension&#x27;s table.  Similar to a relational database outer join.</value>
        [DataMember(Name="leftJoin", EmitDefaultValue=false)]
        public bool? LeftJoin { get; set; }

        /// <summary>
        /// The dimensions to build the cube with.  This can be one or more variables, queries, etc.
        /// </summary>
        /// <value>The dimensions to build the cube with.  This can be one or more variables, queries, etc.</value>
        [DataMember(Name="dimensions", EmitDefaultValue=false)]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// The measures to build the cube with.  This can be one or more aggregations to calculate for the specified dimensions such as counts, sums, means, etc.
        /// </summary>
        /// <value>The measures to build the cube with.  This can be one or more aggregations to calculate for the specified dimensions such as counts, sums, means, etc.</value>
        [DataMember(Name="measures", EmitDefaultValue=false)]
        public List<Measure> Measures { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cube {\n");
            sb.Append("  BaseQuery: ").Append(BaseQuery).Append("\n");
            sb.Append("  ResolveTableName: ").Append(ResolveTableName).Append("\n");
            sb.Append("  FilterQuery: ").Append(FilterQuery).Append("\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
            sb.Append("  LeftJoin: ").Append(LeftJoin).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Measures: ").Append(Measures).Append("\n");
            sb.Append("  SubTotals: ").Append(SubTotals).Append("\n");
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
            return this.Equals(input as Cube);
        }

        /// <summary>
        /// Returns true if Cube instances are equal
        /// </summary>
        /// <param name="input">Instance of Cube to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cube input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseQuery == input.BaseQuery ||
                    (this.BaseQuery != null &&
                    this.BaseQuery.Equals(input.BaseQuery))
                ) && 
                (
                    this.ResolveTableName == input.ResolveTableName ||
                    (this.ResolveTableName != null &&
                    this.ResolveTableName.Equals(input.ResolveTableName))
                ) && 
                (
                    this.FilterQuery == input.FilterQuery ||
                    (this.FilterQuery != null &&
                    this.FilterQuery.Equals(input.FilterQuery))
                ) && 
                (
                    this.Storage == input.Storage ||
                    (this.Storage != null &&
                    this.Storage.Equals(input.Storage))
                ) && 
                (
                    this.LeftJoin == input.LeftJoin ||
                    (this.LeftJoin != null &&
                    this.LeftJoin.Equals(input.LeftJoin))
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    input.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
                ) && 
                (
                    this.Measures == input.Measures ||
                    this.Measures != null &&
                    input.Measures != null &&
                    this.Measures.SequenceEqual(input.Measures)
                ) && 
                (
                    this.SubTotals == input.SubTotals ||
                    (this.SubTotals != null &&
                    this.SubTotals.Equals(input.SubTotals))
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
                if (this.BaseQuery != null)
                    hashCode = hashCode * 59 + this.BaseQuery.GetHashCode();
                if (this.ResolveTableName != null)
                    hashCode = hashCode * 59 + this.ResolveTableName.GetHashCode();
                if (this.FilterQuery != null)
                    hashCode = hashCode * 59 + this.FilterQuery.GetHashCode();
                if (this.Storage != null)
                    hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.LeftJoin != null)
                    hashCode = hashCode * 59 + this.LeftJoin.GetHashCode();
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Measures != null)
                    hashCode = hashCode * 59 + this.Measures.GetHashCode();
                if (this.SubTotals != null)
                    hashCode = hashCode * 59 + this.SubTotals.GetHashCode();
                return hashCode;
            }
        }
    }
}