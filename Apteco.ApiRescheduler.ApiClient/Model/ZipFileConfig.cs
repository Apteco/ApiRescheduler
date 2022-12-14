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
    /// Config for zipping and securing file output
    /// </summary>
    [DataContract]
        public partial class ZipFileConfig :  IEquatable<ZipFileConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipFileConfig" /> class.
        /// </summary>
        /// <param name="zipFile">Name of the zip file to output.</param>
        /// <param name="zipFilePassword">Password for the zip file.</param>
        public ZipFileConfig(bool? zipFile = default(bool?), string zipFilePassword = default(string))
        {
            this.ZipFile = zipFile;
            this.ZipFilePassword = zipFilePassword;
        }
        
        /// <summary>
        /// Name of the zip file to output
        /// </summary>
        /// <value>Name of the zip file to output</value>
        [DataMember(Name="zipFile", EmitDefaultValue=false)]
        public bool? ZipFile { get; set; }

        /// <summary>
        /// Password for the zip file
        /// </summary>
        /// <value>Password for the zip file</value>
        [DataMember(Name="zipFilePassword", EmitDefaultValue=false)]
        public string ZipFilePassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZipFileConfig {\n");
            sb.Append("  ZipFile: ").Append(ZipFile).Append("\n");
            sb.Append("  ZipFilePassword: ").Append(ZipFilePassword).Append("\n");
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
            return this.Equals(input as ZipFileConfig);
        }

        /// <summary>
        /// Returns true if ZipFileConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ZipFileConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZipFileConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ZipFile == input.ZipFile ||
                    (this.ZipFile != null &&
                    this.ZipFile.Equals(input.ZipFile))
                ) && 
                (
                    this.ZipFilePassword == input.ZipFilePassword ||
                    (this.ZipFilePassword != null &&
                    this.ZipFilePassword.Equals(input.ZipFilePassword))
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
                if (this.ZipFile != null)
                    hashCode = hashCode * 59 + this.ZipFile.GetHashCode();
                if (this.ZipFilePassword != null)
                    hashCode = hashCode * 59 + this.ZipFilePassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
