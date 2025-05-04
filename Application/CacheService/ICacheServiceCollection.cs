using Domain.Ingredients;
using Domain.Messures;
using Domain.Nutrients;
using Domain.Recipes;

namespace Application.CacheService
{
    public interface ICacheServiceCollection
    {
        ICacheService<IngredientCategory> IngredientCategory { get; }
        ICacheService<Messure> Messure { get; }
        ICacheService<NutrientType> NutrientType { get; }
        ICacheService<RecipeCategory> RecipeCategory { get; }
        ICacheService<RecipeType> RecipeType { get; }
    }
}