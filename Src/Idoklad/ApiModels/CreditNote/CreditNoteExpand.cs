using System.Runtime.Serialization;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels.CreditNote
{
    [KnownType(typeof (CreditNoteExpand))]
    public class CreditNoteExpand : CreditNote
    {
        /// <summary>
        /// Detail konstantního symbolu
        /// </summary>
        public ConstantSymbol ConstantSymbol { get; set; }

        /// <summary>
        /// Detail měny
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Kontaktní údaje o dodavateli
        /// </summary>
        public DocumentAddress MyCompanyDocumentAddress { get; set; }

        /// <summary>
        /// Detail způsobu úhrady
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Info about purchaser from the address book
        /// </summary>
        public ContactExpand Purchaser { get; set; }

        /// <summary>
        /// Kontaktní údaje o odběrateli
        /// </summary>
        public DocumentAddress PurchaserDocumentAddress { get; set; }
    }
}