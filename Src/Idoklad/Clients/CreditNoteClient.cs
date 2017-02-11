using System;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for credit note resources.
    /// </summary>
    public class CreditNoteClient : BaseClient
    {
        public const string ResourceUrl = "/CreditNotes";

        public CreditNoteClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// PUT api/CreditNotes/{id}/FullyPay?dateOfPayment={dateOfPayment}
        /// Method sets credit note as paid.
        /// </summary>
        public bool FullyPay(int creditNoteId, DateTime paid)
        {
            return Put<bool>(ResourceUrl + "/" + creditNoteId + "/FullyPay" + "?dateOfPayment=" + paid.ToString(ApiContext.Configuration.DateFormat));
        }

        /// <summary>
        /// PUT api/CreditNotes/{id}/FullyUnpay
        /// Method sets credit note as unpaid.
        /// </summary>
        /// <returns></returns>
        public bool FullyUnpay(int creditNoteId)
        {
            return Put<bool>(ResourceUrl + "/" + creditNoteId + "/FullyUnpay");
        }

        /// <summary>
        /// GET api/CreditNotes/Expand
        /// Returns credit note list with related entities such as contact information etc.
        /// </summary>
        public RowsResultWrapper<CreditNoteExpand> CreditNotesExpand(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<CreditNoteExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/CreditNotes/{id}/Expand
        /// Returns Credit note with related entities by Id.
        /// </summary>
        public CreditNoteExpand CreditNoteExpand(int creditNoteId)
        {
            return Get<CreditNoteExpand>(ResourceUrl + "/" + creditNoteId +  "/Expand");
        }

        /// <summary>
        /// PUT api/CreditNotes/{id}/Exported/{value}
        /// Method updates Exported property of the invoice.
        /// </summary>
        public bool UpdateExported(int creditNoteId, ExportedStateEnum state)
        {
            return Put<bool>(ResourceUrl + "/" + creditNoteId + "/Exported" + "/" + (int)state);
        }

        /// <summary>
        /// GET api/CreditNotes
        /// Returns list of credit notes. Filters are optional.
        /// </summary>
        public RowsResultWrapper<CreditNote> CreditNotes(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<CreditNote>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/CreditNotes/{id}
        /// Returns information about credit note including summaries.
        /// </summary>
        public CreditNote CreditNote(int creditNoteId)
        {
            return Get<CreditNote>(ResourceUrl + "/" + creditNoteId);
        }
    }
}
