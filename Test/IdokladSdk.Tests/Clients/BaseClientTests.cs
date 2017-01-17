using System;
using System.Linq;
using IdokladSdk.ApiModels;
using IdokladSdk.Constants;
using NSubstitute;
using NUnit.Framework;
using RestSharp;

namespace IdokladSdk.Tests.Clients
{
    [TestFixture]
    public class BaseClientTests
    {
        [Test]
        public void Get_CallsRestClient()
        {
            var restClient = Substitute.For<RestClient>();
            restClient.Get(Arg.Any<RestRequest>()).Returns(x => new RestResponse());

            var client = new FakeClient(new ApiContext("token"))
            {
                Client = restClient
            };

            client.Get<FakeApiModel>("/resource");

            restClient.Received(1).Execute(Arg.Any<RestRequest>());
        }

        [Test]
        public void Post_CallsRestClient()
        {
            var restClient = Substitute.For<RestClient>();

            var client = new FakeClient(new ApiContext("token"))
            {
                Client = restClient
            };

            client.Post<Contact, FakeApiModel>("/res", new FakeApiModel {Firstname = "Angelina", Lastname = "Jolie"});

            restClient.Received(1).Execute(Arg.Any<RestRequest>());
        }

        [Test]
        public void Post_ModelNotValid_ThrowsApplicationException()
        {
            var restClient = Substitute.For<RestClient>();

            var client = new FakeClient(new ApiContext("token"))
            {
                Client = restClient
            };

            Assert.Throws<ApplicationException>(delegate
            {
                client.Post<Contact, FakeApiModel>("/resource", new FakeApiModel());
            });
        }

        [Test]
        public void CreateRequest_ContainsAllHeaders()
        {
            var restClient = Substitute.For<RestClient>();

            var client = new FakeClient(new ApiContext("token")
            {
                AppName = "My app",
                AppVersion = "1.0.9"
            })
            {
                Client = restClient
            };

            var request = client.ResquestTest("/resource", Method.GET);

            Assert.That(request.Method, Is.EqualTo(Method.GET));
            Assert.True(request.Parameters.Any(x => x.Type == ParameterType.HttpHeader && x.Name == ApiHeaders.SecureToken));
            Assert.True(request.Parameters.Any(x => x.Type == ParameterType.HttpHeader && x.Name == ApiHeaders.App && x.Value == "My app"));
            Assert.True(request.Parameters.Any(x => x.Type == ParameterType.HttpHeader && x.Name == ApiHeaders.AppVersion && x.Value == "1.0.9"));
            Assert.True(request.Parameters.Any(x => x.Type == ParameterType.HttpHeader && x.Name == ApiHeaders.SdkVersion && x.Value == SdkSettings.Version));
        }


    }
}
