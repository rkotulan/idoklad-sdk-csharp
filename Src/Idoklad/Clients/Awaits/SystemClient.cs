using System;
using System.Threading.Tasks;
using IdokladSdk.ApiModels;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// System functions
    /// </summary>
    public partial class SystemClient : BaseClient
    {
        /// <summary>
        /// GET api/System/GetCodeBooksChanges
        /// Provides information about system tables changes.
        /// </summary>
        public async Task<CodeBooksChanges> CodeBookChangesAsync(DateTime lastCheck)
        {
            return await GetAsync<CodeBooksChanges>(ResourceUrl + "/GetCodeBooksChanges" + "?lastCheck="+ lastCheck.ToString(ApiContextConfiguration.DateFormat));
        }
    }
}