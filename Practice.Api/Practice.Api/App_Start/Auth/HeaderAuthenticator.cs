using System;
using System.Linq;
using System.Net.Http;

namespace Practice.Api.Auth
{
    public class HeaderAuthenticator : IHeaderAuthenticator
    {
        private readonly AuthConfig _config;

        public HeaderAuthenticator(AuthConfig config)
        {
            _config = config;
        }

        public bool KeyIsValid(HttpRequestMessage message)
        {
            if (!message.Headers.Contains(Constants.ApiKey))
                return false;

            var token = message.Headers.GetValues(Constants.ApiKey).First();
            return string.Compare(token, _config.ApiKey, StringComparison.OrdinalIgnoreCase) == 0;
        }
    }
}