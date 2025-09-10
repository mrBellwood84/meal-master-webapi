using Application.CacheService.Interfaces;
using Domain.Ingredients;
using Domain.Measures;
using Domain.Nutrients;
using Domain.Recipes;

namespace Application.CacheService
{
    public class CacheServiceCollection : ICacheServiceCollection
    {

        public ICacheService<IngredientCategory> IngredientCategory { get; }
        public ICacheService<Measure> Measure { get; }
        public ICacheService<MeasureType> MeasureType { get; }
        public ICacheService<Nutrient> Nutrient { get; }
        public ICacheService<NutrientType> NutrientType { get; }
        public ICacheService<RecipeType> RecipeType { get; }

        public CacheServiceCollection(
            ICacheService<IngredientCategory> ingredientCategory,
            ICacheService<Measure> measure,
            ICacheService<MeasureType> measureType,
            ICacheService<Nutrient> nutrient,
            ICacheService<NutrientType> nutrientType,
            ICacheService<RecipeType> recipeType
            )
        {
            IngredientCategory = ingredientCategory;
            Measure = measure;
            MeasureType = measureType;
            Nutrient = nutrient;
            NutrientType = nutrientType;
            RecipeType = recipeType;
        }
    }
}
