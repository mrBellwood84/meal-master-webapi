using Application.DataService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class BaseReadOnlyDisabled<TModel> : ControllerBase
    {
        private readonly IDataServiceReadOnly<TModel> _dataService;

        public BaseReadOnlyDisabled(IDataServiceReadOnly<TModel> dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        [NonAction]
        public async Task<ActionResult<List<TModel>>> GetAllAsync()
        {
            var data = await _dataService.GetAllAsync();
            return Ok(data);
        }
    }
}
