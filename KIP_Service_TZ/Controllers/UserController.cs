using KIP_Service_TZ.Logic;
using Microsoft.AspNetCore.Mvc;

namespace KIP_Service_TZ.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserLogic userLogic;
        public UserController(UserLogic userLogic)
        {
            this.userLogic = userLogic;
        }

        [HttpPost("Add")]
        public ActionResult<Guid> UserAdd(string name)
        {
            var user = userLogic.AddUser(name);
            return Ok(user.Id);
        }
    }
}
