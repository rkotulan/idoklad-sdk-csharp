using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class UpdateExported : IApiModel
    {
        public ExportableEntityTypeEnum EntityType { get; set; }
        public ExportedStateEnum Exported { get; set; }
        public int Id { get; set; }
    }
}
