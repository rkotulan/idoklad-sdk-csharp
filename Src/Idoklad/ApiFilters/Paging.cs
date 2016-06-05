namespace IdokladSdk.ApiFilters
{
    public class Paging : IPaging, IApiFilter
    {
        public Paging()
        {
            Page = 1;
            PageSize = 20;
        }

        public Paging(int pageSize)
        {
            Page = 1;
            PageSize = pageSize;
        }

        public Paging(int page, int pageSize)
        {
            Page = page;
            PageSize = pageSize;
        }

        public int? Page { get; set; }

        public int? PageSize { get; set; }
    }
}
