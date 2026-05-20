using astronnCRM.Model.InputModels;
using astronnCRM.Service.IService;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace astronnCRM.Api.Areas.Identity
{
    [Area("Identity")]
    [DisplayName("Authentication controller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
    {
        [HttpPost("login")]
        [DisplayName("Login")]
        public async Task<IActionResult> Login([FromBody] ApplicationUserLoginInputModel model)
        {
            var response = await authenticationService.LoginAsync(model);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpPost("register")]
        [DisplayName("Register")]
        public async Task<IActionResult> Register([FromBody] ApplicationUserRegisterInputModel model)
        {
            var response = await authenticationService.RegisterAsync(model);
            return response ? Ok(response) : StatusCode(500);
        }

        [HttpPost("forgot-password")]
        [DisplayName("Forgot password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ApplicationUserRegisterInputModel model)
        {
            var response = await authenticationService.ForgotPasswordAsync(model);
            return response ? Ok(response) : StatusCode(500);
        }

        [HttpPost("reset-password")]
        [DisplayName("Reset password")]
        public async Task<IActionResult> ResetPassword([FromBody] ApplicationUserRegisterInputModel model)
        {
            var response = await authenticationService.ResetPasswordAsync(model);
            return response ? Ok(response) : StatusCode(500);
        }

        [HttpPost("change-password")]
        [DisplayName("Change password")]
        public async Task<IActionResult> ChangePassword([FromBody] ApplicationUserRegisterInputModel model)
        {
            var response = await authenticationService.ChangePasswordAsync(model);
            return response ? Ok(response) : StatusCode(500);
        }

        [HttpPost("refresh-token")]
        [DisplayName("Refresh token")]
        public async Task<IActionResult> RefreshToken([FromBody] ApplicationUserRegisterInputModel model)
        {
            var response = await authenticationService.RefreshTokenAsync(model);
            return response ? Ok(response) : StatusCode(500);
        }
    }
}
