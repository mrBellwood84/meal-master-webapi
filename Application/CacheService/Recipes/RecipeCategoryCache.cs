using Domain.Recipes;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Recipes
{
    public class RecipeCategoryCache : CacheService<RecipeCategory>
    {
        public RecipeCategoryCache(IMemoryCache cache) : base(cache)
        {
            Key = "recipe_category";
        }
    }
}
