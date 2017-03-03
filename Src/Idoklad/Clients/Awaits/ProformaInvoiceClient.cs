using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    public partial class ProformaInvoiceClient : BaseClient
    {
        /// <summary>
        /// DELETE api/ProformaInvoices/{id}
        /// Deletes proforma invoice by Id.
        /// </summary>
        public async Task<bool> DeleteAsync(int proformaInvoiceId)
        {
            return await DeleteAsync(ResourceUrl + "/" + proformaInvoiceId);
        }

        /// <summary>
        /// DELETE api/ProformaInvoices/DeleteAttachment/{invoiceId}
        /// Deletes a proforma invoice attachment.
        /// </summary>
        public async Task<bool> DeleteAttachmentAsync(int invoiceId)
        {
            return await DeleteAsync(ResourceUrl + "/" + "DeleteAttachment" + "/" + invoiceId);
        }

        /// <summary>
        /// GET api/ProformaInvoices
        /// Method returns list of proforma invoices.
        /// </summary>
        public async Task<RowsResultWrapper<ProformaInvoice>> ProformaInvoicesAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<ProformaInvoice>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/ProformaInvoices/{id}
        /// Method returns proforma invoice by Id.
        /// </summary>
        public async Task<ProformaInvoice> ProformaInvoiceAsync(int proformaInvoiceId)
        {
            return await GetAsync<ProformaInvoice>(ResourceUrl + "/" + proformaInvoiceId);
        }

        /// <summary>
        /// POST api/ProformaInvoices/Recount
        /// Method recounts summaries of the invoice model for creation.
        /// </summary>
        public async Task<ProformaInvoice> RecountAsync(ProformaInvoiceCreate proformaInvoice)
        {
            return await PostAsync<ProformaInvoice, ProformaInvoiceCreate>(ResourceUrl + "/Recount", proformaInvoice);
        }

        /// <summary>
        /// POST api/ProformaInvoices/{id}/Recount
        /// Method recounts summaries of the invoice model for update.
        /// </summary>
        public async Task<ProformaInvoice> RecountAsync(int invoiceId, ProformaInvoiceUpdate proformaInvoice)
        {
            return await PostAsync<ProformaInvoice, ProformaInvoiceUpdate>(ResourceUrl + "/" + invoiceId + "/Recount", proformaInvoice);
        }

        /// <summary>
        /// PUT api/ProformaInvoices/SetAttachment/{invoicdId}
        /// Sets an attachment to the given proforma invoice. If an attachment already exists, it will be overwritten.
        /// </summary>
        public async Task<bool> SetAttachmentAsync(int invoiceId)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + "SetAttachment" + "/" + invoiceId);
        }
    }
}