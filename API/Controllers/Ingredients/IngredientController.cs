using Application.DataService.Ingredients;
using Domain.Ingredients;
using Domain.Ingredients.DTOs;
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
        public async Task<ActionResult<Ingredient>> GetByIdAsync(string Id)
        {
            bool validId = Guid.TryParse(Id, out var result);
            if (!validId) return BadRequest();

            var data = await _data.GetOneByIdAsync(Id);
            if (data == null) return NotFound();
            return Ok(data);
        }

        [HttpPut("update/name")]
        public async Task<IActionResult> UpdateNameAsync(IngredientUpdateNameDTO dto)
        {
            bool validID = Guid.TryParse(dto.Id, out var result);
            if (!validID) return BadRequest();

            if (dto.Name == null) return BadRequest();
            if (dto.NamePlural == null) return BadRequest();

            await _data.UpdateNames(dto);
            return Ok();
        }

        [HttpPost("category")]
        public async Task<IActionResult> AddCategoryAsync(IngredientCategoryUpdateDTO dto)
        {
            bool validIngredientId = Guid.TryParse(dto.IngredientId, out var ingredientId);
            bool validCategoryId = Guid.TryParse(dto.CategoryId, out var categoryId);

            if (!validIngredientId) return BadRequest();
            if (!validCategoryId) return BadRequest();

            await _data.AddIngredientCategory(dto);
            return Ok();
        }

        [HttpDelete("category")]
        public async Task<IActionResult> RemoveCategoryAsync(IngredientCategoryUpdateDTO dto)
        {
            bool validIngredientId = Guid.TryParse(dto.IngredientId, out var ingredientId);
            bool validCategoryId = Guid.TryParse(dto.CategoryId, out var categoryId);

            if (!validIngredientId) return BadRequest();
            if (!validCategoryId) return BadRequest();

            await _data.RemoveIngredientCategory(dto);
            return Ok();
        }
    }
}
