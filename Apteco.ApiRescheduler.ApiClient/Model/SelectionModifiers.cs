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
    /// Modifiers for the nett selection query
    /// </summary>
    [DataContract]
        public partial class SelectionModifiers :  IEquatable<SelectionModifiers>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionModifiers" /> class.
        /// </summary>
        /// <param name="limits">limits.</param>
        /// <param name="topN">topN.</param>
        /// <param name="nPer">nPer.</param>
        /// <param name="rfv">rfv.</param>
        public SelectionModifiers(Limits limits = default(Limits), TopN topN = default(TopN), NPer nPer = default(NPer), RFV rfv = default(RFV))
        {
            this.Limits = limits;
            this.TopN = topN;
            this.NPer = nPer;
            this.Rfv = rfv;
        }
        
        /// <summary>
        /// Gets or Sets Limits
        /// </summary>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public Limits Limits { get; set; }

        /// <summary>
        /// Gets or Sets TopN
        /// </summary>
        [DataMember(Name="topN", EmitDefaultValue=false)]
        public TopN TopN { get; set; }

        /// <summary>
        /// Gets or Sets NPer
        /// </summary>
        [DataMember(Name="nPer", EmitDefaultValue=false)]
        public NPer NPer { get; set; }

        /// <summary>
        /// Gets or Sets Rfv
        /// </summary>
        [DataMember(Name="rfv", EmitDefaultValue=false)]
        public RFV Rfv { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectionModifiers {\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  TopN: ").Append(TopN).Append("\n");
            sb.Append("  NPer: ").Append(NPer).Append("\n");
            sb.Append("  Rfv: ").Append(Rfv).Append("\n");
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
            return this.Equals(input as SelectionModifiers);
        }

        /// <summary>
        /// Returns true if SelectionModifiers instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectionModifiers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectionModifiers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limits == input.Limits ||
                    (this.Limits != null &&
                    this.Limits.Equals(input.Limits))
                ) && 
                (
                    this.TopN == input.TopN ||
                    (this.TopN != null &&
                    this.TopN.Equals(input.TopN))
                ) && 
                (
                    this.NPer == input.NPer ||
                    (this.NPer != null &&
                    this.NPer.Equals(input.NPer))
                ) && 
                (
                    this.Rfv == input.Rfv ||
                    (this.Rfv != null &&
                    this.Rfv.Equals(input.Rfv))
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
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.TopN != null)
                    hashCode = hashCode * 59 + this.TopN.GetHashCode();
                if (this.NPer != null)
                    hashCode = hashCode * 59 + this.NPer.GetHashCode();
                if (this.Rfv != null)
                    hashCode = hashCode * 59 + this.Rfv.GetHashCode();
                return hashCode;
            }
        }
    }
}