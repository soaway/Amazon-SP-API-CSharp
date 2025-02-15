/* 
 * Selling Partner API for FBA Small And Light
 *
 * The Selling Partner API for FBA Small and Light lets you help sellers manage their listings in the Small and Light program. The program reduces the cost of fulfilling orders for small and lightweight FBA inventory. You can enroll or remove items from the program and check item eligibility and enrollment status. You can also preview the estimated program fees charged to a seller for items sold while enrolled in the program.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FbaSmallandLight
{
    /// <summary>
    /// Request schema for submitting items for which to retrieve fee estimates.
    /// </summary>
    [DataContract]
    public partial class SmallAndLightFeePreviewRequest : IEquatable<SmallAndLightFeePreviewRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmallAndLightFeePreviewRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmallAndLightFeePreviewRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmallAndLightFeePreviewRequest" /> class.
        /// </summary>
        /// <param name="MarketplaceId">MarketplaceId (required).</param>
        /// <param name="Items">A list of items for which to retrieve fee estimates (limit: 25). (required).</param>
        public SmallAndLightFeePreviewRequest(MarketplaceId MarketplaceId = default(MarketplaceId), List<Item> Items = default(List<Item>))
        {
            // to ensure "MarketplaceId" is required (not null)
            if (MarketplaceId == null)
            {
                throw new InvalidDataException("MarketplaceId is a required property for SmallAndLightFeePreviewRequest and cannot be null");
            }
            else
            {
                this.MarketplaceId = MarketplaceId;
            }
            // to ensure "Items" is required (not null)
            if (Items == null)
            {
                throw new InvalidDataException("Items is a required property for SmallAndLightFeePreviewRequest and cannot be null");
            }
            else
            {
                this.Items = Items;
            }
        }

        /// <summary>
        /// Gets or Sets MarketplaceId
        /// </summary>
        [DataMember(Name = "marketplaceId", EmitDefaultValue = false)]
        public MarketplaceId MarketplaceId { get; set; }

        /// <summary>
        /// A list of items for which to retrieve fee estimates (limit: 25).
        /// </summary>
        /// <value>A list of items for which to retrieve fee estimates (limit: 25).</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<Item> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmallAndLightFeePreviewRequest {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as SmallAndLightFeePreviewRequest);
        }

        /// <summary>
        /// Returns true if SmallAndLightFeePreviewRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SmallAndLightFeePreviewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmallAndLightFeePreviewRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
