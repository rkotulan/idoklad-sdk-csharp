using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public partial class RegisteredSaleClient : BaseClient
    {
        public const string ResourceUrl = "/RegisteredSales";

        public RegisteredSaleClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/RegisteredSales
        /// Method returns list of registered sales.
        /// </summary>
        public RowsResultWrapper<RegisteredSale> RegisteredSales(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<RegisteredSale>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/RegisteredSales/{id}
        /// Method returns registered sale by Id.
        /// </summary>
        public RegisteredSale RegisteredSale(SalesTypeEnum type, int registeredSaleId)
        {
            return Get<RegisteredSale>(ResourceUrl + "/" + (int)type + "/" + registeredSaleId);
        }

        /// <summary>
        /// GET api/RegisteredSales/Expand
        /// List of registered sales with related entities.
        /// </summary>
        public RowsResultWrapper<RegisteredSaleExpand> RegisteredSalesExpand(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<RegisteredSaleExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/RegisteredSales/{id}/Expand
        /// Returns registered sales with related entities by Id.
        /// </summary>
        public RegisteredSaleExpand RegisteredSalesExpand(SalesTypeEnum type, int registeredSaleId)
        {
            return Get<RegisteredSaleExpand>(ResourceUrl + "/" + (int)type + "/" + registeredSaleId + "/Expand");
        }

        /// <summary>
        /// GET api/RegisteredSales/Default
        /// Method returns empty registered sale with default values. Returned resource is suitable for creation of a new registered sale.
        /// </summary>
        public RegisteredSaleCreate Default()
        {
            return Get<RegisteredSaleCreate>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// POST api/RegisteredSales/{type}/{id}
        /// Create new registered sale.
        /// </summary>
        public RegisteredSale Create(SalesTypeEnum salesType, int salesDocumentId, RegisteredSaleCreate model)
        {
            return Post<RegisteredSale, RegisteredSaleCreate>(ResourceUrl + "/" + (int)salesType + "/" + salesDocumentId, model);
        }
    }
}