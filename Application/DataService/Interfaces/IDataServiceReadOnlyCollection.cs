using Domain.Ingredients;
using Domain.Messures;

namespace Application.DataService.Interfaces
{
    public interface IDataServiceReadOnlyCollection
    {
        IDataServiceReadOnly<IngredientCategory> IngredientCategory { get; }
        IDataServiceReadOnly<Messure> Messure { get; }
        IDataServiceReadOnly<MessureType> MessureType { get; }
    }
}