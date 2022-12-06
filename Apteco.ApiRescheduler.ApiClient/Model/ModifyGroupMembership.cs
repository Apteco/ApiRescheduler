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
    /// Details to update a group with
    /// </summary>
    [DataContract]
        public partial class ModifyGroupMembership :  IEquatable<ModifyGroupMembership>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyGroupMembership" /> class.
        /// </summary>
        /// <param name="userIdsToAdd">When specified, the new ids of the user ids to add to the group.</param>
        /// <param name="userIdsToRemove">When specified, the new ids of the user ids to remove from the group.</param>
        public ModifyGroupMembership(List<int?> userIdsToAdd = default(List<int?>), List<int?> userIdsToRemove = default(List<int?>))
        {
            this.UserIdsToAdd = userIdsToAdd;
            this.UserIdsToRemove = userIdsToRemove;
        }
        
        /// <summary>
        /// When specified, the new ids of the user ids to add to the group
        /// </summary>
        /// <value>When specified, the new ids of the user ids to add to the group</value>
        [DataMember(Name="userIdsToAdd", EmitDefaultValue=false)]
        public List<int?> UserIdsToAdd { get; set; }

        /// <summary>
        /// When specified, the new ids of the user ids to remove from the group
        /// </summary>
        /// <value>When specified, the new ids of the user ids to remove from the group</value>
        [DataMember(Name="userIdsToRemove", EmitDefaultValue=false)]
        public List<int?> UserIdsToRemove { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyGroupMembership {\n");
            sb.Append("  UserIdsToAdd: ").Append(UserIdsToAdd).Append("\n");
            sb.Append("  UserIdsToRemove: ").Append(UserIdsToRemove).Append("\n");
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
            return this.Equals(input as ModifyGroupMembership);
        }

        /// <summary>
        /// Returns true if ModifyGroupMembership instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyGroupMembership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyGroupMembership input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserIdsToAdd == input.UserIdsToAdd ||
                    this.UserIdsToAdd != null &&
                    input.UserIdsToAdd != null &&
                    this.UserIdsToAdd.SequenceEqual(input.UserIdsToAdd)
                ) && 
                (
                    this.UserIdsToRemove == input.UserIdsToRemove ||
                    this.UserIdsToRemove != null &&
                    input.UserIdsToRemove != null &&
                    this.UserIdsToRemove.SequenceEqual(input.UserIdsToRemove)
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
                if (this.UserIdsToAdd != null)
                    hashCode = hashCode * 59 + this.UserIdsToAdd.GetHashCode();
                if (this.UserIdsToRemove != null)
                    hashCode = hashCode * 59 + this.UserIdsToRemove.GetHashCode();
                return hashCode;
            }
        }
    }
}
