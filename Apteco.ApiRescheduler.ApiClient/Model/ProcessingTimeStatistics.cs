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
    /// Communication statistics for a given set of days
    /// </summary>
    [DataContract]
        public partial class ProcessingTimeStatistics :  IEquatable<ProcessingTimeStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingTimeStatistics" /> class.
        /// </summary>
        /// <param name="categories">The set of categories that the jobs have been broken down into (required).</param>
        /// <param name="frequencies">The set of counts representing the number of jobs in each corresponding time period.  The first figure is data for the first category in the Categories list, and so on. (required).</param>
        /// <param name="minimumDurationsInSeconds">The set of figures representing the minimum job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on. (required).</param>
        /// <param name="maximumDurationsInSeconds">The set of figures representing the maximum job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on. (required).</param>
        /// <param name="meanDurationsInSeconds">The set of figures representing the mean job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on. (required).</param>
        /// <param name="standardDeviationOfDurationsInSeconds">The set of figures representing the standard deviation for job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on. (required).</param>
        /// <param name="medianDurationsInSeconds">The set of figures representing the median job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on. (required).</param>
        /// <param name="percent75DurationsInSeconds">The set of figures representing the 75th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on. (required).</param>
        /// <param name="percent90DurationsInSeconds">The set of figures representing the 90th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on. (required).</param>
        /// <param name="percent95DurationsInSeconds">The set of figures representing the 95th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on. (required).</param>
        /// <param name="percent99DurationsInSeconds">The set of figures representing the 99th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on. (required).</param>
        public ProcessingTimeStatistics(List<string> categories = default(List<string>), List<int?> frequencies = default(List<int?>), List<double?> minimumDurationsInSeconds = default(List<double?>), List<double?> maximumDurationsInSeconds = default(List<double?>), List<double?> meanDurationsInSeconds = default(List<double?>), List<double?> standardDeviationOfDurationsInSeconds = default(List<double?>), List<double?> medianDurationsInSeconds = default(List<double?>), List<double?> percent75DurationsInSeconds = default(List<double?>), List<double?> percent90DurationsInSeconds = default(List<double?>), List<double?> percent95DurationsInSeconds = default(List<double?>), List<double?> percent99DurationsInSeconds = default(List<double?>))
        {
            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new InvalidDataException("categories is a required property for ProcessingTimeStatistics and cannot be null");
            }
            else
            {
                this.Categories = categories;
            }
            // to ensure "frequencies" is required (not null)
            if (frequencies == null)
            {
                throw new InvalidDataException("frequencies is a required property for ProcessingTimeStatistics and cannot be null");
            }
            else
            {
                this.Frequencies = frequencies;
            }
            // to ensure "minimumDurationsInSeconds" is required (not null)
            if (minimumDurationsInSeconds == null)
            {
                throw new InvalidDataException("minimumDurationsInSeconds is a required property for ProcessingTimeStatistics and cannot be null");
            }
            else
            {
                this.MinimumDurationsInSeconds = minimumDurationsInSeconds;
            }
            // to ensure "maximumDurationsInSeconds" is required (not null)
            if (maximumDurationsInSeconds == null)
            {
                throw new InvalidDataException("maximumDurationsInSeconds is a required property for ProcessingTimeStatistics and cannot be null");
            }
            else
            {
                this.MaximumDurationsInSeconds = maximumDurationsInSeconds;
            }
            // to ensure "meanDurationsInSeconds" is required (not null)
            if (meanDurationsInSeconds == null)
            {
                throw new InvalidDataException("meanDurationsInSeconds is a required property for ProcessingTimeStatistics and cannot be null");
            }
            else
            {
                this.MeanDurationsInSeconds = meanDurationsInSeconds;
            }
            // to ensure "standardDeviationOfDurationsInSeconds" is required (not null)
            if (standardDeviationOfDurationsInSeconds == null)
            {
                throw new InvalidDataException("standardDeviationOfDurationsInSeconds is a required property for ProcessingTimeStatistics and cannot be null");
            }
            else
            {
                this.StandardDeviationOfDurationsInSeconds = standardDeviationOfDurationsInSeconds;
            }
            // to ensure "medianDurationsInSeconds" is required (not null)
            if (medianDurationsInSeconds == null)
            {
                throw new InvalidDataException("medianDurationsInSeconds is a required property for ProcessingTimeStatistics and cannot be null");
            }
            else
            {
                this.MedianDurationsInSeconds = medianDurationsInSeconds;
            }
            // to ensure "percent75DurationsInSeconds" is required (not null)
            if (percent75DurationsInSeconds == null)
            {
                throw new InvalidDataException("percent75DurationsInSeconds is a required property for ProcessingTimeStatistics and cannot be null");
            }
            else
            {
                this.Percent75DurationsInSeconds = percent75DurationsInSeconds;
            }
            // to ensure "percent90DurationsInSeconds" is required (not null)
            if (percent90DurationsInSeconds == null)
            {
                throw new InvalidDataException("percent90DurationsInSeconds is a required property for ProcessingTimeStatistics and cannot be null");
            }
            else
            {
                this.Percent90DurationsInSeconds = percent90DurationsInSeconds;
            }
            // to ensure "percent95DurationsInSeconds" is required (not null)
            if (percent95DurationsInSeconds == null)
            {
                throw new InvalidDataException("percent95DurationsInSeconds is a required property for ProcessingTimeStatistics and cannot be null");
            }
            else
            {
                this.Percent95DurationsInSeconds = percent95DurationsInSeconds;
            }
            // to ensure "percent99DurationsInSeconds" is required (not null)
            if (percent99DurationsInSeconds == null)
            {
                throw new InvalidDataException("percent99DurationsInSeconds is a required property for ProcessingTimeStatistics and cannot be null");
            }
            else
            {
                this.Percent99DurationsInSeconds = percent99DurationsInSeconds;
            }
        }
        
        /// <summary>
        /// The set of categories that the jobs have been broken down into
        /// </summary>
        /// <value>The set of categories that the jobs have been broken down into</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// The set of counts representing the number of jobs in each corresponding time period.  The first figure is data for the first category in the Categories list, and so on.
        /// </summary>
        /// <value>The set of counts representing the number of jobs in each corresponding time period.  The first figure is data for the first category in the Categories list, and so on.</value>
        [DataMember(Name="frequencies", EmitDefaultValue=false)]
        public List<int?> Frequencies { get; set; }

        /// <summary>
        /// The set of figures representing the minimum job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.
        /// </summary>
        /// <value>The set of figures representing the minimum job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.</value>
        [DataMember(Name="minimumDurationsInSeconds", EmitDefaultValue=false)]
        public List<double?> MinimumDurationsInSeconds { get; set; }

        /// <summary>
        /// The set of figures representing the maximum job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.
        /// </summary>
        /// <value>The set of figures representing the maximum job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.</value>
        [DataMember(Name="maximumDurationsInSeconds", EmitDefaultValue=false)]
        public List<double?> MaximumDurationsInSeconds { get; set; }

        /// <summary>
        /// The set of figures representing the mean job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.
        /// </summary>
        /// <value>The set of figures representing the mean job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.</value>
        [DataMember(Name="meanDurationsInSeconds", EmitDefaultValue=false)]
        public List<double?> MeanDurationsInSeconds { get; set; }

        /// <summary>
        /// The set of figures representing the standard deviation for job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.
        /// </summary>
        /// <value>The set of figures representing the standard deviation for job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.</value>
        [DataMember(Name="standardDeviationOfDurationsInSeconds", EmitDefaultValue=false)]
        public List<double?> StandardDeviationOfDurationsInSeconds { get; set; }

        /// <summary>
        /// The set of figures representing the median job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.
        /// </summary>
        /// <value>The set of figures representing the median job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.</value>
        [DataMember(Name="medianDurationsInSeconds", EmitDefaultValue=false)]
        public List<double?> MedianDurationsInSeconds { get; set; }

        /// <summary>
        /// The set of figures representing the 75th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.
        /// </summary>
        /// <value>The set of figures representing the 75th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.</value>
        [DataMember(Name="percent75DurationsInSeconds", EmitDefaultValue=false)]
        public List<double?> Percent75DurationsInSeconds { get; set; }

        /// <summary>
        /// The set of figures representing the 90th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.
        /// </summary>
        /// <value>The set of figures representing the 90th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.</value>
        [DataMember(Name="percent90DurationsInSeconds", EmitDefaultValue=false)]
        public List<double?> Percent90DurationsInSeconds { get; set; }

        /// <summary>
        /// The set of figures representing the 95th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.
        /// </summary>
        /// <value>The set of figures representing the 95th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.</value>
        [DataMember(Name="percent95DurationsInSeconds", EmitDefaultValue=false)]
        public List<double?> Percent95DurationsInSeconds { get; set; }

        /// <summary>
        /// The set of figures representing the 99th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.
        /// </summary>
        /// <value>The set of figures representing the 99th percentile job duration for each corresponding time period.  The first figure is data for the first category in the Categories  list, and so on.</value>
        [DataMember(Name="percent99DurationsInSeconds", EmitDefaultValue=false)]
        public List<double?> Percent99DurationsInSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessingTimeStatistics {\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Frequencies: ").Append(Frequencies).Append("\n");
            sb.Append("  MinimumDurationsInSeconds: ").Append(MinimumDurationsInSeconds).Append("\n");
            sb.Append("  MaximumDurationsInSeconds: ").Append(MaximumDurationsInSeconds).Append("\n");
            sb.Append("  MeanDurationsInSeconds: ").Append(MeanDurationsInSeconds).Append("\n");
            sb.Append("  StandardDeviationOfDurationsInSeconds: ").Append(StandardDeviationOfDurationsInSeconds).Append("\n");
            sb.Append("  MedianDurationsInSeconds: ").Append(MedianDurationsInSeconds).Append("\n");
            sb.Append("  Percent75DurationsInSeconds: ").Append(Percent75DurationsInSeconds).Append("\n");
            sb.Append("  Percent90DurationsInSeconds: ").Append(Percent90DurationsInSeconds).Append("\n");
            sb.Append("  Percent95DurationsInSeconds: ").Append(Percent95DurationsInSeconds).Append("\n");
            sb.Append("  Percent99DurationsInSeconds: ").Append(Percent99DurationsInSeconds).Append("\n");
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
            return this.Equals(input as ProcessingTimeStatistics);
        }

        /// <summary>
        /// Returns true if ProcessingTimeStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessingTimeStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessingTimeStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Frequencies == input.Frequencies ||
                    this.Frequencies != null &&
                    input.Frequencies != null &&
                    this.Frequencies.SequenceEqual(input.Frequencies)
                ) && 
                (
                    this.MinimumDurationsInSeconds == input.MinimumDurationsInSeconds ||
                    this.MinimumDurationsInSeconds != null &&
                    input.MinimumDurationsInSeconds != null &&
                    this.MinimumDurationsInSeconds.SequenceEqual(input.MinimumDurationsInSeconds)
                ) && 
                (
                    this.MaximumDurationsInSeconds == input.MaximumDurationsInSeconds ||
                    this.MaximumDurationsInSeconds != null &&
                    input.MaximumDurationsInSeconds != null &&
                    this.MaximumDurationsInSeconds.SequenceEqual(input.MaximumDurationsInSeconds)
                ) && 
                (
                    this.MeanDurationsInSeconds == input.MeanDurationsInSeconds ||
                    this.MeanDurationsInSeconds != null &&
                    input.MeanDurationsInSeconds != null &&
                    this.MeanDurationsInSeconds.SequenceEqual(input.MeanDurationsInSeconds)
                ) && 
                (
                    this.StandardDeviationOfDurationsInSeconds == input.StandardDeviationOfDurationsInSeconds ||
                    this.StandardDeviationOfDurationsInSeconds != null &&
                    input.StandardDeviationOfDurationsInSeconds != null &&
                    this.StandardDeviationOfDurationsInSeconds.SequenceEqual(input.StandardDeviationOfDurationsInSeconds)
                ) && 
                (
                    this.MedianDurationsInSeconds == input.MedianDurationsInSeconds ||
                    this.MedianDurationsInSeconds != null &&
                    input.MedianDurationsInSeconds != null &&
                    this.MedianDurationsInSeconds.SequenceEqual(input.MedianDurationsInSeconds)
                ) && 
                (
                    this.Percent75DurationsInSeconds == input.Percent75DurationsInSeconds ||
                    this.Percent75DurationsInSeconds != null &&
                    input.Percent75DurationsInSeconds != null &&
                    this.Percent75DurationsInSeconds.SequenceEqual(input.Percent75DurationsInSeconds)
                ) && 
                (
                    this.Percent90DurationsInSeconds == input.Percent90DurationsInSeconds ||
                    this.Percent90DurationsInSeconds != null &&
                    input.Percent90DurationsInSeconds != null &&
                    this.Percent90DurationsInSeconds.SequenceEqual(input.Percent90DurationsInSeconds)
                ) && 
                (
                    this.Percent95DurationsInSeconds == input.Percent95DurationsInSeconds ||
                    this.Percent95DurationsInSeconds != null &&
                    input.Percent95DurationsInSeconds != null &&
                    this.Percent95DurationsInSeconds.SequenceEqual(input.Percent95DurationsInSeconds)
                ) && 
                (
                    this.Percent99DurationsInSeconds == input.Percent99DurationsInSeconds ||
                    this.Percent99DurationsInSeconds != null &&
                    input.Percent99DurationsInSeconds != null &&
                    this.Percent99DurationsInSeconds.SequenceEqual(input.Percent99DurationsInSeconds)
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
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Frequencies != null)
                    hashCode = hashCode * 59 + this.Frequencies.GetHashCode();
                if (this.MinimumDurationsInSeconds != null)
                    hashCode = hashCode * 59 + this.MinimumDurationsInSeconds.GetHashCode();
                if (this.MaximumDurationsInSeconds != null)
                    hashCode = hashCode * 59 + this.MaximumDurationsInSeconds.GetHashCode();
                if (this.MeanDurationsInSeconds != null)
                    hashCode = hashCode * 59 + this.MeanDurationsInSeconds.GetHashCode();
                if (this.StandardDeviationOfDurationsInSeconds != null)
                    hashCode = hashCode * 59 + this.StandardDeviationOfDurationsInSeconds.GetHashCode();
                if (this.MedianDurationsInSeconds != null)
                    hashCode = hashCode * 59 + this.MedianDurationsInSeconds.GetHashCode();
                if (this.Percent75DurationsInSeconds != null)
                    hashCode = hashCode * 59 + this.Percent75DurationsInSeconds.GetHashCode();
                if (this.Percent90DurationsInSeconds != null)
                    hashCode = hashCode * 59 + this.Percent90DurationsInSeconds.GetHashCode();
                if (this.Percent95DurationsInSeconds != null)
                    hashCode = hashCode * 59 + this.Percent95DurationsInSeconds.GetHashCode();
                if (this.Percent99DurationsInSeconds != null)
                    hashCode = hashCode * 59 + this.Percent99DurationsInSeconds.GetHashCode();
                return hashCode;
            }
        }
    }
}
