using Application.DataService.Ingredients.Interfaces;
using Application.DataService.Interfaces;
using Application.DataService.Recipes.Interfaces;
using Domain.Recipes.DTOs;

namespace Application.DataService.Recipes
{
    public class RecipeDataService : IRecipeDataService
    {
        private readonly IDataServiceReadOnlyCollection _collection;
        private readonly IIngredientDataService _ingredients;

        public RecipeDataService(IDataServiceReadOnlyCollection collection, IIngredientDataService ingredients)
        {
            _collection = collection;
            _ingredients = ingredients;
        }

        public async Task<RecipeCrudOptionsDTO> GetCrudOptionsAsync()
        {
            var data = new RecipeCrudOptionsDTO();
            data.Ingredients = await _ingredients.GetAllAsync();
            data.RecipeTypes = await _collection.RecipeType.GetAllAsync();
            return data;
        }
    }
}
