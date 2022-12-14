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
    /// Details of the output instance settings for using a PeopleStage Channel
    /// </summary>
    [DataContract]
        public partial class OutputInstanceSettings :  IEquatable<OutputInstanceSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputInstanceSettings" /> class.
        /// </summary>
        /// <param name="broadcastOutputInstanceSettings">broadcastOutputInstanceSettings.</param>
        /// <param name="fileOutputInstanceSettings">fileOutputInstanceSettings.</param>
        /// <param name="ftpOutputInstanceSettings">ftpOutputInstanceSettings.</param>
        public OutputInstanceSettings(BroadcastOutputInstanceSettings broadcastOutputInstanceSettings = default(BroadcastOutputInstanceSettings), FileOutputInstanceSettings fileOutputInstanceSettings = default(FileOutputInstanceSettings), FtpOutputInstanceSettings ftpOutputInstanceSettings = default(FtpOutputInstanceSettings))
        {
            this.BroadcastOutputInstanceSettings = broadcastOutputInstanceSettings;
            this.FileOutputInstanceSettings = fileOutputInstanceSettings;
            this.FtpOutputInstanceSettings = ftpOutputInstanceSettings;
        }
        
        /// <summary>
        /// Gets or Sets BroadcastOutputInstanceSettings
        /// </summary>
        [DataMember(Name="broadcastOutputInstanceSettings", EmitDefaultValue=false)]
        public BroadcastOutputInstanceSettings BroadcastOutputInstanceSettings { get; set; }

        /// <summary>
        /// Gets or Sets FileOutputInstanceSettings
        /// </summary>
        [DataMember(Name="fileOutputInstanceSettings", EmitDefaultValue=false)]
        public FileOutputInstanceSettings FileOutputInstanceSettings { get; set; }

        /// <summary>
        /// Gets or Sets FtpOutputInstanceSettings
        /// </summary>
        [DataMember(Name="ftpOutputInstanceSettings", EmitDefaultValue=false)]
        public FtpOutputInstanceSettings FtpOutputInstanceSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputInstanceSettings {\n");
            sb.Append("  BroadcastOutputInstanceSettings: ").Append(BroadcastOutputInstanceSettings).Append("\n");
            sb.Append("  FileOutputInstanceSettings: ").Append(FileOutputInstanceSettings).Append("\n");
            sb.Append("  FtpOutputInstanceSettings: ").Append(FtpOutputInstanceSettings).Append("\n");
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
            return this.Equals(input as OutputInstanceSettings);
        }

        /// <summary>
        /// Returns true if OutputInstanceSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of OutputInstanceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputInstanceSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BroadcastOutputInstanceSettings == input.BroadcastOutputInstanceSettings ||
                    (this.BroadcastOutputInstanceSettings != null &&
                    this.BroadcastOutputInstanceSettings.Equals(input.BroadcastOutputInstanceSettings))
                ) && 
                (
                    this.FileOutputInstanceSettings == input.FileOutputInstanceSettings ||
                    (this.FileOutputInstanceSettings != null &&
                    this.FileOutputInstanceSettings.Equals(input.FileOutputInstanceSettings))
                ) && 
                (
                    this.FtpOutputInstanceSettings == input.FtpOutputInstanceSettings ||
                    (this.FtpOutputInstanceSettings != null &&
                    this.FtpOutputInstanceSettings.Equals(input.FtpOutputInstanceSettings))
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
                if (this.BroadcastOutputInstanceSettings != null)
                    hashCode = hashCode * 59 + this.BroadcastOutputInstanceSettings.GetHashCode();
                if (this.FileOutputInstanceSettings != null)
                    hashCode = hashCode * 59 + this.FileOutputInstanceSettings.GetHashCode();
                if (this.FtpOutputInstanceSettings != null)
                    hashCode = hashCode * 59 + this.FtpOutputInstanceSettings.GetHashCode();
                return hashCode;
            }
        }
    }
}
