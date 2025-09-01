using Application.DataService.Ingredients.Interfaces;
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

        [HttpPost("measure")]
        public async Task<IActionResult> AddIngredientMeasureAsync(IngredientMeasureUpdateDTO dto)
        {
            await _data.AddIngredientMeasureAsync(dto);
            return Ok();
        }

        [HttpPut("measure")]
        public async Task<IActionResult> EditIngredientMeasureAsync(IngredientMeasureUpdateDTO dto)
        {
            await _data.EditIngredientMeasureAsync(dto);
            return Ok();
        }

        [HttpDelete("measure")]
        public async Task<IActionResult> RemoveIngredientMeasureAsync(IdDTO dto)
        {
            await _data.RemoveIngredientMeasureAsync(dto.Id);
            return Ok();
        }
    }
}
