using System;

namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for contact
    /// </summary>
    public class ContactFilter : Paging, IApiFilter
    {
        public DateTime? DateLastChange { get; set; }
        public string Query { get; set; }
        public FilterType? FilterType { get; set; }
    }
}
