using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class BatchResultWrapper<TApiModel> where TApiModel : class, IApiModel
    {
        public BatchItemResult<TApiModel> Results { get; set; }
        public BatchResultTypeEnum Status { get; set; }
    }
}