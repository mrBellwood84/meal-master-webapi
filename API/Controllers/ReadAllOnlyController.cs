using Application.DataService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class ReadAllOnlyController<TModel> : ControllerBase
    {
        private readonly IDataServiceReadAllOnly<TModel> _dataService;

        public ReadAllOnlyController(IDataServiceReadAllOnly<TModel> dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TModel>>> GetAllAsync()
        {
            var data = await _dataService.GetAllAsync();
            return Ok(data);
        }
    }
}
