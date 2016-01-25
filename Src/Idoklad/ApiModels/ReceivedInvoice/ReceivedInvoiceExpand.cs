using System.Runtime.Serialization;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels.ReceivedInvoice
{
    [KnownType(typeof (ReceivedInvoiceExpand))]
    public class ReceivedInvoiceExpand : ReceivedInvoice
    {
        /// <summary>
        /// Detail měny
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Kontaktní údaje o odběrateli
        /// </summary>
        public DocumentAddress MyCompanyDocumentAddress { get; set; }

        /// <summary>
        /// Detail způsobu úhrady
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Info about supplier from the address book
        /// </summary>
        public ContactExpand Supplier { get; set; }

        /// <summary>
        /// Kontaktní údaje o dodavateli
        /// </summary>
        public DocumentAddress SupplierDocumentAddress { get; set; }
    }
}