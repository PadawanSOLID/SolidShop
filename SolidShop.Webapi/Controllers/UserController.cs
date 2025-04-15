using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidShop.Model.Models;

namespace SolidShop.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("/api/login")]
        public ActionResult<UserInfo> Login(LoginData data)
        {
            return Ok(new UserInfo { Token = "Login successful" });
        }
    }
}
