using Application.DataService.Interfaces;
using Domain.Ingredients;
using Domain.Messures;

namespace Application.DataService
{
    public class DataServiceReadOnlyCollection : IDataServiceReadOnlyCollection
    {
        public IDataServiceReadOnly<IngredientCategory> IngredientCategory { get; }
        public IDataServiceReadOnly<Messure> Messure { get; }
        public IDataServiceReadOnly<MessureType> MessureType { get; }

        public DataServiceReadOnlyCollection(
                IDataServiceReadOnly<IngredientCategory> ingredientCategory,
                IDataServiceReadOnly<Messure> messure,
                IDataServiceReadOnly<MessureType> messureType)
        {
            IngredientCategory = ingredientCategory;
            Messure = messure;
            MessureType = messureType;
        }
    }
}
