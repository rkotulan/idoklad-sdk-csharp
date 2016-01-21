namespace IdokladSdk.ApiFilters
{
    public abstract class Paging : IPaging
    {
        protected Paging()
        {
            this.Page = 1;
            this.PageSize = 20;
        }

        public int? Page { get; set; }

        public int? PageSize { get; set; }
    }
}
