using Application.DataService;
using Application.DataService.Messures;
using Domain.Messures;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers.Messures
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessureController : ControllerBase
    {
        private readonly MessureDataService _dataService;

        public MessureController(IDataService dataService)
        {
            _dataService = dataService.Messure;
        }

        [HttpGet]
        public async Task<ActionResult<List<Messure>>> GetAll()
        {
            var data = await _dataService.GetAllAsync();
            return Ok(data);
        }
    }
}
