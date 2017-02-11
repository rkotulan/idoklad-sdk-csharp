using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    public class ProformaInvoiceExpand : ProformaInvoice
    {
        /// <summary>
        /// Constan symbol details
        /// </summary>
        public ConstantSymbol ConstantSymbol { get; set; }

        /// <summary>
        /// Information about currency
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Contact info
        /// </summary>
        public DocumentAddress MyCompanyDocumentAddress { get; set; }

        /// <summary>
        /// Details about payment options
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Info about purchaser from the address book
        /// </summary>
        public ContactExpand Purchaser { get; set; }

        /// <summary>
        /// Purchaser address
        /// </summary>
        public DocumentAddress PurchaserDocumentAddress { get; set; }
    }
}