using System;
using System.Collections.Generic;
using IdokladSdk.ApiModels.IssuedInvoice;

namespace IdokladSdk.ApiModels.CreditNote
{
    public class CreditNote : IssuedInvoiceBase
    {
        /// <summary>
        /// Id of the issued invoice
        /// </summary>
        public int CreditNoteForDocumentId { get; set; }

        /// <summary>
        /// Reason for issuing a credit note
        /// </summary>
        public string CreditNoteReason { get; set; }

        /// <summary>
        /// Date of VAT claim
        /// </summary>
        public DateTime DateOfVatClaim { get; set; }

        /// <summary>
        /// Note on the acceptance of credit note
        /// </summary>
        public string NoteForCreditNote { get; set; }

        /// <summary>
        /// Invoice items
        /// </summary>
        public List<CreditNoteItem> CreditNoteItems { get; set; }
    }
}