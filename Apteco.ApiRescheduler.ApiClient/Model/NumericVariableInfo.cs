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
    /// Details specific for numeric variables in the FastStats system
    /// </summary>
    [DataContract]
        public partial class NumericVariableInfo :  IEquatable<NumericVariableInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumericVariableInfo" /> class.
        /// </summary>
        /// <param name="minimum">The minimum value that this numeric value has.</param>
        /// <param name="maximum">The maximum value that this numeric value has.</param>
        /// <param name="isCurrency">Whether this variable represents a currency value.</param>
        /// <param name="currencyLocale">If this variable is a currency variable, then the locale name for the specific currency (i.e. \&quot;en-GB\&quot; for the UK pound sterling, \&quot;en-US\&quot; for the US dollar).</param>
        /// <param name="currencySymbol">If this variable is a currency variable, then the currency symbolfor the specific currency (i.e. \&quot;£\&quot; for the UK pound sterling, \&quot;$\&quot; for the US dollar).</param>
        /// <param name="decimalPlaces">The number of decimal places that this numeric variable has.</param>
        public NumericVariableInfo(double? minimum = default(double?), double? maximum = default(double?), bool? isCurrency = default(bool?), string currencyLocale = default(string), string currencySymbol = default(string), int? decimalPlaces = default(int?))
        {
            this.Minimum = minimum;
            this.Maximum = maximum;
            this.IsCurrency = isCurrency;
            this.CurrencyLocale = currencyLocale;
            this.CurrencySymbol = currencySymbol;
            this.DecimalPlaces = decimalPlaces;
        }
        
        /// <summary>
        /// The minimum value that this numeric value has
        /// </summary>
        /// <value>The minimum value that this numeric value has</value>
        [DataMember(Name="minimum", EmitDefaultValue=false)]
        public double? Minimum { get; set; }

        /// <summary>
        /// The maximum value that this numeric value has
        /// </summary>
        /// <value>The maximum value that this numeric value has</value>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public double? Maximum { get; set; }

        /// <summary>
        /// Whether this variable represents a currency value
        /// </summary>
        /// <value>Whether this variable represents a currency value</value>
        [DataMember(Name="isCurrency", EmitDefaultValue=false)]
        public bool? IsCurrency { get; set; }

        /// <summary>
        /// If this variable is a currency variable, then the locale name for the specific currency (i.e. \&quot;en-GB\&quot; for the UK pound sterling, \&quot;en-US\&quot; for the US dollar)
        /// </summary>
        /// <value>If this variable is a currency variable, then the locale name for the specific currency (i.e. \&quot;en-GB\&quot; for the UK pound sterling, \&quot;en-US\&quot; for the US dollar)</value>
        [DataMember(Name="currencyLocale", EmitDefaultValue=false)]
        public string CurrencyLocale { get; set; }

        /// <summary>
        /// If this variable is a currency variable, then the currency symbolfor the specific currency (i.e. \&quot;£\&quot; for the UK pound sterling, \&quot;$\&quot; for the US dollar)
        /// </summary>
        /// <value>If this variable is a currency variable, then the currency symbolfor the specific currency (i.e. \&quot;£\&quot; for the UK pound sterling, \&quot;$\&quot; for the US dollar)</value>
        [DataMember(Name="currencySymbol", EmitDefaultValue=false)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// The number of decimal places that this numeric variable has
        /// </summary>
        /// <value>The number of decimal places that this numeric variable has</value>
        [DataMember(Name="decimalPlaces", EmitDefaultValue=false)]
        public int? DecimalPlaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumericVariableInfo {\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            sb.Append("  IsCurrency: ").Append(IsCurrency).Append("\n");
            sb.Append("  CurrencyLocale: ").Append(CurrencyLocale).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
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
            return this.Equals(input as NumericVariableInfo);
        }

        /// <summary>
        /// Returns true if NumericVariableInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NumericVariableInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumericVariableInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Minimum == input.Minimum ||
                    (this.Minimum != null &&
                    this.Minimum.Equals(input.Minimum))
                ) && 
                (
                    this.Maximum == input.Maximum ||
                    (this.Maximum != null &&
                    this.Maximum.Equals(input.Maximum))
                ) && 
                (
                    this.IsCurrency == input.IsCurrency ||
                    (this.IsCurrency != null &&
                    this.IsCurrency.Equals(input.IsCurrency))
                ) && 
                (
                    this.CurrencyLocale == input.CurrencyLocale ||
                    (this.CurrencyLocale != null &&
                    this.CurrencyLocale.Equals(input.CurrencyLocale))
                ) && 
                (
                    this.CurrencySymbol == input.CurrencySymbol ||
                    (this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(input.CurrencySymbol))
                ) && 
                (
                    this.DecimalPlaces == input.DecimalPlaces ||
                    (this.DecimalPlaces != null &&
                    this.DecimalPlaces.Equals(input.DecimalPlaces))
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
                if (this.Minimum != null)
                    hashCode = hashCode * 59 + this.Minimum.GetHashCode();
                if (this.Maximum != null)
                    hashCode = hashCode * 59 + this.Maximum.GetHashCode();
                if (this.IsCurrency != null)
                    hashCode = hashCode * 59 + this.IsCurrency.GetHashCode();
                if (this.CurrencyLocale != null)
                    hashCode = hashCode * 59 + this.CurrencyLocale.GetHashCode();
                if (this.CurrencySymbol != null)
                    hashCode = hashCode * 59 + this.CurrencySymbol.GetHashCode();
                if (this.DecimalPlaces != null)
                    hashCode = hashCode * 59 + this.DecimalPlaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
