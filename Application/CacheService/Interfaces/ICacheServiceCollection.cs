using Domain.Ingredients;
using Domain.Measures;
using Domain.Nutrients;
using Domain.Recipes;

namespace Application.CacheService.Interfaces
{
    public interface ICacheServiceCollection
    {
        ICacheService<IngredientCategory> IngredientCategory { get; }
        ICacheService<Measure> Measure { get; }
        ICacheService<MeasureType> MeasureType { get; }
        ICacheService<Nutrient> Nutrient { get; }
        ICacheService<NutrientType> NutrientType { get; }
        ICacheService<RecipeCategory> RecipeCategory { get; }
        ICacheService<RecipeType> RecipeType { get; }
    }
}