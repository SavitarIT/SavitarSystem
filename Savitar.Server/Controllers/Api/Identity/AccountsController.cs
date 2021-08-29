using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Savitar.Domain.Models.Requests;
using Savitar.Services.Shared;
using Savitar.Web.Server.Controllers.api.Base;
using Savitar.Web.Server.Shared.Interfaces;

namespace Savitar.Web.Server.Controllers.Api.Identity
{
    [Route("api/identity/account")]
    
    public class AccountController : BaseApiController<AccountController>
    {
        private readonly IAccountsService _accountService;
        private readonly ICurrentUserService _currentUserService;

        public AccountController(IAccountsService accountsService, ICurrentUserService currentUserService)
        {
            _accountService = accountsService;
            _currentUserService = currentUserService;
        }

        [HttpPut(nameof(UpdateProfile))]
        public async Task<ActionResult> UpdateProfile(UpdateProfileRequest model)
        {
            var response = await _accountService.UpdateProfileAsync(model, _currentUserService.UserId);
            return Ok(response);
        }

        [HttpPut(nameof(ChangePassword))]
        public async Task<ActionResult> ChangePassword(ChangePasswordRequest model)
        {
            var response = await _accountService.ChangePasswordAsync(model, _currentUserService.UserId);
            return Ok(response);
        }
    }
}