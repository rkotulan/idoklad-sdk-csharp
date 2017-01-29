using IdokladSdk.Enums;

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
        public PriceTypeEnum PriceType { get; set; }

        /// <summary>
        /// Unit of measure.
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Vat rate type.
        /// </summary>
        public VatRateTypeEnum VatRateType { get; set; }
    }
}