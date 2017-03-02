using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    public partial class NumericSequenceClient : BaseClient
    {
        /// <summary>
        /// GET api/NumericSequences
        /// Method returns list of numeric sequences.
        /// </summary>
        public async Task<RowsResultWrapper<NumericSequence>> NumericSequencesAsync(ApiFilter paging = null)
        {
            return await GetAsync<RowsResultWrapper<NumericSequence>>(ResourceUrl, paging);
        }

        /// <summary>
        /// GET api/NumericSequences/{id}
        /// Method returns numeric sequence by Id.
        /// </summary>
        public async Task<NumericSequence> NumericSequenceAsync(int numericSequenceId)
        {
            return await GetAsync<NumericSequence>(ResourceUrl + "/" + numericSequenceId);
        }
    }
}