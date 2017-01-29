using System;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiFilters
{
    public class RegisteredSaleFilter : Paging, IApiFilter
    {
        public int? Id { get; set; }
        public int? SalesReceiptId { get; set; }
        public int? CashVoucherId { get; set; }
        public int? IssuedInvoicePaymentId { get; set; }
        public int? SalesPosEquipmentId { get; set; }
        public DocumentTypeEnum? DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DateOfSale { get; set; }
    }
}