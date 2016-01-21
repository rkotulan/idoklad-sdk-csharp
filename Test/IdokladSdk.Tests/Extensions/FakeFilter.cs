using System;
using IdokladSdk.ApiFilters;

namespace IdokladSdk.Tests.Extensions
{
    public class FakeFilter : IApiFilter
    {
        public string PropertyOfString { get; set; }
        public int PropertyOfInt { get; set; }
        public decimal PropertyOfDecimal { get; set; }
        public int? PropertyOfNullableInt { get; set; }
        public DateTime PropertyOfDate { get; set; }
        public DateTime? PropertyOfNullableDate { get; set; }
        public FilterType PropertyOfFilterType { get; set; }
    }
}