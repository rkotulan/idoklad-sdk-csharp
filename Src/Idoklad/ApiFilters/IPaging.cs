namespace IdokladSdk.ApiFilters
{
    public interface IPaging
    {
        int? Page { get; set; }
        int? PageSize { get; set; }
    }
}