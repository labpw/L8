using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using P05Shop.API.Services.AuthService;
using P06Shop.Shared;
using P06Shop.Shared.Auth;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            this._authService = authService;
        }

        [HttpGet("Secret"), Authorize]
        public string SecretText()
        {
            return "secret";
        }

        //public async Task<ActionResult<ServiceResponse<string>>> Login()
        //{
        //    return Ok("login");
        //}

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDTO userRegisterDTO)
        {
            var user = new User()
            {
                Email = userRegisterDTO.Email,
                Username = userRegisterDTO.Username
            };

            var response = await _authService.Register(user, userRegisterDTO.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        
        }
    }
}
