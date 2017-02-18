using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels
{
    public class BatchItemResult<TApiModel> where TApiModel : class, IApiModel
    {
        public TApiModel Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
    }
}