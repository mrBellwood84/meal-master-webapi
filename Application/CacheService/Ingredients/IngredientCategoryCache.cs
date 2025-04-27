using Domain.Ingredients;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Ingredients
{
    public class IngredientCategoryCache : CacheService<IngredientCategory>
    {
        public IngredientCategoryCache(IMemoryCache cache) : base(cache)
        {
            Key = "ingredient_category";
        }
    }
}
