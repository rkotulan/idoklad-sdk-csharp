using System;
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
        public const string ResourceUrl = "/IssuedInvoices";

        public IssuedInvoiceClient(ApiContext apiContext)
            : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/IssuedInvoices/Default
        /// Method returns empty invoice with default values. Returned resource is suitable for new invoice creation.
        /// </summary>
        public IssuedInvoiceCreate Default()
        {
            return Get<IssuedInvoiceCreate>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/FullyPay?dateOfPayment={dateOfPayment}
        /// Method sets invoice as paid.
        /// </summary>
        public bool FullyPay(int invoiceId, DateTime paid)
        {
            return Put<bool>(ResourceUrl + "/" + invoiceId + "/FullyPay" + "?dateOfPayment=" + paid.ToString(ApiContextConfiguration.DateFormat));
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/FullyUnpay
        /// Method sets invoice as unpaid.
        /// </summary>
        public bool FullyUnpay(int invoiceId)
        {
            return Put<bool>(ResourceUrl + "/" + invoiceId + "/FullyUnpay");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetCashVoucherPdf
        /// Returns Pdf file with Cash voucher report for the invoice. File is Base64 encoded and is returned as string.
        /// </summary>
        public string CashVoucherPdf(int invoiceId)
        {
            return Get<string>(ResourceUrl + "/" + invoiceId + "/GetCashVoucherPdf");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetCashVoucherPdfCompressed
        /// Returns zipped Pdf file with Cash voucher report for the invoice. File is Base64 encoded and is returned as string.
        /// </summary>
        public string CashVoucherPdfCompressed(int invoiceId)
        {
            return Get<string>(ResourceUrl + "/" + invoiceId + "/GetCashVoucherPdfCompressed");
        }

        /// <summary>
        /// GET api/IssuedInvoices/Expand
        /// Returns Issued invoice list with related entities such as contact information etc.
        /// </summary>
        public RowsResultWrapper<IssuedInvoiceExpand> IssuedInvoicesExpand(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<IssuedInvoiceExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/Expand
        /// Returns Issued invoice with related entities by Id.
        /// </summary>
        public IssuedInvoiceExpand IssuedInvoiceExpand(int invoiceId)
        {
            return Get<IssuedInvoiceExpand>(ResourceUrl + "/" + invoiceId + "/Expand");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetPdf
        /// Returns Pdf file with Issued Invoic. File is Base64 encoded and is returned as string.
        /// </summary>
        public string IssuedInvoicePdf(int invoiceId)
        {
            return Get<string>(ResourceUrl + "/" + invoiceId + "/GetPdf");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/GetPdfCompressed
        /// Returns zipped Pdf file with Issued Invoice report. File is Base64 encoded and is returned as string.
        /// </summary>
        public string IssuedInvoicePdfCompressed(int invoiceId)
        {
            return Get<string>(ResourceUrl + "/" + invoiceId + "/GetPdfCompressed");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{contactId}/IssuedInvoices
        /// Returns invoice list for specific contact.
        /// </summary>
        public RowsResultWrapper<IssuedInvoice> IssuedInvoicesByContact(int contactId, ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<IssuedInvoice>>(ResourceUrl + "/" + contactId + "/IssuedInvoices", filter);
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/MyDocumentAddress
        /// Contact information of the supplier for invoice.
        /// </summary>
        public DocumentAddress MyDocumentAddress(int invoiceId)
        {
            return Get<DocumentAddress>(ResourceUrl + "/" + invoiceId + "/MyDocumentAddress");
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}/PurchaserDocumentAddress
        /// Contact information of the purchaser for invoice.
        /// </summary>
        public DocumentAddress PurchaserDocumentAddress(int invoiceId)
        {
            return Get<DocumentAddress>(ResourceUrl + "/" + invoiceId + "/PurchaserDocumentAddress");
        }

        /// <summary>
        /// POST api/IssuedInvoices/Recount
        /// Method recounts summaries of the invoice model for creation. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public IssuedInvoice Recount(IssuedInvoiceCreate invoice)
        {
            return Post<IssuedInvoice, IssuedInvoiceCreate>(ResourceUrl + "/Recount", invoice);
        }

        /// <summary>
        /// POST api/IssuedInvoices/{id}/Recount
        /// Method recounts summaries of the invoice model for update. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public IssuedInvoice Recount(int invoiceId, IssuedInvoiceUpdate invoice)
        {
            return Post<IssuedInvoice, IssuedInvoiceUpdate>(ResourceUrl + "/" + invoiceId + "/Recount", invoice);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/MyDocumentAddress
        /// Method Updates contact informations of the supplier.
        /// </summary>
        public DocumentAddress UpdateMyDocumentAddress(int invoiceId, DocumentAddress address)
        {
            return Put<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + invoiceId + "/MyDocumentAddress", address);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/PurchaserDocumentAddress
        /// Method Updates contact informations of the purchaser.
        /// </summary>
        public DocumentAddress UpdatePurchaserDocumentAddress(int invoiceId, DocumentAddress address)
        {
            return Put<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + invoiceId + "/PurchaserDocumentAddress", address);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/SendMailToPurchaser
        /// Method sends email with issued invoice to the purchaser.
        /// </summary>
        public bool SendMailToPurchaser(int invoiceId)
        {
            return Put<bool>(ResourceUrl + "/" + invoiceId + "/SendMailToPurchaser");
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}/Exported/{value}
        /// Method updates Exported property of the invoice.
        /// </summary>
        public bool SendMailToPurchaser(int invoiceId, ExportedStateEnum state)
        {
            return Put<bool>(ResourceUrl + "/" + invoiceId + "/Exported" + "/" + (int)state);
        }

        /// <summary>
        /// DELETE api/IssuedInvoices/{id}
        /// Deletes issued invoice by Id.
        /// </summary>
        public bool Delete(int invoiceId)
        {
            return Delete(ResourceUrl + "/" + invoiceId);
        }

        /// <summary>
        /// GET api/IssuedInvoices
        /// Returns list of issued invoices. Filters are optional.
        /// </summary>
        public RowsResultWrapper<IssuedInvoice> IssuedInvoices(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<IssuedInvoice>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/IssuedInvoices/{id}
        /// Returns information about issued invoice including summaries.
        /// </summary>
        public IssuedInvoice IssuedInvoice(int invoiceId)
        {
            return Get<IssuedInvoice>(ResourceUrl + "/" + invoiceId);
        }

        /// <summary>
        /// POST api/IssuedInvoices
        /// Create new issued invoice. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public IssuedInvoice Create(IssuedInvoiceCreate invoice)
        {
            return Post<IssuedInvoice, IssuedInvoiceCreate>(ResourceUrl, invoice);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/{id}
        /// Method updates issued invoice by Id. Also possible to update single preperties of invoice. Invoice should contains only items with ItemTypeNormal.
        /// </summary>
        public IssuedInvoice Update(int invoiceId, IssuedInvoiceUpdate invoice)
        {
            return Put<IssuedInvoice, IssuedInvoiceUpdate>(ResourceUrl + "/" + invoiceId, invoice);
        }

        /// <summary>
        /// PUT api/IssuedInvoices/SetAttachment/{invoicdId}
        /// Sets an attachment to the given issued invoice. If an attachment already exists, it will be overwritten.
        /// </summary>
        public bool SetAttachment(int invoiceId)
        {
            return Put<bool>(ResourceUrl + "/" + "SetAttachment" + "/" + invoiceId);
        }
    }
}