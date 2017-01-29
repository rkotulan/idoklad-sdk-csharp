using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    public class ReceivedDocumentPaymentExpand : ReceivedDocumentPayment
    {
        /// <summary>
        /// Currency details
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Payment option details
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Document details
        /// </summary>
        public ReceivedInvoice ReceivedInvoice { get; set; }
    }
}