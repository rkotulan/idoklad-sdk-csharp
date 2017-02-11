using System.Collections.Generic;

namespace IdokladSdk.ApiFilters
{
    public interface IFilterableObject
    {
        HashSet<FilterItem> Build();
    }
}