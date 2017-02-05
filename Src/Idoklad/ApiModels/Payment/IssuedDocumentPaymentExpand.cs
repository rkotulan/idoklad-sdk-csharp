using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    public class IssuedDocumentPaymentExpand : IssuedDocumentPayment
    {
        /// <summary>
        /// Currency details
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Document details
        /// </summary>
        public IssuedInvoice IssuedInvoice { get; set; }

        /// <summary>
        /// Payment option details
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// POS equipment.
        /// </summary>
        public SalesPosEquipment SalesPosEquipment { get; set; }
    }
}