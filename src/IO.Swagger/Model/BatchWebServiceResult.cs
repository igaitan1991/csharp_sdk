/* 
 * predictor_scoring
 *
 * Credit Score Predictor
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// BatchWebServiceResult
    /// </summary>
    [DataContract]
    public partial class BatchWebServiceResult :  IEquatable<BatchWebServiceResult>, IValidatableObject
    {
        /// <summary>
        /// State of the execution. Can be of the following values:  - Pending: The batch execution was submitted but is not yet scheduled. Ready: The batch execution was submitted and can be executed. InProgress: The batch execution is currently being processed. Complete: The batch execution has been completed.
        /// </summary>
        /// <value>State of the execution. Can be of the following values:  - Pending: The batch execution was submitted but is not yet scheduled. Ready: The batch execution was submitted and can be executed. InProgress: The batch execution is currently being processed. Complete: The batch execution has been completed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,
            
            /// <summary>
            /// Enum InProgress for value: inProgress
            /// </summary>
            [EnumMember(Value = "inProgress")]
            InProgress = 2,
            
            /// <summary>
            /// Enum Ready for value: ready
            /// </summary>
            [EnumMember(Value = "ready")]
            Ready = 3,
            
            /// <summary>
            /// Enum Complete for value: complete
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete = 4
        }

        /// <summary>
        /// State of the execution. Can be of the following values:  - Pending: The batch execution was submitted but is not yet scheduled. Ready: The batch execution was submitted and can be executed. InProgress: The batch execution is currently being processed. Complete: The batch execution has been completed.
        /// </summary>
        /// <value>State of the execution. Can be of the following values:  - Pending: The batch execution was submitted but is not yet scheduled. Ready: The batch execution was submitted and can be executed. InProgress: The batch execution is currently being processed. Complete: The batch execution has been completed.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchWebServiceResult" /> class.
        /// </summary>
        /// <param name="state">State of the execution. Can be of the following values:  - Pending: The batch execution was submitted but is not yet scheduled. Ready: The batch execution was submitted and can be executed. InProgress: The batch execution is currently being processed. Complete: The batch execution has been completed..</param>
        /// <param name="completedItemCount">Number of completed items in this batch operation..</param>
        /// <param name="totalItemCount">Number of total items in this batch operation..</param>
        /// <param name="parallelCount">Number of parallel threads that are processing this batch operation..</param>
        /// <param name="batchExecutionResults">The responses of the individual executions..</param>
        public BatchWebServiceResult(StateEnum? state = default(StateEnum?), int? completedItemCount = default(int?), int? totalItemCount = default(int?), int? parallelCount = default(int?), List<WebServiceResult> batchExecutionResults = default(List<WebServiceResult>))
        {
            this.State = state;
            this.CompletedItemCount = completedItemCount;
            this.TotalItemCount = totalItemCount;
            this.ParallelCount = parallelCount;
            this.BatchExecutionResults = batchExecutionResults;
        }
        

        /// <summary>
        /// Number of completed items in this batch operation.
        /// </summary>
        /// <value>Number of completed items in this batch operation.</value>
        [DataMember(Name="completedItemCount", EmitDefaultValue=false)]
        public int? CompletedItemCount { get; set; }

        /// <summary>
        /// Number of total items in this batch operation.
        /// </summary>
        /// <value>Number of total items in this batch operation.</value>
        [DataMember(Name="totalItemCount", EmitDefaultValue=false)]
        public int? TotalItemCount { get; set; }

        /// <summary>
        /// Number of parallel threads that are processing this batch operation.
        /// </summary>
        /// <value>Number of parallel threads that are processing this batch operation.</value>
        [DataMember(Name="parallelCount", EmitDefaultValue=false)]
        public int? ParallelCount { get; set; }

        /// <summary>
        /// The responses of the individual executions.
        /// </summary>
        /// <value>The responses of the individual executions.</value>
        [DataMember(Name="batchExecutionResults", EmitDefaultValue=false)]
        public List<WebServiceResult> BatchExecutionResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchWebServiceResult {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CompletedItemCount: ").Append(CompletedItemCount).Append("\n");
            sb.Append("  TotalItemCount: ").Append(TotalItemCount).Append("\n");
            sb.Append("  ParallelCount: ").Append(ParallelCount).Append("\n");
            sb.Append("  BatchExecutionResults: ").Append(BatchExecutionResults).Append("\n");
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
            return this.Equals(input as BatchWebServiceResult);
        }

        /// <summary>
        /// Returns true if BatchWebServiceResult instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchWebServiceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchWebServiceResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.CompletedItemCount == input.CompletedItemCount ||
                    (this.CompletedItemCount != null &&
                    this.CompletedItemCount.Equals(input.CompletedItemCount))
                ) && 
                (
                    this.TotalItemCount == input.TotalItemCount ||
                    (this.TotalItemCount != null &&
                    this.TotalItemCount.Equals(input.TotalItemCount))
                ) && 
                (
                    this.ParallelCount == input.ParallelCount ||
                    (this.ParallelCount != null &&
                    this.ParallelCount.Equals(input.ParallelCount))
                ) && 
                (
                    this.BatchExecutionResults == input.BatchExecutionResults ||
                    this.BatchExecutionResults != null &&
                    this.BatchExecutionResults.SequenceEqual(input.BatchExecutionResults)
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CompletedItemCount != null)
                    hashCode = hashCode * 59 + this.CompletedItemCount.GetHashCode();
                if (this.TotalItemCount != null)
                    hashCode = hashCode * 59 + this.TotalItemCount.GetHashCode();
                if (this.ParallelCount != null)
                    hashCode = hashCode * 59 + this.ParallelCount.GetHashCode();
                if (this.BatchExecutionResults != null)
                    hashCode = hashCode * 59 + this.BatchExecutionResults.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}