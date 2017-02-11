using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    public class ProformaInvoiceClient : BaseClient
    {
        public const string ResourceUrl = "/ProformaInvoices";

        public ProformaInvoiceClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// DELETE api/ProformaInvoices/{id}
        /// Deletes proforma invoice by Id.
        /// </summary>
        public bool Delete(int proformaInvoiceId)
        {
            return Delete(ResourceUrl + "/" + proformaInvoiceId);
        }

        /// <summary>
        /// DELETE api/ProformaInvoices/DeleteAttachment/{invoiceId}
        /// Deletes a proforma invoice attachment.
        /// </summary>
        public bool DeleteAttachment(int invoiceId)
        {
            return Delete(ResourceUrl + "/" + "DeleteAttachment" + "/" + invoiceId);
        }

        /// <summary>
        /// GET api/ProformaInvoices
        /// Method returns list of proforma invoices.
        /// </summary>
        public RowsResultWrapper<ProformaInvoice> ProformaInvoices(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<ProformaInvoice>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/ProformaInvoices/{id}
        /// Method returns proforma invoice by Id.
        /// </summary>
        public ProformaInvoice ProformaInvoice(int proformaInvoiceId)
        {
            return Get<ProformaInvoice>(ResourceUrl + "/" + proformaInvoiceId);
        }

        /// <summary>
        /// POST api/ProformaInvoices/Recount
        /// Method recounts summaries of the invoice model for creation.
        /// </summary>
        public ProformaInvoice Recount(ProformaInvoiceCreate proformaInvoice)
        {
            return Post<ProformaInvoice, ProformaInvoiceCreate>(ResourceUrl + "/Recount", proformaInvoice);
        }

        /// <summary>
        /// POST api/ProformaInvoices/{id}/Recount
        /// Method recounts summaries of the invoice model for update.
        /// </summary>
        public ProformaInvoice Recount(int invoiceId, ProformaInvoiceUpdate proformaInvoice)
        {
            return Post<ProformaInvoice, ProformaInvoiceUpdate>(ResourceUrl + "/" + invoiceId + "/Recount", proformaInvoice);
        }
    }
}