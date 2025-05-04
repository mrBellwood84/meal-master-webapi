using Application.DataService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class BaseReadOnlyController<TModel> : ControllerBase
    {
        private readonly IDataServiceReadOnly<TModel> _dataService;

        public BaseReadOnlyController(IDataServiceReadOnly<TModel> dataService)
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
