using IdokladSdk.Enums;

namespace IdokladSdk.ApiFilters
{
    public class SalesPosEquipmentFilter : ApiFilter, IApiFilter
    {
        public int? Id { get; set; }
        public SalesPosEquipmentTypeEnum SalesPosEquipmentType { get; set; }
    }
}