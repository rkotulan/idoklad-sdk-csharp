namespace IdokladSdk.ApiModels
{
    public class RegisteredSaleExpand : RegisteredSale
    {
        /// <summary>
        /// Canceled registered sale
        /// </summary>
        public RegisteredSale CancelledRegisteredSale { get; set; }

        /// <summary> 
        /// Cash voucher id
        /// </summary>
        public CashVoucher CashVoucher { get; set; }

        /// <summary> 
        /// Issued invoice
        /// </summary>
        public IssuedInvoice IssuedInvoice { get; set; }

        /// <summary> 
        /// Payment
        /// </summary>
        public IssuedDocumentPayment IssuedInvoicePayment { get; set; }

        /// <summary> 
        /// Point of sale equipment
        /// </summary>
        public SalesPosEquipment SalesPosEquipment { get; set; }

        /// <summary> 
        /// Sales receipt
        /// </summary>
        public SalesReceipt SalesReceipt { get; set; }
    }
}