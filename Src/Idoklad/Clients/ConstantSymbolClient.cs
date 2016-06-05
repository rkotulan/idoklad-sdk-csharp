using System;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for constant symbols.
    /// </summary>
    public class ConstantSymbolClient : BaseClient
    {
        public const string ResourceUrl = "/ConstantSymbols";

        public ConstantSymbolClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/ConstantSymbols/GetChanges
        /// Method returns list of constant symbols, that were changed.
        /// </summary>
        public RowsResultWrapper<ConstantSymbol> Changes(ChangeFilter filter)
        {
            return Get<RowsResultWrapper<ConstantSymbol>>(ResourceUrl + "/GetChanges", filter);
        }

        /// <summary>
        /// GET api/ConstantSymbols
        /// Method returns list of constant symbols.
        /// </summary>
        public RowsResultWrapper<ConstantSymbol> ConstantSymbols()
        {
            return Get<RowsResultWrapper<ConstantSymbol>>(ResourceUrl);
        }

        /// <summary>
        /// GET api/ConstantSymbols/{id}
        /// Method returns constant symbol by Id.
        /// </summary>
        public ConstantSymbol ConstantSymbol(int constantSymbolId)
        {
            return Get<ConstantSymbol>(ResourceUrl + "/" + constantSymbolId);
        }
    }
}