using System;

namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for contact
    /// </summary>
    public class ContactFilter : FilterableObjectBase
    {
        public FilterItem Id { get; set; } = new FilterItem("Id");
        public CompareFilterItem DateLastChange { get; set; } = new CompareFilterItem("DateLastChange");
        public FilterItem IdentificationNumber { get; set; } = new FilterItem("IdentificationNumber");
        public ContainFilterItem CompanyName { get; set; } = new ContainFilterItem("CompanyName");
        public ContainFilterItem Email { get; set; } = new ContainFilterItem("Email");
    }
}
