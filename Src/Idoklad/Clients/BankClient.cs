using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    public class BankClient : BaseClient
    {
        internal const string ResourceUrl = "/Banks";

        public BankClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/Banks/GetChanges
        /// Method returns list of banks, that were changed.
        /// </summary>
        public RowsResultWrapper<Bank> Changes()
        {
            return base.Get<RowsResultWrapper<Bank>>(ResourceUrl + "/GetChanges");
        }

        /// <summary>
        /// GET api/Banks
        /// Method returns list of banks.
        /// </summary>
        public RowsResultWrapper<Bank> Banks()
        {
            return base.Get<RowsResultWrapper<Bank>>(ResourceUrl);
        }

        /// <summary>
        /// GET api/Banks/{id}
        /// Method returns bank by Id.
        /// </summary>
        public Bank Bank(int bankAccountId)
        {
            return base.Get<Bank>(ResourceUrl + "/" + bankAccountId);
        }
    }
}