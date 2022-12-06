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
    /// Details for how a shareable item is shared
    /// </summary>
    [DataContract]
        public partial class ShareDetail :  IEquatable<ShareDetail>
    {
        /// <summary>
        /// The type of the shareable item (collection, audience, etc.)
        /// </summary>
        /// <value>The type of the shareable item (collection, audience, etc.)</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ShareableTypeEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            /// <summary>
            /// Enum Collection for value: Collection
            /// </summary>
            [EnumMember(Value = "Collection")]
            Collection = 2,
            /// <summary>
            /// Enum Audience for value: Audience
            /// </summary>
            [EnumMember(Value = "Audience")]
            Audience = 3,
            /// <summary>
            /// Enum Dashboard for value: Dashboard
            /// </summary>
            [EnumMember(Value = "Dashboard")]
            Dashboard = 4,
            /// <summary>
            /// Enum AudienceComposition for value: AudienceComposition
            /// </summary>
            [EnumMember(Value = "AudienceComposition")]
            AudienceComposition = 5,
            /// <summary>
            /// Enum Workspace for value: Workspace
            /// </summary>
            [EnumMember(Value = "Workspace")]
            Workspace = 6,
            /// <summary>
            /// Enum AudienceExportTemplate for value: AudienceExportTemplate
            /// </summary>
            [EnumMember(Value = "AudienceExportTemplate")]
            AudienceExportTemplate = 7        }
        /// <summary>
        /// The type of the shareable item (collection, audience, etc.)
        /// </summary>
        /// <value>The type of the shareable item (collection, audience, etc.)</value>
        [DataMember(Name="shareableType", EmitDefaultValue=false)]
        public ShareableTypeEnum ShareableType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareDetail" /> class.
        /// </summary>
        /// <param name="id">The id of the share (required).</param>
        /// <param name="shareableType">The type of the shareable item (collection, audience, etc.) (required).</param>
        /// <param name="shareableId">The id of the shareable item being shared (required).</param>
        /// <param name="shareableTitle">The title of the shareable item being shared (required).</param>
        /// <param name="numberOfUsersSharedWith">The number of people the shareable item has been shared with (required).</param>
        /// <param name="sharedToAll">Whether the shareable item has been shared to all users (required).</param>
        /// <param name="sharedToAllPermissions">The permissions the shareable item has been shared to all with (required).</param>
        /// <param name="viewShareableUrl">The URL of a page that will allow users to view the shareable item. (required).</param>
        public ShareDetail(int? id = default(int?), ShareableTypeEnum shareableType = default(ShareableTypeEnum), int? shareableId = default(int?), string shareableTitle = default(string), int? numberOfUsersSharedWith = default(int?), bool? sharedToAll = default(bool?), int? sharedToAllPermissions = default(int?), string viewShareableUrl = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ShareDetail and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "shareableType" is required (not null)
            if (shareableType == null)
            {
                throw new InvalidDataException("shareableType is a required property for ShareDetail and cannot be null");
            }
            else
            {
                this.ShareableType = shareableType;
            }
            // to ensure "shareableId" is required (not null)
            if (shareableId == null)
            {
                throw new InvalidDataException("shareableId is a required property for ShareDetail and cannot be null");
            }
            else
            {
                this.ShareableId = shareableId;
            }
            // to ensure "shareableTitle" is required (not null)
            if (shareableTitle == null)
            {
                throw new InvalidDataException("shareableTitle is a required property for ShareDetail and cannot be null");
            }
            else
            {
                this.ShareableTitle = shareableTitle;
            }
            // to ensure "numberOfUsersSharedWith" is required (not null)
            if (numberOfUsersSharedWith == null)
            {
                throw new InvalidDataException("numberOfUsersSharedWith is a required property for ShareDetail and cannot be null");
            }
            else
            {
                this.NumberOfUsersSharedWith = numberOfUsersSharedWith;
            }
            // to ensure "sharedToAll" is required (not null)
            if (sharedToAll == null)
            {
                throw new InvalidDataException("sharedToAll is a required property for ShareDetail and cannot be null");
            }
            else
            {
                this.SharedToAll = sharedToAll;
            }
            // to ensure "sharedToAllPermissions" is required (not null)
            if (sharedToAllPermissions == null)
            {
                throw new InvalidDataException("sharedToAllPermissions is a required property for ShareDetail and cannot be null");
            }
            else
            {
                this.SharedToAllPermissions = sharedToAllPermissions;
            }
            // to ensure "viewShareableUrl" is required (not null)
            if (viewShareableUrl == null)
            {
                throw new InvalidDataException("viewShareableUrl is a required property for ShareDetail and cannot be null");
            }
            else
            {
                this.ViewShareableUrl = viewShareableUrl;
            }
        }
        
        /// <summary>
        /// The id of the share
        /// </summary>
        /// <value>The id of the share</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// The id of the shareable item being shared
        /// </summary>
        /// <value>The id of the shareable item being shared</value>
        [DataMember(Name="shareableId", EmitDefaultValue=false)]
        public int? ShareableId { get; set; }

        /// <summary>
        /// The title of the shareable item being shared
        /// </summary>
        /// <value>The title of the shareable item being shared</value>
        [DataMember(Name="shareableTitle", EmitDefaultValue=false)]
        public string ShareableTitle { get; set; }

        /// <summary>
        /// The number of people the shareable item has been shared with
        /// </summary>
        /// <value>The number of people the shareable item has been shared with</value>
        [DataMember(Name="numberOfUsersSharedWith", EmitDefaultValue=false)]
        public int? NumberOfUsersSharedWith { get; set; }

        /// <summary>
        /// Whether the shareable item has been shared to all users
        /// </summary>
        /// <value>Whether the shareable item has been shared to all users</value>
        [DataMember(Name="sharedToAll", EmitDefaultValue=false)]
        public bool? SharedToAll { get; set; }

        /// <summary>
        /// The permissions the shareable item has been shared to all with
        /// </summary>
        /// <value>The permissions the shareable item has been shared to all with</value>
        [DataMember(Name="sharedToAllPermissions", EmitDefaultValue=false)]
        public int? SharedToAllPermissions { get; set; }

        /// <summary>
        /// The URL of a page that will allow users to view the shareable item.
        /// </summary>
        /// <value>The URL of a page that will allow users to view the shareable item.</value>
        [DataMember(Name="viewShareableUrl", EmitDefaultValue=false)]
        public string ViewShareableUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ShareableType: ").Append(ShareableType).Append("\n");
            sb.Append("  ShareableId: ").Append(ShareableId).Append("\n");
            sb.Append("  ShareableTitle: ").Append(ShareableTitle).Append("\n");
            sb.Append("  NumberOfUsersSharedWith: ").Append(NumberOfUsersSharedWith).Append("\n");
            sb.Append("  SharedToAll: ").Append(SharedToAll).Append("\n");
            sb.Append("  SharedToAllPermissions: ").Append(SharedToAllPermissions).Append("\n");
            sb.Append("  ViewShareableUrl: ").Append(ViewShareableUrl).Append("\n");
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
            return this.Equals(input as ShareDetail);
        }

        /// <summary>
        /// Returns true if ShareDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShareDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ShareableType == input.ShareableType ||
                    (this.ShareableType != null &&
                    this.ShareableType.Equals(input.ShareableType))
                ) && 
                (
                    this.ShareableId == input.ShareableId ||
                    (this.ShareableId != null &&
                    this.ShareableId.Equals(input.ShareableId))
                ) && 
                (
                    this.ShareableTitle == input.ShareableTitle ||
                    (this.ShareableTitle != null &&
                    this.ShareableTitle.Equals(input.ShareableTitle))
                ) && 
                (
                    this.NumberOfUsersSharedWith == input.NumberOfUsersSharedWith ||
                    (this.NumberOfUsersSharedWith != null &&
                    this.NumberOfUsersSharedWith.Equals(input.NumberOfUsersSharedWith))
                ) && 
                (
                    this.SharedToAll == input.SharedToAll ||
                    (this.SharedToAll != null &&
                    this.SharedToAll.Equals(input.SharedToAll))
                ) && 
                (
                    this.SharedToAllPermissions == input.SharedToAllPermissions ||
                    (this.SharedToAllPermissions != null &&
                    this.SharedToAllPermissions.Equals(input.SharedToAllPermissions))
                ) && 
                (
                    this.ViewShareableUrl == input.ViewShareableUrl ||
                    (this.ViewShareableUrl != null &&
                    this.ViewShareableUrl.Equals(input.ViewShareableUrl))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ShareableType != null)
                    hashCode = hashCode * 59 + this.ShareableType.GetHashCode();
                if (this.ShareableId != null)
                    hashCode = hashCode * 59 + this.ShareableId.GetHashCode();
                if (this.ShareableTitle != null)
                    hashCode = hashCode * 59 + this.ShareableTitle.GetHashCode();
                if (this.NumberOfUsersSharedWith != null)
                    hashCode = hashCode * 59 + this.NumberOfUsersSharedWith.GetHashCode();
                if (this.SharedToAll != null)
                    hashCode = hashCode * 59 + this.SharedToAll.GetHashCode();
                if (this.SharedToAllPermissions != null)
                    hashCode = hashCode * 59 + this.SharedToAllPermissions.GetHashCode();
                if (this.ViewShareableUrl != null)
                    hashCode = hashCode * 59 + this.ViewShareableUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
