using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyJwtAuthAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProtectedController : ControllerBase
    {
        
        [HttpGet]
        [Authorize]
        public IActionResult GetSecret()
        {
            return Ok(" You are authorized to access this protected resource.");
        }

       
        [HttpGet("public")]
        [AllowAnonymous]
        public IActionResult GetPublic()
        {
            return Ok(" This is a public endpoint. No token needed.");
        }
    }
}
