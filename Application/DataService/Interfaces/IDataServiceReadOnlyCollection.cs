using Domain.Ingredients;
using Domain.Measures;
using Domain.Nutrients;
using Domain.Recipes;

namespace Application.DataService.Interfaces
{
    public interface IDataServiceReadOnlyCollection
    {
        IDataServiceReadOnly<IngredientCategory> IngredientCategory { get; }
        IDataServiceReadOnly<Measure> Measure { get; }
        IDataServiceReadOnly<MeasureType> MeasureType { get; }
        IDataServiceReadOnly<Nutrient> Nutrient { get; }
        IDataServiceReadOnly<NutrientType> NutrientType { get; }
        IDataServiceReadOnly<RecipeCategory> RecipeCategory { get; }
        IDataServiceReadOnly<RecipeType> RecipeType { get; }
    }
}