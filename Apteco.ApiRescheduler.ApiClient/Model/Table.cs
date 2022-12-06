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
    /// Details for a table in the FastStats system
    /// </summary>
    [DataContract]
        public partial class Table :  IEquatable<Table>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        /// <param name="name">The name of the table (required).</param>
        /// <param name="singularDisplayName">A description to use for this table when refering to a single entity (i.e. \&quot;A Person\&quot;) (required).</param>
        /// <param name="pluralDisplayName">A description to use for this table when refering to multiple entities (i.e. \&quot;Many People\&quot;) (required).</param>
        /// <param name="isDefaultTable">Whether this table is the default table in the FastStats system or not - i.e. the table to use when creating a blank query (required).</param>
        /// <param name="isPeopleTable">Whether this table is the one in the FastStats system used to represent natural people (required).</param>
        /// <param name="totalRecords">The total number of records in this table (required).</param>
        /// <param name="childRelationshipName">A descriptive word or phrase to use when relating this table to one of its child tables (i.e. a Households \&quot;is occupied by\&quot; a Customer) (required).</param>
        /// <param name="parentRelationshipName">A descriptive word or phrase to use when relating this table to one of its parent tables (i.e. a Customer \&quot;lives at\&quot; a Households) (required).</param>
        /// <param name="hasChildTables">Whether this table has any child tables (required).</param>
        /// <param name="parentTable">The name of the parent table for this table.  The Master table is the only table without a parent (required).</param>
        public Table(string name = default(string), string singularDisplayName = default(string), string pluralDisplayName = default(string), bool? isDefaultTable = default(bool?), bool? isPeopleTable = default(bool?), long? totalRecords = default(long?), string childRelationshipName = default(string), string parentRelationshipName = default(string), bool? hasChildTables = default(bool?), string parentTable = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Table and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "singularDisplayName" is required (not null)
            if (singularDisplayName == null)
            {
                throw new InvalidDataException("singularDisplayName is a required property for Table and cannot be null");
            }
            else
            {
                this.SingularDisplayName = singularDisplayName;
            }
            // to ensure "pluralDisplayName" is required (not null)
            if (pluralDisplayName == null)
            {
                throw new InvalidDataException("pluralDisplayName is a required property for Table and cannot be null");
            }
            else
            {
                this.PluralDisplayName = pluralDisplayName;
            }
            // to ensure "isDefaultTable" is required (not null)
            if (isDefaultTable == null)
            {
                throw new InvalidDataException("isDefaultTable is a required property for Table and cannot be null");
            }
            else
            {
                this.IsDefaultTable = isDefaultTable;
            }
            // to ensure "isPeopleTable" is required (not null)
            if (isPeopleTable == null)
            {
                throw new InvalidDataException("isPeopleTable is a required property for Table and cannot be null");
            }
            else
            {
                this.IsPeopleTable = isPeopleTable;
            }
            // to ensure "totalRecords" is required (not null)
            if (totalRecords == null)
            {
                throw new InvalidDataException("totalRecords is a required property for Table and cannot be null");
            }
            else
            {
                this.TotalRecords = totalRecords;
            }
            // to ensure "childRelationshipName" is required (not null)
            if (childRelationshipName == null)
            {
                throw new InvalidDataException("childRelationshipName is a required property for Table and cannot be null");
            }
            else
            {
                this.ChildRelationshipName = childRelationshipName;
            }
            // to ensure "parentRelationshipName" is required (not null)
            if (parentRelationshipName == null)
            {
                throw new InvalidDataException("parentRelationshipName is a required property for Table and cannot be null");
            }
            else
            {
                this.ParentRelationshipName = parentRelationshipName;
            }
            // to ensure "hasChildTables" is required (not null)
            if (hasChildTables == null)
            {
                throw new InvalidDataException("hasChildTables is a required property for Table and cannot be null");
            }
            else
            {
                this.HasChildTables = hasChildTables;
            }
            // to ensure "parentTable" is required (not null)
            if (parentTable == null)
            {
                throw new InvalidDataException("parentTable is a required property for Table and cannot be null");
            }
            else
            {
                this.ParentTable = parentTable;
            }
        }
        
        /// <summary>
        /// The name of the table
        /// </summary>
        /// <value>The name of the table</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A description to use for this table when refering to a single entity (i.e. \&quot;A Person\&quot;)
        /// </summary>
        /// <value>A description to use for this table when refering to a single entity (i.e. \&quot;A Person\&quot;)</value>
        [DataMember(Name="singularDisplayName", EmitDefaultValue=false)]
        public string SingularDisplayName { get; set; }

        /// <summary>
        /// A description to use for this table when refering to multiple entities (i.e. \&quot;Many People\&quot;)
        /// </summary>
        /// <value>A description to use for this table when refering to multiple entities (i.e. \&quot;Many People\&quot;)</value>
        [DataMember(Name="pluralDisplayName", EmitDefaultValue=false)]
        public string PluralDisplayName { get; set; }

        /// <summary>
        /// Whether this table is the default table in the FastStats system or not - i.e. the table to use when creating a blank query
        /// </summary>
        /// <value>Whether this table is the default table in the FastStats system or not - i.e. the table to use when creating a blank query</value>
        [DataMember(Name="isDefaultTable", EmitDefaultValue=false)]
        public bool? IsDefaultTable { get; set; }

        /// <summary>
        /// Whether this table is the one in the FastStats system used to represent natural people
        /// </summary>
        /// <value>Whether this table is the one in the FastStats system used to represent natural people</value>
        [DataMember(Name="isPeopleTable", EmitDefaultValue=false)]
        public bool? IsPeopleTable { get; set; }

        /// <summary>
        /// The total number of records in this table
        /// </summary>
        /// <value>The total number of records in this table</value>
        [DataMember(Name="totalRecords", EmitDefaultValue=false)]
        public long? TotalRecords { get; set; }

        /// <summary>
        /// A descriptive word or phrase to use when relating this table to one of its child tables (i.e. a Households \&quot;is occupied by\&quot; a Customer)
        /// </summary>
        /// <value>A descriptive word or phrase to use when relating this table to one of its child tables (i.e. a Households \&quot;is occupied by\&quot; a Customer)</value>
        [DataMember(Name="childRelationshipName", EmitDefaultValue=false)]
        public string ChildRelationshipName { get; set; }

        /// <summary>
        /// A descriptive word or phrase to use when relating this table to one of its parent tables (i.e. a Customer \&quot;lives at\&quot; a Households)
        /// </summary>
        /// <value>A descriptive word or phrase to use when relating this table to one of its parent tables (i.e. a Customer \&quot;lives at\&quot; a Households)</value>
        [DataMember(Name="parentRelationshipName", EmitDefaultValue=false)]
        public string ParentRelationshipName { get; set; }

        /// <summary>
        /// Whether this table has any child tables
        /// </summary>
        /// <value>Whether this table has any child tables</value>
        [DataMember(Name="hasChildTables", EmitDefaultValue=false)]
        public bool? HasChildTables { get; set; }

        /// <summary>
        /// The name of the parent table for this table.  The Master table is the only table without a parent
        /// </summary>
        /// <value>The name of the parent table for this table.  The Master table is the only table without a parent</value>
        [DataMember(Name="parentTable", EmitDefaultValue=false)]
        public string ParentTable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Table {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SingularDisplayName: ").Append(SingularDisplayName).Append("\n");
            sb.Append("  PluralDisplayName: ").Append(PluralDisplayName).Append("\n");
            sb.Append("  IsDefaultTable: ").Append(IsDefaultTable).Append("\n");
            sb.Append("  IsPeopleTable: ").Append(IsPeopleTable).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  ChildRelationshipName: ").Append(ChildRelationshipName).Append("\n");
            sb.Append("  ParentRelationshipName: ").Append(ParentRelationshipName).Append("\n");
            sb.Append("  HasChildTables: ").Append(HasChildTables).Append("\n");
            sb.Append("  ParentTable: ").Append(ParentTable).Append("\n");
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
            return this.Equals(input as Table);
        }

        /// <summary>
        /// Returns true if Table instances are equal
        /// </summary>
        /// <param name="input">Instance of Table to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Table input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SingularDisplayName == input.SingularDisplayName ||
                    (this.SingularDisplayName != null &&
                    this.SingularDisplayName.Equals(input.SingularDisplayName))
                ) && 
                (
                    this.PluralDisplayName == input.PluralDisplayName ||
                    (this.PluralDisplayName != null &&
                    this.PluralDisplayName.Equals(input.PluralDisplayName))
                ) && 
                (
                    this.IsDefaultTable == input.IsDefaultTable ||
                    (this.IsDefaultTable != null &&
                    this.IsDefaultTable.Equals(input.IsDefaultTable))
                ) && 
                (
                    this.IsPeopleTable == input.IsPeopleTable ||
                    (this.IsPeopleTable != null &&
                    this.IsPeopleTable.Equals(input.IsPeopleTable))
                ) && 
                (
                    this.TotalRecords == input.TotalRecords ||
                    (this.TotalRecords != null &&
                    this.TotalRecords.Equals(input.TotalRecords))
                ) && 
                (
                    this.ChildRelationshipName == input.ChildRelationshipName ||
                    (this.ChildRelationshipName != null &&
                    this.ChildRelationshipName.Equals(input.ChildRelationshipName))
                ) && 
                (
                    this.ParentRelationshipName == input.ParentRelationshipName ||
                    (this.ParentRelationshipName != null &&
                    this.ParentRelationshipName.Equals(input.ParentRelationshipName))
                ) && 
                (
                    this.HasChildTables == input.HasChildTables ||
                    (this.HasChildTables != null &&
                    this.HasChildTables.Equals(input.HasChildTables))
                ) && 
                (
                    this.ParentTable == input.ParentTable ||
                    (this.ParentTable != null &&
                    this.ParentTable.Equals(input.ParentTable))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SingularDisplayName != null)
                    hashCode = hashCode * 59 + this.SingularDisplayName.GetHashCode();
                if (this.PluralDisplayName != null)
                    hashCode = hashCode * 59 + this.PluralDisplayName.GetHashCode();
                if (this.IsDefaultTable != null)
                    hashCode = hashCode * 59 + this.IsDefaultTable.GetHashCode();
                if (this.IsPeopleTable != null)
                    hashCode = hashCode * 59 + this.IsPeopleTable.GetHashCode();
                if (this.TotalRecords != null)
                    hashCode = hashCode * 59 + this.TotalRecords.GetHashCode();
                if (this.ChildRelationshipName != null)
                    hashCode = hashCode * 59 + this.ChildRelationshipName.GetHashCode();
                if (this.ParentRelationshipName != null)
                    hashCode = hashCode * 59 + this.ParentRelationshipName.GetHashCode();
                if (this.HasChildTables != null)
                    hashCode = hashCode * 59 + this.HasChildTables.GetHashCode();
                if (this.ParentTable != null)
                    hashCode = hashCode * 59 + this.ParentTable.GetHashCode();
                return hashCode;
            }
        }
    }
}
