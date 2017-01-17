using System;
using Newtonsoft.Json;

namespace IdokladSdk
{
    public class Tokenizer
    {
        public Tokenizer()
        {
            Issued = DateTime.Now;
        }

        public GrantType GrantType { get; internal set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; internal set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; internal set; }

        [JsonProperty("expires_in")]
        public int Expires { get; internal set; }

        public DateTime Issued { get; }

        public bool IsValid(DateTime date)
        {
            return date < Issued.AddSeconds(Expires);
        }

        public bool ShouldBeRefreshedNow(int limitInSeconds)
        {
            return GrantType == GrantType.authorization_code && !IsValid(DateTime.Now.AddSeconds(-1  * limitInSeconds));
        }
    }
}
