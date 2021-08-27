using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Savitar.Domain.Models.Requests;
using Savitar.Web.Server.Controllers.api.Base;

namespace Savitar.Web.Server.Controllers.Api.Identity
{
    [Route("api/identity/account")]
    
    public class AccountController : BaseApiController<AccountController>
    {
        /// <summary>
        /// Update Profile
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Status 200 OK</returns>
        [HttpPut(nameof(UpdateProfile))]
        public async Task<ActionResult> UpdateProfile(UpdateProfileRequest model)
        {
            //var response = await _accountService.UpdateProfileAsync(model, _currentUser.UserId);
            //return Ok(response);
            await Task.CompletedTask;
            return Ok();
        }

        /// <summary>
        /// Change Password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Status 200 OK</returns>
        [HttpPut(nameof(ChangePassword))]
        public async Task<ActionResult> ChangePassword(ChangePasswordRequest model)
        {
            //var response = await _accountService.ChangePasswordAsync(model, _currentUser.UserId);
            //return Ok(response);
            await Task.CompletedTask;
            return Ok();
        }
    }
}