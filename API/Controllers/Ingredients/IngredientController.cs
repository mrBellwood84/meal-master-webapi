using Application.DataService.Ingredients.Interfaces;
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
            var ingredients = await _data.GetAllAsync();
            return Ok(ingredients);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Ingredient>> GetByIdAsync(string Id)
        {
            var data = await _data.GetOneByIdAsync(Id);
            if (data == null) return NotFound();
            return Ok(data);
        }
    }
}
