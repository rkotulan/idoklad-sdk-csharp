using IdokladSdk.Constants;
using IdokladSdk.Extensions;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    public class IntegrationTestBase
    {
        protected ApiExplorer ApiExplorer;

        public IntegrationTestBase()
        {
            if (Auth.AuthKey.IsNullOrEmpty())
            {
                Assert.Ignore("Auth key is not presented");
            }

            ApiExplorer = new ApiExplorer(new ApiContext(Auth.AuthKey)
            {
                AppName = "Idoklad.Sdk.Integration.Tests",
                AppVersion = SdkSettings.Version
            });
        }
    }
}
