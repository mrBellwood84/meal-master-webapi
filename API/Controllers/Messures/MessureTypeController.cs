using Domain.Messures;
using Microsoft.AspNetCore.Mvc;
using Persistence.DbService;
using Persistence.DbService.Messures;

namespace API.Controllers.Messures
{
    [Route("api/messure/type")]
    [ApiController]
    public class MessureTypeController : ControllerBase
    {
        private readonly MessureTypeDbService _messureTypeService;

        public MessureTypeController(IDbService dbService)
        {
            _messureTypeService = dbService.MessureTypeDbService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MessureType>>> GetAll()
        {
            var data = await _messureTypeService.GetAll();
            return Ok(data);
        }
    }
}
