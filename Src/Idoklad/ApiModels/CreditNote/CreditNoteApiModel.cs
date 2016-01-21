using System;
using System.Collections.Generic;
using IdokladSdk.ApiModels.IssuedInvoice;

namespace IdokladSdk.ApiModels.CreditNote
{
    public class CreditNote : IssuedInvoiceBase
    {
        /// <summary>
        /// Id dobropisované faktury
        /// </summary>
        /// <summary xml:lang="en">
        /// Id of the issued invoice
        /// </summary>
        public int CreditNoteForDocumentId { get; set; }

        /// <summary>
        /// Zdůvodnění opravy
        /// </summary>
        /// <summary xml:lang="en">
        /// Reason for issuing a credit note
        /// </summary>
        public string CreditNoteReason { get; set; }

        /// <summary>
        /// Datum plnění DPH
        /// </summary>
        /// <summary xml:lang="en">
        /// Date of VAT claim
        /// </summary>
        public DateTime DateOfVatClaim { get; set; }

        /// <summary>
        /// Poznámka o přijetí dobropisu
        /// </summary>
        /// <summary xml:lang="en">
        /// Note on the acceptance of credit note
        /// </summary>
        public string NoteForCreditNote { get; set; }

        /// <summary>
        /// Položky dobropisu
        /// </summary>
        /// <summary xml:lang="en">
        /// Invoice items
        /// </summary>
        public List<CreditNoteItem> CreditNoteItems { get; set; }
    }
}