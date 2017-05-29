using System.Collections.Generic;
using System.Threading.Tasks;
using IdokladSdk.ApiModels;

namespace IdokladSdk.Clients
{
    public partial class BatchClient : BaseClient
    {
        /// <summary>
        /// PUT api/Batch/Exported
        /// Updates an entity's Exported property. Used in communication with external accounting software.
        /// </summary>
        public async Task<BatchResultWrapper<UpdateExported>> UpdateExportedAsync(List<UpdateExported> items)
        {
            return await PutAsync<BatchResultWrapper<UpdateExported>, object>(ResourceUrl + "/" + "Exported", new { Items = items });
        }
    }
}