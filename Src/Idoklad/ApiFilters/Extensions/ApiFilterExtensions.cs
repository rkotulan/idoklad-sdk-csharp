namespace IdokladSdk.ApiFilters
{
    public static class ApiFilterExtensions
    {
        public static ApiFilter AddOrderDesc(this ApiFilter filter, string orderProperty)
        {
            filter.SortOrders.Add(orderProperty, OrderDirection.Desc);

            return filter;
        }

        public static ApiFilter AddOrderAsc(this ApiFilter filter, string orderProperty)
        {
            filter.SortOrders.Add(orderProperty, OrderDirection.Asc);

            return filter;
        }

        public static ApiFilter WithPaging(this ApiFilter filter, int page = 1, int pageSize = 20)
        {
            filter.Page = page;
            filter.PageSize = pageSize;

            return filter;
        }
    }
}