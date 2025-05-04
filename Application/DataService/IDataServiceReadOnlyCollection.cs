using Domain.Ingredients;
using Domain.Messures;
using Domain.Nutrients;
using Domain.Recipes;

namespace Application.DataService
{
    public interface IDataServiceReadOnlyCollection
    {
        IDataServiceReadOnly<IngredientCategory> IngredientCategory { get; }
        IDataServiceReadOnly<Messure> Messure { get; }
        IDataServiceReadOnly<NutrientType> NutrientType { get; }
        IDataServiceReadOnly<RecipeCategory> RecipeCategory { get; }
        IDataServiceReadOnly<RecipeType> RecipeType { get; }
    }
}