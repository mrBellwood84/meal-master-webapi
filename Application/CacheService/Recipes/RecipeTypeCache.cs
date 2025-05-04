using Domain.Recipes;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Recipes
{
    public class RecipeTypeCache : BaseCacheService<RecipeType>
    {
        public RecipeTypeCache(IMemoryCache cache) : base(cache)
        {
            Key = "recipe_type";
        }
    }
}
