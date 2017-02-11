using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public class SalesReceiptClient : BaseClient
    {
        public const string ResourceUrl = "/SalesReceipts";

        public SalesReceiptClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// DELETE api/SalesReceipts/{id}
        /// Deletes sales receipt by Id.
        /// </summary>
        public bool Delete(int salesReceiptId)
        {
            return Delete(ResourceUrl + "/" + salesReceiptId);
        }

        /// <summary>
        /// GET api/SalesReceipts
        /// Method returns list of sales recipes.
        /// </summary>
        public RowsResultWrapper<SalesReceipt> SalesReceipts(PageFilter paging = null)
        {
            return Get<RowsResultWrapper<SalesReceipt>>(ResourceUrl, paging);
        }

        /// <summary>
        /// GET api/SalesReceipts/{id}
        /// Method returns sales recipe by Id.
        /// </summary>
        public SalesReceipt SalesReceipt(int salesRecipeId)
        {
            return Get<SalesReceipt>(ResourceUrl + "/" + salesRecipeId);
        }

        /// <summary>
        /// GET api/SalesReceipts/Expand
        /// List of sales receipts with related entities.
        /// </summary>
        public RowsResultWrapper<SalesReceiptExpand> SalesReceiptsExpand(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<SalesReceiptExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/SalesReceipts/{id}/Expand
        /// Returns sales receipt with related entities by Id.
        /// </summary>
        public SalesReceiptExpand SalesReceiptsExpand(int salesReceiptId)
        {
            return Get<SalesReceiptExpand>(ResourceUrl + "/" + salesReceiptId + "/Expand");
        }

        /// <summary>
        /// GET api/SalesReceipts/Default
        /// Method returns empty sales receipt with default values. Returned resource is suitable for creation of a new sales receipt.
        /// </summary>
        public SalesReceiptCreate Default()
        {
            return Get<SalesReceiptCreate>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// GET api/SalesReceipts/{id}/GetPdf
        /// Returns Pdf file with sales receipt report. File is Base64 encoded and is returned as string.
        /// </summary>
        public string SalesReceiptsPdf(int salesReceiptPdf)
        {
            return Get<string>(ResourceUrl + "/" + salesReceiptPdf + "/GetPdf");
        }

        /// <summary>
        /// GET api/SalesReceipts/{id}/GetPdfCompressed
        /// Returns zipped Pdf file with sales receipt report. File is Base64 encoded and is returned as string.
        /// </summary>
        public string SalesReceiptsPdfCompressed(int salesReceiptPdf)
        {
            return Get<string>(ResourceUrl + "/" + salesReceiptPdf + "/GetPdfCompressed");
        }

        /// <summary>
        /// POST api/SalesReceipts
        /// Create new sales receipt.
        /// </summary>
        public SalesReceipt Create(SalesReceiptCreate model)
        {
            return Post<SalesReceipt, SalesReceiptCreate>(ResourceUrl, model);
        }

        /// <summary>
        /// POST api/SalesReceipts/Recount
        /// Create new sales receipt.
        /// </summary>
        public SalesReceipt Recount(SalesReceiptCreate model)
        {
            return Post<SalesReceipt, SalesReceiptCreate>(ResourceUrl  + "/Recount", model);
        }

        /// <summary>
        /// POST api/SalesReceipts/{id}/Recount
        /// Create new sales receipt.
        /// </summary>
        public SalesReceipt Recount(int salesReceiptId, SalesReceiptCreate model)
        {
            return Post<SalesReceipt, SalesReceiptCreate>(ResourceUrl +"/" + salesReceiptId + "/Recount", model);
        }

        /// <summary>
        /// PUT api/SalesReceipts/{id}
        /// </summary>
        public SalesReceipt Update(int salesReceiptId, SalesReceiptUpdate salesReceipt)
        {
            return Put<SalesReceipt, SalesReceiptUpdate>(ResourceUrl + "/" + salesReceiptId, salesReceipt);
        }

        /// <summary>
        /// PUT api/SalesReceipts/{id}/Imported/{value}
        /// Updates the Imported property of the sales receipt.
        /// </summary>
        public bool Update(int salesReceiptId, ImportedStateEnum importedState)
        {
            return Put<bool>(ResourceUrl + "/" + salesReceiptId + "/" + (int)importedState);
        }

        /// <summary>
        /// PUT api/SalesReceipts/{id}/Exported/{value}
        /// Updates the Exported property of the sales receipt.
        /// </summary>
        public bool Update(int salesReceiptId, ExportedStateEnum exportedState)
        {
            return Put<bool>(ResourceUrl + "/" + salesReceiptId + "/" + (int)exportedState);
        }
    }
}