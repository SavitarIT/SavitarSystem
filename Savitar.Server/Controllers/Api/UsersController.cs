using Microsoft.AspNetCore.Mvc;
using Savitar.Server.Controllers.api.Base;
using Savitar.Services.Shared;

namespace Savitar.Server.Controllers.api
{
    [Route("api/users/[action]")]
    public class UsersController : BaseApiController<UsersController>
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
    }
}