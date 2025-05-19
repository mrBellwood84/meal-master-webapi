using Domain.Ingredients;

namespace Persistence.DbServices.Ingredients
{
    public interface IIngredientDbService
    {
        Task AddCategoryAsync(string IngredientId, string CategoryId);
        Task<List<Ingredient>> GetAllAsync();
        Task<Ingredient> GetOneByIdAsync(string Id);
        Task RemoveCategoryAsync(string IngredientId, string CategoryId);
        Task UpdateNamesAsync(string Id, string Name, string NamePlural);
    }
}