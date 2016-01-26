namespace IdokladSdk.ApiFilters
{
    public abstract class Paging : IPaging
    {
        protected Paging()
        {
            Page = 1;
            PageSize = 20;
        }

        public int? Page { get; set; }

        public int? PageSize { get; set; }
    }
}
