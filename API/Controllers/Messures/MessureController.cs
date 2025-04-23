using Domain.Messures;
using Microsoft.AspNetCore.Mvc;
using Persistence.DbService;
using Persistence.DbService.Messures;

namespace API.Controllers.Messures
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessureController : ControllerBase
    {
        private readonly MessureDbService messureDbService;

        public MessureController(IDbService dbService)
        {

            messureDbService = dbService.MessureDbService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Messure>>> GetAll()
        {
            var data = await messureDbService.GetAll();
            return Ok(data);
        }
    }
}
