using astronnCRM.Model.InputModels;
using astronnCRM.Service.IService;

namespace astronnCRM.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService()
        {
        }

        public Task<bool> ChangePasswordAsync(ApplicationUserInputModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ForgotPasswordAsync(ApplicationUserInputModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LoginAsync(ApplicationUserInputModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RefreshTokenAsync(ApplicationUserInputModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterAsync(ApplicationUserInputModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResetPasswordAsync(ApplicationUserInputModel model)
        {
            throw new NotImplementedException();
        }
    }
}
