using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Savitar.Domain.Models;
using Savitar.Server.Controllers.api.Base;

namespace Savitar.Server.Controllers.Api.SysAdmin
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
    }
}