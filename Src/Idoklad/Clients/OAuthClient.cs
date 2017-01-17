using System;
using System.Security.Authentication;
using IdokladSdk.Extensions;
using RestSharp;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Provides authentication methods
    /// </summary>
    [Obsolete("Use new ClientCredentialFlowAuth with API 2.0+ support")]
    public class OAuthClient
    {
        private const string ResourceUrl = "/Agendas/GetSecureToken?username={0}&password={1}";

        private readonly string _username;
        private readonly string _password;

        public OAuthClient(string username, string password)
        {
            if (username.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                throw new ArgumentException("Username and password must be provided");
            }

            _username = username;
            _password = password;
        }

        /// <summary>
        /// Returns secure token needed for authorization
        /// </summary>
        public string GetSecureToken()
        {
            string authUrl = string.Format(ResourceUrl, _username, _password);

            var client = new RestClient(BaseClient.IdokladBaseUrl);
            var authRequest = new RestRequest(authUrl, Method.GET);
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
