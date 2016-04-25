using System;
using System.Security.Authentication;
using IdokladSdk.Extensions;
using RestSharp;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Provides authentication methods
    /// </summary>
    public class OAuth2Client
    {
        private const string ResourceUrl = "https://idokladauthserver.azurewebsites.net/identity/connect/token";

        private readonly string _clientId;
        private readonly string _clientSecret;

        public OAuth2Client(string clientId, string clientSecret)
        {
            if (clientId.IsNullOrEmpty() || clientSecret.IsNullOrEmpty())
            {
                throw new ArgumentException("client_id and cliend_secret must be provided");
            }

            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        /// <summary>
        /// Returns secure token needed for authorization
        /// </summary>
        public string GetSecureToken()
        {
            var client = new RestClient(ResourceUrl);
            var authRequest = new RestRequest(Method.POST);

            authRequest.AddParameter("content-type", "application/x-www-form-urlencoded");
            authRequest.AddParameter("grant_type", "client_credentials");
            authRequest.AddParameter("client_id", _clientId);
            authRequest.AddParameter("client_secret", _clientSecret);
            authRequest.AddParameter("scope", "idoklad_api");

            IRestResponse authReponse = client.Execute(authRequest);

            string token = authReponse.Content;

            if (token.IsNullOrEmpty())
            {
                throw new AuthenticationException("Authentication failed. Access token has not been obtained.");
            }

            return token.RemoveQuotationMarks();
        }
    }
}
