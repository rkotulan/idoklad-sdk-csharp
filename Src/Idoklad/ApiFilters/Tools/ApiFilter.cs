using System.Collections.Generic;

namespace IdokladSdk.ApiFilters
{
    public class ApiFilter : PageFilter
    {
        public ApiFilter(IFilterableObject filters = null, FilterType filterType = FilterType.And)
        {
            SortOrders = new Dictionary<string, OrderDirection>();
            FilterType = filterType;

            Filters = new HashSet<FilterItem>();
            if (filters != null)
            {
                Filters = filters.Build();
            }
        }

        public HashSet<FilterItem> Filters { get; set; }
        public Dictionary<string, OrderDirection> SortOrders { get; set; }
        public FilterType FilterType { get; set; }
    }
}
