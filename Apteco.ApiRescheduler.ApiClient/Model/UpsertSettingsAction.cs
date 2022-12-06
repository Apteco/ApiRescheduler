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
    /// Details for creating or updating a settings action
    /// </summary>
    [DataContract]
        public partial class UpsertSettingsAction :  IEquatable<UpsertSettingsAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertSettingsAction" /> class.
        /// </summary>
        /// <param name="storeHistory">storeHistory.</param>
        public UpsertSettingsAction(StoreHistorySettingsAction storeHistory = default(StoreHistorySettingsAction))
        {
            this.StoreHistory = storeHistory;
        }
        
        /// <summary>
        /// Gets or Sets StoreHistory
        /// </summary>
        [DataMember(Name="storeHistory", EmitDefaultValue=false)]
        public StoreHistorySettingsAction StoreHistory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertSettingsAction {\n");
            sb.Append("  StoreHistory: ").Append(StoreHistory).Append("\n");
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
            return this.Equals(input as UpsertSettingsAction);
        }

        /// <summary>
        /// Returns true if UpsertSettingsAction instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertSettingsAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertSettingsAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreHistory == input.StoreHistory ||
                    (this.StoreHistory != null &&
                    this.StoreHistory.Equals(input.StoreHistory))
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
                if (this.StoreHistory != null)
                    hashCode = hashCode * 59 + this.StoreHistory.GetHashCode();
                return hashCode;
            }
        }
    }
}
