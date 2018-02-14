using System.Net.Http.Headers;
using System.Web.Http;
using Practice.Api.Auth;
using Practice.Api.Logic;
using Practice.Api.Models;

namespace Practice.Api.Controllers
{
    [RoutePrefix("api/calculations")]
    public class CalculationsController : ApiController
    {
        private readonly ICalculator _calculator;
        private readonly IHeaderAuthenticator _headerAuthenticator;

        public CalculationsController(IHeaderAuthenticator headerAuthenticator, ICalculator calculator)
        {
            _headerAuthenticator = headerAuthenticator;
            _calculator = calculator;
        }

        [Route("calculateTotalAmount")]
        [HttpPost]
        public IHttpActionResult CalculateTotalAmount([FromBody] CalculateViewModel model)
        {
            if (_headerAuthenticator.KeyIsValid(Request))
                if (ModelState.IsValid)
                    return Ok(_calculator.CalculateInterest(model));
                else
                    return BadRequest(ModelState);

            return Unauthorized(new AuthenticationHeaderValue("Basic", Constants.ApiKey));
        }
    }
}