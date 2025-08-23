using Application.DataService.Interfaces;
using Domain.Ingredients;
using Domain.Messures;
using Domain.Misc;
using Domain.Nutrients;
using Domain.Recipes;

namespace Application.DataService
{
    public class DataServiceReadOnlyCollection : IDataServiceReadOnlyCollection
    {
        public IDataServiceReadOnly<IngredientCategory> IngredientCategory { get; }
        public IDataServiceReadOnly<Messure> Messure { get; }
        public IDataServiceReadOnly<MessureType> MessureType { get; }
        public IDataServiceReadOnly<Nutrient> Nutrient { get; }
        public IDataServiceReadOnly<NutrientType> NutrientType { get; }
        public IDataServiceReadOnly<RecipeCategory> RecipeCategory { get; }
        public IDataServiceReadOnly<RecipeType> RecipeType { get; }
        public IDataServiceReadOnly<SourceType> SourceType { get; }

        public DataServiceReadOnlyCollection(
                IDataServiceReadOnly<IngredientCategory> ingredientCategory,
                IDataServiceReadOnly<Messure> messure,
                IDataServiceReadOnly<MessureType> messureType,
                IDataServiceReadOnly<Nutrient> nutrient,
                IDataServiceReadOnly<NutrientType> nutrientType,
                IDataServiceReadOnly<RecipeCategory> recipeCategory,
                IDataServiceReadOnly<RecipeType> recipeType,
                IDataServiceReadOnly<SourceType> sourceType)
        {
            IngredientCategory = ingredientCategory;
            Messure = messure;
            MessureType = messureType;
            Nutrient = nutrient;
            NutrientType = nutrientType;
            RecipeCategory = recipeCategory;
            RecipeType = recipeType;
            SourceType = sourceType;
        }
    }
}
