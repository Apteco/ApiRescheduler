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
    /// Details for a count of records from a particular table
    /// </summary>
    [DataContract]
        public partial class Count :  IEquatable<Count>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Count" /> class.
        /// </summary>
        /// <param name="tableName">The name of the table that the count comes from (required).</param>
        /// <param name="countValue">The count of the number of records selected on this table (required).</param>
        public Count(string tableName = default(string), long? countValue = default(long?))
        {
            // to ensure "tableName" is required (not null)
            if (tableName == null)
            {
                throw new InvalidDataException("tableName is a required property for Count and cannot be null");
            }
            else
            {
                this.TableName = tableName;
            }
            // to ensure "countValue" is required (not null)
            if (countValue == null)
            {
                throw new InvalidDataException("countValue is a required property for Count and cannot be null");
            }
            else
            {
                this.CountValue = countValue;
            }
        }
        
        /// <summary>
        /// The name of the table that the count comes from
        /// </summary>
        /// <value>The name of the table that the count comes from</value>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The count of the number of records selected on this table
        /// </summary>
        /// <value>The count of the number of records selected on this table</value>
        [DataMember(Name="countValue", EmitDefaultValue=false)]
        public long? CountValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Count {\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  CountValue: ").Append(CountValue).Append("\n");
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
            return this.Equals(input as Count);
        }

        /// <summary>
        /// Returns true if Count instances are equal
        /// </summary>
        /// <param name="input">Instance of Count to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Count input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.CountValue == input.CountValue ||
                    (this.CountValue != null &&
                    this.CountValue.Equals(input.CountValue))
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
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.CountValue != null)
                    hashCode = hashCode * 59 + this.CountValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
