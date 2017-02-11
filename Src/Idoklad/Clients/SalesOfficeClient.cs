using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    public class SalesOfficeClient : BaseClient
    {
        public const string ResourceUrl = "/SalesOffices";

        public SalesOfficeClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/SalesOffices
        /// Method returns list of sales offices.
        /// </summary>
        public RowsResultWrapper<SalesOffice> SalesOffices(PageFilter paging = null)
        {
            return Get<RowsResultWrapper<SalesOffice>>(ResourceUrl, paging);
        }
    }
}