using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for price list.
    /// </summary>
    public class PriceListClient : BaseClient
    {
        internal const string ResourceUrl = "/PriceListItems";

        public PriceListClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/PriceListItems/Default
        /// Method returns default price list item that is suitable for new item creation.
        /// </summary>
        public PriceList Default()
        {
            return base.Get<PriceList>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// GET api/PriceListItems/{id}/Expand
        /// Method returns price list item by its Id with extended entities.
        /// </summary>
        public PriceListExpand PriceListItemExpand(int priceListItemId)
        {
            return base.Get<PriceListExpand>(ResourceUrl + "/" + priceListItemId + "/Expand");
        }

        /// <summary>
        /// DELETE api/PriceListItems/{id}
        /// Method deletes price list item.
        /// </summary>
        public bool Delete(int priceListItemId)
        {
            return base.Delete(ResourceUrl + "/" + priceListItemId);
        }

        /// <summary>
        /// GET api/PriceListItems
        /// Returns price list with pages.
        /// </summary>
        public RowsResultWrapper<PriceList> PriceListItems(PriceListFilter filter)
        {
            return base.Get<RowsResultWrapper<PriceList>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/PriceListItems/{id}
        /// Returns price list item by Id.
        /// </summary>
        public PriceList PriceListItem(int priceListItemId)
        {
            return base.Get<PriceList>(ResourceUrl + "/" + priceListItemId);
        }

        /// <summary>
        /// POST api/PriceListItems
        /// Insert new price item into the price list.
        /// </summary>
        public PriceList Create(PriceList model)
        {
            return base.Post<PriceList, PriceList>(ResourceUrl, model);
        }

        /// <summary>
        /// PUT api/PriceListItems/{id}
        /// Method updates price list item.
        /// </summary>
        public PriceList Update(int priceListItemId, PriceList model)
        {
            return base.Put<PriceList, PriceList>(ResourceUrl + "/" + priceListItemId, model);
        }
    }
}