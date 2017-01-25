namespace IdokladSdk.Clients
{
    public class CashRegisterClient : BaseClient
    {
        public const string ResourceUrl = "/CashRegisters";

        public CashRegisterClient(ApiContext apiContext) : base(apiContext)
        {
        }
    }
}