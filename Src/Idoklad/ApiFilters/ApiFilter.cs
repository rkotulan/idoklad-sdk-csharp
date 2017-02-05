using System.Collections.Generic;

namespace IdokladSdk.ApiFilters
{
    public class ApiFilter : Paging, IApiFilter
    {
        public ApiFilter()
        {
            SortOrders = new Dictionary<string, OrderDirection>();
            FilterType = FilterKind.And;
        }

        public Dictionary<string, OrderDirection> SortOrders { get; set; }
        public FilterKind FilterType { get; set; }
    }
}
