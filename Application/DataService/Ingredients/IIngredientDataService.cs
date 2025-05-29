using Domain.Ingredients;
using Domain.Ingredients.DTOs;

namespace Application.DataService.Ingredients
{
    public interface IIngredientDataService
    {
        Task AddIngredientCategoryAsync(IngredientCategoryUpdateDTO dto);
        Task AddIngredientMessureAsync(IngredientMessureUpdateDTO dto);
        Task EditIngredientMessureAsync(IngredientMessureUpdateDTO dto);
        Task<List<Ingredient>> GetAllAsync();
        Task<Ingredient> GetOneByIdAsync(string Id);
        Task RemoveIngredientCategoryAsync(IngredientCategoryUpdateDTO dto);
        Task RemoveIngredientMessureAsync(string Id);
        Task UpdateNamesAsync(IngredientUpdateNameDTO dto);
    }
}