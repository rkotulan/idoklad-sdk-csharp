using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public partial class SalesReceiptClient : BaseClient
    {
        /// <summary>
        /// DELETE api/SalesReceipts/{id}
        /// Deletes sales receipt by Id.
        /// </summary>
        public async Task<bool> DeleteAsync(int salesReceiptId)
        {
            return await DeleteAsync(ResourceUrl + "/" + salesReceiptId);
        }

        /// <summary>
        /// GET api/SalesReceipts
        /// Method returns list of sales recipes.
        /// </summary>
        public async Task<RowsResultWrapper<SalesReceipt>> SalesReceiptsAsync(ApiFilter paging = null)
        {
            return await GetAsync<RowsResultWrapper<SalesReceipt>>(ResourceUrl, paging);
        }

        /// <summary>
        /// GET api/SalesReceipts/{id}
        /// Method returns sales recipe by Id.
        /// </summary>
        public async Task<SalesReceipt> SalesReceiptAsync(int salesRecipeId)
        {
            return await GetAsync<SalesReceipt>(ResourceUrl + "/" + salesRecipeId);
        }

        /// <summary>
        /// GET api/SalesReceipts/Expand
        /// List of sales receipts with related entities.
        /// </summary>
        public async Task<RowsResultWrapper<SalesReceiptExpand>> SalesReceiptsExpandAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<SalesReceiptExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/SalesReceipts/{id}/Expand
        /// Returns sales receipt with related entities by Id.
        /// </summary>
        public async Task<SalesReceiptExpand> SalesReceiptsExpandAsync(int salesReceiptId)
        {
            return await GetAsync<SalesReceiptExpand>(ResourceUrl + "/" + salesReceiptId + "/Expand");
        }

        /// <summary>
        /// GET api/SalesReceipts/Default
        /// Method returns empty sales receipt with default values. Returned resource is suitable for creation of a new sales receipt.
        /// </summary>
        public async Task<SalesReceiptCreate> DefaultAsync()
        {
            return await GetAsync<SalesReceiptCreate>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// GET api/SalesReceipts/{id}/GetPdf
        /// Returns Pdf file with sales receipt report. File is Base64 encoded and is returned as string.
        /// </summary>
        public async Task<string> SalesReceiptsPdfAsync(int salesReceiptPdf)
        {
            return await GetAsync<string>(ResourceUrl + "/" + salesReceiptPdf + "/GetPdf");
        }

        /// <summary>
        /// GET api/SalesReceipts/{id}/GetPdfCompressed
        /// Returns zipped Pdf file with sales receipt report. File is Base64 encoded and is returned as string.
        /// </summary>
        public async Task<string> SalesReceiptsPdfCompressedAsync(int salesReceiptPdf)
        {
            return await GetAsync<string>(ResourceUrl + "/" + salesReceiptPdf + "/GetPdfCompressed");
        }

        /// <summary>
        /// POST api/SalesReceipts
        /// Create new sales receipt.
        /// </summary>
        public async Task<SalesReceipt> CreateAsync(SalesReceiptCreate model)
        {
            return await PostAsync<SalesReceipt, SalesReceiptCreate>(ResourceUrl, model);
        }

        /// <summary>
        /// POST api/SalesReceipts/Recount
        /// Create new sales receipt.
        /// </summary>
        public async Task<SalesReceipt> RecountAsync(SalesReceiptCreate model)
        {
            return await PostAsync<SalesReceipt, SalesReceiptCreate>(ResourceUrl  + "/Recount", model);
        }

        /// <summary>
        /// POST api/SalesReceipts/{id}/Recount
        /// Create new sales receipt.
        /// </summary>
        public async Task<SalesReceipt> RecountAsync(int salesReceiptId, SalesReceiptCreate model)
        {
            return await PostAsync<SalesReceipt, SalesReceiptCreate>(ResourceUrl +"/" + salesReceiptId + "/Recount", model);
        }

        /// <summary>
        /// PUT api/SalesReceipts/{id}
        /// </summary>
        public async Task<SalesReceipt> UpdateAsync(int salesReceiptId, SalesReceiptUpdate salesReceipt)
        {
            return await PutAsync<SalesReceipt, SalesReceiptUpdate>(ResourceUrl + "/" + salesReceiptId, salesReceipt);
        }

        /// <summary>
        /// PUT api/SalesReceipts/{id}/Imported/{value}
        /// Updates the Imported property of the sales receipt.
        /// </summary>
        public async Task<bool> UpdateAsync(int salesReceiptId, ImportedStateEnum importedState)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + salesReceiptId + "/" + (int)importedState);
        }

        /// <summary>
        /// PUT api/SalesReceipts/{id}/Exported/{value}
        /// Updates the Exported property of the sales receipt.
        /// </summary>
        public async Task<bool> UpdateAsync(int salesReceiptId, ExportedStateEnum exportedState)
        {
            return await PutAsync<bool>(ResourceUrl + "/" + salesReceiptId + "/" + (int)exportedState);
        }
    }
}