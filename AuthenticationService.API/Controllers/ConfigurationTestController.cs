using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AuthenticationService.API.Configuration;
using Microsoft.Extensions.Options;
namespace AuthenticationService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationTestController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;
        private readonly SmsSettings _smsSettings;
        public ConfigurationTestController(IOptions<JwtSettings> jwtOptions,IOptions<SmsSettings> smsOptions)
        {
            _jwtSettings = jwtOptions.Value;
            _smsSettings = smsOptions.Value;
        }
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok(new
            {
                JwtConfigured = !string.IsNullOrWhiteSpace(_jwtSettings.SecretKey),
                JwtIssuer=_jwtSettings.SecretKey,
                smsProvider=_smsSettings.Provider,
                smsSenderId=_smsSettings.SenderId,
             });
                

        }
    }
}
