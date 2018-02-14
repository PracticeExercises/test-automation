using System.Configuration;

namespace Practice.Api.Auth
{
    public class AuthConfig
    {
        public string ApiKey => ConfigurationManager.AppSettings[nameof(Constants.ApiKey)];
    }
}