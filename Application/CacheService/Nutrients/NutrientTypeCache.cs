using Domain.Nutrients;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Nutrients
{
    public class NutrientTypeCache : BaseCacheService<NutrientType>
    {
        public NutrientTypeCache(IMemoryCache cache) : base(cache)
        {
            Key = "nutrient_types";
        }
    }
}
