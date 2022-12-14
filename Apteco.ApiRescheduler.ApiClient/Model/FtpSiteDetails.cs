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
    /// Ftp site details for a system
    /// </summary>
    [DataContract]
        public partial class FtpSiteDetails :  IEquatable<FtpSiteDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FtpSiteDetails" /> class.
        /// </summary>
        /// <param name="ftpSites">The ftp sites (required).</param>
        /// <param name="tagsLookup">tagsLookup.</param>
        public FtpSiteDetails(List<FtpSite> ftpSites = default(List<FtpSite>), TagsLookup tagsLookup = default(TagsLookup))
        {
            // to ensure "ftpSites" is required (not null)
            if (ftpSites == null)
            {
                throw new InvalidDataException("ftpSites is a required property for FtpSiteDetails and cannot be null");
            }
            else
            {
                this.FtpSites = ftpSites;
            }
            this.TagsLookup = tagsLookup;
        }
        
        /// <summary>
        /// The ftp sites
        /// </summary>
        /// <value>The ftp sites</value>
        [DataMember(Name="ftpSites", EmitDefaultValue=false)]
        public List<FtpSite> FtpSites { get; set; }

        /// <summary>
        /// Gets or Sets TagsLookup
        /// </summary>
        [DataMember(Name="tagsLookup", EmitDefaultValue=false)]
        public TagsLookup TagsLookup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FtpSiteDetails {\n");
            sb.Append("  FtpSites: ").Append(FtpSites).Append("\n");
            sb.Append("  TagsLookup: ").Append(TagsLookup).Append("\n");
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
            return this.Equals(input as FtpSiteDetails);
        }

        /// <summary>
        /// Returns true if FtpSiteDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of FtpSiteDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FtpSiteDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FtpSites == input.FtpSites ||
                    this.FtpSites != null &&
                    input.FtpSites != null &&
                    this.FtpSites.SequenceEqual(input.FtpSites)
                ) && 
                (
                    this.TagsLookup == input.TagsLookup ||
                    (this.TagsLookup != null &&
                    this.TagsLookup.Equals(input.TagsLookup))
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
                if (this.FtpSites != null)
                    hashCode = hashCode * 59 + this.FtpSites.GetHashCode();
                if (this.TagsLookup != null)
                    hashCode = hashCode * 59 + this.TagsLookup.GetHashCode();
                return hashCode;
            }
        }
    }
}
