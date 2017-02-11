using System;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    public class PriceList : IApiModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Item amount
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Code from price list
        /// </summary>
        [StringLength(20)]
        public string Code { get; set; }

        /// <summary>
        /// Currency ID
        /// </summary>
        public int? CurrencyId { get; set; }

        /// <summary>
        /// Name of the item
        /// </summary>
        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Price for one piece
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// Type of price
        /// </summary>
        [ValidEnumValue]
        public PriceTypeEnum? PriceType { get; set; }

        /// <summary>
        /// Unit
        /// </summary>
        [StringLength(20)]
        public string Unit { get; set; }

        /// <summary>
        /// VAT rate type
        /// </summary>
        [ValidEnumValue]
        public VatRateTypeEnum? VatRateType { get; set; }

        /// <summary>
        /// Last change of price list item
        /// </summary>
        public DateTime? DateLastChange { get; set; }

        public bool? HasStockMovement { get; set; }
    }
}