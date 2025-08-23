using Domain.Ingredients;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Ingredients
{
    public class IngredientCategoryCache : BaseCacheService<IngredientCategory>
    {
        public IngredientCategoryCache(IMemoryCache cache) : base(cache)
        {
            Key = "ingredientcategory";
        }
    }
}
