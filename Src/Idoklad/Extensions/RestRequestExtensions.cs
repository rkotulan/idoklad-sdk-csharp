using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
        public static void ApplyFiltersAsQueryString(this RestRequest request, IApiFilter apiFilter)
        {
            if (apiFilter == null)
            {
                return;
            }

            PropertyInfo[] properties = apiFilter.GetType().GetProperties();

            foreach (var propertyInfo in properties.Where(x=> x.GetValue(apiFilter) != null))
            {
                if (propertyInfo.PropertyType == typeof (DateTime) || propertyInfo.PropertyType == typeof (DateTime?))
                {
                    request.AddQueryParameter(propertyInfo.Name, ((DateTime)propertyInfo.GetValue(apiFilter)).ToString(BaseClient.DateFormat));
                    continue;
                }

                if (propertyInfo.PropertyType == typeof(FilterType))
                {
                    request.AddQueryParameter(propertyInfo.Name, ExtractFilterTypeToString(propertyInfo.GetValue(apiFilter)));
                    continue;
                }

                request.AddQueryParameter(propertyInfo.Name, propertyInfo.GetValue(apiFilter).ToString());
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
