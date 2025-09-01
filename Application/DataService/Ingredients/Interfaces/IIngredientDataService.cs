using Domain.Ingredients;
using Domain.Ingredients.DTOs;

namespace Application.DataService.Ingredients.Interfaces
{
    public interface IIngredientDataService
    {
        Task AddIngredientCategoryAsync(IngredientCategoryUpdateDTO dto);
        Task AddIngredientMeasureAsync(IngredientMeasureUpdateDTO dto);
        Task EditIngredientMeasureAsync(IngredientMeasureUpdateDTO dto);
        Task<List<Ingredient>> GetAllAsync();
        Task<Ingredient> GetOneByIdAsync(string Id);
        Task RemoveIngredientCategoryAsync(IngredientCategoryUpdateDTO dto);
        Task RemoveIngredientMeasureAsync(string Id);
        Task UpdateNamesAsync(IngredientUpdateNameDTO dto);
    }
}