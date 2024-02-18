using be_artwork_sharing_platform.Core.Constancs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace be_artwork_sharing_platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        [Route("get-public")]
        public IActionResult GetPublicData()
        {
            return Ok("Public data");
        }

        [HttpGet]
        [Route("get-customer-role")]
        [Authorize(Roles = StaticUserRole.CUSTOMER)]
        public IActionResult GetUserData()
        {
            return Ok("User Customer data");
        }

        [HttpGet]
        [Route("get-creator-role")]
        [Authorize(Roles = StaticUserRole.CREATOR)]
        public IActionResult GetManagerData()
        {
            return Ok("Manager Creator data");
        }

        [HttpGet]
        [Route("get-admin-role")]
        [Authorize(Roles = StaticUserRole.ADMIN)]
        public IActionResult GetAdminData()
        {
            return Ok("Admin Role data");
        }
    }
}
