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
    /// Summary details for a user
    /// </summary>
    [DataContract]
        public partial class UserSummary :  IEquatable<UserSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSummary" /> class.
        /// </summary>
        /// <param name="id">The user&#x27;s id (required).</param>
        /// <param name="username">The user&#x27;s username (required).</param>
        /// <param name="systems">The systems that the user is connected to (required).</param>
        /// <param name="bundles">The bundles that the user is a licensed to use (required).</param>
        /// <param name="groupId">The id of the group the user is in (or null if they aren&#x27;t allocated to a group) (required).</param>
        /// <param name="groups">The groups that the user is a member of (required).</param>
        /// <param name="firstname">The user&#x27;s first name (required).</param>
        /// <param name="surname">The user&#x27;s surname (required).</param>
        /// <param name="emailAddress">The user&#x27;s email address (required).</param>
        /// <param name="userDisabledDate">The date on which the user was or will become disabled,  or null if the user has not been disabled.</param>
        /// <param name="lastAccessDate">The date on which the user last accessed the system.</param>
        /// <param name="userLockedOutDate">The date on which the user was locked out.</param>
        /// <param name="loginFailures">The amount of times a user failed a login attempt.</param>
        /// <param name="timePasswordSet">The time the users password was set.</param>
        /// <param name="passwordManuallyExpired">Whether the users password has manually expired.</param>
        /// <param name="passwordNeverExpires">Whether the users password never expires.</param>
        public UserSummary(int? id = default(int?), string username = default(string), List<string> systems = default(List<string>), List<LicensedUserBundle> bundles = default(List<LicensedUserBundle>), int? groupId = default(int?), List<GroupSummary> groups = default(List<GroupSummary>), string firstname = default(string), string surname = default(string), string emailAddress = default(string), DateTime? userDisabledDate = default(DateTime?), DateTime? lastAccessDate = default(DateTime?), DateTime? userLockedOutDate = default(DateTime?), int? loginFailures = default(int?), DateTime? timePasswordSet = default(DateTime?), bool? passwordManuallyExpired = default(bool?), bool? passwordNeverExpires = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UserSummary and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for UserSummary and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            // to ensure "systems" is required (not null)
            if (systems == null)
            {
                throw new InvalidDataException("systems is a required property for UserSummary and cannot be null");
            }
            else
            {
                this.Systems = systems;
            }
            // to ensure "bundles" is required (not null)
            if (bundles == null)
            {
                throw new InvalidDataException("bundles is a required property for UserSummary and cannot be null");
            }
            else
            {
                this.Bundles = bundles;
            }
            // to ensure "groupId" is required (not null)
            if (groupId == null)
            {
                throw new InvalidDataException("groupId is a required property for UserSummary and cannot be null");
            }
            else
            {
                this.GroupId = groupId;
            }
            // to ensure "groups" is required (not null)
            if (groups == null)
            {
                throw new InvalidDataException("groups is a required property for UserSummary and cannot be null");
            }
            else
            {
                this.Groups = groups;
            }
            // to ensure "firstname" is required (not null)
            if (firstname == null)
            {
                throw new InvalidDataException("firstname is a required property for UserSummary and cannot be null");
            }
            else
            {
                this.Firstname = firstname;
            }
            // to ensure "surname" is required (not null)
            if (surname == null)
            {
                throw new InvalidDataException("surname is a required property for UserSummary and cannot be null");
            }
            else
            {
                this.Surname = surname;
            }
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null)
            {
                throw new InvalidDataException("emailAddress is a required property for UserSummary and cannot be null");
            }
            else
            {
                this.EmailAddress = emailAddress;
            }
            this.UserDisabledDate = userDisabledDate;
            this.LastAccessDate = lastAccessDate;
            this.UserLockedOutDate = userLockedOutDate;
            this.LoginFailures = loginFailures;
            this.TimePasswordSet = timePasswordSet;
            this.PasswordManuallyExpired = passwordManuallyExpired;
            this.PasswordNeverExpires = passwordNeverExpires;
        }
        
        /// <summary>
        /// The user&#x27;s id
        /// </summary>
        /// <value>The user&#x27;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The user&#x27;s username
        /// </summary>
        /// <value>The user&#x27;s username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The systems that the user is connected to
        /// </summary>
        /// <value>The systems that the user is connected to</value>
        [DataMember(Name="systems", EmitDefaultValue=false)]
        public List<string> Systems { get; set; }

        /// <summary>
        /// The bundles that the user is a licensed to use
        /// </summary>
        /// <value>The bundles that the user is a licensed to use</value>
        [DataMember(Name="bundles", EmitDefaultValue=false)]
        public List<LicensedUserBundle> Bundles { get; set; }

        /// <summary>
        /// The id of the group the user is in (or null if they aren&#x27;t allocated to a group)
        /// </summary>
        /// <value>The id of the group the user is in (or null if they aren&#x27;t allocated to a group)</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// The groups that the user is a member of
        /// </summary>
        /// <value>The groups that the user is a member of</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<GroupSummary> Groups { get; set; }

        /// <summary>
        /// The user&#x27;s first name
        /// </summary>
        /// <value>The user&#x27;s first name</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// The user&#x27;s surname
        /// </summary>
        /// <value>The user&#x27;s surname</value>
        [DataMember(Name="surname", EmitDefaultValue=false)]
        public string Surname { get; set; }

        /// <summary>
        /// The user&#x27;s email address
        /// </summary>
        /// <value>The user&#x27;s email address</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The date on which the user was or will become disabled,  or null if the user has not been disabled
        /// </summary>
        /// <value>The date on which the user was or will become disabled,  or null if the user has not been disabled</value>
        [DataMember(Name="userDisabledDate", EmitDefaultValue=false)]
        public DateTime? UserDisabledDate { get; set; }

        /// <summary>
        /// The date on which the user last accessed the system
        /// </summary>
        /// <value>The date on which the user last accessed the system</value>
        [DataMember(Name="lastAccessDate", EmitDefaultValue=false)]
        public DateTime? LastAccessDate { get; set; }

        /// <summary>
        /// The date on which the user was locked out
        /// </summary>
        /// <value>The date on which the user was locked out</value>
        [DataMember(Name="userLockedOutDate", EmitDefaultValue=false)]
        public DateTime? UserLockedOutDate { get; set; }

        /// <summary>
        /// The amount of times a user failed a login attempt
        /// </summary>
        /// <value>The amount of times a user failed a login attempt</value>
        [DataMember(Name="loginFailures", EmitDefaultValue=false)]
        public int? LoginFailures { get; set; }

        /// <summary>
        /// The time the users password was set
        /// </summary>
        /// <value>The time the users password was set</value>
        [DataMember(Name="timePasswordSet", EmitDefaultValue=false)]
        public DateTime? TimePasswordSet { get; set; }

        /// <summary>
        /// Whether the users password has manually expired
        /// </summary>
        /// <value>Whether the users password has manually expired</value>
        [DataMember(Name="passwordManuallyExpired", EmitDefaultValue=false)]
        public bool? PasswordManuallyExpired { get; set; }

        /// <summary>
        /// Whether the users password never expires
        /// </summary>
        /// <value>Whether the users password never expires</value>
        [DataMember(Name="passwordNeverExpires", EmitDefaultValue=false)]
        public bool? PasswordNeverExpires { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Systems: ").Append(Systems).Append("\n");
            sb.Append("  Bundles: ").Append(Bundles).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  UserDisabledDate: ").Append(UserDisabledDate).Append("\n");
            sb.Append("  LastAccessDate: ").Append(LastAccessDate).Append("\n");
            sb.Append("  UserLockedOutDate: ").Append(UserLockedOutDate).Append("\n");
            sb.Append("  LoginFailures: ").Append(LoginFailures).Append("\n");
            sb.Append("  TimePasswordSet: ").Append(TimePasswordSet).Append("\n");
            sb.Append("  PasswordManuallyExpired: ").Append(PasswordManuallyExpired).Append("\n");
            sb.Append("  PasswordNeverExpires: ").Append(PasswordNeverExpires).Append("\n");
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
            return this.Equals(input as UserSummary);
        }

        /// <summary>
        /// Returns true if UserSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSummary input)
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
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Systems == input.Systems ||
                    this.Systems != null &&
                    input.Systems != null &&
                    this.Systems.SequenceEqual(input.Systems)
                ) && 
                (
                    this.Bundles == input.Bundles ||
                    this.Bundles != null &&
                    input.Bundles != null &&
                    this.Bundles.SequenceEqual(input.Bundles)
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.UserDisabledDate == input.UserDisabledDate ||
                    (this.UserDisabledDate != null &&
                    this.UserDisabledDate.Equals(input.UserDisabledDate))
                ) && 
                (
                    this.LastAccessDate == input.LastAccessDate ||
                    (this.LastAccessDate != null &&
                    this.LastAccessDate.Equals(input.LastAccessDate))
                ) && 
                (
                    this.UserLockedOutDate == input.UserLockedOutDate ||
                    (this.UserLockedOutDate != null &&
                    this.UserLockedOutDate.Equals(input.UserLockedOutDate))
                ) && 
                (
                    this.LoginFailures == input.LoginFailures ||
                    (this.LoginFailures != null &&
                    this.LoginFailures.Equals(input.LoginFailures))
                ) && 
                (
                    this.TimePasswordSet == input.TimePasswordSet ||
                    (this.TimePasswordSet != null &&
                    this.TimePasswordSet.Equals(input.TimePasswordSet))
                ) && 
                (
                    this.PasswordManuallyExpired == input.PasswordManuallyExpired ||
                    (this.PasswordManuallyExpired != null &&
                    this.PasswordManuallyExpired.Equals(input.PasswordManuallyExpired))
                ) && 
                (
                    this.PasswordNeverExpires == input.PasswordNeverExpires ||
                    (this.PasswordNeverExpires != null &&
                    this.PasswordNeverExpires.Equals(input.PasswordNeverExpires))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Systems != null)
                    hashCode = hashCode * 59 + this.Systems.GetHashCode();
                if (this.Bundles != null)
                    hashCode = hashCode * 59 + this.Bundles.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.UserDisabledDate != null)
                    hashCode = hashCode * 59 + this.UserDisabledDate.GetHashCode();
                if (this.LastAccessDate != null)
                    hashCode = hashCode * 59 + this.LastAccessDate.GetHashCode();
                if (this.UserLockedOutDate != null)
                    hashCode = hashCode * 59 + this.UserLockedOutDate.GetHashCode();
                if (this.LoginFailures != null)
                    hashCode = hashCode * 59 + this.LoginFailures.GetHashCode();
                if (this.TimePasswordSet != null)
                    hashCode = hashCode * 59 + this.TimePasswordSet.GetHashCode();
                if (this.PasswordManuallyExpired != null)
                    hashCode = hashCode * 59 + this.PasswordManuallyExpired.GetHashCode();
                if (this.PasswordNeverExpires != null)
                    hashCode = hashCode * 59 + this.PasswordNeverExpires.GetHashCode();
                return hashCode;
            }
        }
    }
}
