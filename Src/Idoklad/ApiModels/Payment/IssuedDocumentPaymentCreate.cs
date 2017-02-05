namespace IdokladSdk.ApiModels
{
    public class IssuedDocumentPaymentCreate : PaymentCreate
    {
        /// <summary>
        /// Electronic records of sales information.
        /// </summary>
        public ElectronicRecordsOfSales ElectronicRecordsOfSales { get; set; }

        /// <summary>
        /// POS equipment Id.
        /// </summary>
        public int? SalesPosEquipmentId { get; set; }
    }
}