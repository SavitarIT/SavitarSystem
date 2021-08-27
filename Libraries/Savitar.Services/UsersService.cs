using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Savitar.Domain.Models;
using Savitar.Domain.Shared.Wrapper;
using Savitar.Services.Shared;

namespace Savitar.Services
{
    public class UsersService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UsersService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IResult> Login(LoginParameters model)
        {
            var user = await _userManager.FindByNameAsync(model.Email);
            if (user == null)
                return await Result.FailAsync("User does not exist");

            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            if (!signInResult.Succeeded)
                return await Result.FailAsync("Invalid password");

            await _signInManager.SignInAsync(user, model.RememberMe);
            return await Result.SuccessAsync();
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IResult> Register(RegisterParameters model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                EmailConfirmed = true,
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return await Result.FailAsync(result.Errors.FirstOrDefault()?.Description);

            return await Result.SuccessAsync();
        }
    }
}
