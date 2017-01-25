namespace IdokladSdk.Clients
{
    public class CashVoucherClient : BaseClient
    {
        public const string ResourceUrl = "/CashVouchers";

        public CashVoucherClient(ApiContext apiContext) : base(apiContext)
        {
        }
    }
}