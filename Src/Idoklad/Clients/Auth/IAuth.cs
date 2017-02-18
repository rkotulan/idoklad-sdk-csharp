namespace IdokladSdk.Clients.Auth
{
    public interface IAuth
    {
        /// <summary>
        /// Configuration for authentication
        /// </summary>
        AuthConfiguration Configuration { get; set; }

        /// <summary>
        /// Returns secure token needed for authorization
        /// </summary>
        Tokenizer GetSecureToken();
    }
}