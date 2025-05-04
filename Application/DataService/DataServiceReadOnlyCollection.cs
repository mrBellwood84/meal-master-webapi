using Domain.Ingredients;
using Domain.Messures;
using Domain.Nutrients;
using Domain.Recipes;

namespace Application.DataService
{
    public class DataServiceReadOnlyCollection : IDataServiceReadOnlyCollection
    {
        public IDataServiceReadOnly<IngredientCategory> IngredientCategory { get; }
        public IDataServiceReadOnly<Messure> Messure { get; }
        public IDataServiceReadOnly<NutrientType> NutrientType { get; }
        public IDataServiceReadOnly<RecipeCategory> RecipeCategory { get; }
        public IDataServiceReadOnly<RecipeType> RecipeType { get; }


        public DataServiceReadOnlyCollection(
                IDataServiceReadOnly<IngredientCategory> ingredientCategory,
                IDataServiceReadOnly<Messure> messure,
                IDataServiceReadOnly<NutrientType> nutrientType,
                IDataServiceReadOnly<RecipeCategory> recipeCategory,
                IDataServiceReadOnly<RecipeType> recipeType)
        {
            IngredientCategory = ingredientCategory;
            Messure = messure;
            NutrientType = nutrientType;
            RecipeCategory = recipeCategory;
            RecipeType = recipeType;
        }
    }
}
