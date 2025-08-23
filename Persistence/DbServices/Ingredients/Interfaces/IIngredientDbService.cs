using Domain.Ingredients;

namespace Persistence.DbServices.Ingredients.Interfaces
{
    public interface IIngredientDbService
    {
        Task AddCategoryAsync(string IngredientId, string CategoryId);
        Task AddIngredientMessureAsync(string Id, string IngredientId, string MessureId, float Quantity);
        Task EditIngredientMessureAsync(string Id, float Quantity);
        Task<List<Ingredient>> GetAllAsync();
        Task<Ingredient> GetOneByIdAsync(string Id);
        Task RemoveCategoryAsync(string IngredientId, string CategoryId);
        Task RemoveIngredientMessureAsync(string Id);
        Task UpdateNamesAsync(string Id, string Name, string NamePlural);
    }
}