using System;
using System.Security.Authentication;
using IdokladSdk.Extensions;
using Newtonsoft.Json;
using RestSharp;

namespace IdokladSdk.Clients.Auth
{
    public class AuthorizationCodeAuth : IAuth
    {
        public AuthConfiguration Configuration { get; set; } = new AuthConfiguration();

        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _code;
        private readonly string _redirectUri;

        public static string GetClientAuthenticationUrl(string clientId, string redirectUri, string customAuthorizeUrl = null)
        {
            string IdokladAuthorizeUrl = "https://app.idoklad.cz/identity/server/connect/authorize";
            return (customAuthorizeUrl ?? IdokladAuthorizeUrl) + $"?scope=idoklad_api%20offline_access&client_id={clientId}&response_type=code&redirect_uri={redirectUri}";
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
            var client = new RestClient(Configuration.IdokladTokenUrl);
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

            Tokenizer tokenizer = JsonConvert.DeserializeObject<Tokenizer>(responseJson);
            if (string.IsNullOrEmpty(tokenizer.AccessToken))
            {
                var errorMessage = (JsonConvert.DeserializeObject<dynamic>(responseJson)).error;
                throw new AuthenticationException("Authentication failed: " + errorMessage);
            }

            tokenizer.GrantType = GrantType.authorization_code;
            tokenizer.ClientId = _clientId;
            tokenizer.ClientSecret = _clientSecret;
            tokenizer.RedirectUri = _redirectUri;

            return tokenizer;
        }
    }
}