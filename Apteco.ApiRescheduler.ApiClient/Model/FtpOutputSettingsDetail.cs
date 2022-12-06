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
    /// Details for a FtpOutputSettings
    /// </summary>
    [DataContract]
        public partial class FtpOutputSettingsDetail :  IEquatable<FtpOutputSettingsDetail>
    {
        /// <summary>
        /// When adding additional variables directly - add to the end or the beginning
        /// </summary>
        /// <value>When adding additional variables directly - add to the end or the beginning</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DirectAdditionalVariablesLocationEnum
        {
            /// <summary>
            /// Enum End for value: End
            /// </summary>
            [EnumMember(Value = "End")]
            End = 1,
            /// <summary>
            /// Enum Beginning for value: Beginning
            /// </summary>
            [EnumMember(Value = "Beginning")]
            Beginning = 2        }
        /// <summary>
        /// When adding additional variables directly - add to the end or the beginning
        /// </summary>
        /// <value>When adding additional variables directly - add to the end or the beginning</value>
        [DataMember(Name="directAdditionalVariablesLocation", EmitDefaultValue=false)]
        public DirectAdditionalVariablesLocationEnum? DirectAdditionalVariablesLocation { get; set; }
        /// <summary>
        /// Whether a channel is allowed to be used with \&quot;Transactional\&quot; campaigns - i.e. campaigns on tables lower than the Person table.
        /// </summary>
        /// <value>Whether a channel is allowed to be used with \&quot;Transactional\&quot; campaigns - i.e. campaigns on tables lower than the Person table.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AllowTransactionalOutputEnum
        {
            /// <summary>
            /// Enum No for value: No
            /// </summary>
            [EnumMember(Value = "No")]
            No = 1,
            /// <summary>
            /// Enum Yes for value: Yes
            /// </summary>
            [EnumMember(Value = "Yes")]
            Yes = 2        }
        /// <summary>
        /// Whether a channel is allowed to be used with \&quot;Transactional\&quot; campaigns - i.e. campaigns on tables lower than the Person table.
        /// </summary>
        /// <value>Whether a channel is allowed to be used with \&quot;Transactional\&quot; campaigns - i.e. campaigns on tables lower than the Person table.</value>
        [DataMember(Name="allowTransactionalOutput", EmitDefaultValue=false)]
        public AllowTransactionalOutputEnum AllowTransactionalOutput { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FtpOutputSettingsDetail" /> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="privateKeyPath">The path to a private key file for the FTP site.</param>
        /// <param name="addAdditionalVariablesDirectly">Whether to add additional variables directly..</param>
        /// <param name="directAdditionalVariablesLocation">When adding additional variables directly - add to the end or the beginning.</param>
        /// <param name="initialResponseImpact">The initial response impact for a communication on this channel. Ranges from 0-100, default is 100.</param>
        /// <param name="ftpUri">FTP URL (required).</param>
        /// <param name="addCommunicationKey">Add Communication Key to the file.</param>
        /// <param name="overwrite">Whether to overwrite the file or not.</param>
        /// <param name="allowTransactionalOutput">Whether a channel is allowed to be used with \&quot;Transactional\&quot; campaigns - i.e. campaigns on tables lower than the Person table. (required).</param>
        /// <param name="additionalVariables">Details of variables always included with this channel.</param>
        /// <param name="fileSettings">fileSettings.</param>
        public FtpOutputSettingsDetail(string username = default(string), string privateKeyPath = default(string), bool? addAdditionalVariablesDirectly = default(bool?), DirectAdditionalVariablesLocationEnum? directAdditionalVariablesLocation = default(DirectAdditionalVariablesLocationEnum?), int? initialResponseImpact = default(int?), string ftpUri = default(string), bool? addCommunicationKey = default(bool?), bool? overwrite = default(bool?), AllowTransactionalOutputEnum allowTransactionalOutput = default(AllowTransactionalOutputEnum), List<VariableDetails> additionalVariables = default(List<VariableDetails>), FileSettings fileSettings = default(FileSettings))
        {
            // to ensure "ftpUri" is required (not null)
            if (ftpUri == null)
            {
                throw new InvalidDataException("ftpUri is a required property for FtpOutputSettingsDetail and cannot be null");
            }
            else
            {
                this.FtpUri = ftpUri;
            }
            // to ensure "allowTransactionalOutput" is required (not null)
            if (allowTransactionalOutput == null)
            {
                throw new InvalidDataException("allowTransactionalOutput is a required property for FtpOutputSettingsDetail and cannot be null");
            }
            else
            {
                this.AllowTransactionalOutput = allowTransactionalOutput;
            }
            this.Username = username;
            this.PrivateKeyPath = privateKeyPath;
            this.AddAdditionalVariablesDirectly = addAdditionalVariablesDirectly;
            this.DirectAdditionalVariablesLocation = directAdditionalVariablesLocation;
            this.InitialResponseImpact = initialResponseImpact;
            this.AddCommunicationKey = addCommunicationKey;
            this.Overwrite = overwrite;
            this.AdditionalVariables = additionalVariables;
            this.FileSettings = fileSettings;
        }
        
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The path to a private key file for the FTP site
        /// </summary>
        /// <value>The path to a private key file for the FTP site</value>
        [DataMember(Name="privateKeyPath", EmitDefaultValue=false)]
        public string PrivateKeyPath { get; set; }

        /// <summary>
        /// Whether to add additional variables directly.
        /// </summary>
        /// <value>Whether to add additional variables directly.</value>
        [DataMember(Name="addAdditionalVariablesDirectly", EmitDefaultValue=false)]
        public bool? AddAdditionalVariablesDirectly { get; set; }


        /// <summary>
        /// The initial response impact for a communication on this channel. Ranges from 0-100, default is 100
        /// </summary>
        /// <value>The initial response impact for a communication on this channel. Ranges from 0-100, default is 100</value>
        [DataMember(Name="initialResponseImpact", EmitDefaultValue=false)]
        public int? InitialResponseImpact { get; set; }

        /// <summary>
        /// FTP URL
        /// </summary>
        /// <value>FTP URL</value>
        [DataMember(Name="ftpUri", EmitDefaultValue=false)]
        public string FtpUri { get; set; }

        /// <summary>
        /// Add Communication Key to the file
        /// </summary>
        /// <value>Add Communication Key to the file</value>
        [DataMember(Name="addCommunicationKey", EmitDefaultValue=false)]
        public bool? AddCommunicationKey { get; set; }

        /// <summary>
        /// Whether to overwrite the file or not
        /// </summary>
        /// <value>Whether to overwrite the file or not</value>
        [DataMember(Name="overwrite", EmitDefaultValue=false)]
        public bool? Overwrite { get; set; }


        /// <summary>
        /// Details of variables always included with this channel
        /// </summary>
        /// <value>Details of variables always included with this channel</value>
        [DataMember(Name="additionalVariables", EmitDefaultValue=false)]
        public List<VariableDetails> AdditionalVariables { get; set; }

        /// <summary>
        /// Gets or Sets FileSettings
        /// </summary>
        [DataMember(Name="fileSettings", EmitDefaultValue=false)]
        public FileSettings FileSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FtpOutputSettingsDetail {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  PrivateKeyPath: ").Append(PrivateKeyPath).Append("\n");
            sb.Append("  AddAdditionalVariablesDirectly: ").Append(AddAdditionalVariablesDirectly).Append("\n");
            sb.Append("  DirectAdditionalVariablesLocation: ").Append(DirectAdditionalVariablesLocation).Append("\n");
            sb.Append("  InitialResponseImpact: ").Append(InitialResponseImpact).Append("\n");
            sb.Append("  FtpUri: ").Append(FtpUri).Append("\n");
            sb.Append("  AddCommunicationKey: ").Append(AddCommunicationKey).Append("\n");
            sb.Append("  Overwrite: ").Append(Overwrite).Append("\n");
            sb.Append("  AllowTransactionalOutput: ").Append(AllowTransactionalOutput).Append("\n");
            sb.Append("  AdditionalVariables: ").Append(AdditionalVariables).Append("\n");
            sb.Append("  FileSettings: ").Append(FileSettings).Append("\n");
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
            return this.Equals(input as FtpOutputSettingsDetail);
        }

        /// <summary>
        /// Returns true if FtpOutputSettingsDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of FtpOutputSettingsDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FtpOutputSettingsDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.PrivateKeyPath == input.PrivateKeyPath ||
                    (this.PrivateKeyPath != null &&
                    this.PrivateKeyPath.Equals(input.PrivateKeyPath))
                ) && 
                (
                    this.AddAdditionalVariablesDirectly == input.AddAdditionalVariablesDirectly ||
                    (this.AddAdditionalVariablesDirectly != null &&
                    this.AddAdditionalVariablesDirectly.Equals(input.AddAdditionalVariablesDirectly))
                ) && 
                (
                    this.DirectAdditionalVariablesLocation == input.DirectAdditionalVariablesLocation ||
                    (this.DirectAdditionalVariablesLocation != null &&
                    this.DirectAdditionalVariablesLocation.Equals(input.DirectAdditionalVariablesLocation))
                ) && 
                (
                    this.InitialResponseImpact == input.InitialResponseImpact ||
                    (this.InitialResponseImpact != null &&
                    this.InitialResponseImpact.Equals(input.InitialResponseImpact))
                ) && 
                (
                    this.FtpUri == input.FtpUri ||
                    (this.FtpUri != null &&
                    this.FtpUri.Equals(input.FtpUri))
                ) && 
                (
                    this.AddCommunicationKey == input.AddCommunicationKey ||
                    (this.AddCommunicationKey != null &&
                    this.AddCommunicationKey.Equals(input.AddCommunicationKey))
                ) && 
                (
                    this.Overwrite == input.Overwrite ||
                    (this.Overwrite != null &&
                    this.Overwrite.Equals(input.Overwrite))
                ) && 
                (
                    this.AllowTransactionalOutput == input.AllowTransactionalOutput ||
                    (this.AllowTransactionalOutput != null &&
                    this.AllowTransactionalOutput.Equals(input.AllowTransactionalOutput))
                ) && 
                (
                    this.AdditionalVariables == input.AdditionalVariables ||
                    this.AdditionalVariables != null &&
                    input.AdditionalVariables != null &&
                    this.AdditionalVariables.SequenceEqual(input.AdditionalVariables)
                ) && 
                (
                    this.FileSettings == input.FileSettings ||
                    (this.FileSettings != null &&
                    this.FileSettings.Equals(input.FileSettings))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.PrivateKeyPath != null)
                    hashCode = hashCode * 59 + this.PrivateKeyPath.GetHashCode();
                if (this.AddAdditionalVariablesDirectly != null)
                    hashCode = hashCode * 59 + this.AddAdditionalVariablesDirectly.GetHashCode();
                if (this.DirectAdditionalVariablesLocation != null)
                    hashCode = hashCode * 59 + this.DirectAdditionalVariablesLocation.GetHashCode();
                if (this.InitialResponseImpact != null)
                    hashCode = hashCode * 59 + this.InitialResponseImpact.GetHashCode();
                if (this.FtpUri != null)
                    hashCode = hashCode * 59 + this.FtpUri.GetHashCode();
                if (this.AddCommunicationKey != null)
                    hashCode = hashCode * 59 + this.AddCommunicationKey.GetHashCode();
                if (this.Overwrite != null)
                    hashCode = hashCode * 59 + this.Overwrite.GetHashCode();
                if (this.AllowTransactionalOutput != null)
                    hashCode = hashCode * 59 + this.AllowTransactionalOutput.GetHashCode();
                if (this.AdditionalVariables != null)
                    hashCode = hashCode * 59 + this.AdditionalVariables.GetHashCode();
                if (this.FileSettings != null)
                    hashCode = hashCode * 59 + this.FileSettings.GetHashCode();
                return hashCode;
            }
        }
    }
}