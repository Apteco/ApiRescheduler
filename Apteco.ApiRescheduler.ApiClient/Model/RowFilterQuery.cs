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
        public partial class RowFilterQuery :  IEquatable<RowFilterQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RowFilterQuery" /> class.
        /// </summary>
        /// <param name="name">The name (required).</param>
        /// <param name="tableName">The table name (required).</param>
        /// <param name="path">The path.</param>
        /// <param name="audienceId">The audience id.</param>
        /// <param name="query">The query.</param>
        public RowFilterQuery(string name = default(string), string tableName = default(string), string path = default(string), int? audienceId = default(int?), string query = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RowFilterQuery and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "tableName" is required (not null)
            if (tableName == null)
            {
                throw new InvalidDataException("tableName is a required property for RowFilterQuery and cannot be null");
            }
            else
            {
                this.TableName = tableName;
            }
            this.Path = path;
            this.AudienceId = audienceId;
            this.Query = query;
        }
        
        /// <summary>
        /// The name
        /// </summary>
        /// <value>The name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The table name
        /// </summary>
        /// <value>The table name</value>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The path
        /// </summary>
        /// <value>The path</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// The audience id
        /// </summary>
        /// <value>The audience id</value>
        [DataMember(Name="audienceId", EmitDefaultValue=false)]
        public int? AudienceId { get; set; }

        /// <summary>
        /// The query
        /// </summary>
        /// <value>The query</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RowFilterQuery {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  AudienceId: ").Append(AudienceId).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(input as RowFilterQuery);
        }

        /// <summary>
        /// Returns true if RowFilterQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of RowFilterQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RowFilterQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.AudienceId == input.AudienceId ||
                    (this.AudienceId != null &&
                    this.AudienceId.Equals(input.AudienceId))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.AudienceId != null)
                    hashCode = hashCode * 59 + this.AudienceId.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                return hashCode;
            }
        }
    }
}