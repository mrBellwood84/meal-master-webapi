using Domain.Ingredients;
using Domain.Messures;
using Domain.Misc;
using Domain.Nutrients;
using Domain.Recipes;

namespace Application.DataService.Interfaces
{
    public interface IDataServiceReadOnlyCollection
    {
        IDataServiceReadOnly<IngredientCategory> IngredientCategory { get; }
        IDataServiceReadOnly<Messure> Messure { get; }
        IDataServiceReadOnly<MessureType> MessureType { get; }
        IDataServiceReadOnly<Nutrient> Nutrient { get; }
        IDataServiceReadOnly<NutrientType> NutrientType { get; }
        IDataServiceReadOnly<RecipeCategory> RecipeCategory { get; }
        IDataServiceReadOnly<RecipeType> RecipeType { get; }
        IDataServiceReadOnly<SourceType> SourceType { get; }
    }
}