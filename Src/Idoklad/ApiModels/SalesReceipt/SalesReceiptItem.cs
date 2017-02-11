using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class SalesReceiptItem : IApiModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Amount/number of items
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Item name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Unit price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Pricelist item id.
        /// </summary>
        public int? PriceListItemId { get; set; }

        /// <summary>
        /// Total amount without VAT in the used currency.
        /// </summary>
        public decimal PriceTotalWithoutVat { get; set; }

        /// <summary>
        /// Total amount without VAT in home currency
        /// </summary>
        public decimal PriceTotalWithoutVatHc { get; set; }

        /// <summary>
        /// Total amount with VAT in used currency
        /// </summary>
        public decimal PriceTotalWithVat { get; set; }

        /// <summary>
        /// Total amount with VAT in home currency
        /// </summary>
        public decimal PriceTotalWithVatHc { get; set; }

        /// <summary>
        /// Price type
        /// </summary>
        public PriceTypeEnum PriceType { get; set; }

        public int Rank { get; set; }

        public int SalesReceiptId { get; set; }

        /// <summary>
        /// Unit of measure.
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Vat rate amount
        /// </summary>
        public decimal VatRate { get; set; }

        /// <summary>
        /// Vat rate type.
        /// </summary>
        public VatRateTypeEnum VatRateType { get; set; }

        /// <summary>
        /// Total amount of VAT in used currency
        /// </summary>
        public decimal VatTotal { get; set; }

        /// <summary>
        /// Total amount of VAT in home currency
        /// </summary>
        public decimal VatTotalHc { get; set; }
    }
}