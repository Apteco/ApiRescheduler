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
    /// The details required to transfer the ownership of a collection
    /// </summary>
    [DataContract]
        public partial class TransferCollectionOwnershipDetails :  IEquatable<TransferCollectionOwnershipDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCollectionOwnershipDetails" /> class.
        /// </summary>
        /// <param name="newUsername">The username of the new owning user (required).</param>
        public TransferCollectionOwnershipDetails(string newUsername = default(string))
        {
            // to ensure "newUsername" is required (not null)
            if (newUsername == null)
            {
                throw new InvalidDataException("newUsername is a required property for TransferCollectionOwnershipDetails and cannot be null");
            }
            else
            {
                this.NewUsername = newUsername;
            }
        }
        
        /// <summary>
        /// The username of the new owning user
        /// </summary>
        /// <value>The username of the new owning user</value>
        [DataMember(Name="newUsername", EmitDefaultValue=false)]
        public string NewUsername { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferCollectionOwnershipDetails {\n");
            sb.Append("  NewUsername: ").Append(NewUsername).Append("\n");
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
            return this.Equals(input as TransferCollectionOwnershipDetails);
        }

        /// <summary>
        /// Returns true if TransferCollectionOwnershipDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferCollectionOwnershipDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferCollectionOwnershipDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewUsername == input.NewUsername ||
                    (this.NewUsername != null &&
                    this.NewUsername.Equals(input.NewUsername))
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
                if (this.NewUsername != null)
                    hashCode = hashCode * 59 + this.NewUsername.GetHashCode();
                return hashCode;
            }
        }
    }
}
