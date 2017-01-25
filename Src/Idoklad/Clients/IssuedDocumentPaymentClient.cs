namespace IdokladSdk.Clients
{
    public class IssuedDocumentPaymentClient : BaseClient
    {
        public const string ResourceUrl = "/IssuedDocumentPayments";

        public IssuedDocumentPaymentClient(ApiContext apiContext) : base(apiContext)
        {
        }
    }
}