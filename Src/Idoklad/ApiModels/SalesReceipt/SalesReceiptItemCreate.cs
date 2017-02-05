using System.ComponentModel.DataAnnotations;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    public class SalesReceiptItemCreate
    {
        /// <summary>
        /// Amount/number of items.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Item name.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(200)]
        public string Name { get; set; }

        /// <summary>
        /// Unit price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Pricelist item id.
        /// </summary>
        public int? PriceListItemId { get; set; }

        /// <summary>
        /// Price type.
        /// </summary>
        [ValidEnumValue]
        public PriceTypeEnum PriceType { get; set; }

        /// <summary>
        /// Unit of measure.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(20)]
        public string Unit { get; set; }

        /// <summary>
        /// Vat rate type.
        /// </summary>
        [ValidEnumValue]
        public VatRateTypeEnum VatRateType { get; set; }
    }
}