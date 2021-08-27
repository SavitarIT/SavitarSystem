using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Savitar.Server.Controllers.api
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Produces("application/json")]
    public class BaseApiController : ControllerBase
    {

    }
}
