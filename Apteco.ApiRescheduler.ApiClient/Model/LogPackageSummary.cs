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
    /// Summary details of a DataView that can be connected to
    /// </summary>
    [DataContract]
        public partial class LogPackageSummary :  IEquatable<LogPackageSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogPackageSummary" /> class.
        /// </summary>
        /// <param name="temporaryZipFileName">The name of the file stored in the API&#x27;s temp file store (accessible via the temporary files API endpoints) (required).</param>
        /// <param name="location">The full uri of the created log zip file (required).</param>
        public LogPackageSummary(string temporaryZipFileName = default(string), string location = default(string))
        {
            // to ensure "temporaryZipFileName" is required (not null)
            if (temporaryZipFileName == null)
            {
                throw new InvalidDataException("temporaryZipFileName is a required property for LogPackageSummary and cannot be null");
            }
            else
            {
                this.TemporaryZipFileName = temporaryZipFileName;
            }
            // to ensure "location" is required (not null)
            if (location == null)
            {
                throw new InvalidDataException("location is a required property for LogPackageSummary and cannot be null");
            }
            else
            {
                this.Location = location;
            }
        }
        
        /// <summary>
        /// The name of the file stored in the API&#x27;s temp file store (accessible via the temporary files API endpoints)
        /// </summary>
        /// <value>The name of the file stored in the API&#x27;s temp file store (accessible via the temporary files API endpoints)</value>
        [DataMember(Name="temporaryZipFileName", EmitDefaultValue=false)]
        public string TemporaryZipFileName { get; set; }

        /// <summary>
        /// The full uri of the created log zip file
        /// </summary>
        /// <value>The full uri of the created log zip file</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogPackageSummary {\n");
            sb.Append("  TemporaryZipFileName: ").Append(TemporaryZipFileName).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as LogPackageSummary);
        }

        /// <summary>
        /// Returns true if LogPackageSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of LogPackageSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogPackageSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemporaryZipFileName == input.TemporaryZipFileName ||
                    (this.TemporaryZipFileName != null &&
                    this.TemporaryZipFileName.Equals(input.TemporaryZipFileName))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                if (this.TemporaryZipFileName != null)
                    hashCode = hashCode * 59 + this.TemporaryZipFileName.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                return hashCode;
            }
        }
    }
}
