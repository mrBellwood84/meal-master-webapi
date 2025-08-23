using Application.CacheService.Interfaces;
using Domain.Ingredients;
using Domain.Messures;

namespace Application.CacheService
{
    public class CacheServiceCollection : ICacheServiceCollection
    {

        public ICacheService<IngredientCategory> IngredientCategory { get; }
        public ICacheService<Messure> Messure { get; }
        public ICacheService<MessureType> MessureType { get; set; }

        public CacheServiceCollection(
            ICacheService<IngredientCategory> ingredientCategory,
            ICacheService<Messure> messure,
            ICacheService<MessureType> messureType)
        {
            IngredientCategory = ingredientCategory;
            Messure = messure;
            MessureType = messureType;
        }
    }
}
