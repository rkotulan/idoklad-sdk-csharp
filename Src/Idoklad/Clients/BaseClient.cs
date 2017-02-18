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
        protected readonly ApiContext ApiContext;

        protected RestClient Client;

        protected BaseClient(ApiContext apiContext)
        {
            ApiContext = apiContext;

            Client = new RestClient(ApiContext.Configuration.IdokladBaseUrl);
        }

        protected T Get<T>(string resource, IFilter filter = null)
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

        protected bool Delete(string resource, object[] ids = null)
        {
            RestRequest request = CreateRequest(resource, Method.DELETE);

            if (ids != null)
            {
                request.AddBody(ids);
            }

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
            request.DateFormat = ApiContextConfiguration.DateFormat;

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
            request.DateFormat = ApiContextConfiguration.DateFormat;
            request.AddBody(model);

            IRestResponse response = Client.Execute(request);
            return DeserializedResult<T>(response);
        }

        protected T Put<T>(string resource)
        {
            RestRequest request = CreateRequest(resource, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.DateFormat = ApiContextConfiguration.DateFormat;

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

            if (ApiContext.Token.GrantType == GrantType.any)
            {
                request.AddHeader(ApiHeaders.SecureToken, ApiContext.Token.AccessToken);
            }
            else
            {
                request.AddHeader(ApiHeaders.Authorization, "Bearer " + ApiContext.Token.AccessToken);
            }

            request.AddHeader(ApiHeaders.App, ApiContext.AppName);
            request.AddHeader(ApiHeaders.AppVersion, ApiContext.AppVersion);
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
