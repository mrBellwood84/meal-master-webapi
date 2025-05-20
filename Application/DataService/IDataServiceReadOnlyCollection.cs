using Domain.Ingredients;
using Domain.Messures;

namespace Application.DataService
{
    public interface IDataServiceReadOnlyCollection
    {
        IDataServiceReadOnly<IngredientCategory> IngredientCategory { get; }
        IDataServiceReadOnly<Messure> Messure { get; }
    }
}