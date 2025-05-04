using Domain.Ingredients;
using Domain.Messures;
using Domain.Nutrients;
using Domain.Recipes;

namespace Application.CacheService
{
    public class CacheServiceCollection : ICacheServiceCollection
    {

        public ICacheService<IngredientCategory> IngredientCategory { get; }
        public ICacheService<Messure> Messure { get; }
        public ICacheService<NutrientType> NutrientType { get; }
        public ICacheService<RecipeCategory> RecipeCategory { get; }
        public ICacheService<RecipeType> RecipeType { get; }

        public CacheServiceCollection(
            ICacheService<IngredientCategory> ingredientCategory,
            ICacheService<Messure> messure,
            ICacheService<NutrientType> nutrientType,
            ICacheService<RecipeCategory> recipeCategory,
            ICacheService<RecipeType> recipeType)
        {
            IngredientCategory = ingredientCategory;
            Messure = messure;
            NutrientType = nutrientType;
            RecipeCategory = recipeCategory;
            RecipeType = recipeType;
        }

    }
}
