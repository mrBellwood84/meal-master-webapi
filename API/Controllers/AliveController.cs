using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AliveController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("...i am alive...");
        }
    }
}
