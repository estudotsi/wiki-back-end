using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace WikiGC.Controllers
{
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("anonimo")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("user")]
        [Authorize(Roles = "user, admin")]
        public string Employee() => "User";

        [HttpGet]
        [Route("admin")]
        [Authorize(Roles = "admin")]
        public string Manager() => "Admin";
    }
}
