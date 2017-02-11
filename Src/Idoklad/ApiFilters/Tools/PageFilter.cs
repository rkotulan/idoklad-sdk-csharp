namespace IdokladSdk.ApiFilters
{
    public class PageFilter : IFilter
    {
        public PageFilter()
        {
            Page = 1;
            PageSize = 20;
        }

        public PageFilter(int pageSize)
        {
            Page = 1;
            PageSize = pageSize;
        }

        public PageFilter(int page, int pageSize)
        {
            Page = page;
            PageSize = pageSize;
        }

        public int? Page { get; set; }
        public int? PageSize { get; set; }
    }
}