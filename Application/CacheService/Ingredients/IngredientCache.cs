using Domain.Ingredients;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Ingredients
{
    public class IngredientCache : BaseCacheService<Ingredient>
    {
        public IngredientCache(IMemoryCache cache) : base(cache)
        {
            Key = "ingredients";
        }
    }
}
