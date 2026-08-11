using AuthenticationService.Application.Interfaces;
using AuthenticationService.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.API.Controllers
{
    [Route("api/di")]
    [ApiController]
    public class DependencyInjectionController : ControllerBase
    {
        private readonly IAuthService _authService;
        public DependencyInjectionController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpGet("Test")]
        public IActionResult TestDi() 
        {
            return Ok(new
            {
                Message = "Dependency Injection is working.",
                Service = _authService.GetServiceName()
            });

        }
    }
}
