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
    /// Details for a ftp site
    /// </summary>
    [DataContract]
        public partial class FtpSite :  IEquatable<FtpSite>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FtpSite" /> class.
        /// </summary>
        /// <param name="id">The ftp site Id.</param>
        /// <param name="name">The ftp site name (required).</param>
        /// <param name="uri">The ftp site uri (required).</param>
        /// <param name="privateKey">The ftp site private key.</param>
        /// <param name="privateKeySpecified">The ftp site private key has been specified.</param>
        /// <param name="tags">The ftp site tags.</param>
        public FtpSite(int? id = default(int?), string name = default(string), string uri = default(string), string privateKey = default(string), bool? privateKeySpecified = default(bool?), List<string> tags = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for FtpSite and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new InvalidDataException("uri is a required property for FtpSite and cannot be null");
            }
            else
            {
                this.Uri = uri;
            }
            this.Id = id;
            this.PrivateKey = privateKey;
            this.PrivateKeySpecified = privateKeySpecified;
            this.Tags = tags;
        }
        
        /// <summary>
        /// The ftp site Id
        /// </summary>
        /// <value>The ftp site Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The ftp site name
        /// </summary>
        /// <value>The ftp site name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ftp site uri
        /// </summary>
        /// <value>The ftp site uri</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// The ftp site private key
        /// </summary>
        /// <value>The ftp site private key</value>
        [DataMember(Name="privateKey", EmitDefaultValue=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// The ftp site private key has been specified
        /// </summary>
        /// <value>The ftp site private key has been specified</value>
        [DataMember(Name="privateKeySpecified", EmitDefaultValue=false)]
        public bool? PrivateKeySpecified { get; set; }

        /// <summary>
        /// The ftp site tags
        /// </summary>
        /// <value>The ftp site tags</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FtpSite {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  PrivateKeySpecified: ").Append(PrivateKeySpecified).Append("\n");
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
            return this.Equals(input as FtpSite);
        }

        /// <summary>
        /// Returns true if FtpSite instances are equal
        /// </summary>
        /// <param name="input">Instance of FtpSite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FtpSite input)
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
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.PrivateKeySpecified == input.PrivateKeySpecified ||
                    (this.PrivateKeySpecified != null &&
                    this.PrivateKeySpecified.Equals(input.PrivateKeySpecified))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.PrivateKeySpecified != null)
                    hashCode = hashCode * 59 + this.PrivateKeySpecified.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
