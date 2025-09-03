using Domain.Ingredients;

namespace Application.DataService.Ingredients.Interfaces
{
    public interface IIngredientDataService
    {
        Task<List<Ingredient>> GetAllAsync();
        Task<Ingredient> GetOneByIdAsync(string Id);
    }
}