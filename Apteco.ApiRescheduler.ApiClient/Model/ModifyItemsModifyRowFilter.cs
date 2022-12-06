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
    /// A set of items to modify
    /// </summary>
    [DataContract]
        public partial class ModifyItemsModifyRowFilter :  IEquatable<ModifyItemsModifyRowFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyItemsModifyRowFilter" /> class.
        /// </summary>
        /// <param name="returnModifiedItem">Whether to return the modified item in the results (required).</param>
        /// <param name="_list">The list of items to modify (required).</param>
        public ModifyItemsModifyRowFilter(bool? returnModifiedItem = default(bool?), List<ModifyRowFilter> _list = default(List<ModifyRowFilter>))
        {
            // to ensure "returnModifiedItem" is required (not null)
            if (returnModifiedItem == null)
            {
                throw new InvalidDataException("returnModifiedItem is a required property for ModifyItemsModifyRowFilter and cannot be null");
            }
            else
            {
                this.ReturnModifiedItem = returnModifiedItem;
            }
            // to ensure "_list" is required (not null)
            if (_list == null)
            {
                throw new InvalidDataException("_list is a required property for ModifyItemsModifyRowFilter and cannot be null");
            }
            else
            {
                this._List = _list;
            }
        }
        
        /// <summary>
        /// Whether to return the modified item in the results
        /// </summary>
        /// <value>Whether to return the modified item in the results</value>
        [DataMember(Name="returnModifiedItem", EmitDefaultValue=false)]
        public bool? ReturnModifiedItem { get; set; }

        /// <summary>
        /// The list of items to modify
        /// </summary>
        /// <value>The list of items to modify</value>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public List<ModifyRowFilter> _List { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyItemsModifyRowFilter {\n");
            sb.Append("  ReturnModifiedItem: ").Append(ReturnModifiedItem).Append("\n");
            sb.Append("  _List: ").Append(_List).Append("\n");
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
            return this.Equals(input as ModifyItemsModifyRowFilter);
        }

        /// <summary>
        /// Returns true if ModifyItemsModifyRowFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyItemsModifyRowFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyItemsModifyRowFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnModifiedItem == input.ReturnModifiedItem ||
                    (this.ReturnModifiedItem != null &&
                    this.ReturnModifiedItem.Equals(input.ReturnModifiedItem))
                ) && 
                (
                    this._List == input._List ||
                    this._List != null &&
                    input._List != null &&
                    this._List.SequenceEqual(input._List)
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
                if (this.ReturnModifiedItem != null)
                    hashCode = hashCode * 59 + this.ReturnModifiedItem.GetHashCode();
                if (this._List != null)
                    hashCode = hashCode * 59 + this._List.GetHashCode();
                return hashCode;
            }
        }
    }
}
