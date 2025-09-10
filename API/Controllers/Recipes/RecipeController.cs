using Application.DataService.Recipes.Interfaces;
using Domain.Recipes.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Recipes
{
    [Route("api/[controller]/")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeDataService _data;
        public RecipeController(IRecipeDataService recipeData)
        {
            _data = recipeData;
        }

        [HttpGet("options")]
        public async Task<ActionResult<RecipeCrudOptionsDTO>> GetOptionsAsync()
        {
            var options = await _data.GetCrudOptionsAsync();
            return Ok(options);
        }

    }
}
