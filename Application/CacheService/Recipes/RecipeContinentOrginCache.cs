using Domain.Recipes;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Recipes
{
    public class RecipeContinentOrginCache : CacheService<RecipeContinentOrgin>
    {
        public RecipeContinentOrginCache(IMemoryCache cache) : base(cache)
        {
            Key = "recipe_continent_orgin";
        }
    }
}
