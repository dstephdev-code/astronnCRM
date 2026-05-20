using astronnCRM.Model.IdentityModels;
using astronnCRM.Model.InputModels;
using astronnCRM.Service.IService;
using Microsoft.AspNetCore.Identity;

namespace astronnCRM.Service
{
    public class AuthenticationService(UserManager<ApplicationUser> userManager) : IAuthenticationService
    {
        public async Task<bool> LoginAsync(ApplicationUserInputModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RegisterAsync(ApplicationUserInputModel model)
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

        public async Task<bool> ForgotPasswordAsync(ApplicationUserInputModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ResetPasswordAsync(ApplicationUserInputModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ChangePasswordAsync(ApplicationUserInputModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RefreshTokenAsync(ApplicationUserInputModel model)
        {
            throw new NotImplementedException();
        }
    }
}
