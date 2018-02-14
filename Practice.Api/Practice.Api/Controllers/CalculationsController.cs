using System.Net.Http.Headers;
using System.Web.Http;
using Practice.Api.Auth;

namespace Practice.Api.Controllers
{
    [RoutePrefix("api/calculations")]
    public class CalculationsController : ApiController
    {
        private readonly IHeaderAuthenticator _headerAuthenticator;

        public CalculationsController(IHeaderAuthenticator headerAuthenticator)
        {
            _headerAuthenticator = headerAuthenticator;
        }

        [Route("authCheck")]
        [HttpGet]
        public IHttpActionResult CheckAuth()
        {
            return _headerAuthenticator.KeyIsValid(Request)
                ? (IHttpActionResult) Ok()
                : Unauthorized(new AuthenticationHeaderValue("Basic", Constants.ApiKey));
        }
    }
}