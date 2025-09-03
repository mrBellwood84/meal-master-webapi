using Domain.Ingredients;

namespace Persistence.DbServices.Ingredients.Interfaces
{
    public interface IIngredientDbService
    {
        Task<List<Ingredient>> GetAllAsync();
        Task<Ingredient> GetOneByIdAsync(string Id);
    }
}