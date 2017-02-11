using System.Globalization;
using System.Linq;
using IdokladSdk.ApiFilters;
using RestSharp;

namespace IdokladSdk.Extensions
{
    internal static class RestRequestExtensions
    {
        /// <summary>
        /// Converts any IApiFilter implementation to QueryParameters applied on RestRequest
        /// </summary>
        public static void ApplyFiltersAsQueryString(this RestRequest request, IFilter apiFilter)
        {
            if (apiFilter == null)
            {
                return;
            }

            // Paging
            request.AddQueryParameter("page", apiFilter.Page.ToString());
            request.AddQueryParameter("pagesize", apiFilter.PageSize.ToString());

            if (!(apiFilter is ApiFilter))
            {
                return;
            }

            var filter = (ApiFilter)apiFilter;

            // Filter Type
            request.AddQueryParameter("filtertype", filter.FilterType.ToString().ToLowerInvariant());

            // Filters
            if (filter.Filters.Any())
            {
                var filterString = string.Empty;
                foreach (var filterItem in filter.Filters)
                {
                    filterString = filterString + filterItem.ToString();

                    if (filterItem != filter.Filters.LastOrDefault())
                    {
                        filterString = filterString + "|";
                    }
                }
                request.AddQueryParameter("filter", filterString);
            }

            // Sort
            if (filter.SortOrders.Any())
            {
                var sortString = string.Empty;
                foreach (var filterSortOrder in filter.SortOrders)
                {
                    sortString = sortString + filterSortOrder.Key + "~" + filterSortOrder.Value.ToString().ToLowerInvariant();
                    if (filterSortOrder.Key != filter.SortOrders.LastOrDefault().Key)
                    {
                        sortString = sortString + "|";
                    }
                }
                request.AddQueryParameter("sort", sortString);
            }
        }

        /// <summary>
        /// Converts FilterType instance to string number representation
        /// For example FilterType.Gt to "2"
        /// </summary>
        public static string ExtractFilterTypeToString(object filterType)
        {
            int defeault = 0;
            if (filterType.GetType() == typeof(FilterOperator))
            {
                var type = (FilterOperator)filterType;
                defeault = (int)type;
            }

            return defeault.ToString(CultureInfo.InvariantCulture);
        }
    }
}