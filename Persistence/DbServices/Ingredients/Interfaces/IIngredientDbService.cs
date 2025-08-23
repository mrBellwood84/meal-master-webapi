using Domain.Ingredients;

namespace Persistence.DbServices.Ingredients.Interfaces
{
    /// <summary>
    /// Defines a contract for managing ingredient-related data in a database.
    /// </summary>
    /// <remarks>This service provides methods for adding, editing, retrieving, and removing ingredients, 
    /// categories, and measurement associations. It is designed to support asynchronous operations  for scalability and
    /// responsiveness.</remarks>
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