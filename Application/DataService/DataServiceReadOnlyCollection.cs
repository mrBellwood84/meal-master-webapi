using Application.DataService.Interfaces;
using Domain.Ingredients;
using Domain.Measures;
using Domain.Misc;
using Domain.Nutrients;
using Domain.Recipes;

namespace Application.DataService
{
    public class DataServiceReadOnlyCollection : IDataServiceReadOnlyCollection
    {
        public IDataServiceReadOnly<IngredientCategory> IngredientCategory { get; }
        public IDataServiceReadOnly<Measure> Measure { get; }
        public IDataServiceReadOnly<MeasureType> MeasureType { get; }
        public IDataServiceReadOnly<Nutrient> Nutrient { get; }
        public IDataServiceReadOnly<NutrientType> NutrientType { get; }
        public IDataServiceReadOnly<RecipeCategory> RecipeCategory { get; }
        public IDataServiceReadOnly<RecipeType> RecipeType { get; }
        public IDataServiceReadOnly<SourceType> SourceType { get; }

        public DataServiceReadOnlyCollection(
                IDataServiceReadOnly<IngredientCategory> ingredientCategory,
                IDataServiceReadOnly<Measure> measure,
                IDataServiceReadOnly<MeasureType> measureType,
                IDataServiceReadOnly<Nutrient> nutrient,
                IDataServiceReadOnly<NutrientType> nutrientType,
                IDataServiceReadOnly<RecipeCategory> recipeCategory,
                IDataServiceReadOnly<RecipeType> recipeType,
                IDataServiceReadOnly<SourceType> sourceType)
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
