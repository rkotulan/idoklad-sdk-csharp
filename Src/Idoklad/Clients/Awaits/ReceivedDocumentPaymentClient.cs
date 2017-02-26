using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public partial class ReceivedDocumentPaymentClient : BaseClient
    {
        /// <summary>
        /// GET api/ReceivedDocumentPayments
        /// Method returns list of received document payments.
        /// </summary>
        public async Task<RowsResultWrapper<ReceivedDocumentPayment>> ReceivedDocumentPaymentsAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<ReceivedDocumentPayment>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/ReceivedDocumentPayments/{id}
        /// Method returns received document payment by Id.
        /// </summary>
        public async Task<ReceivedDocumentPayment> ReceivedDocumentPaymentAsync(int receivedDocumentPaymentId)
        {
            return await GetAsync<ReceivedDocumentPayment>(ResourceUrl + "/" + receivedDocumentPaymentId);
        }

        /// <summary>
        /// GET api/ReceivedDocumentPayments/Expand
        /// List of received document payment with related entities.
        /// </summary>
        public async Task<RowsResultWrapper<ReceivedDocumentPaymentExpand>> ReceivedDocumentPaymentsExpandAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<ReceivedDocumentPaymentExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/ReceivedDocumentPayments/{id}/Expand
        /// Returns received document payment with related entities by Id.
        /// </summary>
        public async Task<ReceivedDocumentPaymentExpand> ReceivedDocumentPaymentExpandAsync(int receivedDocumentPaymentId)
        {
            return await GetAsync<ReceivedDocumentPaymentExpand>(ResourceUrl + "/" + receivedDocumentPaymentId + "/Expand");
        }

        /// <summary>
        /// GET api/ReceivedDocumentPayments/Default/{documentId}
        /// Method returns default payment for given document. Returned model is suitable for new payment creation.
        /// </summary>
        public async Task<ReceivedDocumentPaymentCreate> DefaultAsync(int documentId)
        {
            return await GetAsync<ReceivedDocumentPaymentCreate>(ResourceUrl + "/Default" + "/" + documentId);
        }

        /// <summary>
        /// DELETE api/ReceivedDocumentPayments/{id}
        /// Deletes payment by Id. If payment has cash voucher, it is deleted as well.
        /// </summary>
        public async Task<bool> DeleteAsync(int paymentId)
        {
            return await DeleteAsync(ResourceUrl + "/" + paymentId);
        }

        /// <summary>
        /// POST api/ReceivedDocumentPayments
        /// Create new payment. Payment should contains id of payed document.
        /// </summary>
        public async Task<ReceivedDocumentPayment> CreateAsync(ReceivedDocumentPaymentCreate receivedDocumentPayment)
        {
            return await PostAsync<ReceivedDocumentPayment, ReceivedDocumentPaymentCreate>(ResourceUrl, receivedDocumentPayment);
        }

        /// <summary>
        /// PUT api/ReceivedDocumentPayments/{id}/Exported/{exported}
        /// Method updates Exported property of the payment.
        /// </summary>
        public async Task<bool> UpdateAsync(int paymentId, ExportedStateEnum exportedState)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + paymentId  + "/" + "Exported" + "/" + (int)exportedState);
        }
    }
}