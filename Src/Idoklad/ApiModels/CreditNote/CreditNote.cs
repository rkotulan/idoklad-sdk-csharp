using System;
using System.Collections.Generic;

namespace IdokladSdk.ApiModels
{
    public class CreditNote : IssuedInvoiceBase
    {
        public int Id { get; set; }

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
        /// Numeric sequence ID
        /// </summary>
        public int NumericSequenceId { get; set; }

        /// <summary>
        /// Name of the attached file. If no attachment is included, this will be empty.
        /// </summary>
        public string AttachmentFileName { get; set; }

        /// <summary>
        /// Invoice items
        /// </summary>
        public List<CreditNoteItem> CreditNoteItems { get; set; }
    }
}