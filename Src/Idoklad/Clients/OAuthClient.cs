using System;
using System.Security.Authentication;
using IdokladSdk.Extensions;
using RestSharp;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Provides authentication methods
    /// </summary>
    public class OAuthClient
    {
        internal const string ResourceUrl = "/Agendas/GetSecureToken?username={0}&password={1}";

        private readonly string username;
        private readonly string password;

        public OAuthClient(string username, string password)
        {
            if (username.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                throw new ArgumentException("Username and password must be provided");
            }

            this.username = username;
            this.password = password;
        }

        /// <summary>
        /// Returns secure token needed for authorization
        /// </summary>
        public string GetSecureToken()
        {
            string authUrl = string.Format(ResourceUrl, this.username, this.password);

            RestClient client = new RestClient(BaseClient.IdokladBaseUrl);
            RestRequest authRequest = new RestRequest(authUrl, Method.GET);
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
