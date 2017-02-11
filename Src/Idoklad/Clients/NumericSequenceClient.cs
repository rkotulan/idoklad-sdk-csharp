using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    public class NumericSequenceClient : BaseClient
    {
        public const string ResourceUrl = "/NumericSequences";

        public NumericSequenceClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/NumericSequences
        /// Method returns list of numeric sequences.
        /// </summary>
        public RowsResultWrapper<NumericSequence> NumericSequences(PageFilter paging = null)
        {
            return Get<RowsResultWrapper<NumericSequence>>(ResourceUrl, paging);
        }

        /// <summary>
        /// GET api/NumericSequences/{id}
        /// Method returns numeric sequence by Id.
        /// </summary>
        public NumericSequence NumericSequence(int numericSequenceId)
        {
            return Get<NumericSequence>(ResourceUrl + "/" + numericSequenceId);
        }
    }
}