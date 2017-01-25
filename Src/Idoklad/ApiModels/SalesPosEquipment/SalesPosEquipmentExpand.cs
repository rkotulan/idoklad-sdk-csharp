namespace IdokladSdk.ApiModels
{
    public class SalesPosEquipmentExpand : SalesPosEquipment
    {
        /// <summary>
        /// Cash register entity.
        /// </summary>
        public CashRegister CashRegister { get; set; }

        /// <summary>
        /// Sales office entity.
        /// </summary>
        public SalesOffice SalesOffice { get; set; }
    }
}