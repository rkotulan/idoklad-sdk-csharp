using IdokladSdk.Enums;

namespace IdokladSdk.ApiFilters
{
    public class NumericSequenceFilter : ApiFilter, IApiFilter
    {
        public int? Id { get; set; }
        public bool? IsDefault { get; set; }
        public DocumentTypeEnum? DocumentType { get; set; }

    }
}