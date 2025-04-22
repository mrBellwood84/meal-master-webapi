using Domain.Messures;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Messures;

namespace API.Controllers.Messures
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessureController : ControllerBase
    {
        private readonly IMessureDbService _dbService;

        public MessureController(IMessureDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Messure>>> GetAll()
        {
            var data = await _dbService.GetAll();
            return Ok(data);
        }
    }
}
