using Domain.Ingredients;
using Domain.Messures;

namespace Application.CacheService
{
    public class CacheServiceCollection : ICacheServiceCollection
    {

        public ICacheService<IngredientCategory> IngredientCategory { get; }
        public ICacheService<Messure> Messure { get; }

        public CacheServiceCollection(
            ICacheService<IngredientCategory> ingredientCategory,
            ICacheService<Messure> messure)
        {
            IngredientCategory = ingredientCategory;
            Messure = messure;
        }

    }
}
