using System;
using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for received invoice resources.
    /// </summary>
    public partial class ReceivedInvoiceClient : BaseClient
    {
        /// <summary>
        /// GET api/Receivedinvoices/Default
        /// Method returns empty invoice with default values. Returned resource is suitable for new invoice creation.
        /// </summary>
        public async Task<ReceivedInvoice> DefaultAsync()
        {
            return await GetAsync<ReceivedInvoice>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// PUT api/Receivedinvoices/{id}/FullyPay?dateOfPayment={dateOfPayment}
        /// Method sets invoice as paid.
        /// </summary>
        public async Task<bool> FullyPayAsync(int invoiceId, DateTime paid)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + invoiceId + "/FullyPay" + "?dateOfPayment=" + paid.ToString(ApiContextConfiguration.DateFormat));
        }

        /// <summary>
        /// PUT api/Receivedinvoices/{id}/FullyUnpay
        /// Method sets invoice as unpaid.
        /// </summary>
        public async Task<bool> FullyUnpayAsync(int invoiceId)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + invoiceId + "/FullyUnpay");
        }

        /// <summary>
        /// GET api/Receivedinvoices/{id}/GetAttachment
        /// Returns attachment for invoice. File is Base64 encoded and is returned as string.
        /// </summary>
        public async Task<string> AttachmentAsync(int invoiceId)
        {
            return await GetAsync<string>(ResourceUrl + "/" + invoiceId + "/GetAttachment");
        }

        /// <summary>
        /// GET api/Receivedinvoices/{id}/GetAttachmentCompressed
        /// Returns compressed attachment for invoice. File is Base64 encoded and is returned as string.
        /// </summary>
        public async Task<string> AttachmentCompressedAsync(int invoiceId)
        {
            return await GetAsync<string>(ResourceUrl + "/" + invoiceId + "/GetAttachmentCompressed");
        }

        /// <summary>
        /// GET api/Receivedinvoices/Expand
        /// Returns Receivied invoice list with related entities such as contact information etc.
        /// </summary>
        public async Task<RowsResultWrapper<ReceivedInvoiceExpand>> ReceivedInvoicesExpandAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<ReceivedInvoiceExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/Receivedinvoices/{id}/Expand
        /// Returns Received invoice with related entities by Id.
        /// </summary>
        public async Task<ReceivedInvoiceExpand> ReceivedInvoiceExpandAsync(int invoiceId)
        {
            return await GetAsync<ReceivedInvoiceExpand>(ResourceUrl + "/" + invoiceId + "/Expand");
        }

        /// <summary>
        /// GET api/Receivedinvoices/{id}/MyDocumentAddress
        /// Contact information of the purchaser for invoice.
        /// </summary>
        public async Task<DocumentAddress> MyDocumentAddressAsync(int invoiceId)
        {
            return await GetAsync<DocumentAddress>(ResourceUrl + "/" + invoiceId + "/MyDocumentAddress");
        }

        /// <summary>
        /// GET api/Receivedinvoices/{supplierId}/ReceivedInvoices
        /// Returns received invoice list for specific contact.
        /// </summary>
        public async Task<RowsResultWrapper<ReceivedInvoice>> ReceivedInvoicesBySupplierAsync(int supplierId, ReceivedInvoiceFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<ReceivedInvoice>>(ResourceUrl + "/" + supplierId + "/ReceivedInvoices");
        }

        /// <summary>
        /// GET api/Receivedinvoices/{id}/SupplierDocumentAddress
        /// Contact information of the supplier for invoice.
        /// </summary>
        public async Task<DocumentAddress> SupplierDocumentAddressAsync(int invoiceId)
        {
            return await GetAsync<DocumentAddress>(ResourceUrl + "/" + invoiceId + "/SupplierDocumentAddress");
        }

        /// <summary>
        /// PUT api/Receivedinvoices/{id}/MyDocumentAddress
        /// Method Updates contact informations of the purchaser.
        /// </summary>
        public async Task<DocumentAddress> UpdateMyDocumentAddressAsync(int invoiceId, DocumentAddress documentAddress)
        {
            return await PutAsync<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + invoiceId + "/MyDocumentAddress", documentAddress);
        }

        /// <summary>
        /// PUT api/Receivedinvoices/{id}/SupplierPurchaserDocumentAddress
        /// Method Updates contact informations of the supplier.
        /// </summary>
        public async Task<DocumentAddress> UpdateSupplierPurchaserDocumentAddressAsync(int invoiceId, DocumentAddress documentAddress)
        {
            return await PutAsync<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + invoiceId + "/SupplierPurchaserDocumentAddress", documentAddress);
        }

        /// <summary>
        /// POST api/Receivedinvoices/Recount
        /// Method recounts summaries of the invoice model for creation.
        /// </summary>
        public async Task<ReceivedInvoice> RecountAsync(ReceivedInvoiceCreate invoice)
        {
            return await PostAsync<ReceivedInvoice, ReceivedInvoiceCreate>(ResourceUrl + "/Recount", invoice);
        }

        /// <summary>
        /// POST api/Receivedinvoices/{id}/Recount
        /// Method recounts summaries of the invoice model for update.
        /// </summary>
        public async Task<ReceivedInvoice> RecountAsync(int invoiceId, ReceivedInvoiceUpdate invoice)
        {
            return await PostAsync<ReceivedInvoice, ReceivedInvoiceUpdate>(ResourceUrl + "/" + invoiceId + "/Recount", invoice);
        }

        /// <summary>
        /// PUT api/Receivedinvoices/{id}/Exported/{value}
        /// Method updates Exported proterty of the invoice.
        /// </summary>
        public async Task<bool> UpdateExportedAsync(int invoiceId, ExportedStateEnum state)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + invoiceId + "/Exported" + "/" + (int)state);
        }

        /// <summary>
        /// DELETE api/ReceivedInvoices/{id}
        /// Deletes received invoice by Id.
        /// </summary>
        public async Task<bool> DeleteAsync(int invoiceId)
        {
            return await DeleteAsync(ResourceUrl + "/" + invoiceId);
        }

        /// <summary>
        /// DELETE api/ReceivedInvoices/DeleteAttachment/{invoiceId}
        /// Deletes a received invoice attachment.
        /// </summary>
        public async Task<bool> DeleteAttachmentAsync(int invoiceId)
        {
            return await DeleteAsync(ResourceUrl + "/" + "DeleteAttachment" + "/" +  invoiceId);
        }

        /// <summary>
        /// GET api/ReceivedInvoices
        /// Returns list of received invoices. Filters are optional.
        /// </summary>
        public async Task<RowsResultWrapper<ReceivedInvoice>> ReceivedInvoicesAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<ReceivedInvoice>>(ResourceUrl, filter);
        }

        /// <summary>
        /// api/ReceivedInvoices/{id}
        /// Returns information about received invoice including summaries.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        public async Task<ReceivedInvoice> ReceivedInvoiceAsync(int invoiceId)
        {
            return await GetAsync<ReceivedInvoice>(ResourceUrl + "/" + invoiceId);
        }

        /// <summary>
        /// POST api/ReceivedInvoices
        /// Create new Received Invoice.
        /// </summary>
        public async Task<ReceivedInvoice> CreateAsync(ReceivedInvoiceCreate invoice)
        {
            return await PostAsync<ReceivedInvoice, ReceivedInvoiceCreate>(ResourceUrl, invoice);
        }

        /// <summary>
        /// PUT api/ReceivedInvoices/{id}
        /// Method updates received invoice by Id. Also possible to update single properties of invoice.
        /// </summary>
        public async Task<ReceivedInvoice> UpdateAsync(int invoiceId, ReceivedInvoiceUpdate invoice)
        {
            return await PutAsync<ReceivedInvoice, ReceivedInvoiceUpdate>(ResourceUrl + "/" + invoiceId, invoice);
        }

        /// <summary>
        /// PUT api/ReceivedInvoices/SetAttachment/{invoicdId}
        /// Sets an attachment to the given received invoice. If an attachment already exists, it will be overwritten.
        /// </summary>
        public async Task<bool> SetAttachmentAsync(int invoiceId)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + "SetAttachment" + "/" + invoiceId);
        }
    }
}