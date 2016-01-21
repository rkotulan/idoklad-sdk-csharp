using IdokladSdk.Clients;
using RestSharp;

namespace IdokladSdk.Tests.Clients
{
    public class FakeClient : BaseClient
    {
        public FakeClient(ApiContext apiContext) : base(apiContext)
        {
        }

        public new RestClient Client
        {
            get { return base.Client; }
            set { base.Client = value; }
        }

        public RestRequest ResquestTest(string resource, Method method)
        {
            return base.CreateRequest(resource, method);
        }

        public new T Get<T>(string resource)
        {
            return base.Get<T>(resource);
        }

        public new T Post<T, TI>(string resource, TI model)
        {
            return base.Post<T, TI>(resource, model);
        }
    }
}