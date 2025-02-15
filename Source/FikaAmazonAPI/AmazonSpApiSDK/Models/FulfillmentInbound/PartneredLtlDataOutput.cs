/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Information returned by Amazon about a Less Than Truckload/Full Truckload (LTL/FTL) shipment by an Amazon-partnered carrier.
    /// </summary>
    [DataContract]
    public partial class PartneredLtlDataOutput : IEquatable<PartneredLtlDataOutput>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SellerFreightClass
        /// </summary>
        [DataMember(Name = "SellerFreightClass", EmitDefaultValue = false)]
        public SellerFreightClass? SellerFreightClass { get; set; }
        /// <summary>
        /// The freight class of the shipment as estimated by Amazon if you did not include a freight class when you called the putTransportDetails operation.
        /// </summary>
        /// <value>The freight class of the shipment as estimated by Amazon if you did not include a freight class when you called the putTransportDetails operation.</value>
        [DataMember(Name = "PreviewFreightClass", EmitDefaultValue = false)]
        public SellerFreightClass PreviewFreightClass { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartneredLtlDataOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartneredLtlDataOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartneredLtlDataOutput" /> class.
        /// </summary>
        /// <param name="Contact">Contact information for the person in the seller&#39;s organization who is responsible for the shipment. Used by the carrier if they have questions about the shipment. (required).</param>
        /// <param name="BoxCount">The number of boxes in the shipment. (required).</param>
        /// <param name="SellerFreightClass">SellerFreightClass.</param>
        /// <param name="FreightReadyDate">The date that the shipment will be ready to be picked up by the carrier. Must be in YYYY-MM-DD format. (required).</param>
        /// <param name="PalletList">PalletList (required).</param>
        /// <param name="TotalWeight">The total weight of the shipment. (required).</param>
        /// <param name="SellerDeclaredValue">Your declaration of the total value of the inventory in the shipment..</param>
        /// <param name="AmazonCalculatedValue">Estimate by Amazon of the total value of the inventory in the shipment..</param>
        /// <param name="PreviewPickupDate">The estimated date that the shipment will be picked up by the carrier, in YYYY-MM-DD format. (required).</param>
        /// <param name="PreviewDeliveryDate">The estimated date that the shipment will be delivered to an Amazon fulfillment center, in YYYY-MM-DD format. (required).</param>
        /// <param name="PreviewFreightClass">The freight class of the shipment as estimated by Amazon if you did not include a freight class when you called the putTransportDetails operation. (required).</param>
        /// <param name="AmazonReferenceId">A unique identifier created by Amazon that identifies this Amazon-partnered, Less Than Truckload/Full Truckload (LTL/FTL) shipment. (required).</param>
        /// <param name="IsBillOfLadingAvailable">Indicates whether the bill of lading for the shipment is available. (required).</param>
        /// <param name="PartneredEstimate">The estimated shipping cost using an Amazon-partnered carrier..</param>
        /// <param name="CarrierName">The carrier for the inbound shipment. (required).</param>
        public PartneredLtlDataOutput(Contact Contact = default(Contact), UnsignedIntType BoxCount = default(UnsignedIntType), SellerFreightClass? SellerFreightClass = default(SellerFreightClass?), DateStringType FreightReadyDate = default(DateStringType), PalletList PalletList = default(PalletList), Weight TotalWeight = default(Weight), Amount SellerDeclaredValue = default(Amount), Amount AmazonCalculatedValue = default(Amount), DateStringType PreviewPickupDate = default(DateStringType), DateStringType PreviewDeliveryDate = default(DateStringType), SellerFreightClass PreviewFreightClass = default(SellerFreightClass), string AmazonReferenceId = default(string), bool? IsBillOfLadingAvailable = default(bool?), PartneredEstimate PartneredEstimate = default(PartneredEstimate), string CarrierName = default(string))
        {
            // to ensure "Contact" is required (not null)
            if (Contact == null)
            {
                throw new InvalidDataException("Contact is a required property for PartneredLtlDataOutput and cannot be null");
            }
            else
            {
                this.Contact = Contact;
            }
            // to ensure "BoxCount" is required (not null)
            if (BoxCount == null)
            {
                throw new InvalidDataException("BoxCount is a required property for PartneredLtlDataOutput and cannot be null");
            }
            else
            {
                this.BoxCount = BoxCount;
            }
            // to ensure "FreightReadyDate" is required (not null)
            if (FreightReadyDate == null)
            {
                throw new InvalidDataException("FreightReadyDate is a required property for PartneredLtlDataOutput and cannot be null");
            }
            else
            {
                this.FreightReadyDate = FreightReadyDate;
            }
            // to ensure "PalletList" is required (not null)
            if (PalletList == null)
            {
                throw new InvalidDataException("PalletList is a required property for PartneredLtlDataOutput and cannot be null");
            }
            else
            {
                this.PalletList = PalletList;
            }
            // to ensure "TotalWeight" is required (not null)
            if (TotalWeight == null)
            {
                throw new InvalidDataException("TotalWeight is a required property for PartneredLtlDataOutput and cannot be null");
            }
            else
            {
                this.TotalWeight = TotalWeight;
            }
            // to ensure "PreviewPickupDate" is required (not null)
            if (PreviewPickupDate == null)
            {
                throw new InvalidDataException("PreviewPickupDate is a required property for PartneredLtlDataOutput and cannot be null");
            }
            else
            {
                this.PreviewPickupDate = PreviewPickupDate;
            }
            // to ensure "PreviewDeliveryDate" is required (not null)
            if (PreviewDeliveryDate == null)
            {
                throw new InvalidDataException("PreviewDeliveryDate is a required property for PartneredLtlDataOutput and cannot be null");
            }
            else
            {
                this.PreviewDeliveryDate = PreviewDeliveryDate;
            }
            // to ensure "PreviewFreightClass" is required (not null)
            if (PreviewFreightClass == null)
            {
                throw new InvalidDataException("PreviewFreightClass is a required property for PartneredLtlDataOutput and cannot be null");
            }
            else
            {
                this.PreviewFreightClass = PreviewFreightClass;
            }
            // to ensure "AmazonReferenceId" is required (not null)
            if (AmazonReferenceId == null)
            {
                throw new InvalidDataException("AmazonReferenceId is a required property for PartneredLtlDataOutput and cannot be null");
            }
            else
            {
                this.AmazonReferenceId = AmazonReferenceId;
            }
            // to ensure "IsBillOfLadingAvailable" is required (not null)
            if (IsBillOfLadingAvailable == null)
            {
                throw new InvalidDataException("IsBillOfLadingAvailable is a required property for PartneredLtlDataOutput and cannot be null");
            }
            else
            {
                this.IsBillOfLadingAvailable = IsBillOfLadingAvailable;
            }
            // to ensure "CarrierName" is required (not null)
            if (CarrierName == null)
            {
                throw new InvalidDataException("CarrierName is a required property for PartneredLtlDataOutput and cannot be null");
            }
            else
            {
                this.CarrierName = CarrierName;
            }
            this.SellerFreightClass = SellerFreightClass;
            this.SellerDeclaredValue = SellerDeclaredValue;
            this.AmazonCalculatedValue = AmazonCalculatedValue;
            this.PartneredEstimate = PartneredEstimate;
        }

        /// <summary>
        /// Contact information for the person in the seller&#39;s organization who is responsible for the shipment. Used by the carrier if they have questions about the shipment.
        /// </summary>
        /// <value>Contact information for the person in the seller&#39;s organization who is responsible for the shipment. Used by the carrier if they have questions about the shipment.</value>
        [DataMember(Name = "Contact", EmitDefaultValue = false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// The number of boxes in the shipment.
        /// </summary>
        /// <value>The number of boxes in the shipment.</value>
        [DataMember(Name = "BoxCount", EmitDefaultValue = false)]
        public UnsignedIntType BoxCount { get; set; }


        /// <summary>
        /// The date that the shipment will be ready to be picked up by the carrier. Must be in YYYY-MM-DD format.
        /// </summary>
        /// <value>The date that the shipment will be ready to be picked up by the carrier. Must be in YYYY-MM-DD format.</value>
        [DataMember(Name = "FreightReadyDate", EmitDefaultValue = false)]
        public DateStringType FreightReadyDate { get; set; }

        /// <summary>
        /// Gets or Sets PalletList
        /// </summary>
        [DataMember(Name = "PalletList", EmitDefaultValue = false)]
        public PalletList PalletList { get; set; }

        /// <summary>
        /// The total weight of the shipment.
        /// </summary>
        /// <value>The total weight of the shipment.</value>
        [DataMember(Name = "TotalWeight", EmitDefaultValue = false)]
        public Weight TotalWeight { get; set; }

        /// <summary>
        /// Your declaration of the total value of the inventory in the shipment.
        /// </summary>
        /// <value>Your declaration of the total value of the inventory in the shipment.</value>
        [DataMember(Name = "SellerDeclaredValue", EmitDefaultValue = false)]
        public Amount SellerDeclaredValue { get; set; }

        /// <summary>
        /// Estimate by Amazon of the total value of the inventory in the shipment.
        /// </summary>
        /// <value>Estimate by Amazon of the total value of the inventory in the shipment.</value>
        [DataMember(Name = "AmazonCalculatedValue", EmitDefaultValue = false)]
        public Amount AmazonCalculatedValue { get; set; }

        /// <summary>
        /// The estimated date that the shipment will be picked up by the carrier, in YYYY-MM-DD format.
        /// </summary>
        /// <value>The estimated date that the shipment will be picked up by the carrier, in YYYY-MM-DD format.</value>
        [DataMember(Name = "PreviewPickupDate", EmitDefaultValue = false)]
        public DateStringType PreviewPickupDate { get; set; }

        /// <summary>
        /// The estimated date that the shipment will be delivered to an Amazon fulfillment center, in YYYY-MM-DD format.
        /// </summary>
        /// <value>The estimated date that the shipment will be delivered to an Amazon fulfillment center, in YYYY-MM-DD format.</value>
        [DataMember(Name = "PreviewDeliveryDate", EmitDefaultValue = false)]
        public DateStringType PreviewDeliveryDate { get; set; }


        /// <summary>
        /// A unique identifier created by Amazon that identifies this Amazon-partnered, Less Than Truckload/Full Truckload (LTL/FTL) shipment.
        /// </summary>
        /// <value>A unique identifier created by Amazon that identifies this Amazon-partnered, Less Than Truckload/Full Truckload (LTL/FTL) shipment.</value>
        [DataMember(Name = "AmazonReferenceId", EmitDefaultValue = false)]
        public string AmazonReferenceId { get; set; }

        /// <summary>
        /// Indicates whether the bill of lading for the shipment is available.
        /// </summary>
        /// <value>Indicates whether the bill of lading for the shipment is available.</value>
        [DataMember(Name = "IsBillOfLadingAvailable", EmitDefaultValue = false)]
        public bool? IsBillOfLadingAvailable { get; set; }

        /// <summary>
        /// The estimated shipping cost using an Amazon-partnered carrier.
        /// </summary>
        /// <value>The estimated shipping cost using an Amazon-partnered carrier.</value>
        [DataMember(Name = "PartneredEstimate", EmitDefaultValue = false)]
        public PartneredEstimate PartneredEstimate { get; set; }

        /// <summary>
        /// The carrier for the inbound shipment.
        /// </summary>
        /// <value>The carrier for the inbound shipment.</value>
        [DataMember(Name = "CarrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartneredLtlDataOutput {\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  BoxCount: ").Append(BoxCount).Append("\n");
            sb.Append("  SellerFreightClass: ").Append(SellerFreightClass).Append("\n");
            sb.Append("  FreightReadyDate: ").Append(FreightReadyDate).Append("\n");
            sb.Append("  PalletList: ").Append(PalletList).Append("\n");
            sb.Append("  TotalWeight: ").Append(TotalWeight).Append("\n");
            sb.Append("  SellerDeclaredValue: ").Append(SellerDeclaredValue).Append("\n");
            sb.Append("  AmazonCalculatedValue: ").Append(AmazonCalculatedValue).Append("\n");
            sb.Append("  PreviewPickupDate: ").Append(PreviewPickupDate).Append("\n");
            sb.Append("  PreviewDeliveryDate: ").Append(PreviewDeliveryDate).Append("\n");
            sb.Append("  PreviewFreightClass: ").Append(PreviewFreightClass).Append("\n");
            sb.Append("  AmazonReferenceId: ").Append(AmazonReferenceId).Append("\n");
            sb.Append("  IsBillOfLadingAvailable: ").Append(IsBillOfLadingAvailable).Append("\n");
            sb.Append("  PartneredEstimate: ").Append(PartneredEstimate).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
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
            return this.Equals(input as PartneredLtlDataOutput);
        }

        /// <summary>
        /// Returns true if PartneredLtlDataOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of PartneredLtlDataOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartneredLtlDataOutput input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) &&
                (
                    this.BoxCount == input.BoxCount ||
                    (this.BoxCount != null &&
                    this.BoxCount.Equals(input.BoxCount))
                ) &&
                (
                    this.SellerFreightClass == input.SellerFreightClass ||
                    (this.SellerFreightClass != null &&
                    this.SellerFreightClass.Equals(input.SellerFreightClass))
                ) &&
                (
                    this.FreightReadyDate == input.FreightReadyDate ||
                    (this.FreightReadyDate != null &&
                    this.FreightReadyDate.Equals(input.FreightReadyDate))
                ) &&
                (
                    this.PalletList == input.PalletList ||
                    (this.PalletList != null &&
                    this.PalletList.Equals(input.PalletList))
                ) &&
                (
                    this.TotalWeight == input.TotalWeight ||
                    (this.TotalWeight != null &&
                    this.TotalWeight.Equals(input.TotalWeight))
                ) &&
                (
                    this.SellerDeclaredValue == input.SellerDeclaredValue ||
                    (this.SellerDeclaredValue != null &&
                    this.SellerDeclaredValue.Equals(input.SellerDeclaredValue))
                ) &&
                (
                    this.AmazonCalculatedValue == input.AmazonCalculatedValue ||
                    (this.AmazonCalculatedValue != null &&
                    this.AmazonCalculatedValue.Equals(input.AmazonCalculatedValue))
                ) &&
                (
                    this.PreviewPickupDate == input.PreviewPickupDate ||
                    (this.PreviewPickupDate != null &&
                    this.PreviewPickupDate.Equals(input.PreviewPickupDate))
                ) &&
                (
                    this.PreviewDeliveryDate == input.PreviewDeliveryDate ||
                    (this.PreviewDeliveryDate != null &&
                    this.PreviewDeliveryDate.Equals(input.PreviewDeliveryDate))
                ) &&
                (
                    this.PreviewFreightClass == input.PreviewFreightClass ||
                    (this.PreviewFreightClass != null &&
                    this.PreviewFreightClass.Equals(input.PreviewFreightClass))
                ) &&
                (
                    this.AmazonReferenceId == input.AmazonReferenceId ||
                    (this.AmazonReferenceId != null &&
                    this.AmazonReferenceId.Equals(input.AmazonReferenceId))
                ) &&
                (
                    this.IsBillOfLadingAvailable == input.IsBillOfLadingAvailable ||
                    (this.IsBillOfLadingAvailable != null &&
                    this.IsBillOfLadingAvailable.Equals(input.IsBillOfLadingAvailable))
                ) &&
                (
                    this.PartneredEstimate == input.PartneredEstimate ||
                    (this.PartneredEstimate != null &&
                    this.PartneredEstimate.Equals(input.PartneredEstimate))
                ) &&
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
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
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.BoxCount != null)
                    hashCode = hashCode * 59 + this.BoxCount.GetHashCode();
                if (this.SellerFreightClass != null)
                    hashCode = hashCode * 59 + this.SellerFreightClass.GetHashCode();
                if (this.FreightReadyDate != null)
                    hashCode = hashCode * 59 + this.FreightReadyDate.GetHashCode();
                if (this.PalletList != null)
                    hashCode = hashCode * 59 + this.PalletList.GetHashCode();
                if (this.TotalWeight != null)
                    hashCode = hashCode * 59 + this.TotalWeight.GetHashCode();
                if (this.SellerDeclaredValue != null)
                    hashCode = hashCode * 59 + this.SellerDeclaredValue.GetHashCode();
                if (this.AmazonCalculatedValue != null)
                    hashCode = hashCode * 59 + this.AmazonCalculatedValue.GetHashCode();
                if (this.PreviewPickupDate != null)
                    hashCode = hashCode * 59 + this.PreviewPickupDate.GetHashCode();
                if (this.PreviewDeliveryDate != null)
                    hashCode = hashCode * 59 + this.PreviewDeliveryDate.GetHashCode();
                if (this.PreviewFreightClass != null)
                    hashCode = hashCode * 59 + this.PreviewFreightClass.GetHashCode();
                if (this.AmazonReferenceId != null)
                    hashCode = hashCode * 59 + this.AmazonReferenceId.GetHashCode();
                if (this.IsBillOfLadingAvailable != null)
                    hashCode = hashCode * 59 + this.IsBillOfLadingAvailable.GetHashCode();
                if (this.PartneredEstimate != null)
                    hashCode = hashCode * 59 + this.PartneredEstimate.GetHashCode();
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
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
