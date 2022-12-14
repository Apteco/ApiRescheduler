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
    /// Information to request the exporting data from FastStats based upon a query
    /// </summary>
    [DataContract]
        public partial class Export :  IEquatable<Export>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Export" /> class.
        /// </summary>
        /// <param name="baseQuery">baseQuery (required).</param>
        /// <param name="resolveTableName">The name of the table to resolve this export to.  I.e. each row will correspond to one record from this table (required).</param>
        /// <param name="filterQuery">filterQuery.</param>
        /// <param name="maximumNumberOfRowsToBrowse">The maximum number of rows to return in the browse results  Any browse results returned will be constrained by both this value and the MaximumBrowseBufferSizeInBytes. (required).</param>
        /// <param name="maximumBrowseBufferSizeInMB">The maximum amount of memory to use when returning browse results.  If not specified defaults to 8MB.  Any browse results returned will be constrained by both this value and the MaximumNumberOfRowsToBrowse..</param>
        /// <param name="returnBrowseRows">Whether to output browse rows as well as generating a file (required).</param>
        /// <param name="pathToExportTo">The path of the file to export results to.</param>
        /// <param name="pathToExportUrnFileTo">If specified, the path to export a file of URNs that correspond to the records exported.</param>
        /// <param name="output">output.</param>
        /// <param name="columns">The name of the table to resolve this export to.  I.e. each row will correspond to one record from this table (required).</param>
        /// <param name="limits">limits.</param>
        public Export(Query baseQuery = default(Query), string resolveTableName = default(string), Query filterQuery = default(Query), long? maximumNumberOfRowsToBrowse = default(long?), int? maximumBrowseBufferSizeInMB = default(int?), bool? returnBrowseRows = default(bool?), string pathToExportTo = default(string), string pathToExportUrnFileTo = default(string), Output output = default(Output), List<Column> columns = default(List<Column>), Limits limits = default(Limits))
        {
            // to ensure "baseQuery" is required (not null)
            if (baseQuery == null)
            {
                throw new InvalidDataException("baseQuery is a required property for Export and cannot be null");
            }
            else
            {
                this.BaseQuery = baseQuery;
            }
            // to ensure "resolveTableName" is required (not null)
            if (resolveTableName == null)
            {
                throw new InvalidDataException("resolveTableName is a required property for Export and cannot be null");
            }
            else
            {
                this.ResolveTableName = resolveTableName;
            }
            // to ensure "maximumNumberOfRowsToBrowse" is required (not null)
            if (maximumNumberOfRowsToBrowse == null)
            {
                throw new InvalidDataException("maximumNumberOfRowsToBrowse is a required property for Export and cannot be null");
            }
            else
            {
                this.MaximumNumberOfRowsToBrowse = maximumNumberOfRowsToBrowse;
            }
            // to ensure "returnBrowseRows" is required (not null)
            if (returnBrowseRows == null)
            {
                throw new InvalidDataException("returnBrowseRows is a required property for Export and cannot be null");
            }
            else
            {
                this.ReturnBrowseRows = returnBrowseRows;
            }
            // to ensure "columns" is required (not null)
            if (columns == null)
            {
                throw new InvalidDataException("columns is a required property for Export and cannot be null");
            }
            else
            {
                this.Columns = columns;
            }
            this.FilterQuery = filterQuery;
            this.MaximumBrowseBufferSizeInMB = maximumBrowseBufferSizeInMB;
            this.PathToExportTo = pathToExportTo;
            this.PathToExportUrnFileTo = pathToExportUrnFileTo;
            this.Output = output;
            this.Limits = limits;
        }
        
        /// <summary>
        /// Gets or Sets BaseQuery
        /// </summary>
        [DataMember(Name="baseQuery", EmitDefaultValue=false)]
        public Query BaseQuery { get; set; }

        /// <summary>
        /// The name of the table to resolve this export to.  I.e. each row will correspond to one record from this table
        /// </summary>
        /// <value>The name of the table to resolve this export to.  I.e. each row will correspond to one record from this table</value>
        [DataMember(Name="resolveTableName", EmitDefaultValue=false)]
        public string ResolveTableName { get; set; }

        /// <summary>
        /// Gets or Sets FilterQuery
        /// </summary>
        [DataMember(Name="filterQuery", EmitDefaultValue=false)]
        public Query FilterQuery { get; set; }

        /// <summary>
        /// The maximum number of rows to return in the browse results  Any browse results returned will be constrained by both this value and the MaximumBrowseBufferSizeInBytes.
        /// </summary>
        /// <value>The maximum number of rows to return in the browse results  Any browse results returned will be constrained by both this value and the MaximumBrowseBufferSizeInBytes.</value>
        [DataMember(Name="maximumNumberOfRowsToBrowse", EmitDefaultValue=false)]
        public long? MaximumNumberOfRowsToBrowse { get; set; }

        /// <summary>
        /// The maximum amount of memory to use when returning browse results.  If not specified defaults to 8MB.  Any browse results returned will be constrained by both this value and the MaximumNumberOfRowsToBrowse.
        /// </summary>
        /// <value>The maximum amount of memory to use when returning browse results.  If not specified defaults to 8MB.  Any browse results returned will be constrained by both this value and the MaximumNumberOfRowsToBrowse.</value>
        [DataMember(Name="maximumBrowseBufferSizeInMB", EmitDefaultValue=false)]
        public int? MaximumBrowseBufferSizeInMB { get; set; }

        /// <summary>
        /// Whether to output browse rows as well as generating a file
        /// </summary>
        /// <value>Whether to output browse rows as well as generating a file</value>
        [DataMember(Name="returnBrowseRows", EmitDefaultValue=false)]
        public bool? ReturnBrowseRows { get; set; }

        /// <summary>
        /// The path of the file to export results to
        /// </summary>
        /// <value>The path of the file to export results to</value>
        [DataMember(Name="pathToExportTo", EmitDefaultValue=false)]
        public string PathToExportTo { get; set; }

        /// <summary>
        /// If specified, the path to export a file of URNs that correspond to the records exported
        /// </summary>
        /// <value>If specified, the path to export a file of URNs that correspond to the records exported</value>
        [DataMember(Name="pathToExportUrnFileTo", EmitDefaultValue=false)]
        public string PathToExportUrnFileTo { get; set; }

        /// <summary>
        /// Gets or Sets Output
        /// </summary>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public Output Output { get; set; }

        /// <summary>
        /// The name of the table to resolve this export to.  I.e. each row will correspond to one record from this table
        /// </summary>
        /// <value>The name of the table to resolve this export to.  I.e. each row will correspond to one record from this table</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<Column> Columns { get; set; }

        /// <summary>
        /// Gets or Sets Limits
        /// </summary>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public Limits Limits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Export {\n");
            sb.Append("  BaseQuery: ").Append(BaseQuery).Append("\n");
            sb.Append("  ResolveTableName: ").Append(ResolveTableName).Append("\n");
            sb.Append("  FilterQuery: ").Append(FilterQuery).Append("\n");
            sb.Append("  MaximumNumberOfRowsToBrowse: ").Append(MaximumNumberOfRowsToBrowse).Append("\n");
            sb.Append("  MaximumBrowseBufferSizeInMB: ").Append(MaximumBrowseBufferSizeInMB).Append("\n");
            sb.Append("  ReturnBrowseRows: ").Append(ReturnBrowseRows).Append("\n");
            sb.Append("  PathToExportTo: ").Append(PathToExportTo).Append("\n");
            sb.Append("  PathToExportUrnFileTo: ").Append(PathToExportUrnFileTo).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
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
            return this.Equals(input as Export);
        }

        /// <summary>
        /// Returns true if Export instances are equal
        /// </summary>
        /// <param name="input">Instance of Export to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Export input)
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
                    this.MaximumNumberOfRowsToBrowse == input.MaximumNumberOfRowsToBrowse ||
                    (this.MaximumNumberOfRowsToBrowse != null &&
                    this.MaximumNumberOfRowsToBrowse.Equals(input.MaximumNumberOfRowsToBrowse))
                ) && 
                (
                    this.MaximumBrowseBufferSizeInMB == input.MaximumBrowseBufferSizeInMB ||
                    (this.MaximumBrowseBufferSizeInMB != null &&
                    this.MaximumBrowseBufferSizeInMB.Equals(input.MaximumBrowseBufferSizeInMB))
                ) && 
                (
                    this.ReturnBrowseRows == input.ReturnBrowseRows ||
                    (this.ReturnBrowseRows != null &&
                    this.ReturnBrowseRows.Equals(input.ReturnBrowseRows))
                ) && 
                (
                    this.PathToExportTo == input.PathToExportTo ||
                    (this.PathToExportTo != null &&
                    this.PathToExportTo.Equals(input.PathToExportTo))
                ) && 
                (
                    this.PathToExportUrnFileTo == input.PathToExportUrnFileTo ||
                    (this.PathToExportUrnFileTo != null &&
                    this.PathToExportUrnFileTo.Equals(input.PathToExportUrnFileTo))
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    input.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
                ) && 
                (
                    this.Limits == input.Limits ||
                    (this.Limits != null &&
                    this.Limits.Equals(input.Limits))
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
                if (this.MaximumNumberOfRowsToBrowse != null)
                    hashCode = hashCode * 59 + this.MaximumNumberOfRowsToBrowse.GetHashCode();
                if (this.MaximumBrowseBufferSizeInMB != null)
                    hashCode = hashCode * 59 + this.MaximumBrowseBufferSizeInMB.GetHashCode();
                if (this.ReturnBrowseRows != null)
                    hashCode = hashCode * 59 + this.ReturnBrowseRows.GetHashCode();
                if (this.PathToExportTo != null)
                    hashCode = hashCode * 59 + this.PathToExportTo.GetHashCode();
                if (this.PathToExportUrnFileTo != null)
                    hashCode = hashCode * 59 + this.PathToExportUrnFileTo.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                return hashCode;
            }
        }
    }
}
