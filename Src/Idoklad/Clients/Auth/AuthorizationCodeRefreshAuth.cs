using System;
using System.Security.Authentication;
using IdokladSdk.Extensions;
using Newtonsoft.Json;
using RestSharp;

namespace IdokladSdk.Clients.Auth
{
    public class AuthorizationCodeRefreshAuth
    {
        private readonly Tokenizer _token;
        private const string TokenUrl = "https://app.idoklad.cz/identity/server/connect/token";

        public AuthorizationCodeRefreshAuth(Tokenizer token)
        {
            _token = token;
        }

        public Tokenizer RefreshToken()
        {
            if (string.IsNullOrEmpty(_token?.RefreshToken) || 
                string.IsNullOrEmpty(_token.ClientId) || 
                string.IsNullOrEmpty(_token.ClientSecret) || 
                string.IsNullOrEmpty(_token.RedirectUri))
            {
                return _token;
            }

            var client = new RestClient(TokenUrl);
            var authRequest = new RestRequest(Method.POST);

            authRequest.AddParameter("content-type", "application/x-www-form-urlencoded");
            authRequest.AddParameter("grant_type", "refresh_token");
            authRequest.AddParameter("client_id", _token.ClientId);
            authRequest.AddParameter("client_secret", _token.ClientSecret);
            authRequest.AddParameter("redirect_uri", _token.RedirectUri);
            authRequest.AddParameter("scope", "idoklad_api%20offline_access");
            authRequest.AddParameter("refresh_token", _token.RefreshToken);

            IRestResponse authReponse = client.Execute(authRequest);

            string responseJson = authReponse.Content;

            if (responseJson.IsNullOrEmpty())
            {
                throw new AuthenticationException("Authentication failed. Access token has not been obtained.");
            }

            Tokenizer tokenizer = JsonConvert.DeserializeObject<Tokenizer>(responseJson);
            tokenizer.GrantType = GrantType.authorization_code;
            tokenizer.ClientId = _token.ClientId;
            tokenizer.ClientSecret = _token.ClientSecret;
            tokenizer.RedirectUri = _token.RedirectUri;

            return tokenizer;
        }
    }
}