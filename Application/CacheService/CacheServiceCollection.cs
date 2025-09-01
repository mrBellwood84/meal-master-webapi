using Application.CacheService.Interfaces;
using Domain.Ingredients;
using Domain.Measures;
using Domain.Misc;
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
        public ICacheService<RecipeCategory> RecipeCategory { get; }
        public ICacheService<RecipeType> RecipeType { get; }
        public ICacheService<SourceType> SourceType { get; }

        public CacheServiceCollection(
            ICacheService<IngredientCategory> ingredientCategory,
            ICacheService<Measure> measure,
            ICacheService<MeasureType> measureType,
            ICacheService<Nutrient> nutrient,
            ICacheService<NutrientType> nutrientType,
            ICacheService<RecipeCategory> recipeCategory,
            ICacheService<RecipeType> recipeType,
            ICacheService<SourceType> sourceType
            )
        {
            IngredientCategory = ingredientCategory;
            Measure = measure;
            MeasureType = measureType;
            Nutrient = nutrient;
            NutrientType = nutrientType;
            RecipeCategory = recipeCategory;
            RecipeType = recipeType;
            SourceType = sourceType;
        }
    }
}
