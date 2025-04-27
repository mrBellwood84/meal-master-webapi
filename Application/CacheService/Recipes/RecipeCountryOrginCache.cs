using Domain.Recipes;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Recipes
{
    public class RecipeCountryOrginCache : CacheService<RecipeCountryOrgin>
    {
        public RecipeCountryOrginCache(IMemoryCache cache) : base(cache)
        {
            Key = "recipe_country_orgin";
        }
    }
}
