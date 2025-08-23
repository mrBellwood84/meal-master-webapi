using Domain.Ingredients;
using Domain.Messures;
using Domain.Misc;
using Domain.Nutrients;
using Domain.Recipes;

namespace Persistence.DbServices.Interfaces
{
    /// <summary>
    /// Defines a read-only collection of database service methods for retrieving various domain entities.
    /// </summary>
    public interface IDbServiceReadOnlyCollection
    {
        Task<List<IngredientCategory>> IngredientCategoriesGetAllAsync();
        Task<List<Messure>> MessureGetAllAsync();
        Task<List<MessureType>> MessureTypeGetAllAsync();
        Task<List<Nutrient>> NutrientGetAllAsync();
        Task<List<NutrientType>> NutrientTypeGetAllAsync();
        Task<List<RecipeCategory>> RecipeCategoryGetAllAsync();
        Task<List<RecipeType>> RecipeTypeGetAllAsync();
        Task<List<SourceType>> SourceTypeGetAllAsync();
    }
}