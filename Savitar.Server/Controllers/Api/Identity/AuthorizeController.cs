using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Savitar.Domain.Models;
using Savitar.Domain.Models.Entities;
using Savitar.Web.Server.Controllers.api.Base;

namespace Savitar.Web.Server.Controllers.Api.Identity
{
    [Route("api/identity/authorize/[action]")]
    public class AuthorizeController : BaseApiController<AuthorizeController>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthorizeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(LoginParameters model)
        {
            var user = await _userManager.FindByNameAsync(model.Email);
            if (user == null)
                return BadRequest("User does not exist");

            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            if (!signInResult.Succeeded)
                return BadRequest("Invalid password");

            await _signInManager.SignInAsync(user, model.RememberMe);
            return Ok();
        }


        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Register(RegisterParameters model)
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
                return BadRequest(result.Errors.FirstOrDefault()?.Description);

            return await Login(new LoginParameters
            {
                Email = model.Email,
                Password = model.Password
            });
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
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
