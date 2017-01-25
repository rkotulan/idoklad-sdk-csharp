namespace IdokladSdk.Clients
{
    public class ReceivedDocumentPaymentClient : BaseClient
    {
        public const string ResourceUrl = "/ReceivedDocumentPayments";

        public ReceivedDocumentPaymentClient(ApiContext apiContext) : base(apiContext)
        {
        }
    }
}