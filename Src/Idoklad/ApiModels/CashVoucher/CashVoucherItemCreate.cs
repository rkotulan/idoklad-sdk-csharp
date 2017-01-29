using System.ComponentModel.DataAnnotations;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class CashVoucherItemCreate
    {
        public decimal Amount { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public PriceTypeEnum PriceType { get; set; }

        public byte Status { get; set; }

        public string VariableSymbol { get; set; }

        public decimal VatRate { get; set; }

        public VatRateTypeEnum VatRateType { get; set; }

    }
}