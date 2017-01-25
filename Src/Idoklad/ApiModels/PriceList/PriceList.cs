using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    public class PriceList : ApiModel
    {
        /// <summary>
        /// Množství položky
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Kód položky ceníku
        /// </summary>
        [StringLength(20)]
        public string Code { get; set; }

        /// <summary>
        /// Id měny
        /// </summary>
        public int? CurrencyId { get; set; }

        /// <summary>
        /// Název položky
        /// </summary>
        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Cena za jednotku
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// Typ ceny položky
        /// </summary>
        [ValidEnumValue]
        public PriceTypeEnum? PriceType { get; set; }

        /// <summary>
        /// Měrná jednotka
        /// </summary>
        [StringLength(20)]
        public string Unit { get; set; }

        /// <summary>
        /// Typ DPH položky
        /// </summary>
        [ValidEnumValue]
        public VatRateTypeEnum? VatRateType { get; set; }

        /// <summary>
        /// Datum poslední změny
        /// </summary>
        public DateTime? DateLastChange { get; set; }

        public bool? HasStockMovement { get; set; }
    }
}