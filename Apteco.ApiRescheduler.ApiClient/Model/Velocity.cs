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
    /// Details for a velocity
    /// </summary>
    [DataContract]
        public partial class Velocity :  IEquatable<Velocity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Velocity" /> class.
        /// </summary>
        /// <param name="id">The velocity Id.</param>
        /// <param name="name">The velocity name (required).</param>
        /// <param name="actionType">The velocity action type (EXPORT / PURCHASE) (required).</param>
        /// <param name="velocityBand">The velocity band (required).</param>
        /// <param name="tags">The velocity tags.</param>
        public Velocity(int? id = default(int?), string name = default(string), string actionType = default(string), string velocityBand = default(string), List<string> tags = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Velocity and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "actionType" is required (not null)
            if (actionType == null)
            {
                throw new InvalidDataException("actionType is a required property for Velocity and cannot be null");
            }
            else
            {
                this.ActionType = actionType;
            }
            // to ensure "velocityBand" is required (not null)
            if (velocityBand == null)
            {
                throw new InvalidDataException("velocityBand is a required property for Velocity and cannot be null");
            }
            else
            {
                this.VelocityBand = velocityBand;
            }
            this.Id = id;
            this.Tags = tags;
        }
        
        /// <summary>
        /// The velocity Id
        /// </summary>
        /// <value>The velocity Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The velocity name
        /// </summary>
        /// <value>The velocity name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The velocity action type (EXPORT / PURCHASE)
        /// </summary>
        /// <value>The velocity action type (EXPORT / PURCHASE)</value>
        [DataMember(Name="actionType", EmitDefaultValue=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// The velocity band
        /// </summary>
        /// <value>The velocity band</value>
        [DataMember(Name="velocityBand", EmitDefaultValue=false)]
        public string VelocityBand { get; set; }

        /// <summary>
        /// The velocity tags
        /// </summary>
        /// <value>The velocity tags</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Velocity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  VelocityBand: ").Append(VelocityBand).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as Velocity);
        }

        /// <summary>
        /// Returns true if Velocity instances are equal
        /// </summary>
        /// <param name="input">Instance of Velocity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Velocity input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ActionType == input.ActionType ||
                    (this.ActionType != null &&
                    this.ActionType.Equals(input.ActionType))
                ) && 
                (
                    this.VelocityBand == input.VelocityBand ||
                    (this.VelocityBand != null &&
                    this.VelocityBand.Equals(input.VelocityBand))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ActionType != null)
                    hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.VelocityBand != null)
                    hashCode = hashCode * 59 + this.VelocityBand.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}