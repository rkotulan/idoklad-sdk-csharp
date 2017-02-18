using System;
using System.Security.Authentication;
using IdokladSdk.Extensions;
using Newtonsoft.Json;
using RestSharp;

namespace IdokladSdk.Clients.Auth
{
    /// <summary>
    /// Provides authentication using the Client Credential Flow
    /// </summary>
    public class ClientCredentialAuth : IAuth
    {
        public AuthConfiguration Configuration { get; set; } = new AuthConfiguration();

        private readonly string _clientId;
        private readonly string _clientSecret;

        public ClientCredentialAuth(string clientId, string clientSecret)
        {
            if (clientId.IsNullOrEmpty() || clientSecret.IsNullOrEmpty())
            {
                throw new ArgumentException("client_id and client_secret must be provided");
            }

            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        /// <summary>
        /// Returns secure token needed for authorization
        /// </summary>
        public Tokenizer GetSecureToken()
        {
            var client = new RestClient(Configuration.IdokladTokenUrl);
            var authRequest = new RestRequest(Method.POST);

            authRequest.AddParameter("content-type", "application/x-www-form-urlencoded");
            authRequest.AddParameter("grant_type", "client_credentials");
            authRequest.AddParameter("client_id", _clientId);
            authRequest.AddParameter("client_secret", _clientSecret);
            authRequest.AddParameter("scope", "idoklad_api");

            IRestResponse authReponse = client.Execute(authRequest);

            string responseJson = authReponse.Content;

            Tokenizer tokenizer = JsonConvert.DeserializeObject<Tokenizer>(responseJson);
            tokenizer.GrantType = GrantType.client_credentials;

            if (string.IsNullOrEmpty(tokenizer.AccessToken))
            {
                var errorMessage = (JsonConvert.DeserializeObject<dynamic>(responseJson)).error;
                throw new AuthenticationException("Authentication failed: " + errorMessage);
            }

            return tokenizer;
        }
    }
}
