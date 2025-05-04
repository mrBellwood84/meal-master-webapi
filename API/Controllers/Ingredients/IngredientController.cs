using Application.DataService.Ingredients;
using Domain.Ingredients;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Ingredients
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientDataService _data;

        public IngredientController(IIngredientDataService data)
        {
            _data = data;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ingredient>>> GetAllAsync()
        {
            var data = await _data.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Ingredient>> Get(string Id)
        {
            bool validId = Guid.TryParse(Id, out var result);
            if (!validId) return BadRequest();
            
            var data = await _data.GetOneByIdAsync(Id);
            if (data == null) return NotFound();
            return Ok(data);
        }

    }
}
