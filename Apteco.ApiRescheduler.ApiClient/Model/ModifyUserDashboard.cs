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
    /// Details used to modify an audience for a given user
    /// </summary>
    [DataContract]
        public partial class ModifyUserDashboard :  IEquatable<ModifyUserDashboard>
    {
        /// <summary>
        /// The type of modification to perform.  If the type is delete or undelete, any other specified item details will be ignored
        /// </summary>
        /// <value>The type of modification to perform.  If the type is delete or undelete, any other specified item details will be ignored</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ModificationTypeEnum
        {
            /// <summary>
            /// Enum Modify for value: Modify
            /// </summary>
            [EnumMember(Value = "Modify")]
            Modify = 1,
            /// <summary>
            /// Enum Delete for value: Delete
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete = 2,
            /// <summary>
            /// Enum Undelete for value: Undelete
            /// </summary>
            [EnumMember(Value = "Undelete")]
            Undelete = 3        }
        /// <summary>
        /// The type of modification to perform.  If the type is delete or undelete, any other specified item details will be ignored
        /// </summary>
        /// <value>The type of modification to perform.  If the type is delete or undelete, any other specified item details will be ignored</value>
        [DataMember(Name="modificationType", EmitDefaultValue=false)]
        public ModificationTypeEnum ModificationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyUserDashboard" /> class.
        /// </summary>
        /// <param name="dashboard">dashboard (required).</param>
        /// <param name="id">The id of the item to update.</param>
        /// <param name="modificationType">The type of modification to perform.  If the type is delete or undelete, any other specified item details will be ignored (required).</param>
        public ModifyUserDashboard(ModifyUserDashboardDetail dashboard = default(ModifyUserDashboardDetail), string id = default(string), ModificationTypeEnum modificationType = default(ModificationTypeEnum))
        {
            // to ensure "dashboard" is required (not null)
            if (dashboard == null)
            {
                throw new InvalidDataException("dashboard is a required property for ModifyUserDashboard and cannot be null");
            }
            else
            {
                this.Dashboard = dashboard;
            }
            // to ensure "modificationType" is required (not null)
            if (modificationType == null)
            {
                throw new InvalidDataException("modificationType is a required property for ModifyUserDashboard and cannot be null");
            }
            else
            {
                this.ModificationType = modificationType;
            }
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets Dashboard
        /// </summary>
        [DataMember(Name="dashboard", EmitDefaultValue=false)]
        public ModifyUserDashboardDetail Dashboard { get; set; }

        /// <summary>
        /// The id of the item to update
        /// </summary>
        /// <value>The id of the item to update</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyUserDashboard {\n");
            sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModificationType: ").Append(ModificationType).Append("\n");
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
            return this.Equals(input as ModifyUserDashboard);
        }

        /// <summary>
        /// Returns true if ModifyUserDashboard instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyUserDashboard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyUserDashboard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dashboard == input.Dashboard ||
                    (this.Dashboard != null &&
                    this.Dashboard.Equals(input.Dashboard))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ModificationType == input.ModificationType ||
                    (this.ModificationType != null &&
                    this.ModificationType.Equals(input.ModificationType))
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
                if (this.Dashboard != null)
                    hashCode = hashCode * 59 + this.Dashboard.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ModificationType != null)
                    hashCode = hashCode * 59 + this.ModificationType.GetHashCode();
                return hashCode;
            }
        }
    }
}
