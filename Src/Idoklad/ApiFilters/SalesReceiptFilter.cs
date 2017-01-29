using System;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiFilters
{
    public class SalesReceiptFilter : Paging, IApiFilter
    {
        public int? Id { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public ExportedStateEnum? Exported { get; set; }
        public int? SalesPosEquipmentId { get; set; }
        public string DocumentNumber { get; set; }
    }
}