using Application.DataService;
using Application.DataService.Messures;
using Domain.Messures;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Messures
{
    [Route("api/messure/type")]
    [ApiController]
    public class MessureTypeController : ControllerBase
    {
        private readonly MessureTypeDataService _dataService;

        public MessureTypeController(IDataService dataService)
        {
            _dataService = dataService.MessureType;
        }

        [HttpGet]
        public async Task<ActionResult<List<MessureType>>> GetAll()
        {
            var data = await _dataService.GetAllAsync();
            return Ok(data);
        }
    }
}
