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
    /// Details of a user registration request
    /// </summary>
    [DataContract]
        public partial class UserRegistrationRequestDetail :  IEquatable<UserRegistrationRequestDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegistrationRequestDetail" /> class.
        /// </summary>
        /// <param name="confirmRegistrationUrl">The URL sent in the notification to the user to allow them to confirm their registration.</param>
        /// <param name="hasNotificationBeenSent">Whether the notification has been sent to the user or not. (required).</param>
        /// <param name="username">The requested username (required).</param>
        /// <param name="firstname">The requested first name.</param>
        /// <param name="surname">The requested surname.</param>
        /// <param name="emailAddress">The requested email address (required).</param>
        /// <param name="creationDate">The date and time this request was created (required).</param>
        /// <param name="confirmedDate">The date and time this request was confirmed.</param>
        /// <param name="expiredDate">The date and time this request expired.</param>
        public UserRegistrationRequestDetail(string confirmRegistrationUrl = default(string), bool? hasNotificationBeenSent = default(bool?), string username = default(string), string firstname = default(string), string surname = default(string), string emailAddress = default(string), DateTime? creationDate = default(DateTime?), DateTime? confirmedDate = default(DateTime?), DateTime? expiredDate = default(DateTime?))
        {
            // to ensure "hasNotificationBeenSent" is required (not null)
            if (hasNotificationBeenSent == null)
            {
                throw new InvalidDataException("hasNotificationBeenSent is a required property for UserRegistrationRequestDetail and cannot be null");
            }
            else
            {
                this.HasNotificationBeenSent = hasNotificationBeenSent;
            }
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for UserRegistrationRequestDetail and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null)
            {
                throw new InvalidDataException("emailAddress is a required property for UserRegistrationRequestDetail and cannot be null");
            }
            else
            {
                this.EmailAddress = emailAddress;
            }
            // to ensure "creationDate" is required (not null)
            if (creationDate == null)
            {
                throw new InvalidDataException("creationDate is a required property for UserRegistrationRequestDetail and cannot be null");
            }
            else
            {
                this.CreationDate = creationDate;
            }
            this.ConfirmRegistrationUrl = confirmRegistrationUrl;
            this.Firstname = firstname;
            this.Surname = surname;
            this.ConfirmedDate = confirmedDate;
            this.ExpiredDate = expiredDate;
        }
        
        /// <summary>
        /// The URL sent in the notification to the user to allow them to confirm their registration
        /// </summary>
        /// <value>The URL sent in the notification to the user to allow them to confirm their registration</value>
        [DataMember(Name="confirmRegistrationUrl", EmitDefaultValue=false)]
        public string ConfirmRegistrationUrl { get; set; }

        /// <summary>
        /// Whether the notification has been sent to the user or not.
        /// </summary>
        /// <value>Whether the notification has been sent to the user or not.</value>
        [DataMember(Name="hasNotificationBeenSent", EmitDefaultValue=false)]
        public bool? HasNotificationBeenSent { get; set; }

        /// <summary>
        /// The requested username
        /// </summary>
        /// <value>The requested username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The requested first name
        /// </summary>
        /// <value>The requested first name</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// The requested surname
        /// </summary>
        /// <value>The requested surname</value>
        [DataMember(Name="surname", EmitDefaultValue=false)]
        public string Surname { get; set; }

        /// <summary>
        /// The requested email address
        /// </summary>
        /// <value>The requested email address</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The date and time this request was created
        /// </summary>
        /// <value>The date and time this request was created</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// The date and time this request was confirmed
        /// </summary>
        /// <value>The date and time this request was confirmed</value>
        [DataMember(Name="confirmedDate", EmitDefaultValue=false)]
        public DateTime? ConfirmedDate { get; set; }

        /// <summary>
        /// The date and time this request expired
        /// </summary>
        /// <value>The date and time this request expired</value>
        [DataMember(Name="expiredDate", EmitDefaultValue=false)]
        public DateTime? ExpiredDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRegistrationRequestDetail {\n");
            sb.Append("  ConfirmRegistrationUrl: ").Append(ConfirmRegistrationUrl).Append("\n");
            sb.Append("  HasNotificationBeenSent: ").Append(HasNotificationBeenSent).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  ConfirmedDate: ").Append(ConfirmedDate).Append("\n");
            sb.Append("  ExpiredDate: ").Append(ExpiredDate).Append("\n");
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
            return this.Equals(input as UserRegistrationRequestDetail);
        }

        /// <summary>
        /// Returns true if UserRegistrationRequestDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of UserRegistrationRequestDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRegistrationRequestDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfirmRegistrationUrl == input.ConfirmRegistrationUrl ||
                    (this.ConfirmRegistrationUrl != null &&
                    this.ConfirmRegistrationUrl.Equals(input.ConfirmRegistrationUrl))
                ) && 
                (
                    this.HasNotificationBeenSent == input.HasNotificationBeenSent ||
                    (this.HasNotificationBeenSent != null &&
                    this.HasNotificationBeenSent.Equals(input.HasNotificationBeenSent))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.ConfirmedDate == input.ConfirmedDate ||
                    (this.ConfirmedDate != null &&
                    this.ConfirmedDate.Equals(input.ConfirmedDate))
                ) && 
                (
                    this.ExpiredDate == input.ExpiredDate ||
                    (this.ExpiredDate != null &&
                    this.ExpiredDate.Equals(input.ExpiredDate))
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
                if (this.ConfirmRegistrationUrl != null)
                    hashCode = hashCode * 59 + this.ConfirmRegistrationUrl.GetHashCode();
                if (this.HasNotificationBeenSent != null)
                    hashCode = hashCode * 59 + this.HasNotificationBeenSent.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.ConfirmedDate != null)
                    hashCode = hashCode * 59 + this.ConfirmedDate.GetHashCode();
                if (this.ExpiredDate != null)
                    hashCode = hashCode * 59 + this.ExpiredDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
