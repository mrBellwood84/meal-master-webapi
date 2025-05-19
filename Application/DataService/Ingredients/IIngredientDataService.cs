using Domain.Ingredients;
using Domain.Ingredients.DTOs;

namespace Application.DataService.Ingredients
{
    public interface IIngredientDataService
    {
        Task AddIngredientCategory(IngredientCategoryUpdateDTO dto);
        Task<List<Ingredient>> GetAllAsync();
        Task<Ingredient> GetOneByIdAsync(string Id);
        Task RemoveIngredientCategory(IngredientCategoryUpdateDTO dto);
        Task UpdateNames(IngredientUpdateNameDTO dto);
    }
}