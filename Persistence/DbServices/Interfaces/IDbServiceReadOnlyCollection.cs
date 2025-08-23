using Domain.Ingredients;
using Domain.Messures;

namespace Persistence.DbServices.Interfaces
{
    public interface IDbServiceReadOnlyCollection
    {
        Task<List<IngredientCategory>> IngredientCategoriesGetAllAsync();
        Task<List<Messure>> MessureGetAllAsync();
        Task<List<MessureType>> MessureTypeGetAllAsync();
    }
}