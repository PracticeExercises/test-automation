using System.Net.Http;

namespace Practice.Api.Auth
{
    public interface IHeaderAuthenticator
    {
        bool KeyIsValid(HttpRequestMessage message);
    }
}