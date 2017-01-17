namespace IdokladSdk.Clients.Auth
{
    public interface IAuth
    {
        /// <summary>
        /// Returns secure token needed for authorization
        /// </summary>
        Tokenizer GetSecureToken();
    }
}