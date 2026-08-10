using AuthenticationService.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        private readonly IConfigurationTestService _configurationService;

        public TestApiController(
            IConfigurationTestService configurationService)
        {
            _configurationService = configurationService;
        }
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok(new
            {
                JwtConfigured = _configurationService.IsJwtConfigured(),
                JwtIssuer = _configurationService.GetJwtIssuer(),
                SmsProvider = _configurationService.GetSmsProvider(),
                SmsSenderId = _configurationService.GetSmsSenderId()
            });
        }

    }
}
