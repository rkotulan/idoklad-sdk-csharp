using System;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for cash register
    /// </summary>
    public class CashVoucherFilter : ApiFilter, IApiFilter
    {
        public int? Id { get; set; }
        public int? CashRegisterId { get; set; }
        public int? CurrencyId { get; set; }
        public ExportedStateEnum? Exported { get; set; }
        public MovementTypeEnum? MovementType { get; set; }
        public DateTime? DateLastChange { get; set; }
        public DateTime? DateOfTransaction { get; set; }
        public string DocumentNumber { get; set; }
    }
}