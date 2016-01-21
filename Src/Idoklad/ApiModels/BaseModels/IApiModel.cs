using System.Collections.Generic;

namespace IdokladSdk.ApiModels.BaseModels
{
    public interface IApiModel
    {
        int Id { get; set; }

        IDictionary<string, string> Links { get; set; }
    }
}