using Domain.Ingredients;
using Domain.Measures;
using Domain.Misc;
using Domain.Nutrients;
using Domain.Recipes;

namespace Persistence.DbServices.Interfaces
{
    public interface IDbServiceReadOnlyCollection
    {
        Task<List<IngredientCategory>> IngredientCategoriesGetAllAsync();
        Task<List<Measure>> MeasureGetAllAsync();
        Task<List<MeasureType>> MeasureTypeGetAllAsync();
        Task<List<Nutrient>> NutrientGetAllAsync();
        Task<List<NutrientType>> NutrientTypeGetAllAsync();
        Task<List<RecipeCategory>> RecipeCategoryGetAllAsync();
        Task<List<RecipeType>> RecipeTypeGetAllAsync();
        Task<List<SourceType>> SourceTypeGetAllAsync();
    }
}