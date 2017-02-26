using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public partial class IssuedDocumentPaymentClient : BaseClient
    {
        /// <summary>
        /// GET api/IssuedDocumentPayments/Default/{documentId}
        /// Method returns empty issued document payment with default values.
        /// </summary>
        public async Task<IssuedDocumentPaymentCreate> DefaultAsync(int documentId)
        {
            return await GetAsync<IssuedDocumentPaymentCreate>(ResourceUrl + "/Default"  + "/" + documentId);
        }

        /// <summary>
        /// GET api/IssuedDocumentPayments
        /// Returns list of payments.
        /// </summary>
        public async Task<RowsResultWrapper<IssuedDocumentPayment>> IssuedDocumentPaymentsAsync(ApiFilter filter)
        {
            return await GetAsync<RowsResultWrapper<IssuedDocumentPayment>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/IssuedDocumentPayments/{id}
        /// Returns information about a payment.
        /// </summary>
        public async Task<IssuedDocumentPayment> IssuedDocumentPaymentAsync(int issuedDocumentPaymentId)
        {
            return await GetAsync<IssuedDocumentPayment>(ResourceUrl + "/" + issuedDocumentPaymentId);
        }

        /// <summary>
        /// GET api/IssuedDocumentPayments/Expand
        /// Returns list of payments with related entities such as document of payment.
        /// </summary>
        public async Task<RowsResultWrapper<IssuedDocumentPaymentExpand>> IssuedDocumentPaymentsExpandAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<IssuedDocumentPaymentExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/IssuedDocumentPayments/{id}/Expand
        /// Returns payment with related entities by Id.
        /// </summary>
        public async Task<IssuedDocumentPaymentExpand> IssuedDocumentPaymentExpandAsync(int issuedDocumentPaymentId)
        {
            return await GetAsync<IssuedDocumentPaymentExpand>(ResourceUrl + "/" + issuedDocumentPaymentId + "/Expand");
        }

        /// <summary>
        /// POST api/IssuedDocumentPayments
        /// Create new payment. Payment should contains id of payed document.
        /// </summary>
        public async Task<IssuedDocumentPayment> CreateAsync(IssuedDocumentPaymentCreate invoice)
        {
            return await PostAsync<IssuedDocumentPayment, IssuedDocumentPaymentCreate>(ResourceUrl, invoice);
        }

        /// <summary>
        /// PUT api/IssuedDocumentPayments/{id}/Exported/{exported}
        /// Method updates Exported property of the payment.
        /// </summary>
        public async Task<IssuedInvoice> UpdateAsync(int paymentId, ExportedStateEnum  exportedState)
        {
            return await PutAsync<IssuedInvoice>(ResourceUrl + "/" + paymentId + "/" + (int)exportedState);
        }

        /// <summary>
        /// DELETE api/IssuedDocumentPayments/{id}
        /// Deletes payment by Id. If payment has cash voucher, it is deleted as well.
        /// </summary>
        public async Task<bool> DeleteAsync(int invoiceId)
        {
            return await DeleteAsync(ResourceUrl + "/" + invoiceId);
        }
    }
}