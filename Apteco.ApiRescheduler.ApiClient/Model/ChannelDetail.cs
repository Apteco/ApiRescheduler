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
    /// Details for a PeopleStage Channel
    /// </summary>
    [DataContract]
        public partial class ChannelDetail :  IEquatable<ChannelDetail>
    {
        /// <summary>
        /// The channel&#x27;s type
        /// </summary>
        /// <value>The channel&#x27;s type</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            /// <summary>
            /// Enum Control for value: Control
            /// </summary>
            [EnumMember(Value = "Control")]
            Control = 2,
            /// <summary>
            /// Enum Broadcast for value: Broadcast
            /// </summary>
            [EnumMember(Value = "Broadcast")]
            Broadcast = 3,
            /// <summary>
            /// Enum File for value: File
            /// </summary>
            [EnumMember(Value = "File")]
            File = 4,
            /// <summary>
            /// Enum Ftp for value: Ftp
            /// </summary>
            [EnumMember(Value = "Ftp")]
            Ftp = 5,
            /// <summary>
            /// Enum Facebook for value: Facebook
            /// </summary>
            [EnumMember(Value = "Facebook")]
            Facebook = 6,
            /// <summary>
            /// Enum MicrosoftDynamics for value: MicrosoftDynamics
            /// </summary>
            [EnumMember(Value = "MicrosoftDynamics")]
            MicrosoftDynamics = 7,
            /// <summary>
            /// Enum SalesForce for value: SalesForce
            /// </summary>
            [EnumMember(Value = "SalesForce")]
            SalesForce = 8,
            /// <summary>
            /// Enum PushNotification for value: PushNotification
            /// </summary>
            [EnumMember(Value = "PushNotification")]
            PushNotification = 9,
            /// <summary>
            /// Enum Twitter for value: Twitter
            /// </summary>
            [EnumMember(Value = "Twitter")]
            Twitter = 10,
            /// <summary>
            /// Enum Google for value: Google
            /// </summary>
            [EnumMember(Value = "Google")]
            Google = 11,
            /// <summary>
            /// Enum LinkedIn for value: LinkedIn
            /// </summary>
            [EnumMember(Value = "LinkedIn")]
            LinkedIn = 12,
            /// <summary>
            /// Enum PullMarketing for value: PullMarketing
            /// </summary>
            [EnumMember(Value = "PullMarketing")]
            PullMarketing = 13,
            /// <summary>
            /// Enum Composite for value: Composite
            /// </summary>
            [EnumMember(Value = "Composite")]
            Composite = 14,
            /// <summary>
            /// Enum Email for value: Email
            /// </summary>
            [EnumMember(Value = "Email")]
            Email = 15,
            /// <summary>
            /// Enum Sms for value: Sms
            /// </summary>
            [EnumMember(Value = "Sms")]
            Sms = 16,
            /// <summary>
            /// Enum Waba for value: Waba
            /// </summary>
            [EnumMember(Value = "Waba")]
            Waba = 17,
            /// <summary>
            /// Enum Mock for value: Mock
            /// </summary>
            [EnumMember(Value = "Mock")]
            Mock = 18        }
        /// <summary>
        /// The channel&#x27;s type
        /// </summary>
        /// <value>The channel&#x27;s type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// The access rights for the channel
        /// </summary>
        /// <value>The access rights for the channel</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AccessRightsEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            /// <summary>
            /// Enum Create for value: Create
            /// </summary>
            [EnumMember(Value = "Create")]
            Create = 2,
            /// <summary>
            /// Enum Read for value: Read
            /// </summary>
            [EnumMember(Value = "Read")]
            Read = 3,
            /// <summary>
            /// Enum Update for value: Update
            /// </summary>
            [EnumMember(Value = "Update")]
            Update = 4,
            /// <summary>
            /// Enum Delete for value: Delete
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete = 5,
            /// <summary>
            /// Enum All for value: All
            /// </summary>
            [EnumMember(Value = "All")]
            All = 6        }
        /// <summary>
        /// The access rights for the channel
        /// </summary>
        /// <value>The access rights for the channel</value>
        [DataMember(Name="accessRights", EmitDefaultValue=false)]
        public AccessRightsEnum? AccessRights { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelDetail" /> class.
        /// </summary>
        /// <param name="broadcastOutputSettings">broadcastOutputSettings.</param>
        /// <param name="fileOutputSettings">fileOutputSettings.</param>
        /// <param name="ftpOutputSettings">ftpOutputSettings.</param>
        /// <param name="id">The channel&#x27;s id (required).</param>
        /// <param name="schemaId">The channel&#x27;s \&quot;schema id\&quot;, used for looking up information about the channel in the run history of PeopleStage.</param>
        /// <param name="description">The channel&#x27;s description (required).</param>
        /// <param name="type">The channel&#x27;s type (required).</param>
        /// <param name="parentId">The id of the channel&#x27;s parent.</param>
        /// <param name="systemLookup">systemLookup.</param>
        /// <param name="accessRights">The access rights for the channel.</param>
        public ChannelDetail(BroadcastOutputSettingsDetail broadcastOutputSettings = default(BroadcastOutputSettingsDetail), FileOutputSettingsDetail fileOutputSettings = default(FileOutputSettingsDetail), FtpOutputSettingsDetail ftpOutputSettings = default(FtpOutputSettingsDetail), string id = default(string), int? schemaId = default(int?), string description = default(string), TypeEnum type = default(TypeEnum), string parentId = default(string), SystemLookup systemLookup = default(SystemLookup), AccessRightsEnum? accessRights = default(AccessRightsEnum?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ChannelDetail and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for ChannelDetail and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ChannelDetail and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.BroadcastOutputSettings = broadcastOutputSettings;
            this.FileOutputSettings = fileOutputSettings;
            this.FtpOutputSettings = ftpOutputSettings;
            this.SchemaId = schemaId;
            this.ParentId = parentId;
            this.SystemLookup = systemLookup;
            this.AccessRights = accessRights;
        }
        
        /// <summary>
        /// Gets or Sets BroadcastOutputSettings
        /// </summary>
        [DataMember(Name="broadcastOutputSettings", EmitDefaultValue=false)]
        public BroadcastOutputSettingsDetail BroadcastOutputSettings { get; set; }

        /// <summary>
        /// Gets or Sets FileOutputSettings
        /// </summary>
        [DataMember(Name="fileOutputSettings", EmitDefaultValue=false)]
        public FileOutputSettingsDetail FileOutputSettings { get; set; }

        /// <summary>
        /// Gets or Sets FtpOutputSettings
        /// </summary>
        [DataMember(Name="ftpOutputSettings", EmitDefaultValue=false)]
        public FtpOutputSettingsDetail FtpOutputSettings { get; set; }

        /// <summary>
        /// The channel&#x27;s id
        /// </summary>
        /// <value>The channel&#x27;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The channel&#x27;s \&quot;schema id\&quot;, used for looking up information about the channel in the run history of PeopleStage
        /// </summary>
        /// <value>The channel&#x27;s \&quot;schema id\&quot;, used for looking up information about the channel in the run history of PeopleStage</value>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public int? SchemaId { get; set; }

        /// <summary>
        /// The channel&#x27;s description
        /// </summary>
        /// <value>The channel&#x27;s description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// The id of the channel&#x27;s parent
        /// </summary>
        /// <value>The id of the channel&#x27;s parent</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public string ParentId { get; set; }

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
            sb.Append("class ChannelDetail {\n");
            sb.Append("  BroadcastOutputSettings: ").Append(BroadcastOutputSettings).Append("\n");
            sb.Append("  FileOutputSettings: ").Append(FileOutputSettings).Append("\n");
            sb.Append("  FtpOutputSettings: ").Append(FtpOutputSettings).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  SystemLookup: ").Append(SystemLookup).Append("\n");
            sb.Append("  AccessRights: ").Append(AccessRights).Append("\n");
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
            return this.Equals(input as ChannelDetail);
        }

        /// <summary>
        /// Returns true if ChannelDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BroadcastOutputSettings == input.BroadcastOutputSettings ||
                    (this.BroadcastOutputSettings != null &&
                    this.BroadcastOutputSettings.Equals(input.BroadcastOutputSettings))
                ) && 
                (
                    this.FileOutputSettings == input.FileOutputSettings ||
                    (this.FileOutputSettings != null &&
                    this.FileOutputSettings.Equals(input.FileOutputSettings))
                ) && 
                (
                    this.FtpOutputSettings == input.FtpOutputSettings ||
                    (this.FtpOutputSettings != null &&
                    this.FtpOutputSettings.Equals(input.FtpOutputSettings))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SchemaId == input.SchemaId ||
                    (this.SchemaId != null &&
                    this.SchemaId.Equals(input.SchemaId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.SystemLookup == input.SystemLookup ||
                    (this.SystemLookup != null &&
                    this.SystemLookup.Equals(input.SystemLookup))
                ) && 
                (
                    this.AccessRights == input.AccessRights ||
                    (this.AccessRights != null &&
                    this.AccessRights.Equals(input.AccessRights))
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
                if (this.BroadcastOutputSettings != null)
                    hashCode = hashCode * 59 + this.BroadcastOutputSettings.GetHashCode();
                if (this.FileOutputSettings != null)
                    hashCode = hashCode * 59 + this.FileOutputSettings.GetHashCode();
                if (this.FtpOutputSettings != null)
                    hashCode = hashCode * 59 + this.FtpOutputSettings.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SchemaId != null)
                    hashCode = hashCode * 59 + this.SchemaId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.SystemLookup != null)
                    hashCode = hashCode * 59 + this.SystemLookup.GetHashCode();
                if (this.AccessRights != null)
                    hashCode = hashCode * 59 + this.AccessRights.GetHashCode();
                return hashCode;
            }
        }
    }
}
