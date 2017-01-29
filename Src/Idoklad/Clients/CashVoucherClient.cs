using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public class CashVoucherClient : BaseClient
    {
        public const string ResourceUrl = "/CashVouchers";

        public CashVoucherClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/CashVouchers
        /// Method returns list of cash vouchers.
        /// </summary>
        public RowsResultWrapper<CashVoucher> CashVouchers(Paging paging = null)
        {
            return Get<RowsResultWrapper<CashVoucher>>(ResourceUrl, paging);
        }

        /// <summary>
        /// GET api/CashVouchers/{id}
        /// Method returns cash voucher by Id.
        /// </summary>
        public CashVoucher CashVoucher(int cashVoucherId)
        {
            return Get<CashVoucher>(ResourceUrl + "/" + cashVoucherId);
        }
        
        /// <summary>
        /// GET api/CashVouchers/Expand
        /// List of cash vouchers with related entities.
        /// </summary>
        public RowsResultWrapper<CashVoucherExpand> CashVouchersExpand(CashVoucherFilter filter = null)
        {
            return Get<RowsResultWrapper<CashVoucherExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/CashVouchers/{id}/Expand
        /// Returns cash voucher with related entities by Id.
        /// </summary>
        public CashVoucherExpand CashVoucherExpand(int cashVoucherId)
        {
            return Get<CashVoucherExpand>(ResourceUrl + "/" + cashVoucherId + "/Expand");
        }

        /// <summary>
        /// GET api/CashVouchers/Default
        /// Returns default cash voucher. This resource is suitable for creation of new contact by the POST method.
        /// </summary>
        public CashVoucher Default()
        {
            return Get<CashVoucher>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// GET api/CashVouchers/{id}/GetCashVoucherPdf
        /// Returns Pdf file with Cash voucher report for the cash voucher. File is Base64 encoded and is returned as string.
        /// </summary>
        public string CashVoucherPdf(int cashVoucherId)
        {
            return Get<string>(ResourceUrl + "/" + cashVoucherId + "/GetCashVoucherPdf");
        }

        /// <summary>
        /// GET api/CashVouchers/{id}/GetCashVoucherPdfCompressed
        /// Returns zipped Pdf file with Cash voucher report for the cash voucher. File is Base64 encoded and is returned as string.
        /// </summary>
        public string CashVoucherPdfCompressed(int cashVoucherId)
        {
            return Get<string>(ResourceUrl + "/" + cashVoucherId + "/GetCashVoucherPdfCompressed");
        }

        /// <summary>
        /// GET api/IssuedInvoices/Default/{movementType}/{invoiceType}/{invoiceId}
        /// Method returns empty cash voucher with default values. Returned resource is suitable for creation of a new cash voucher.
        /// </summary>
        public CashVoucherCreate Default(MovementTypeEnum movementType, InvoiceTypeEnum invoiceType, int invoiceId)
        {
            return Get<CashVoucherCreate>(ResourceUrl + "/Default/"+ (int)movementType + "/" + (int)invoiceType + "/" + invoiceId);
        }
    }
}