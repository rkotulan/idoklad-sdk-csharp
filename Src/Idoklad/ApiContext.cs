using System;
using IdokladSdk.Clients.Auth;

namespace IdokladSdk
{
    public class ApiContext
    {
        private Tokenizer _token;

        public ApiContextConfiguration Configuration { get; set; } = new ApiContextConfiguration();

        /// <summary>
        /// Refresh token before expiration limit (in seconds)
        /// </summary>
        public int RefreshTokenLimit { get; set; } = 600;

        /// <summary>
        /// Access token
        /// </summary>
        public Tokenizer Token
        {
            get
            {
                if (_token.ShouldBeRefreshedNow(RefreshTokenLimit))
                {
                    RefreshToken();
                }

                return _token;
            }
        }

        /// <summary>
        /// Your application name (optional but recommended)
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// Your application version (optional)
        /// </summary>
        public string AppVersion { get; set; }

        public ApiContext(Tokenizer token)
        {
            if (token == null)
            {
                throw new ArgumentNullException("Token object can not be null");
            }

            _token = token;
        }

        public ApiContext(IAuth authenticationFlow)
        {
            if (authenticationFlow == null)
            {
                throw new ArgumentNullException("Authentication object can not be null");
            }

            _token = authenticationFlow.GetSecureToken();
        }

        /// <summary>
        /// Refresh token internally when possible
        /// </summary>
        private void RefreshToken()
        {
            AuthorizationCodeRefreshAuth refreshTokenAuth = new AuthorizationCodeRefreshAuth(_token);

            _token = refreshTokenAuth.RefreshToken();
        }
    }
}
