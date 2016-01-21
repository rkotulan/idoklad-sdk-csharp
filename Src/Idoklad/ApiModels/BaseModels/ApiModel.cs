using System.Collections.Generic;
using System.ComponentModel;

namespace IdokladSdk.ApiModels.BaseModels
{
    public class ApiModel : IApiModel
    {
        public ApiModel()
        {
            this.Links = new Dictionary<string, string>();
        }

        /// <summary>
        /// Identifikace resource
        /// </summary>
        /// <summary xml:lang="en">
        /// Resource identifier
        /// </summary>
        [ReadOnly(true)]
        public virtual int Id { get; set; }

        /// <summary>
        /// Seznam odkazů na resource
        /// </summary>
        /// <summary xml:lang="en">
        /// List of resource links
        /// </summary>
        [ReadOnly(true)]
        public IDictionary<string, string> Links { get; set; }
    }
}