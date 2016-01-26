using System;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// System functions
    /// </summary>
    public class SystemClient : BaseClient
    {
        internal const string ResourceUrl = "/System";

        public SystemClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/System/GetCodeBooksChanges
        /// Provides information about system tables changes.
        /// </summary>
        public CodeBooksChanges CodeBookChanges(ChangeFilter filter)
        {
            return base.Get<CodeBooksChanges>(ResourceUrl + "/GetCodeBooksChanges", filter);
        }
    }
}