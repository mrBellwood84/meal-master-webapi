using Domain.Messures;
using Microsoft.AspNetCore.Mvc;
using Persistence.Messures;

namespace API.Controllers.Messures
{
    [Route("api/messure/type")]
    [ApiController]
    public class MessureTypeController : ControllerBase
    {
        private readonly IMessureTypeDbService _dbService;

        public MessureTypeController(IMessureTypeDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MessureType>>> GetAll()
        {
            var data = await _dbService.GetAll();
            return Ok(data);
        }
    }
}
