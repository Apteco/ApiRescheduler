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
    /// Lookups
    /// </summary>
    [DataContract]
        public partial class Lookups :  IEquatable<Lookups>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lookups" /> class.
        /// </summary>
        /// <param name="systemLookup">systemLookup.</param>
        /// <param name="peopleStageLookup">peopleStageLookup.</param>
        /// <param name="usersLookup">usersLookup.</param>
        public Lookups(SystemLookup systemLookup = default(SystemLookup), PeopleStageLookup peopleStageLookup = default(PeopleStageLookup), UsersLookup usersLookup = default(UsersLookup))
        {
            this.SystemLookup = systemLookup;
            this.PeopleStageLookup = peopleStageLookup;
            this.UsersLookup = usersLookup;
        }
        
        /// <summary>
        /// Gets or Sets SystemLookup
        /// </summary>
        [DataMember(Name="systemLookup", EmitDefaultValue=false)]
        public SystemLookup SystemLookup { get; set; }

        /// <summary>
        /// Gets or Sets PeopleStageLookup
        /// </summary>
        [DataMember(Name="peopleStageLookup", EmitDefaultValue=false)]
        public PeopleStageLookup PeopleStageLookup { get; set; }

        /// <summary>
        /// Gets or Sets UsersLookup
        /// </summary>
        [DataMember(Name="usersLookup", EmitDefaultValue=false)]
        public UsersLookup UsersLookup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Lookups {\n");
            sb.Append("  SystemLookup: ").Append(SystemLookup).Append("\n");
            sb.Append("  PeopleStageLookup: ").Append(PeopleStageLookup).Append("\n");
            sb.Append("  UsersLookup: ").Append(UsersLookup).Append("\n");
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
            return this.Equals(input as Lookups);
        }

        /// <summary>
        /// Returns true if Lookups instances are equal
        /// </summary>
        /// <param name="input">Instance of Lookups to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Lookups input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SystemLookup == input.SystemLookup ||
                    (this.SystemLookup != null &&
                    this.SystemLookup.Equals(input.SystemLookup))
                ) && 
                (
                    this.PeopleStageLookup == input.PeopleStageLookup ||
                    (this.PeopleStageLookup != null &&
                    this.PeopleStageLookup.Equals(input.PeopleStageLookup))
                ) && 
                (
                    this.UsersLookup == input.UsersLookup ||
                    (this.UsersLookup != null &&
                    this.UsersLookup.Equals(input.UsersLookup))
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
                if (this.SystemLookup != null)
                    hashCode = hashCode * 59 + this.SystemLookup.GetHashCode();
                if (this.PeopleStageLookup != null)
                    hashCode = hashCode * 59 + this.PeopleStageLookup.GetHashCode();
                if (this.UsersLookup != null)
                    hashCode = hashCode * 59 + this.UsersLookup.GetHashCode();
                return hashCode;
            }
        }
    }
}
