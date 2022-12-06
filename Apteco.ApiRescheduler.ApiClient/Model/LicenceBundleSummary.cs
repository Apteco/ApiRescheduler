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
    /// Information about a particular bundle associated with a licence
    /// </summary>
    [DataContract]
        public partial class LicenceBundleSummary :  IEquatable<LicenceBundleSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenceBundleSummary" /> class.
        /// </summary>
        /// <param name="numberOfUsers">The number of users that can be licensed to use this bundle (required).</param>
        /// <param name="slotsAvailable">The number of slots that are available.</param>
        /// <param name="id">The id of the bundle (required).</param>
        /// <param name="name">The general name of the bundle (i.e. \&quot;Orchestrator\&quot;) (required).</param>
        /// <param name="instanceName">The specific name of this instance of the bundle, including version information  (i.e. \&quot;Orchestrator V2\&quot;) (required).</param>
        public LicenceBundleSummary(int? numberOfUsers = default(int?), int? slotsAvailable = default(int?), int? id = default(int?), string name = default(string), string instanceName = default(string))
        {
            // to ensure "numberOfUsers" is required (not null)
            if (numberOfUsers == null)
            {
                throw new InvalidDataException("numberOfUsers is a required property for LicenceBundleSummary and cannot be null");
            }
            else
            {
                this.NumberOfUsers = numberOfUsers;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for LicenceBundleSummary and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for LicenceBundleSummary and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "instanceName" is required (not null)
            if (instanceName == null)
            {
                throw new InvalidDataException("instanceName is a required property for LicenceBundleSummary and cannot be null");
            }
            else
            {
                this.InstanceName = instanceName;
            }
            this.SlotsAvailable = slotsAvailable;
        }
        
        /// <summary>
        /// The number of users that can be licensed to use this bundle
        /// </summary>
        /// <value>The number of users that can be licensed to use this bundle</value>
        [DataMember(Name="numberOfUsers", EmitDefaultValue=false)]
        public int? NumberOfUsers { get; set; }

        /// <summary>
        /// The number of slots that are available
        /// </summary>
        /// <value>The number of slots that are available</value>
        [DataMember(Name="slotsAvailable", EmitDefaultValue=false)]
        public int? SlotsAvailable { get; set; }

        /// <summary>
        /// The id of the bundle
        /// </summary>
        /// <value>The id of the bundle</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The general name of the bundle (i.e. \&quot;Orchestrator\&quot;)
        /// </summary>
        /// <value>The general name of the bundle (i.e. \&quot;Orchestrator\&quot;)</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The specific name of this instance of the bundle, including version information  (i.e. \&quot;Orchestrator V2\&quot;)
        /// </summary>
        /// <value>The specific name of this instance of the bundle, including version information  (i.e. \&quot;Orchestrator V2\&quot;)</value>
        [DataMember(Name="instanceName", EmitDefaultValue=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenceBundleSummary {\n");
            sb.Append("  NumberOfUsers: ").Append(NumberOfUsers).Append("\n");
            sb.Append("  SlotsAvailable: ").Append(SlotsAvailable).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InstanceName: ").Append(InstanceName).Append("\n");
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
            return this.Equals(input as LicenceBundleSummary);
        }

        /// <summary>
        /// Returns true if LicenceBundleSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of LicenceBundleSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenceBundleSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumberOfUsers == input.NumberOfUsers ||
                    (this.NumberOfUsers != null &&
                    this.NumberOfUsers.Equals(input.NumberOfUsers))
                ) && 
                (
                    this.SlotsAvailable == input.SlotsAvailable ||
                    (this.SlotsAvailable != null &&
                    this.SlotsAvailable.Equals(input.SlotsAvailable))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
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
                if (this.NumberOfUsers != null)
                    hashCode = hashCode * 59 + this.NumberOfUsers.GetHashCode();
                if (this.SlotsAvailable != null)
                    hashCode = hashCode * 59 + this.SlotsAvailable.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
