using System;
using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for issued invoice resources.
    /// </summary>
    public partial class IssuedInvoiceClient : BaseClient
    {
        /// <summary>
        /// GET api/IssuedInvoices/Default
        /// Method returns empty invoice with default values. Returned resource is suitable for new invoice creation.
        /// </summary>
        public async Task<IssuedInvoiceCreate> DefaultAsync()
        {
            return await GetAsync<IssuedInvoiceCreate>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/FullyPay?dateOfPayment={dateOfPayment}
        /// Method sets invoice as paid.
        /// </summary>
        public async Task<bool> FullyPayAsync(int invoiceId, DateTime paid)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + invoiceId + "/FullyPay" + "?dateOfPayment=" + paid.ToString(ApiContextConfiguration.DateFormat));
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/FullyUnpay
        /// Method sets invoice as unpaid.
        /// </summary>
        public async Task<bool> FullyUnpayAsync(int invoiceId)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + invoiceId + "/FullyUnpay");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetCashVoucherPdf
        /// Returns Pdf file with Cash voucher report for the invoice. File is Base64 encoded and is returned as string.
        /// </summary>
        public async Task<string> CashVoucherPdfAsync(int invoiceId)
        {
            return await GetAsync<string>(ResourceUrl + "/" + invoiceId + "/GetCashVoucherPdf");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetCashVoucherPdfCompressed
        /// Returns zipped Pdf file with Cash voucher report for the invoice. File is Base64 encoded and is returned as string.
        /// </summary>
        public async Task<string> CashVoucherPdfCompressedAsync(int invoiceId)
        {
            return await GetAsync<string>(ResourceUrl + "/" + invoiceId + "/GetCashVoucherPdfCompressed");
        }

        /// <summary>
        /// GET api/IssuedInvoices/Expand
        /// Returns Issued invoice list with related entities such as contact information etc.
        /// </summary>
        public async Task<RowsResultWrapper<IssuedInvoiceExpand>> IssuedInvoicesExpandAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<IssuedInvoiceExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/Expand
        /// Returns Issued invoice with related entities by Id.
        /// </summary>
        public async Task<IssuedInvoiceExpand> IssuedInvoiceExpandAsync(int invoiceId)
        {
            return await GetAsync<IssuedInvoiceExpand>(ResourceUrl + "/" + invoiceId + "/Expand");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetPdf
        /// Returns Pdf file with Issued Invoic. File is Base64 encoded and is returned as string.
        /// </summary>
        public async Task<string> IssuedInvoicePdfAsync(int invoiceId)
        {
            return await GetAsync<string>(ResourceUrl + "/" + invoiceId + "/GetPdf");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetPdfCompressed
        /// Returns zipped Pdf file with Issued Invoice report. File is Base64 encoded and is returned as string.
        /// </summary>
        public async Task<string> IssuedInvoicePdfCompressedAsync(int invoiceId)
        {
            return await GetAsync<string>(ResourceUrl + "/" + invoiceId + "/GetPdfCompressed");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{contactId}/IssuedInvoices
        /// Returns invoice list for specific contact.
        /// </summary>
        public async Task<RowsResultWrapper<IssuedInvoice>> IssuedInvoicesByContactAsync(int contactId, ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<IssuedInvoice>>(ResourceUrl + "/" + contactId + "/IssuedInvoices", filter);
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/MyDocumentAddress
        /// Contact information of the supplier for invoice.
        /// </summary>
        public async Task<DocumentAddress> MyDocumentAddressAsync(int invoiceId)
        {
            return await GetAsync<DocumentAddress>(ResourceUrl + "/" + invoiceId + "/MyDocumentAddress");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/PurchaserDocumentAddress
        /// Contact information of the purchaser for invoice.
        /// </summary>
        public async Task<DocumentAddress> PurchaserDocumentAddressAsync(int invoiceId)
        {
            return await GetAsync<DocumentAddress>(ResourceUrl + "/" + invoiceId + "/PurchaserDocumentAddress");
        }

        /// <summary>
        /// POST api/IssuedInvoices/Recount
        /// Method recounts summaries of the invoice model for creation. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public async Task<IssuedInvoice> RecountAsync(IssuedInvoiceCreate invoice)
        {
            return await PostAsync<IssuedInvoice, IssuedInvoiceCreate>(ResourceUrl + "/Recount", invoice);
        }

        /// <summary>
        /// POST api/IssuedInvoices/{id}/Recount
        /// Method recounts summaries of the invoice model for update. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public async Task<IssuedInvoice> RecountAsync(int invoiceId, IssuedInvoiceUpdate invoice)
        {
            return await PostAsync<IssuedInvoice, IssuedInvoiceUpdate>(ResourceUrl + "/" + invoiceId + "/Recount", invoice);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/MyDocumentAddress
        /// Method Updates contact informations of the supplier.
        /// </summary>
        public async Task<DocumentAddress> UpdateMyDocumentAddressAsync(int invoiceId, DocumentAddress address)
        {
            return await PutAsync<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + invoiceId + "/MyDocumentAddress", address);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/PurchaserDocumentAddress
        /// Method Updates contact informations of the purchaser.
        /// </summary>
        public async Task<DocumentAddress> UpdatePurchaserDocumentAddressAsync(int invoiceId, DocumentAddress address)
        {
            return await PutAsync<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + invoiceId + "/PurchaserDocumentAddress", address);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/SendMailToPurchaser
        /// Method sends email with issued invoice to the purchaser.
        /// </summary>
        public async Task<bool> SendMailToPurchaserAsync(int invoiceId)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + invoiceId + "/SendMailToPurchaser");
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/Exported/{value}
        /// Method updates Exported property of the invoice.
        /// </summary>
        public async Task<bool> ExportedAsync(int invoiceId, ExportedStateEnum state)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + invoiceId + "/Exported" + "/" + (int)state);
        }

        /// <summary>
        /// DELETE api/IssuedInvoices/{id}
        /// Deletes issued invoice by Id.
        /// </summary>
        public async Task<bool> DeleteAsync(int invoiceId)
        {
            return await DeleteAsync(ResourceUrl + "/" + invoiceId);
        }

        /// <summary>
        /// GET api/IssuedInvoices
        /// Returns list of issued invoices. Filters are optional.
        /// </summary>
        public async Task<RowsResultWrapper<IssuedInvoice>> IssuedInvoicesAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<IssuedInvoice>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}
        /// Returns information about issued invoice including summaries.
        /// </summary>
        public async Task<IssuedInvoice> IssuedInvoiceAsync(int invoiceId)
        {
            return await GetAsync<IssuedInvoice>(ResourceUrl + "/" + invoiceId);
        }

        /// <summary>
        /// POST api/IssuedInvoices
        /// Create new issued invoice. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public async Task<IssuedInvoice> CreateAsync(IssuedInvoiceCreate invoice)
        {
            return await PostAsync<IssuedInvoice, IssuedInvoiceCreate>(ResourceUrl, invoice);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}
        /// Method updates issued invoice by Id. Also possible to update single preperties of invoice. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public async Task<IssuedInvoice> UpdateAsync(int invoiceId, IssuedInvoiceUpdate invoice)
        {
            return await PutAsync<IssuedInvoice, IssuedInvoiceUpdate>(ResourceUrl + "/" + invoiceId, invoice);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/SetAttachment/{invoicdId}
        /// Sets an attachment to the given issued invoice. If an attachment already exists, it will be overwritten.
        /// </summary>
        public async Task<bool> SetAttachmentAsync(int invoiceId)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + "SetAttachment" + "/" + invoiceId);
        }
    }
}