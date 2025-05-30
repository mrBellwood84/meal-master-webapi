using Application.DataService.Ingredients;
using Domain.Ingredients;
using Domain.Ingredients.DTOs;
using Domain.Misc;
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
            var data = await _data.GetOneByIdAsync(Id);
            if (data == null) return NotFound();
            return Ok(data);
        }

        [HttpPut("update/name")]
        public async Task<IActionResult> UpdateNameAsync(IngredientUpdateNameDTO dto)
        {
            await _data.UpdateNamesAsync(dto);
            return Ok();
        }

        [HttpPost("category")]
        public async Task<IActionResult> AddCategoryAsync(IngredientCategoryUpdateDTO dto)
        {
            await _data.AddIngredientCategoryAsync(dto);
            return Ok();
        }

        [HttpDelete("category")]
        public async Task<IActionResult> RemoveCategoryAsync(IngredientCategoryUpdateDTO dto)
        {
            await _data.RemoveIngredientCategoryAsync(dto);
            return Ok();
        }

        [HttpPost("messure")]
        public async Task<IActionResult> AddIngredientMessureAsync(IngredientMessureUpdateDTO dto)
        {
            await _data.AddIngredientMessureAsync(dto);
            return Ok();
        }

        [HttpPut("messure")]
        public async Task<IActionResult> EditIngredientMessureAsync(IngredientMessureUpdateDTO dto)
        {
            await _data.EditIngredientMessureAsync(dto);
            return Ok();
        }

        [HttpDelete("messure")]
        public async Task<IActionResult> RemoveIngredientMessureAsync(IdDTO dto)
        {
            await _data.RemoveIngredientMessureAsync(dto.Id);
            return Ok();
        }
    }
}
