using astronnCRM.Model.IdentityModels;
using astronnCRM.Model.InputModels;
using astronnCRM.Service.IService;
using Microsoft.AspNetCore.Identity;

namespace astronnCRM.Service
{
    public class AuthenticationService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) : IAuthenticationService
    {
        public async Task<bool> LoginAsync(ApplicationUserLoginInputModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            return result.Succeeded ? true : throw new Exception("Unable to login user; Errors: " + result.ToString());
        }

        public async Task<bool> RegisterAsync(ApplicationUserRegisterInputModel model)
        {
            ArgumentNullException.ThrowIfNull(model.Email);
            ArgumentNullException.ThrowIfNull(model.Password);

            var user = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Email,

                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = model.Gender,
                DateOfBirth = model.DateOfBirth,
                DateOfRegistration = DateTime.UtcNow
            };

            var result = await userManager.CreateAsync(user, model.Password);
            return result.Succeeded ? true : throw new Exception("Unable to create user; Errors: " + result.Errors);
        }

        public async Task<bool> ForgotPasswordAsync(ApplicationUserRegisterInputModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ResetPasswordAsync(ApplicationUserRegisterInputModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ChangePasswordAsync(ApplicationUserRegisterInputModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RefreshTokenAsync(ApplicationUserRegisterInputModel model)
        {
            throw new NotImplementedException();
        }
    }
}
