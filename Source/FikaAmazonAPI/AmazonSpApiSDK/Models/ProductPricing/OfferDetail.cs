/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductPricing
{
    /// <summary>
    /// OfferDetail
    /// </summary>
    [DataContract]
    public partial class OfferDetail : IEquatable<OfferDetail>, IValidatableObject
    {
        /// <summary>
        /// Indicates the type of customer that the offer is valid for.
        /// </summary>
        /// <value>Indicates the type of customer that the offer is valid for.</value>
        [DataMember(Name = "offerType", EmitDefaultValue = false)]
        public OfferTypeEnum? OfferType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OfferDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferDetail" /> class.
        /// </summary>
        /// <param name="myOffer">When true, this is the seller&#39;s offer..</param>
        /// <param name="offerType">Indicates the type of customer that the offer is valid for..</param>
        /// <param name="subCondition">The subcondition of the item. Subcondition values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, or Other. (required).</param>
        /// <param name="sellerId">The seller identifier for the offer..</param>
        /// <param name="conditionNotes">Information about the condition of the item..</param>
        /// <param name="sellerFeedbackRating">Information about the seller&#39;s feedback, including the percentage of positive feedback, and the total number of ratings received..</param>
        /// <param name="shippingTime">The maximum time within which the item will likely be shipped once an order has been placed. (required).</param>
        /// <param name="listingPrice">The price of the item. (required).</param>
        /// <param name="quantityDiscountPrices">quantityDiscountPrices.</param>
        /// <param name="points">The number of Amazon Points offered with the purchase of an item..</param>
        /// <param name="shipping">The shipping cost. (required).</param>
        /// <param name="shipsFrom">The state and country from where the item is shipped..</param>
        /// <param name="isFulfilledByAmazon">When true, the offer is fulfilled by Amazon. (required).</param>
        /// <param name="primeInformation">Amazon Prime information..</param>
        /// <param name="isBuyBoxWinner">When true, the offer is currently in the Buy Box. There can be up to two Buy Box winners at any time per ASIN, one that is eligible for Prime and one that is not eligible for Prime..</param>
        /// <param name="isFeaturedMerchant">When true, the seller of the item is eligible to win the Buy Box..</param>
        public OfferDetail(bool? myOffer = default(bool?), OfferTypeEnum? offerType = default(OfferTypeEnum?), string subCondition = default(string), string sellerId = default(string), string conditionNotes = default(string), SellerFeedbackType sellerFeedbackRating = default(SellerFeedbackType), DetailedShippingTimeType shippingTime = default(DetailedShippingTimeType), MoneyType listingPrice = default(MoneyType), List<QuantityDiscountPriceType> quantityDiscountPrices = default(List<QuantityDiscountPriceType>), Points points = default(Points), MoneyType shipping = default(MoneyType), ShipsFromType shipsFrom = default(ShipsFromType), bool? isFulfilledByAmazon = default(bool?), PrimeInformationType primeInformation = default(PrimeInformationType), bool? isBuyBoxWinner = default(bool?), bool? isFeaturedMerchant = default(bool?))
        {
            // to ensure "subCondition" is required (not null)
            if (subCondition == null)
            {
                throw new InvalidDataException("subCondition is a required property for OfferDetail and cannot be null");
            }
            else
            {
                this.SubCondition = subCondition;
            }
            // to ensure "shippingTime" is required (not null)
            if (shippingTime == null)
            {
                throw new InvalidDataException("shippingTime is a required property for OfferDetail and cannot be null");
            }
            else
            {
                this.ShippingTime = shippingTime;
            }
            // to ensure "listingPrice" is required (not null)
            if (listingPrice == null)
            {
                throw new InvalidDataException("listingPrice is a required property for OfferDetail and cannot be null");
            }
            else
            {
                this.ListingPrice = listingPrice;
            }
            // to ensure "shipping" is required (not null)
            if (shipping == null)
            {
                throw new InvalidDataException("shipping is a required property for OfferDetail and cannot be null");
            }
            else
            {
                this.Shipping = shipping;
            }
            // to ensure "isFulfilledByAmazon" is required (not null)
            if (isFulfilledByAmazon == null)
            {
                throw new InvalidDataException("isFulfilledByAmazon is a required property for OfferDetail and cannot be null");
            }
            else
            {
                this.IsFulfilledByAmazon = isFulfilledByAmazon;
            }
            this.MyOffer = myOffer;
            this.OfferType = offerType;
            this.SellerId = sellerId;
            this.ConditionNotes = conditionNotes;
            this.SellerFeedbackRating = sellerFeedbackRating;
            this.QuantityDiscountPrices = quantityDiscountPrices;
            this.Points = points;
            this.ShipsFrom = shipsFrom;
            this.PrimeInformation = primeInformation;
            this.IsBuyBoxWinner = isBuyBoxWinner;
            this.IsFeaturedMerchant = isFeaturedMerchant;
        }

        /// <summary>
        /// When true, this is the seller&#39;s offer.
        /// </summary>
        /// <value>When true, this is the seller&#39;s offer.</value>
        [DataMember(Name = "MyOffer", EmitDefaultValue = false)]
        public bool? MyOffer { get; set; }


        /// <summary>
        /// The subcondition of the item. Subcondition values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, or Other.
        /// </summary>
        /// <value>The subcondition of the item. Subcondition values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, or Other.</value>
        [DataMember(Name = "SubCondition", EmitDefaultValue = false)]
        public string SubCondition { get; set; }

        /// <summary>
        /// The seller identifier for the offer.
        /// </summary>
        /// <value>The seller identifier for the offer.</value>
        [DataMember(Name = "SellerId", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// Information about the condition of the item.
        /// </summary>
        /// <value>Information about the condition of the item.</value>
        [DataMember(Name = "ConditionNotes", EmitDefaultValue = false)]
        public string ConditionNotes { get; set; }

        /// <summary>
        /// Information about the seller&#39;s feedback, including the percentage of positive feedback, and the total number of ratings received.
        /// </summary>
        /// <value>Information about the seller&#39;s feedback, including the percentage of positive feedback, and the total number of ratings received.</value>
        [DataMember(Name = "SellerFeedbackRating", EmitDefaultValue = false)]
        public SellerFeedbackType SellerFeedbackRating { get; set; }

        /// <summary>
        /// The maximum time within which the item will likely be shipped once an order has been placed.
        /// </summary>
        /// <value>The maximum time within which the item will likely be shipped once an order has been placed.</value>
        [DataMember(Name = "ShippingTime", EmitDefaultValue = false)]
        public DetailedShippingTimeType ShippingTime { get; set; }

        /// <summary>
        /// The price of the item.
        /// </summary>
        /// <value>The price of the item.</value>
        [DataMember(Name = "ListingPrice", EmitDefaultValue = false)]
        public MoneyType ListingPrice { get; set; }

        /// <summary>
        /// Gets or Sets QuantityDiscountPrices
        /// </summary>
        [DataMember(Name = "quantityDiscountPrices", EmitDefaultValue = false)]
        public List<QuantityDiscountPriceType> QuantityDiscountPrices { get; set; }

        /// <summary>
        /// The number of Amazon Points offered with the purchase of an item.
        /// </summary>
        /// <value>The number of Amazon Points offered with the purchase of an item.</value>
        [DataMember(Name = "Points", EmitDefaultValue = false)]
        public Points Points { get; set; }

        /// <summary>
        /// The shipping cost.
        /// </summary>
        /// <value>The shipping cost.</value>
        [DataMember(Name = "Shipping", EmitDefaultValue = false)]
        public MoneyType Shipping { get; set; }

        /// <summary>
        /// The state and country from where the item is shipped.
        /// </summary>
        /// <value>The state and country from where the item is shipped.</value>
        [DataMember(Name = "ShipsFrom", EmitDefaultValue = false)]
        public ShipsFromType ShipsFrom { get; set; }

        /// <summary>
        /// When true, the offer is fulfilled by Amazon.
        /// </summary>
        /// <value>When true, the offer is fulfilled by Amazon.</value>
        [DataMember(Name = "IsFulfilledByAmazon", EmitDefaultValue = false)]
        public bool? IsFulfilledByAmazon { get; set; }

        /// <summary>
        /// Amazon Prime information.
        /// </summary>
        /// <value>Amazon Prime information.</value>
        [DataMember(Name = "PrimeInformation", EmitDefaultValue = false)]
        public PrimeInformationType PrimeInformation { get; set; }

        /// <summary>
        /// When true, the offer is currently in the Buy Box. There can be up to two Buy Box winners at any time per ASIN, one that is eligible for Prime and one that is not eligible for Prime.
        /// </summary>
        /// <value>When true, the offer is currently in the Buy Box. There can be up to two Buy Box winners at any time per ASIN, one that is eligible for Prime and one that is not eligible for Prime.</value>
        [DataMember(Name = "IsBuyBoxWinner", EmitDefaultValue = false)]
        public bool? IsBuyBoxWinner { get; set; }

        /// <summary>
        /// When true, the seller of the item is eligible to win the Buy Box.
        /// </summary>
        /// <value>When true, the seller of the item is eligible to win the Buy Box.</value>
        [DataMember(Name = "IsFeaturedMerchant", EmitDefaultValue = false)]
        public bool? IsFeaturedMerchant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferDetail {\n");
            sb.Append("  MyOffer: ").Append(MyOffer).Append("\n");
            sb.Append("  OfferType: ").Append(OfferType).Append("\n");
            sb.Append("  SubCondition: ").Append(SubCondition).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  ConditionNotes: ").Append(ConditionNotes).Append("\n");
            sb.Append("  SellerFeedbackRating: ").Append(SellerFeedbackRating).Append("\n");
            sb.Append("  ShippingTime: ").Append(ShippingTime).Append("\n");
            sb.Append("  ListingPrice: ").Append(ListingPrice).Append("\n");
            sb.Append("  QuantityDiscountPrices: ").Append(QuantityDiscountPrices).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  ShipsFrom: ").Append(ShipsFrom).Append("\n");
            sb.Append("  IsFulfilledByAmazon: ").Append(IsFulfilledByAmazon).Append("\n");
            sb.Append("  PrimeInformation: ").Append(PrimeInformation).Append("\n");
            sb.Append("  IsBuyBoxWinner: ").Append(IsBuyBoxWinner).Append("\n");
            sb.Append("  IsFeaturedMerchant: ").Append(IsFeaturedMerchant).Append("\n");
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
            return this.Equals(input as OfferDetail);
        }

        /// <summary>
        /// Returns true if OfferDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferDetail input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MyOffer == input.MyOffer ||
                    (this.MyOffer != null &&
                    this.MyOffer.Equals(input.MyOffer))
                ) &&
                (
                    this.OfferType == input.OfferType ||
                    (this.OfferType != null &&
                    this.OfferType.Equals(input.OfferType))
                ) &&
                (
                    this.SubCondition == input.SubCondition ||
                    (this.SubCondition != null &&
                    this.SubCondition.Equals(input.SubCondition))
                ) &&
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) &&
                (
                    this.ConditionNotes == input.ConditionNotes ||
                    (this.ConditionNotes != null &&
                    this.ConditionNotes.Equals(input.ConditionNotes))
                ) &&
                (
                    this.SellerFeedbackRating == input.SellerFeedbackRating ||
                    (this.SellerFeedbackRating != null &&
                    this.SellerFeedbackRating.Equals(input.SellerFeedbackRating))
                ) &&
                (
                    this.ShippingTime == input.ShippingTime ||
                    (this.ShippingTime != null &&
                    this.ShippingTime.Equals(input.ShippingTime))
                ) &&
                (
                    this.ListingPrice == input.ListingPrice ||
                    (this.ListingPrice != null &&
                    this.ListingPrice.Equals(input.ListingPrice))
                ) &&
                (
                    this.QuantityDiscountPrices == input.QuantityDiscountPrices ||
                    this.QuantityDiscountPrices != null
                ) &&
                (
                    this.Points == input.Points ||
                    (this.Points != null &&
                    this.Points.Equals(input.Points))
                ) &&
                (
                    this.Shipping == input.Shipping ||
                    (this.Shipping != null &&
                    this.Shipping.Equals(input.Shipping))
                ) &&
                (
                    this.ShipsFrom == input.ShipsFrom ||
                    (this.ShipsFrom != null &&
                    this.ShipsFrom.Equals(input.ShipsFrom))
                ) &&
                (
                    this.IsFulfilledByAmazon == input.IsFulfilledByAmazon ||
                    (this.IsFulfilledByAmazon != null &&
                    this.IsFulfilledByAmazon.Equals(input.IsFulfilledByAmazon))
                ) &&
                (
                    this.PrimeInformation == input.PrimeInformation ||
                    (this.PrimeInformation != null &&
                    this.PrimeInformation.Equals(input.PrimeInformation))
                ) &&
                (
                    this.IsBuyBoxWinner == input.IsBuyBoxWinner ||
                    (this.IsBuyBoxWinner != null &&
                    this.IsBuyBoxWinner.Equals(input.IsBuyBoxWinner))
                ) &&
                (
                    this.IsFeaturedMerchant == input.IsFeaturedMerchant ||
                    (this.IsFeaturedMerchant != null &&
                    this.IsFeaturedMerchant.Equals(input.IsFeaturedMerchant))
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
                if (this.MyOffer != null)
                    hashCode = hashCode * 59 + this.MyOffer.GetHashCode();
                if (this.OfferType != null)
                    hashCode = hashCode * 59 + this.OfferType.GetHashCode();
                if (this.SubCondition != null)
                    hashCode = hashCode * 59 + this.SubCondition.GetHashCode();
                if (this.SellerId != null)
                    hashCode = hashCode * 59 + this.SellerId.GetHashCode();
                if (this.ConditionNotes != null)
                    hashCode = hashCode * 59 + this.ConditionNotes.GetHashCode();
                if (this.SellerFeedbackRating != null)
                    hashCode = hashCode * 59 + this.SellerFeedbackRating.GetHashCode();
                if (this.ShippingTime != null)
                    hashCode = hashCode * 59 + this.ShippingTime.GetHashCode();
                if (this.ListingPrice != null)
                    hashCode = hashCode * 59 + this.ListingPrice.GetHashCode();
                if (this.QuantityDiscountPrices != null)
                    hashCode = hashCode * 59 + this.QuantityDiscountPrices.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.ShipsFrom != null)
                    hashCode = hashCode * 59 + this.ShipsFrom.GetHashCode();
                if (this.IsFulfilledByAmazon != null)
                    hashCode = hashCode * 59 + this.IsFulfilledByAmazon.GetHashCode();
                if (this.PrimeInformation != null)
                    hashCode = hashCode * 59 + this.PrimeInformation.GetHashCode();
                if (this.IsBuyBoxWinner != null)
                    hashCode = hashCode * 59 + this.IsBuyBoxWinner.GetHashCode();
                if (this.IsFeaturedMerchant != null)
                    hashCode = hashCode * 59 + this.IsFeaturedMerchant.GetHashCode();
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
