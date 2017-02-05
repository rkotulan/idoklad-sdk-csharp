using System.ComponentModel.DataAnnotations;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    public class CashVoucherItemCreate
    {
        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DecimalGreaterThanZero]
        public decimal Price { get; set; }

        [ValidEnumValue]
        public PriceTypeEnum PriceType { get; set; }

        public byte Status { get; set; }

        public string VariableSymbol { get; set; }

        public decimal VatRate { get; set; }

        [ValidEnumValue]
        public VatRateTypeEnum VatRateType { get; set; }

    }
}