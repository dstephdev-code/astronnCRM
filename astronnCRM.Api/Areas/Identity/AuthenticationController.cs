using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace astronnCRM.Api.Areas.Identity
{
    [Area("Identity")]
    [DisplayName("Authentication controller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authentificationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authentificationService = authenticationService;
        }

        [HttpPost("login")]
        [DisplayName("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var response = await _authentificationService.LoginAsync(request);
            return Ok(response);
        }

        [HttpPost("register")]
        [DisplayName("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var response = await _authentificationService.RegisterAsync(request);
            return Ok(response);
        }

        [HttpPost("forgot-password")]
        [DisplayName("Forgot password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequest request)
        {
            var response = await _authentificationService.ForgotPasswordAsync(request);
            return Ok(response);
        }

        [HttpPost("reset-password")]
        [DisplayName("Reset password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest request)
        {
            var response = await _authentificationService.ResetPasswordAsync(request);
            return Ok(response);
        }

        [HttpPost("change-password")]
        [DisplayName("Change password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        {
            var response = await _authentificationService.ChangePasswordAsync(request);
            return Ok(response);
        }

        [HttpPost("refresh-token")]
        [DisplayName("Refresh token")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            var response = await _authentificationService.RefreshTokenAsync(request);
            return Ok(response);
        }
    }
}
