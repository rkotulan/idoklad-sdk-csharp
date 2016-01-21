using IdokladSdk.Constants;

namespace IdokladSdk.Integration.Tests
{
    public class IntegrationTestBase
    {
        protected ApiExplorer ApiExplorer;

        public IntegrationTestBase()
        {
            this.ApiExplorer = new ApiExplorer(new ApiContext(Auth.AuthKey)
            {
                AppName = "Idoklad.Sdk.Integration.Tests",
                AppVersion = SdkSettings.Version
            });
        }
    }
}
