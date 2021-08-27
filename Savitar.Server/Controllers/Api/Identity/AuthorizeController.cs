using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Savitar.Domain.Models;
using Savitar.Server.Controllers.api.Base;
using Savitar.Services.Shared;

namespace Savitar.Server.Controllers.Api.Identity
{
    [Route("api/identity/authorize/[action]")]
    public class AuthorizeController : BaseApiController<AuthorizeController>
    {
        private readonly IUserService _userService;

        public AuthorizeController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(LoginParameters model)
        {
            var result = await _userService.Login(model);
            if (!result.Succeeded)
                return BadRequest(result.ToString());

            return Ok();
        }


        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Register(RegisterParameters model)
        {
            var result = await _userService.Register(model);
            if (!result.Succeeded)
                return BadRequest(result.ToString());

            return await Login(new LoginParameters
            {
                Email = model.Email,
                Password = model.Password
            });
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _userService.Logout();
            return Ok();
        }

        [HttpGet]
        public UserInfo UserInfo()
        {
            return GetUserInformation();
        }


        [HttpGet]
        private UserInfo GetUserInformation()
        {
            if (User  == null)
                throw new Exception("Unable to GetUserInformation as User is null");
            if (User.Identity == null)
                throw new Exception("Unable to GetUserInformation as User.Identity is null");

            return new UserInfo
            {
                IsAuthenticated = User.Identity.IsAuthenticated,
                Email = User.Identity.Name,
                ExposedClaims = User.Claims
                    //Optionally: filter the claims you want to expose to the client
                    //.Where(c => c.Type == "test-claim")
                    .ToDictionary(c => c.Type, c => c.Value)
            };
        }
    }
}
