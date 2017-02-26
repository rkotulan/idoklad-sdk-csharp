using System;
using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for countries. Primary used with contacts.
    /// </summary>
    public partial class CountryClient : BaseClient
    {
        /// <summary>
        /// GET api/Countries/GetChanges
        /// Method returns list of countries, that were changed.
        /// </summary>
        public async Task<RowsResultWrapper<Country>> ChangesAsync(DateTime lastCheck, ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<Country>>(ResourceUrl + "/GetChanges" + "?lastCheck=" + lastCheck.ToString(ApiContextConfiguration.DateFormat), filter);
        }

        /// <summary>
        /// GET api/Countries
        /// Method returns list of countries.
        /// </summary>
        public async Task<RowsResultWrapper<Country>> CountriesAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<Country>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/Countries/{id}
        /// Method returns country by Id.
        /// </summary>
        public async Task<Country> CountryAsync(int countryId)
        {
            return await GetAsync<Country>(ResourceUrl + "/" + countryId);
        }
    }
}