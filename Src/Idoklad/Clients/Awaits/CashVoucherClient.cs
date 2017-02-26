using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public partial class CashVoucherClient : BaseClient
    {
        /// <summary>
        /// GET api/CashVouchers
        /// Method returns list of cash vouchers.
        /// </summary>
        public async Task<RowsResultWrapper<CashVoucher>> CashVouchersAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<CashVoucher>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/CashVouchers/{id}
        /// Method returns cash voucher by Id.
        /// </summary>
        public async Task<CashVoucher> CashVoucherAsync(int cashVoucherId)
        {
            return await GetAsync<CashVoucher>(ResourceUrl + "/" + cashVoucherId);
        }
        
        /// <summary>
        /// GET api/CashVouchers/Expand
        /// List of cash vouchers with related entities.
        /// </summary>
        public async Task<RowsResultWrapper<CashVoucherExpand>> CashVouchersExpandAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<CashVoucherExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/CashVouchers/{id}/Expand
        /// Returns cash voucher with related entities by Id.
        /// </summary>
        public async Task<CashVoucherExpand> CashVoucherExpandAsync(int cashVoucherId)
        {
            return await GetAsync<CashVoucherExpand>(ResourceUrl + "/" + cashVoucherId + "/Expand");
        }

        /// <summary>
        /// GET api/CashVouchers/Default
        /// Returns default cash voucher. This resource is suitable for creation of new contact by the POST method.
        /// </summary>
        public async Task<CashVoucher> DefaultAsync(MovementTypeEnum movementType)
        {
            return await GetAsync<CashVoucher>(ResourceUrl + "/Default" + "/" + (int)movementType);
        }

        /// <summary>
        /// GET api/CashVouchers/{id}/GetCashVoucherPdf
        /// Returns Pdf file with Cash voucher report for the cash voucher. File is Base64 encoded and is returned as string.
        /// </summary>
        public async Task<string> CashVoucherPdfAsync(int cashVoucherId)
        {
            return await GetAsync<string>(ResourceUrl + "/" + cashVoucherId + "/GetCashVoucherPdf");
        }

        /// <summary>
        /// GET api/CashVouchers/{id}/GetCashVoucherPdfCompressed
        /// Returns zipped Pdf file with Cash voucher report for the cash voucher. File is Base64 encoded and is returned as string.
        /// </summary>
        public async Task<string> CashVoucherPdfCompressedAsync(int cashVoucherId)
        {
            return await GetAsync<string>(ResourceUrl + "/" + cashVoucherId + "/GetCashVoucherPdfCompressed");
        }

        /// <summary>
        /// GET api/IssuedInvoices/Default/{movementType}/{invoiceType}/{invoiceId}
        /// Method returns empty cash voucher with default values. Returned resource is suitable for creation of a new cash voucher.
        /// </summary>
        public async Task<CashVoucherCreate> DefaultAsync(MovementTypeEnum movementType, InvoiceTypeEnum invoiceType, int invoiceId)
        {
            return await GetAsync<CashVoucherCreate>(ResourceUrl + "/Default/"+ (int)movementType + "/" + (int)invoiceType + "/" + invoiceId);
        }

        /// <summary>
        /// POST api/CashVouchers
        /// Add new cash voucher.
        /// </summary>
        public async Task<CashVoucher> CreateAsync(CashVoucherCreate model)
        {
            return await PostAsync<CashVoucher, CashVoucherCreate>(ResourceUrl, model);
        }

        /// <summary>
        /// POST api/CashVouchers/Pair/{invoiceType}/{invoiceId}
        /// Add new cash voucher.
        /// </summary>
        public async Task<CashVoucher> CreateAsync(CashVoucherCreate model, InvoiceTypeEnum invoiceType, int invoiceId)
        {
            return await PostAsync<CashVoucher, CashVoucherCreate>(ResourceUrl + "/Pair" + "/" + (int)invoiceType + "/" + invoiceId, model);
        }

        /// <summary>
        /// POST api/CashVouchers/Pair/{cashVoucherId}/{invoiceType}/{invoiceId}
        /// Add new cash voucher.
        /// </summary>
        public async Task<CashVoucher> CreateAsync(CashVoucherCreate model, int cashVoucherId, InvoiceTypeEnum invoiceType, int invoiceId)
        {
            return await PostAsync<CashVoucher, CashVoucherCreate>(ResourceUrl + "/Pair" + "/" + cashVoucherId + "/" + (int)invoiceType + "/" + invoiceId, model);
        }

        /// <summary>
        /// PUT api/CashVouchers/{id}
        /// Update cash voucher. 
        /// </summary>
        public async Task<CashVoucher> UpdateAsync(int cashVoucherId, ExportedStateEnum exportedState)
        {
            return await PutAsync<CashVoucher>(ResourceUrl + "/" + cashVoucherId + "/Exported" + "/" + (int)exportedState);
        }
    }
}