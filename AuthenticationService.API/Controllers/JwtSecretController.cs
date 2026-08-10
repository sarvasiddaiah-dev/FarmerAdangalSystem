using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace AuthenticationService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtSecretController : ControllerBase
    {
        [HttpGet("generate-jwt-secret")]
        public IActionResult GenerateJwtSecret()
        {
            // Generate 64 cryptographically secure random bytes
            byte[] bytes = new byte[64];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }

            string secretKey = Convert.ToBase64String(bytes);

            return Ok(new
            {
                SecretKey = secretKey,
                Length = secretKey.Length,
                Message = "Development use only. Store this key in User Secrets."
            });
        }
    }
}
