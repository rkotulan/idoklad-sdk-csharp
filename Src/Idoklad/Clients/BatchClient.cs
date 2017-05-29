using System.Collections.Generic;
using IdokladSdk.ApiModels;

namespace IdokladSdk.Clients
{
    public partial class BatchClient : BaseClient
    {
        public const string ResourceUrl = "/Batch";

        public BatchClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// PUT api/Batch/Exported
        /// Updates an entity's Exported property. Used in communication with external accounting software.
        /// </summary>
        public BatchResultWrapper<UpdateExported> UpdateExported(List<UpdateExported> items)
        {
            return Put<BatchResultWrapper<UpdateExported>, object>(ResourceUrl + "/" + "Exported", new { Items = items });
        }
    }
}