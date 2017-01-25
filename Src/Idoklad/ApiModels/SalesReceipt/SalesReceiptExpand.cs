using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    public class SalesReceiptExpand : SalesReceipt
    {
        /// <summary>
        /// Currency model
        /// </summary>
        public Currency Currency { get; set; }
    }
}