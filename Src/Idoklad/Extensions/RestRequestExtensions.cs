using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using IdokladSdk.ApiFilters;
using IdokladSdk.Clients;
using RestSharp;

namespace IdokladSdk.Extensions
{
    internal static class RestRequestExtensions
    {
        /// <summary>
        /// Converts any IApiFilter implementation to QueryParameters applied on RestRequest
        /// </summary>
        public static void ApplyFiltersAsQueryString(this RestRequest request, IApiFilter apiFilter, int apiVersion)
        {
            if (apiFilter == null)
            {
                return;
            }

            if (apiVersion < 2)
            {
                string[] ignoredPropertyNames = new[] {"FilterType", "SortOrders"};
                PropertyInfo[] properties = apiFilter.GetType().GetProperties().Where(x => !ignoredPropertyNames.Contains(x.Name)).ToArray();

                foreach (var propertyInfo in properties.Where(x => x.GetValue(apiFilter) != null))
                {
                    if (propertyInfo.PropertyType == typeof(DateTime) || propertyInfo.PropertyType == typeof(DateTime?))
                    {
                        request.AddQueryParameter(propertyInfo.Name,
                            ((DateTime) propertyInfo.GetValue(apiFilter)).ToString(BaseClient.DateFormat));
                        continue;
                    }

                    if (propertyInfo.PropertyType == typeof(FilterType))
                    {
                        request.AddQueryParameter(propertyInfo.Name,
                            ExtractFilterTypeToString(propertyInfo.GetValue(apiFilter)));
                        continue;
                    }

                    request.AddQueryParameter(propertyInfo.Name, propertyInfo.GetValue(apiFilter).ToString());
                }
            }
            else
            {
                var filter = (ApiFilter) apiFilter;
                
                // Filter Type
                request.AddQueryParameter("filtertype", filter.FilterType.ToString().ToLowerInvariant());

                // Paging
                request.AddQueryParameter("page", filter.Page.ToString());
                request.AddQueryParameter("pagesize", filter.PageSize.ToString());

                // Sort
                var sortString = string.Empty;
                foreach (var filterSortOrder in filter.SortOrders)
                {
                    sortString = sortString + filterSortOrder.Key + "~" + filterSortOrder.Value.ToString().ToLowerInvariant();
                    if (filterSortOrder.Key != filter.SortOrders.LastOrDefault().Key)
                    {
                        sortString = sortString + "|";
                    }
                }
            }
        }

        /// <summary>
        /// Converts FilterType instance to string number representation
        /// For example FilterType.Gt to "2"
        /// </summary>
        public static string ExtractFilterTypeToString(object filterType)
        {
            int defeault = 0;
            if (filterType.GetType() == typeof (FilterType))
            {
                var type = (FilterType)filterType;
                defeault = (int) type;
            }

            return defeault.ToString(CultureInfo.InvariantCulture);
        }
    }
}
