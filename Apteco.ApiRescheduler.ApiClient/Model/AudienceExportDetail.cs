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
    /// Detail information for an audience export
    /// </summary>
    [DataContract]
        public partial class AudienceExportDetail :  IEquatable<AudienceExportDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceExportDetail" /> class.
        /// </summary>
        /// <param name="audienceUpdateId">The id of the update (audience version) that the export was created from (required).</param>
        /// <param name="timestamp">The date and time that the export was produced (required).</param>
        /// <param name="fastStatsBuildDate">The date and time that the FastStats system used to create this export was built (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="nettCounts">The set of overall counts for the audience behind this export (required).</param>
        /// <param name="urnFilePath">If a URN file was generated as part of this export then this will be its path within the FastStats system (required).</param>
        /// <param name="maximumNumberOfRowsToBrowse">The requested maximum number of rows to return when browsing the data (required).</param>
        /// <param name="returnBrowseRows">Whether data rows were requested to be returned or whether the data was exported directly to the specified file (required).</param>
        /// <param name="filePath">If specified, the path of a file that the data was exported to.</param>
        /// <param name="output">output.</param>
        /// <param name="columns">The list of columns that have been included in this export (required).</param>
        /// <param name="rows">If data rows were requested to be returned then the set of rows containing data for the given columns selected by the audience queries.</param>
        /// <param name="systemLookup">systemLookup.</param>
        public AudienceExportDetail(int? audienceUpdateId = default(int?), DateTime? timestamp = default(DateTime?), DateTime? fastStatsBuildDate = default(DateTime?), UserDisplayDetails user = default(UserDisplayDetails), List<Count> nettCounts = default(List<Count>), string urnFilePath = default(string), long? maximumNumberOfRowsToBrowse = default(long?), bool? returnBrowseRows = default(bool?), string filePath = default(string), Output output = default(Output), List<Column> columns = default(List<Column>), List<Row> rows = default(List<Row>), SystemLookup systemLookup = default(SystemLookup))
        {
            // to ensure "audienceUpdateId" is required (not null)
            if (audienceUpdateId == null)
            {
                throw new InvalidDataException("audienceUpdateId is a required property for AudienceExportDetail and cannot be null");
            }
            else
            {
                this.AudienceUpdateId = audienceUpdateId;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for AudienceExportDetail and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "fastStatsBuildDate" is required (not null)
            if (fastStatsBuildDate == null)
            {
                throw new InvalidDataException("fastStatsBuildDate is a required property for AudienceExportDetail and cannot be null");
            }
            else
            {
                this.FastStatsBuildDate = fastStatsBuildDate;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for AudienceExportDetail and cannot be null");
            }
            else
            {
                this.User = user;
            }
            // to ensure "nettCounts" is required (not null)
            if (nettCounts == null)
            {
                throw new InvalidDataException("nettCounts is a required property for AudienceExportDetail and cannot be null");
            }
            else
            {
                this.NettCounts = nettCounts;
            }
            // to ensure "urnFilePath" is required (not null)
            if (urnFilePath == null)
            {
                throw new InvalidDataException("urnFilePath is a required property for AudienceExportDetail and cannot be null");
            }
            else
            {
                this.UrnFilePath = urnFilePath;
            }
            // to ensure "maximumNumberOfRowsToBrowse" is required (not null)
            if (maximumNumberOfRowsToBrowse == null)
            {
                throw new InvalidDataException("maximumNumberOfRowsToBrowse is a required property for AudienceExportDetail and cannot be null");
            }
            else
            {
                this.MaximumNumberOfRowsToBrowse = maximumNumberOfRowsToBrowse;
            }
            // to ensure "returnBrowseRows" is required (not null)
            if (returnBrowseRows == null)
            {
                throw new InvalidDataException("returnBrowseRows is a required property for AudienceExportDetail and cannot be null");
            }
            else
            {
                this.ReturnBrowseRows = returnBrowseRows;
            }
            // to ensure "columns" is required (not null)
            if (columns == null)
            {
                throw new InvalidDataException("columns is a required property for AudienceExportDetail and cannot be null");
            }
            else
            {
                this.Columns = columns;
            }
            this.FilePath = filePath;
            this.Output = output;
            this.Rows = rows;
            this.SystemLookup = systemLookup;
        }
        
        /// <summary>
        /// The id of the update (audience version) that the export was created from
        /// </summary>
        /// <value>The id of the update (audience version) that the export was created from</value>
        [DataMember(Name="audienceUpdateId", EmitDefaultValue=false)]
        public int? AudienceUpdateId { get; set; }

        /// <summary>
        /// The date and time that the export was produced
        /// </summary>
        /// <value>The date and time that the export was produced</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The date and time that the FastStats system used to create this export was built
        /// </summary>
        /// <value>The date and time that the FastStats system used to create this export was built</value>
        [DataMember(Name="fastStatsBuildDate", EmitDefaultValue=false)]
        public DateTime? FastStatsBuildDate { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserDisplayDetails User { get; set; }

        /// <summary>
        /// The set of overall counts for the audience behind this export
        /// </summary>
        /// <value>The set of overall counts for the audience behind this export</value>
        [DataMember(Name="nettCounts", EmitDefaultValue=false)]
        public List<Count> NettCounts { get; set; }

        /// <summary>
        /// If a URN file was generated as part of this export then this will be its path within the FastStats system
        /// </summary>
        /// <value>If a URN file was generated as part of this export then this will be its path within the FastStats system</value>
        [DataMember(Name="urnFilePath", EmitDefaultValue=false)]
        public string UrnFilePath { get; set; }

        /// <summary>
        /// The requested maximum number of rows to return when browsing the data
        /// </summary>
        /// <value>The requested maximum number of rows to return when browsing the data</value>
        [DataMember(Name="maximumNumberOfRowsToBrowse", EmitDefaultValue=false)]
        public long? MaximumNumberOfRowsToBrowse { get; set; }

        /// <summary>
        /// Whether data rows were requested to be returned or whether the data was exported directly to the specified file
        /// </summary>
        /// <value>Whether data rows were requested to be returned or whether the data was exported directly to the specified file</value>
        [DataMember(Name="returnBrowseRows", EmitDefaultValue=false)]
        public bool? ReturnBrowseRows { get; set; }

        /// <summary>
        /// If specified, the path of a file that the data was exported to
        /// </summary>
        /// <value>If specified, the path of a file that the data was exported to</value>
        [DataMember(Name="filePath", EmitDefaultValue=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or Sets Output
        /// </summary>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public Output Output { get; set; }

        /// <summary>
        /// The list of columns that have been included in this export
        /// </summary>
        /// <value>The list of columns that have been included in this export</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<Column> Columns { get; set; }

        /// <summary>
        /// If data rows were requested to be returned then the set of rows containing data for the given columns selected by the audience queries
        /// </summary>
        /// <value>If data rows were requested to be returned then the set of rows containing data for the given columns selected by the audience queries</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public List<Row> Rows { get; set; }

        /// <summary>
        /// Gets or Sets SystemLookup
        /// </summary>
        [DataMember(Name="systemLookup", EmitDefaultValue=false)]
        public SystemLookup SystemLookup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudienceExportDetail {\n");
            sb.Append("  AudienceUpdateId: ").Append(AudienceUpdateId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  FastStatsBuildDate: ").Append(FastStatsBuildDate).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  NettCounts: ").Append(NettCounts).Append("\n");
            sb.Append("  UrnFilePath: ").Append(UrnFilePath).Append("\n");
            sb.Append("  MaximumNumberOfRowsToBrowse: ").Append(MaximumNumberOfRowsToBrowse).Append("\n");
            sb.Append("  ReturnBrowseRows: ").Append(ReturnBrowseRows).Append("\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  SystemLookup: ").Append(SystemLookup).Append("\n");
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
            return this.Equals(input as AudienceExportDetail);
        }

        /// <summary>
        /// Returns true if AudienceExportDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of AudienceExportDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudienceExportDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AudienceUpdateId == input.AudienceUpdateId ||
                    (this.AudienceUpdateId != null &&
                    this.AudienceUpdateId.Equals(input.AudienceUpdateId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.FastStatsBuildDate == input.FastStatsBuildDate ||
                    (this.FastStatsBuildDate != null &&
                    this.FastStatsBuildDate.Equals(input.FastStatsBuildDate))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.NettCounts == input.NettCounts ||
                    this.NettCounts != null &&
                    input.NettCounts != null &&
                    this.NettCounts.SequenceEqual(input.NettCounts)
                ) && 
                (
                    this.UrnFilePath == input.UrnFilePath ||
                    (this.UrnFilePath != null &&
                    this.UrnFilePath.Equals(input.UrnFilePath))
                ) && 
                (
                    this.MaximumNumberOfRowsToBrowse == input.MaximumNumberOfRowsToBrowse ||
                    (this.MaximumNumberOfRowsToBrowse != null &&
                    this.MaximumNumberOfRowsToBrowse.Equals(input.MaximumNumberOfRowsToBrowse))
                ) && 
                (
                    this.ReturnBrowseRows == input.ReturnBrowseRows ||
                    (this.ReturnBrowseRows != null &&
                    this.ReturnBrowseRows.Equals(input.ReturnBrowseRows))
                ) && 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
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
                    this.Rows == input.Rows ||
                    this.Rows != null &&
                    input.Rows != null &&
                    this.Rows.SequenceEqual(input.Rows)
                ) && 
                (
                    this.SystemLookup == input.SystemLookup ||
                    (this.SystemLookup != null &&
                    this.SystemLookup.Equals(input.SystemLookup))
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
                if (this.AudienceUpdateId != null)
                    hashCode = hashCode * 59 + this.AudienceUpdateId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.FastStatsBuildDate != null)
                    hashCode = hashCode * 59 + this.FastStatsBuildDate.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.NettCounts != null)
                    hashCode = hashCode * 59 + this.NettCounts.GetHashCode();
                if (this.UrnFilePath != null)
                    hashCode = hashCode * 59 + this.UrnFilePath.GetHashCode();
                if (this.MaximumNumberOfRowsToBrowse != null)
                    hashCode = hashCode * 59 + this.MaximumNumberOfRowsToBrowse.GetHashCode();
                if (this.ReturnBrowseRows != null)
                    hashCode = hashCode * 59 + this.ReturnBrowseRows.GetHashCode();
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
                if (this.SystemLookup != null)
                    hashCode = hashCode * 59 + this.SystemLookup.GetHashCode();
                return hashCode;
            }
        }
    }
}
