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
    /// Details for a collection viewable by a given user
    /// </summary>
    [DataContract]
        public partial class UserCollectionDetail :  IEquatable<UserCollectionDetail>
    {
        /// <summary>
        /// The status of the collection
        /// </summary>
        /// <value>The status of the collection</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,
            /// <summary>
            /// Enum Pinned for value: Pinned
            /// </summary>
            [EnumMember(Value = "Pinned")]
            Pinned = 2,
            /// <summary>
            /// Enum Archived for value: Archived
            /// </summary>
            [EnumMember(Value = "Archived")]
            Archived = 3        }
        /// <summary>
        /// The status of the collection
        /// </summary>
        /// <value>The status of the collection</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCollectionDetail" /> class.
        /// </summary>
        /// <param name="viewingUsername">The username of the user that has access to this collection (required).</param>
        /// <param name="status">The status of the collection (required).</param>
        /// <param name="sharedToMe">Whether this collection has been shared to the given user by someone else (required).</param>
        /// <param name="sharedByMe">Whether this collection has been shared to others by the given user (required).</param>
        /// <param name="accessRights">The access rights for this collection for the given user.</param>
        /// <param name="id">The collection&#x27;s id (required).</param>
        /// <param name="owner">owner (required).</param>
        /// <param name="numberOfParts">The number of parts within this collection.</param>
        /// <param name="numberOfUsersSharedWith">The number of people this collection has been shared with (required).</param>
        /// <param name="sharedToAll">Whether this collection has been shared with all users (required).</param>
        /// <param name="shareId">The id of the share associated with this collection, or null if the  collection has not yet been shared (required).</param>
        /// <param name="numberOfHits">The number of hits associated with this collection (required).</param>
        /// <param name="systemName">The FastStats system that this collection has been created against (required).</param>
        /// <param name="title">The title of the collection (required).</param>
        /// <param name="description">The description of the collection (required).</param>
        /// <param name="creationDate">The date the collection was created (required).</param>
        /// <param name="filePath">The path to the file that contains the parts of this collection (required).</param>
        /// <param name="deletionDate">The date the collection was deleted, or null if it has not been deleted.</param>
        public UserCollectionDetail(string viewingUsername = default(string), StatusEnum status = default(StatusEnum), bool? sharedToMe = default(bool?), bool? sharedByMe = default(bool?), int? accessRights = default(int?), int? id = default(int?), UserDisplayDetails owner = default(UserDisplayDetails), int? numberOfParts = default(int?), int? numberOfUsersSharedWith = default(int?), bool? sharedToAll = default(bool?), int? shareId = default(int?), int? numberOfHits = default(int?), string systemName = default(string), string title = default(string), string description = default(string), DateTime? creationDate = default(DateTime?), string filePath = default(string), DateTime? deletionDate = default(DateTime?))
        {
            // to ensure "viewingUsername" is required (not null)
            if (viewingUsername == null)
            {
                throw new InvalidDataException("viewingUsername is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.ViewingUsername = viewingUsername;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "sharedToMe" is required (not null)
            if (sharedToMe == null)
            {
                throw new InvalidDataException("sharedToMe is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.SharedToMe = sharedToMe;
            }
            // to ensure "sharedByMe" is required (not null)
            if (sharedByMe == null)
            {
                throw new InvalidDataException("sharedByMe is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.SharedByMe = sharedByMe;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            // to ensure "numberOfUsersSharedWith" is required (not null)
            if (numberOfUsersSharedWith == null)
            {
                throw new InvalidDataException("numberOfUsersSharedWith is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.NumberOfUsersSharedWith = numberOfUsersSharedWith;
            }
            // to ensure "sharedToAll" is required (not null)
            if (sharedToAll == null)
            {
                throw new InvalidDataException("sharedToAll is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.SharedToAll = sharedToAll;
            }
            // to ensure "shareId" is required (not null)
            if (shareId == null)
            {
                throw new InvalidDataException("shareId is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.ShareId = shareId;
            }
            // to ensure "numberOfHits" is required (not null)
            if (numberOfHits == null)
            {
                throw new InvalidDataException("numberOfHits is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.NumberOfHits = numberOfHits;
            }
            // to ensure "systemName" is required (not null)
            if (systemName == null)
            {
                throw new InvalidDataException("systemName is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.SystemName = systemName;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "creationDate" is required (not null)
            if (creationDate == null)
            {
                throw new InvalidDataException("creationDate is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.CreationDate = creationDate;
            }
            // to ensure "filePath" is required (not null)
            if (filePath == null)
            {
                throw new InvalidDataException("filePath is a required property for UserCollectionDetail and cannot be null");
            }
            else
            {
                this.FilePath = filePath;
            }
            this.AccessRights = accessRights;
            this.NumberOfParts = numberOfParts;
            this.DeletionDate = deletionDate;
        }
        
        /// <summary>
        /// The username of the user that has access to this collection
        /// </summary>
        /// <value>The username of the user that has access to this collection</value>
        [DataMember(Name="viewingUsername", EmitDefaultValue=false)]
        public string ViewingUsername { get; set; }


        /// <summary>
        /// Whether this collection has been shared to the given user by someone else
        /// </summary>
        /// <value>Whether this collection has been shared to the given user by someone else</value>
        [DataMember(Name="sharedToMe", EmitDefaultValue=false)]
        public bool? SharedToMe { get; set; }

        /// <summary>
        /// Whether this collection has been shared to others by the given user
        /// </summary>
        /// <value>Whether this collection has been shared to others by the given user</value>
        [DataMember(Name="sharedByMe", EmitDefaultValue=false)]
        public bool? SharedByMe { get; set; }

        /// <summary>
        /// The access rights for this collection for the given user
        /// </summary>
        /// <value>The access rights for this collection for the given user</value>
        [DataMember(Name="accessRights", EmitDefaultValue=false)]
        public int? AccessRights { get; set; }

        /// <summary>
        /// The collection&#x27;s id
        /// </summary>
        /// <value>The collection&#x27;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserDisplayDetails Owner { get; set; }

        /// <summary>
        /// The number of parts within this collection
        /// </summary>
        /// <value>The number of parts within this collection</value>
        [DataMember(Name="numberOfParts", EmitDefaultValue=false)]
        public int? NumberOfParts { get; set; }

        /// <summary>
        /// The number of people this collection has been shared with
        /// </summary>
        /// <value>The number of people this collection has been shared with</value>
        [DataMember(Name="numberOfUsersSharedWith", EmitDefaultValue=false)]
        public int? NumberOfUsersSharedWith { get; set; }

        /// <summary>
        /// Whether this collection has been shared with all users
        /// </summary>
        /// <value>Whether this collection has been shared with all users</value>
        [DataMember(Name="sharedToAll", EmitDefaultValue=false)]
        public bool? SharedToAll { get; set; }

        /// <summary>
        /// The id of the share associated with this collection, or null if the  collection has not yet been shared
        /// </summary>
        /// <value>The id of the share associated with this collection, or null if the  collection has not yet been shared</value>
        [DataMember(Name="shareId", EmitDefaultValue=false)]
        public int? ShareId { get; set; }

        /// <summary>
        /// The number of hits associated with this collection
        /// </summary>
        /// <value>The number of hits associated with this collection</value>
        [DataMember(Name="numberOfHits", EmitDefaultValue=false)]
        public int? NumberOfHits { get; set; }

        /// <summary>
        /// The FastStats system that this collection has been created against
        /// </summary>
        /// <value>The FastStats system that this collection has been created against</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// The title of the collection
        /// </summary>
        /// <value>The title of the collection</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the collection
        /// </summary>
        /// <value>The description of the collection</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The date the collection was created
        /// </summary>
        /// <value>The date the collection was created</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// The path to the file that contains the parts of this collection
        /// </summary>
        /// <value>The path to the file that contains the parts of this collection</value>
        [DataMember(Name="filePath", EmitDefaultValue=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// The date the collection was deleted, or null if it has not been deleted
        /// </summary>
        /// <value>The date the collection was deleted, or null if it has not been deleted</value>
        [DataMember(Name="deletionDate", EmitDefaultValue=false)]
        public DateTime? DeletionDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCollectionDetail {\n");
            sb.Append("  ViewingUsername: ").Append(ViewingUsername).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SharedToMe: ").Append(SharedToMe).Append("\n");
            sb.Append("  SharedByMe: ").Append(SharedByMe).Append("\n");
            sb.Append("  AccessRights: ").Append(AccessRights).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  NumberOfParts: ").Append(NumberOfParts).Append("\n");
            sb.Append("  NumberOfUsersSharedWith: ").Append(NumberOfUsersSharedWith).Append("\n");
            sb.Append("  SharedToAll: ").Append(SharedToAll).Append("\n");
            sb.Append("  ShareId: ").Append(ShareId).Append("\n");
            sb.Append("  NumberOfHits: ").Append(NumberOfHits).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
            sb.Append("  DeletionDate: ").Append(DeletionDate).Append("\n");
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
            return this.Equals(input as UserCollectionDetail);
        }

        /// <summary>
        /// Returns true if UserCollectionDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCollectionDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCollectionDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ViewingUsername == input.ViewingUsername ||
                    (this.ViewingUsername != null &&
                    this.ViewingUsername.Equals(input.ViewingUsername))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SharedToMe == input.SharedToMe ||
                    (this.SharedToMe != null &&
                    this.SharedToMe.Equals(input.SharedToMe))
                ) && 
                (
                    this.SharedByMe == input.SharedByMe ||
                    (this.SharedByMe != null &&
                    this.SharedByMe.Equals(input.SharedByMe))
                ) && 
                (
                    this.AccessRights == input.AccessRights ||
                    (this.AccessRights != null &&
                    this.AccessRights.Equals(input.AccessRights))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.NumberOfParts == input.NumberOfParts ||
                    (this.NumberOfParts != null &&
                    this.NumberOfParts.Equals(input.NumberOfParts))
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
                    this.ShareId == input.ShareId ||
                    (this.ShareId != null &&
                    this.ShareId.Equals(input.ShareId))
                ) && 
                (
                    this.NumberOfHits == input.NumberOfHits ||
                    (this.NumberOfHits != null &&
                    this.NumberOfHits.Equals(input.NumberOfHits))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
                ) && 
                (
                    this.DeletionDate == input.DeletionDate ||
                    (this.DeletionDate != null &&
                    this.DeletionDate.Equals(input.DeletionDate))
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
                if (this.ViewingUsername != null)
                    hashCode = hashCode * 59 + this.ViewingUsername.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SharedToMe != null)
                    hashCode = hashCode * 59 + this.SharedToMe.GetHashCode();
                if (this.SharedByMe != null)
                    hashCode = hashCode * 59 + this.SharedByMe.GetHashCode();
                if (this.AccessRights != null)
                    hashCode = hashCode * 59 + this.AccessRights.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.NumberOfParts != null)
                    hashCode = hashCode * 59 + this.NumberOfParts.GetHashCode();
                if (this.NumberOfUsersSharedWith != null)
                    hashCode = hashCode * 59 + this.NumberOfUsersSharedWith.GetHashCode();
                if (this.SharedToAll != null)
                    hashCode = hashCode * 59 + this.SharedToAll.GetHashCode();
                if (this.ShareId != null)
                    hashCode = hashCode * 59 + this.ShareId.GetHashCode();
                if (this.NumberOfHits != null)
                    hashCode = hashCode * 59 + this.NumberOfHits.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.DeletionDate != null)
                    hashCode = hashCode * 59 + this.DeletionDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
