using Domain.Ingredients;
using Domain.Messures;

namespace Persistence.DbService
{
    public interface IDbServiceReadOnlyCollection
    {
        Task<List<IngredientCategory>> IngredientCategoriesGetAllAsync();
        Task<List<Messure>> MessureGetAllAsync();
    }
}