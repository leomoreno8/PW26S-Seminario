using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserApi.Models;

namespace UserApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {
        [HttpGet]
        public ActionResult<List<UserModel>> SearchAllUsers() {
            return Ok();
        }
    }
}
