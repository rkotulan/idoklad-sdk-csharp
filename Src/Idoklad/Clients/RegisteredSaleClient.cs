namespace IdokladSdk.Clients
{
    public class RegisteredSaleClient : BaseClient
    {
        public const string ResourceUrl = "/RegisteredSales";

        public RegisteredSaleClient(ApiContext apiContext) : base(apiContext)
        {
        }
    }
}