using Domain.Ingredients;
using Domain.Messures;
using Domain.Nutrients;
using Domain.Recipes;

namespace Persistence.DbService
{
    public interface IDbServiceReadOnlyCollection
    {
        Task<List<IngredientCategory>> IngredientCategoriesGetAllAsync();
        Task<List<Messure>> MessureGetAllAsync();
        Task<List<NutrientType>> NutrientTypesGetAllAsync();
        Task<List<RecipeCategory>> RecipeCategoriesGetAllAsync();
        Task<List<RecipeType>> RecipeTypesGetAllAsync();
    }
}