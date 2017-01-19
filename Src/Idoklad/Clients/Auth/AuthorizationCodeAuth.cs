using System;
using System.Security.Authentication;
using IdokladSdk.Extensions;
using Newtonsoft.Json;
using RestSharp;

namespace IdokladSdk.Clients.Auth
{
    public class AuthorizationCodeAuth : IAuth
    {
        private const string AuthorizeUrl = "https://app.idoklad.cz/identity/server/connect/authorize";
        private const string TokenUrl = "https://app.idoklad.cz/identity/server/connect/token";

        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _code;
        private readonly string _redirectUri;

        public static string GetClientAuthenticationUrl(string clientId, string redirectUri)
        {
            return AuthorizeUrl + $"?scope=idoklad_api%20offline_access&client_id={clientId}&response_type=code&redirect_uri={redirectUri}";
        }

        public AuthorizationCodeAuth(string clientId, string clientSecret, string code, string redirectUri)
        {
            if (clientId.IsNullOrEmpty() || clientSecret.IsNullOrEmpty() || code.IsNullOrEmpty() || redirectUri.IsNullOrEmpty())
            {
                throw new ArgumentException("client_id, client_secret, code and redirect_uri must be provided");
            }

            _clientId = clientId;
            _clientSecret = clientSecret;
            _code = code;
            _redirectUri = redirectUri;
        }

        public Tokenizer GetSecureToken()
        {
            var client = new RestClient(TokenUrl);
            var authRequest = new RestRequest(Method.POST);

            authRequest.AddParameter("content-type", "application/x-www-form-urlencoded");
            authRequest.AddParameter("grant_type", "authorization_code");
            authRequest.AddParameter("client_id", _clientId);
            authRequest.AddParameter("client_secret", _clientSecret);
            authRequest.AddParameter("code", _code);
            authRequest.AddParameter("redirect_uri", _redirectUri);
            authRequest.AddParameter("scope", "idoklad_api%20offline_access");

            IRestResponse authReponse = client.Execute(authRequest);

            string responseJson = authReponse.Content;

            if (responseJson.IsNullOrEmpty())
            {
                throw new AuthenticationException("Authentication failed. Access token has not been obtained.");
            }

            Tokenizer tokenizer = JsonConvert.DeserializeObject<Tokenizer>(responseJson);
            tokenizer.GrantType = GrantType.authorization_code;

            return tokenizer;
        }
    }
}