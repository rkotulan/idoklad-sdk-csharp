using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    public class SalesPosEquipmentClient : BaseClient
    {
        public const string ResourceUrl = "/SalesPosEquipment";

        public SalesPosEquipmentClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/SalesPosEquipment
        /// Method returns list of sales pos equipments.
        /// </summary>
        public RowsResultWrapper<SalesPosEquipment> SalesPosEquipment(Paging paging = null)
        {
            return Get<RowsResultWrapper<SalesPosEquipment>>(ResourceUrl, paging);
        }

        /// <summary>
        /// GET api/SalesPosEquipment/Info
        /// Returns information about the paired device, including numeric sequence info.
        /// </summary>
        public SalesPosEquipmentInfo Info()
        {
            return Get<SalesPosEquipmentInfo>(ResourceUrl + "/Info");
        }

        /// <summary>
        /// GET api/SalesPosEquipment/Expand
        /// Returns POS equipments list with related entities.
        /// </summary>
        public RowsResultWrapper<SalesPosEquipmentExpand> Expand()
        {
            return Get<RowsResultWrapper<SalesPosEquipmentExpand>>(ResourceUrl + "/Expand");
        }
    }
}