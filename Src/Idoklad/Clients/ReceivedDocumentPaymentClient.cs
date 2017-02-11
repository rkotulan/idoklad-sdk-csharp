using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public class ReceivedDocumentPaymentClient : BaseClient
    {
        public const string ResourceUrl = "/ReceivedDocumentPayments";

        public ReceivedDocumentPaymentClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/ReceivedDocumentPayments
        /// Method returns list of received document payments.
        /// </summary>
        public RowsResultWrapper<ReceivedDocumentPayment> ReceivedDocumentPayments(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<ReceivedDocumentPayment>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/ReceivedDocumentPayments/{id}
        /// Method returns received document payment by Id.
        /// </summary>
        public ReceivedDocumentPayment ReceivedDocumentPayment(int receivedDocumentPaymentId)
        {
            return Get<ReceivedDocumentPayment>(ResourceUrl + "/" + receivedDocumentPaymentId);
        }

        /// <summary>
        /// GET api/ReceivedDocumentPayments/Expand
        /// List of received document payment with related entities.
        /// </summary>
        public RowsResultWrapper<ReceivedDocumentPaymentExpand> ReceivedDocumentPaymentsExpand(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<ReceivedDocumentPaymentExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/ReceivedDocumentPayments/{id}/Expand
        /// Returns received document payment with related entities by Id.
        /// </summary>
        public ReceivedDocumentPaymentExpand ReceivedDocumentPaymentExpand(int receivedDocumentPaymentId)
        {
            return Get<ReceivedDocumentPaymentExpand>(ResourceUrl + "/" + receivedDocumentPaymentId + "/Expand");
        }

        /// <summary>
        /// GET api/ReceivedDocumentPayments/Default/{documentId}
        /// Method returns default payment for given document. Returned model is suitable for new payment creation.
        /// </summary>
        public ReceivedDocumentPaymentCreate Default(int documentId)
        {
            return Get<ReceivedDocumentPaymentCreate>(ResourceUrl + "/Default" + "/" + documentId);
        }

        /// <summary>
        /// DELETE api/ReceivedDocumentPayments/{id}
        /// Deletes payment by Id. If payment has cash voucher, it is deleted as well.
        /// </summary>
        public bool Delete(int paymentId)
        {
            return Delete(ResourceUrl + "/" + paymentId);
        }

        /// <summary>
        /// POST api/ReceivedDocumentPayments
        /// Create new payment. Payment should contains id of payed document.
        /// </summary>
        public ReceivedDocumentPayment Create(ReceivedDocumentPaymentCreate receivedDocumentPayment)
        {
            return Post<ReceivedDocumentPayment, ReceivedDocumentPaymentCreate>(ResourceUrl, receivedDocumentPayment);
        }

        /// <summary>
        /// PUT api/ReceivedDocumentPayments/{id}/Exported/{exported}
        /// Method updates Exported property of the payment.
        /// </summary>
        public bool Update(int paymentId, ExportedStateEnum exportedState)
        {
            return Put<bool>(ResourceUrl + "/" + paymentId  + "/" + "Exported" + "/" + (int)exportedState);
        }
    }
}