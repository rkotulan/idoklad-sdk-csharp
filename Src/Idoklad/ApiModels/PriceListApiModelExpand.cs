using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    public class PriceListExpand : PriceList
    {
        public Currency Currency { get; set; }
    }
}