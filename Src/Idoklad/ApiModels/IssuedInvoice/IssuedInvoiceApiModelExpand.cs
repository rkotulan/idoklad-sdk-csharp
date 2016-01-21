using System.Runtime.Serialization;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels.IssuedInvoice
{
    /// <summary>
    /// Model reprezentuje fakturu vydanou včetně detailních informací o konstantním symbolu, fakturačních údajích i
    /// informacích o kontaktu.
    /// </summary>
    /// <summary xml:lang="en">
    /// Resource that represent issued invoice with exteded information about contact addresses, currency and constant
    /// symbol.
    /// </summary>
    [KnownType(typeof (IssuedInvoiceExpand))]
    public class IssuedInvoiceExpand : IssuedInvoice
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
        /// Informace o odběrateli z adresaře agendy
        /// </summary>
        /// <summary xml:lang="en">
        /// Info about purchaser from the address book
        /// </summary>
        public ContactExpand Purchaser { get; set; }

        /// <summary>
        /// Kontaktní údaje o odběrateli
        /// </summary>
        public DocumentAddress PurchaserDocumentAddress { get; set; }
    }
}