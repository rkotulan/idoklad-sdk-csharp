using System;

namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for contact
    /// </summary>
    public class ContactFilter : Paging, IApiFilter
    {
        public int? Id { get; set; }
        public DateTime? DateLastChange { get; set; }
        public string IdentificationNumber { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
    }
}
