using System.Web.Http;

namespace Practice.Api.Controllers
{
    [RoutePrefix("api")]
    public class HealthController : ApiController
    {
        [Route("health")]
        [HttpGet]
        public string CheckHealth() => "OK";
    }
}