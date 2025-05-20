using Domain.Ingredients;
using Domain.Messures;

namespace Application.DataService
{
    public class DataServiceReadOnlyCollection : IDataServiceReadOnlyCollection
    {
        public IDataServiceReadOnly<IngredientCategory> IngredientCategory { get; }
        public IDataServiceReadOnly<Messure> Messure { get; }


        public DataServiceReadOnlyCollection(
                IDataServiceReadOnly<IngredientCategory> ingredientCategory,
                IDataServiceReadOnly<Messure> messure)
        {
            IngredientCategory = ingredientCategory;
            Messure = messure;
        }
    }
}
