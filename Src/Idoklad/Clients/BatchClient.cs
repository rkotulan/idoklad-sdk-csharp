using System.Collections.Generic;
using IdokladSdk.ApiModels;

namespace IdokladSdk.Clients
{
    public class BatchClient : BaseClient
    {
        public const string ResourceUrl = "/Batch";

        public BatchClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// PUT api/Batch/Exported
        /// Updates an entity's Exported property. Used in communication with external accounting software.
        /// </summary>
        public BatchResultWrapper<UpdateExported> UpdatePurchaserDocumentAddress(List<UpdateExported> items)
        {
            return Put<BatchResultWrapper<UpdateExported>, List<UpdateExported>>(ResourceUrl + "/" + "Exported", items);
        }
    }
}