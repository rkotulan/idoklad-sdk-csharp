namespace IdokladSdk.ApiFilters
{
    public interface IFilter
    {
        int? Page { get; set; }
        int? PageSize { get; set; }
    }
}