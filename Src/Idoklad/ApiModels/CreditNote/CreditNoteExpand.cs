using System.Runtime.Serialization;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels.CreditNote
{
    [KnownType(typeof (CreditNoteExpand))]
    public class CreditNoteExpand : CreditNote
    {
        /// <summary>
        /// Contant symbol details
        /// </summary>
        public ConstantSymbol ConstantSymbol { get; set; }

        /// <summary>
        /// Currency details
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Supplier contact address
        /// </summary>
        public DocumentAddress MyCompanyDocumentAddress { get; set; }

        /// <summary>
        /// Payment option details
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Info about purchaser from the address book
        /// </summary>
        public ContactExpand Purchaser { get; set; }

        /// <summary>
        /// Purchaser contact address
        /// </summary>
        public DocumentAddress PurchaserDocumentAddress { get; set; }
    }
}