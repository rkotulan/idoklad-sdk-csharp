using System;
using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for constant symbols.
    /// </summary>
    public partial class ConstantSymbolClient : BaseClient
    {
        /// <summary>
        /// GET api/ConstantSymbols/GetChanges
        /// Method returns list of constant symbols, that were changed.
        /// </summary>
        public async Task<RowsResultWrapper<ConstantSymbol>> ChangesAsync(DateTime lastCheck, ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<ConstantSymbol>>(ResourceUrl + "/GetChanges"  + "?lastCheck=" + lastCheck.ToString(ApiContextConfiguration.DateFormat), filter);
        }

        /// <summary>
        /// GET api/ConstantSymbols
        /// Method returns list of constant symbols.
        /// </summary>
        public async Task<RowsResultWrapper<ConstantSymbol>> ConstantSymbolsAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<ConstantSymbol>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/ConstantSymbols/{id}
        /// Method returns constant symbol by Id.
        /// </summary>
        public async Task<ConstantSymbol> ConstantSymbolAsync(int constantSymbolId)
        {
            return await GetAsync<ConstantSymbol>(ResourceUrl + "/" + constantSymbolId);
        }
    }
}