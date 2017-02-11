
namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for change
    /// </summary>
    public class ChangeFilter : FilterableObjectBase
    {
        public CompareFilterItem Date { get; set; } = new CompareFilterItem("Date");
    }
}
