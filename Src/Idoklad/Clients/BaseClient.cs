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

        private readonly ApiContext apiContext;

        protected RestClient Client = new RestClient(IdokladBaseUrl);

        protected BaseClient(ApiContext apiContext)
        {
            this.apiContext = apiContext;
        }

        protected T Get<T>(string resource, IApiFilter filter = null)
        {
            RestRequest request = this.CreateRequest(resource, Method.GET);
            request.ApplyFiltersAsQueryString(filter);

            IRestResponse response = this.Client.Execute(request);
            return this.DeserializedResult<T>(response);
        }

        protected bool Delete(string resource)
        {
            RestRequest request = this.CreateRequest(resource, Method.DELETE);

            IRestResponse response = this.Client.Execute(request);

            if (response.StatusCode == HttpStatusCode.NoContent || response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }

        protected T Post<T, TI>(string resource, TI model)
        {
            List<ValidationMessage> errors;
            if(!this.IsValidObject(model, out errors))
            {
                throw new ApplicationException("Model is not valid. " + string.Join(". ", errors.Select(x=> x.Message)));
            }

            RestRequest request = this.CreateRequest(resource, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.DateFormat = DateFormat;

            request.AddBody(model);

            IRestResponse response = this.Client.Execute(request);
            return this.DeserializedResult<T>(response);
        }

        protected T Put<T, TI>(string resource, TI model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("Model is not presented");
            }

            List<ValidationMessage> errors;
            if (!this.IsValidObject(model, out errors))
            {
                throw new ApplicationException("Model is not valid. " + string.Join(". ", errors));
            }

            RestRequest request = this.CreateRequest(resource, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.DateFormat = DateFormat;
            request.AddBody(model);

            IRestResponse response = this.Client.Execute(request);
            return this.DeserializedResult<T>(response);
        }

        protected T Put<T>(string resource)
        {
            RestRequest request = this.CreateRequest(resource, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.DateFormat = DateFormat;

            IRestResponse response = this.Client.Execute(request);
            return this.DeserializedResult<T>(response);
        }

        protected bool IsValidObject(object obj, out List<ValidationMessage> results)
        {
            return ApiValidator.ValidateObject(obj, out results);
        }

        protected RestRequest CreateRequest(string resource, Method method)
        {
            var request = new RestRequest(resource, method);

            request.AddHeader(ApiHeaders.Token, apiContext.AccessToken);
            request.AddHeader(ApiHeaders.App, apiContext.AppName);
            request.AddHeader(ApiHeaders.AppVersion, apiContext.AppVersion);
            request.AddHeader(ApiHeaders.Agenda, apiContext.Agenda.ToString());

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
