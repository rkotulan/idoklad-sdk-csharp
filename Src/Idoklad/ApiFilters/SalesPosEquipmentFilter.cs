using IdokladSdk.Enums;

namespace IdokladSdk.ApiFilters
{
    public class SalesPosEquipmentFilter : Paging, IApiFilter
    {
        public int? Id { get; set; }
        public SalesPosEquipmentTypeEnum SalesPosEquipmentType { get; set; }
    }
}