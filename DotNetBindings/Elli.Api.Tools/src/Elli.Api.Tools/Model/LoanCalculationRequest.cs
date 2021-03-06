/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Tools
 *
 * Represents calculations applied on a loan
 *
 * OpenAPI spec version: 1.4.1
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
using SwaggerDateConverter = Elli.Api.Tools.Client.SwaggerDateConverter;

namespace Elli.Api.Tools.Model
{
    /// <summary>
    /// LoanCalculationRequest
    /// </summary>
    [DataContract]
    public partial class LoanCalculationRequest :  IEquatable<LoanCalculationRequest>, IValidatableObject
    {
    
        
        /// <summary>
        /// Unique identifier of a loan
        /// </summary>
        /// <value>Unique identifier of a loan</value>
        [DataMember(Name="loanId", EmitDefaultValue=false)]
        public string LoanId { get; set; }

        /// <summary>
        /// Gets or Sets LoanData
        /// </summary>
        [DataMember(Name="loanData", EmitDefaultValue=false)]
        public LoanContract LoanData { get; set; }

        /// <summary>
        /// List of Loan Entities
        /// </summary>
        /// <value>List of Loan Entities</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<string> Entities { get; set; }

        /// <summary>
        /// Indicates calculations will be executed for all fields
        /// </summary>
        /// <value>Indicates calculations will be executed for all fields</value>
        [DataMember(Name="calcAllOnly", EmitDefaultValue=false)]
        public bool? CalcAllOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanCalculationRequest {\n");
            sb.Append("  LoanId: ").Append(LoanId).Append("\n");
            sb.Append("  LoanData: ").Append(LoanData).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  CalcAllOnly: ").Append(CalcAllOnly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as LoanCalculationRequest);
        }

        /// <summary>
        /// Returns true if LoanCalculationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanCalculationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanCalculationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoanId == input.LoanId ||
                    (this.LoanId != null &&
                    this.LoanId.Equals(input.LoanId))
                ) && 
                (
                    this.LoanData == input.LoanData ||
                    (this.LoanData != null &&
                    this.LoanData.Equals(input.LoanData))
                ) && 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
                ) && 
                (
                    this.CalcAllOnly == input.CalcAllOnly ||
                    (this.CalcAllOnly != null &&
                    this.CalcAllOnly.Equals(input.CalcAllOnly))
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
                if (this.LoanId != null)
                    hashCode = hashCode * 59 + this.LoanId.GetHashCode();
                if (this.LoanData != null)
                    hashCode = hashCode * 59 + this.LoanData.GetHashCode();
                if (this.Entities != null)
                    hashCode = hashCode * 59 + this.Entities.GetHashCode();
                if (this.CalcAllOnly != null)
                    hashCode = hashCode * 59 + this.CalcAllOnly.GetHashCode();
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
