namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for sales pos equipment
    /// </summary>
    public class SalesPosEquipmentFilter : FilterableObjectBase
    {
        public FilterItem Id { get; set; } = new FilterItem("Id");
        public FilterItem SalesPosEquipmentType { get; set; } = new FilterItem("SalesPosEquipmentType");
    }
}