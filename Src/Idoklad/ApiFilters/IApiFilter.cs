using System.Collections.Generic;

namespace IdokladSdk.ApiFilters
{
    public interface IApiFilter
    {
        int? Page { get; set; }
        int? PageSize { get; set; }
    }
}