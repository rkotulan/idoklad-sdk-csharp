using System;
using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for credit note resources.
    /// </summary>
    public partial class CreditNoteClient : BaseClient
    {
        /// <summary>
        /// PUT api/CreditNotes/{id}/FullyPay?dateOfPayment={dateOfPayment}
        /// Method sets credit note as paid.
        /// </summary>
        public async Task<bool> FullyPayAsync(int creditNoteId, DateTime paid)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + creditNoteId + "/FullyPay" + "?dateOfPayment=" + paid.ToString(ApiContextConfiguration.DateFormat));
        }

        /// <summary>
        /// PUT api/CreditNotes/{id}/FullyUnpay
        /// Method sets credit note as unpaid.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> FullyUnpayAsync(int creditNoteId)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + creditNoteId + "/FullyUnpay");
        }

        /// <summary>
        /// GET api/CreditNotes/Expand
        /// Returns credit note list with related entities such as contact information etc.
        /// </summary>
        public async Task<RowsResultWrapper<CreditNoteExpand>> CreditNotesExpandAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<CreditNoteExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/CreditNotes/{id}/Expand
        /// Returns Credit note with related entities by Id.
        /// </summary>
        public async Task<CreditNoteExpand> CreditNoteExpandAsync(int creditNoteId)
        {
            return await GetAsync<CreditNoteExpand>(ResourceUrl + "/" + creditNoteId +  "/Expand");
        }

        /// <summary>
        /// PUT api/CreditNotes/{id}/Exported/{value}
        /// Method updates Exported property of the invoice.
        /// </summary>
        public async Task<bool> UpdateExportedAsync(int creditNoteId, ExportedStateEnum state)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + creditNoteId + "/Exported" + "/" + (int)state);
        }

        /// <summary>
        /// GET api/CreditNotes
        /// Returns list of credit notes. Filters are optional.
        /// </summary>
        public async Task<RowsResultWrapper<CreditNote>> CreditNotesAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<CreditNote>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/CreditNotes/{id}
        /// Returns information about credit note including summaries.
        /// </summary>
        public async Task<CreditNote> CreditNoteAsync(int creditNoteId)
        {
            return await GetAsync<CreditNote>(ResourceUrl + "/" + creditNoteId);
        }
    }
}
