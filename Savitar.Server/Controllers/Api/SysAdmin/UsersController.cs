using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Savitar.Domain.Models.Dtos;
using Savitar.Domain.Models.Entities;
using Savitar.Domain.Models.Requests;
using Savitar.Web.Server.Controllers.api.Base;

namespace Savitar.Web.Server.Controllers.Api.SysAdmin
{
    [Route("api/sysadmin/[controller]")]
    public class UsersController : BaseApiController<UsersController>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        [ResponseCache(NoStore = true)]
        public virtual async Task<ActionResult<IEnumerable<UserInfo>>> Get()
        {
            try
            {
                var data = await _userManager.Users
                    .Select(x => new UserInfo { Email = x.Email })
                    .ToListAsync();

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{userId:guid}")]
        public async Task<ActionResult<UpdateProfileRequest>> Get(Guid userId)
        {
            ApplicationUser data = null;

            if (userId == Guid.Empty)
                data = _userManager.Users.SingleOrDefault(x => x.Email == User.Identity.Name);
            else
                data = await _userManager.Users.SingleOrDefaultAsync(x => x.Id == userId);

            if (data == null)
                return BadRequest("No user could be found with the passed userId");

            var result = new UpdateProfileRequest
            {
                Email = data.Email,
                FirstName = data.FirstName,
                LastName = data.LastName
            };

            return Ok(result);
        }
    }
}