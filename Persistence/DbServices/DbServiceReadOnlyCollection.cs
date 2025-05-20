using Domain.Ingredients;
using Domain.Messures;

namespace Persistence.DbService
{
    public class DbServiceReadOnlyCollection : IDbServiceReadOnlyCollection
    {
        private readonly IDbServiceReadOnly<IngredientCategory> _ingredientCategory;
        private readonly IDbServiceReadOnly<Messure> _messure;

        public DbServiceReadOnlyCollection(
            IDbServiceReadOnly<IngredientCategory> ingredientCategory,
            IDbServiceReadOnly<Messure> messure)
        {
            _ingredientCategory = ingredientCategory;
            _messure = messure;
        }

        public Task<List<IngredientCategory>> IngredientCategoriesGetAllAsync() => _ingredientCategory.GetAllAsync();
        public Task<List<Messure>> MessureGetAllAsync() => _messure.GetAllAsync();
    }
}
