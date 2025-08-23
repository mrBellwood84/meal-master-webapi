using Domain.Ingredients;
using Domain.Messures;
using Domain.Misc;
using Domain.Nutrients;
using Domain.Recipes;

namespace Application.CacheService.Interfaces
{
    public interface ICacheServiceCollection
    {
        ICacheService<IngredientCategory> IngredientCategory { get; }
        ICacheService<Messure> Messure { get; }
        ICacheService<MessureType> MessureType { get; }
        ICacheService<Nutrient> Nutrient { get; }
        ICacheService<NutrientType> NutrientType { get; }
        ICacheService<RecipeCategory> RecipeCategory { get; }
        ICacheService<RecipeType> RecipeType { get; }
        ICacheService<SourceType> SourceType { get; }
    }
}