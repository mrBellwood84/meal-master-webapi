using Domain.Ingredients;
using Domain.Messures;
using Persistence.DbServices.Interfaces;

namespace Persistence.DbService
{
    public class DbServiceReadOnlyCollection : IDbServiceReadOnlyCollection
    {
        private readonly IDbServiceReadOnly<IngredientCategory> _ingredientCategory;
        private readonly IDbServiceReadOnly<Messure> _messure;
        private readonly IDbServiceReadOnly<MessureType> _messureType;

        public DbServiceReadOnlyCollection(
            IDbServiceReadOnly<IngredientCategory> ingredientCategory,
            IDbServiceReadOnly<Messure> messure,
            IDbServiceReadOnly<MessureType> messureType)

        {
            _ingredientCategory = ingredientCategory;
            _messure = messure;
            _messureType = messureType;
        }

        public Task<List<IngredientCategory>> IngredientCategoriesGetAllAsync() => _ingredientCategory.GetAllAsync();
        public Task<List<Messure>> MessureGetAllAsync() => _messure.GetAllAsync();
        public Task<List<MessureType>> MessureTypeGetAllAsync() => _messureType.GetAllAsync();
    }
}
