using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Savitar.Domain.Models.Requests;
using Savitar.Domain.Shared.Wrapper;
using Savitar.Services.Shared;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Savitar.Domain.Models.Entities;

namespace Savitar.Services
{
    internal class AccountsService : IAccountsService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountsService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IResult> UpdateProfileAsync(UpdateProfileRequest request, Guid userId)
        {
            if (!string.IsNullOrWhiteSpace(request.PhoneNumber))
            {
                var userWithSamePhoneNumber = await _userManager.Users.FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber);
                if (userWithSamePhoneNumber != null)
                    return await Result.FailAsync($"Phone number {request.PhoneNumber} is already used.");
            }

            var userWithSameEmail = await _userManager.FindByEmailAsync(request.Email);
            if (userWithSameEmail == null || userWithSameEmail.Id == userId)
            {
                var user = await _userManager.FindByIdAsync(userId.ToString());
                if (user == null)
                    return await Result.FailAsync("User Not Found.");
                
                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.PhoneNumber = request.PhoneNumber;
                var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
                if (request.PhoneNumber != phoneNumber)
                {
                    var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, request.PhoneNumber);
                }
                var identityResult = await _userManager.UpdateAsync(user);
                var errors = identityResult.Errors.Select(e => e.Description).ToList();
                await _signInManager.RefreshSignInAsync(user);

                return identityResult.Succeeded ? await Result.SuccessAsync() : await Result.FailAsync(errors);
            }

            return await Result.FailAsync($"Email {request.Email} is already used.");
        }

        public async Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                return await Result.FailAsync("User Not Found.");
            }

            var identityResult = await this._userManager.ChangePasswordAsync(
                user,
                model.Password,
                model.NewPassword);
            var errors = identityResult.Errors.Select(e => e.Description).ToList();
            
            return identityResult.Succeeded ? await Result.SuccessAsync() : await Result.FailAsync(errors);
        }
    }
}
