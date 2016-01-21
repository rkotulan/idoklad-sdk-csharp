using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    /// <summary>
    /// Položka faktury vydané pro změnu existujícího záznamu
    /// </summary>
    /// <summary xml:lang="en">
    /// Issued invoice item for update
    /// </summary>
    public class IssuedInvoiceItemUpdate : ApiModel
    {
        /// <summary>
        /// Množství položky
        /// </summary>
        [Range(0.0, double.MaxValue)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Název položky
        /// </summary>
        [StringLength(200)]
        public string Name { get; set; }

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
        /// Cena za jednotku
        /// </summary>
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Typ DPH položky
        /// </summary>
        [ValidEnumValue]
        public VatRateTypeEnum? VatRateType { get; set; }
    }
}