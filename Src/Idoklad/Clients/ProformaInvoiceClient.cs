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
        /// GET api/ProformaInvoices
        /// Method returns list of proforma invoices.
        /// </summary>
        public RowsResultWrapper<ProformaInvoice> ProformaInvoices(Paging paging = null)
        {
            return Get<RowsResultWrapper<ProformaInvoice>>(ResourceUrl, paging);
        }

        /// <summary>
        /// GET api/ProformaInvoices/{id}
        /// Method returns proforma invoice by Id.
        /// </summary>
        public ProformaInvoice ProformaInvoice(int proformaInvoiceId)
        {
            return Get<ProformaInvoice>(ResourceUrl + "/" + proformaInvoiceId);
        }
    }
}