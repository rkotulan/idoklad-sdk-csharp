namespace IdokladSdk.Clients.Auth
{
    public class AuthorizationCodeRefreshAuth
    {
        private readonly Tokenizer _token;

        public AuthorizationCodeRefreshAuth(Tokenizer token)
        {
            _token = token;
        }

        public Tokenizer RefreshToken()
        {
            return null;
        }
    }
}