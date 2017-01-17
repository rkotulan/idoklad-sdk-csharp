using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using IdokladSdk.ApiFilters;
using IdokladSdk.Constants;
using IdokladSdk.Extensions;
using Newtonsoft.Json;
using RestSharp;

namespace IdokladSdk.Clients
{
    public abstract class BaseClient
    {
        internal const string IdokladBaseUrl = "https://app.idoklad.cz/developer/api";
        internal const string DateFormat = "yyyy-MM-dd HH:mm";

        private readonly ApiContext _apiContext;

        protected RestClient Client;

        protected BaseClient(ApiContext apiContext)
        {
            _apiContext = apiContext;

            Client = apiContext.ApiVersion < 2 ? new RestClient(IdokladBaseUrl) : new RestClient(IdokladBaseUrl + "/v2");
        }

        protected T Get<T>(string resource, IApiFilter filter = null)
        {
            RestRequest request = CreateRequest(resource, Method.GET);
            request.ApplyFiltersAsQueryString(filter);

            IRestResponse response = Client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ApplicationException("Response from API is " + response.StatusCode);
            }

            return DeserializedResult<T>(response);
        }

        protected bool Delete(string resource)
        {
            RestRequest request = CreateRequest(resource, Method.DELETE);

            IRestResponse response = Client.Execute(request);

            if (response.StatusCode == HttpStatusCode.NoContent || response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }

        protected T Post<T, TI>(string resource, TI model)
        {
            List<ValidationMessage> errors;
            if(!IsValidObject(model, out errors))
            {
                throw new ApplicationException("Model is not valid. " + string.Join(". ", errors.Select(x=> x.Message)));
            }

            RestRequest request = CreateRequest(resource, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.DateFormat = DateFormat;

            request.AddBody(model);

            IRestResponse response = Client.Execute(request);
            return DeserializedResult<T>(response);
        }

        protected T Put<T, TI>(string resource, TI model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model", "Model is not presented");
            }

            List<ValidationMessage> errors;
            if (!IsValidObject(model, out errors))
            {
                throw new ApplicationException("Model is not valid. " + string.Join(". ", errors));
            }

            RestRequest request = CreateRequest(resource, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.DateFormat = DateFormat;
            request.AddBody(model);

            IRestResponse response = Client.Execute(request);
            return DeserializedResult<T>(response);
        }

        protected T Put<T>(string resource)
        {
            RestRequest request = CreateRequest(resource, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.DateFormat = DateFormat;

            IRestResponse response = Client.Execute(request);
            return DeserializedResult<T>(response);
        }

        protected bool IsValidObject(object obj, out List<ValidationMessage> results)
        {
            return ApiValidator.ValidateObject(obj, out results);
        }

        protected RestRequest CreateRequest(string resource, Method method)
        {
            var request = new RestRequest(resource, method);

            if (_apiContext.Token.GrantType == GrantType.any)
            {
                request.AddHeader(ApiHeaders.SecureToken, _apiContext.Token.AccessToken);
            }
            else
            {
                request.AddHeader(ApiHeaders.Authorization, "Bearer " + _apiContext.Token.AccessToken);
            }

            request.AddHeader(ApiHeaders.App, _apiContext.AppName);
            request.AddHeader(ApiHeaders.AppVersion, _apiContext.AppVersion);
            request.AddHeader(ApiHeaders.ApiVersion, _apiContext.ApiVersion.ToString());

            request.AddHeader(ApiHeaders.SdkVersion, SdkSettings.Version);

            return request;
        }

        private T DeserializedResult<T>(IRestResponse response)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }
            catch (Exception e)
            {
                throw new ApplicationException(response.Content);
            }
        }
    }
}
