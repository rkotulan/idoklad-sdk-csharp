using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace IdokladSdk.ApiFilters
{
    public class FilterableObjectBase : IFilterableObject
    {
        public HashSet<FilterItem> Build()
        {
            HashSet<FilterItem> filters = new HashSet<FilterItem>();

            PropertyInfo[] properties = this.GetType().GetProperties().ToArray();

            foreach (var propertyInfo in properties)
            {
                var filterItem = (FilterItem)propertyInfo.GetValue(this, null);

                if (!filterItem.IsActive())
                {
                    continue;
                }

                filters.Add(filterItem);
            }

            return filters;
        }
    }
}