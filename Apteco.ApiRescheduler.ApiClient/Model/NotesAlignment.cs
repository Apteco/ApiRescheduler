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
    /// NotesAlignment
    /// </summary>
    [DataContract]
        public partial class NotesAlignment :  IEquatable<NotesAlignment>
    {
        /// <summary>
        /// The notes position
        /// </summary>
        /// <value>The notes position</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum NotesPositionEnum
        {
            /// <summary>
            /// Enum Top for value: Top
            /// </summary>
            [EnumMember(Value = "Top")]
            Top = 1,
            /// <summary>
            /// Enum Right for value: Right
            /// </summary>
            [EnumMember(Value = "Right")]
            Right = 2,
            /// <summary>
            /// Enum Bottom for value: Bottom
            /// </summary>
            [EnumMember(Value = "Bottom")]
            Bottom = 3,
            /// <summary>
            /// Enum Left for value: Left
            /// </summary>
            [EnumMember(Value = "Left")]
            Left = 4        }
        /// <summary>
        /// The notes position
        /// </summary>
        /// <value>The notes position</value>
        [DataMember(Name="notesPosition", EmitDefaultValue=false)]
        public NotesPositionEnum NotesPosition { get; set; }
        /// <summary>
        /// The notes content vertical alignment
        /// </summary>
        /// <value>The notes content vertical alignment</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum NotesContentVerticalAlignmentEnum
        {
            /// <summary>
            /// Enum Top for value: Top
            /// </summary>
            [EnumMember(Value = "Top")]
            Top = 1,
            /// <summary>
            /// Enum Middle for value: Middle
            /// </summary>
            [EnumMember(Value = "Middle")]
            Middle = 2,
            /// <summary>
            /// Enum Bottom for value: Bottom
            /// </summary>
            [EnumMember(Value = "Bottom")]
            Bottom = 3        }
        /// <summary>
        /// The notes content vertical alignment
        /// </summary>
        /// <value>The notes content vertical alignment</value>
        [DataMember(Name="notesContentVerticalAlignment", EmitDefaultValue=false)]
        public NotesContentVerticalAlignmentEnum NotesContentVerticalAlignment { get; set; }
        /// <summary>
        /// The notes content horizontal alignment
        /// </summary>
        /// <value>The notes content horizontal alignment</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum NotesContentHorizontalAlignmentEnum
        {
            /// <summary>
            /// Enum Left for value: Left
            /// </summary>
            [EnumMember(Value = "Left")]
            Left = 1,
            /// <summary>
            /// Enum Right for value: Right
            /// </summary>
            [EnumMember(Value = "Right")]
            Right = 2,
            /// <summary>
            /// Enum Center for value: Center
            /// </summary>
            [EnumMember(Value = "Center")]
            Center = 3,
            /// <summary>
            /// Enum Justify for value: Justify
            /// </summary>
            [EnumMember(Value = "Justify")]
            Justify = 4        }
        /// <summary>
        /// The notes content horizontal alignment
        /// </summary>
        /// <value>The notes content horizontal alignment</value>
        [DataMember(Name="notesContentHorizontalAlignment", EmitDefaultValue=false)]
        public NotesContentHorizontalAlignmentEnum NotesContentHorizontalAlignment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesAlignment" /> class.
        /// </summary>
        /// <param name="notesPosition">The notes position (required).</param>
        /// <param name="notesContentVerticalAlignment">The notes content vertical alignment (required).</param>
        /// <param name="notesContentHorizontalAlignment">The notes content horizontal alignment (required).</param>
        public NotesAlignment(NotesPositionEnum notesPosition = default(NotesPositionEnum), NotesContentVerticalAlignmentEnum notesContentVerticalAlignment = default(NotesContentVerticalAlignmentEnum), NotesContentHorizontalAlignmentEnum notesContentHorizontalAlignment = default(NotesContentHorizontalAlignmentEnum))
        {
            // to ensure "notesPosition" is required (not null)
            if (notesPosition == null)
            {
                throw new InvalidDataException("notesPosition is a required property for NotesAlignment and cannot be null");
            }
            else
            {
                this.NotesPosition = notesPosition;
            }
            // to ensure "notesContentVerticalAlignment" is required (not null)
            if (notesContentVerticalAlignment == null)
            {
                throw new InvalidDataException("notesContentVerticalAlignment is a required property for NotesAlignment and cannot be null");
            }
            else
            {
                this.NotesContentVerticalAlignment = notesContentVerticalAlignment;
            }
            // to ensure "notesContentHorizontalAlignment" is required (not null)
            if (notesContentHorizontalAlignment == null)
            {
                throw new InvalidDataException("notesContentHorizontalAlignment is a required property for NotesAlignment and cannot be null");
            }
            else
            {
                this.NotesContentHorizontalAlignment = notesContentHorizontalAlignment;
            }
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotesAlignment {\n");
            sb.Append("  NotesPosition: ").Append(NotesPosition).Append("\n");
            sb.Append("  NotesContentVerticalAlignment: ").Append(NotesContentVerticalAlignment).Append("\n");
            sb.Append("  NotesContentHorizontalAlignment: ").Append(NotesContentHorizontalAlignment).Append("\n");
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
            return this.Equals(input as NotesAlignment);
        }

        /// <summary>
        /// Returns true if NotesAlignment instances are equal
        /// </summary>
        /// <param name="input">Instance of NotesAlignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotesAlignment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotesPosition == input.NotesPosition ||
                    (this.NotesPosition != null &&
                    this.NotesPosition.Equals(input.NotesPosition))
                ) && 
                (
                    this.NotesContentVerticalAlignment == input.NotesContentVerticalAlignment ||
                    (this.NotesContentVerticalAlignment != null &&
                    this.NotesContentVerticalAlignment.Equals(input.NotesContentVerticalAlignment))
                ) && 
                (
                    this.NotesContentHorizontalAlignment == input.NotesContentHorizontalAlignment ||
                    (this.NotesContentHorizontalAlignment != null &&
                    this.NotesContentHorizontalAlignment.Equals(input.NotesContentHorizontalAlignment))
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
                if (this.NotesPosition != null)
                    hashCode = hashCode * 59 + this.NotesPosition.GetHashCode();
                if (this.NotesContentVerticalAlignment != null)
                    hashCode = hashCode * 59 + this.NotesContentVerticalAlignment.GetHashCode();
                if (this.NotesContentHorizontalAlignment != null)
                    hashCode = hashCode * 59 + this.NotesContentHorizontalAlignment.GetHashCode();
                return hashCode;
            }
        }
    }
}
