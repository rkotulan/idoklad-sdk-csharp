namespace IdokladSdk.ApiModels
{
    public class RegisteredSaleCreate : RegisteredSaleInformation
    {
        /// <summary>
        /// Canceled registered sale id
        /// </summary>
        public int? CancelledRegisteredSaleId { get; set; }

        /// <summary>
        /// Is canceled
        /// </summary>
        public bool IsCanceled { get; set; }
    }
}