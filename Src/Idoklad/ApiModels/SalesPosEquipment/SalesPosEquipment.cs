using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class SalesPosEquipment : ApiModel
    {
        /// <summary>
        /// Cash register id.
        /// </summary>
        public int? CashRegisterId { get; set; }

        /// <summary>
        /// Sales office designation
        /// </summary>
        public string Designation { get; set; }

        /// <summary>
        /// Flag determining whether the equipment is registered for EET.
        /// </summary>
        public bool IsRegisteredEet { get; set; }

        /// <summary>
        /// POS equipment name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sales office id.
        /// </summary>
        public int? SalesOfficeId { get; set; }

        /// <summary>
        /// POS equipment type.
        /// </summary>
        public SalesPosEquipmentTypeEnum SalesPosEquipmentType { get; set; }
    }
}
