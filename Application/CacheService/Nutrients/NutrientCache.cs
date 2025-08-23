using Domain.Nutrients;

namespace Application.CacheService.Nutrients
{
    public class NutrientCache : BaseCacheService<Nutrient>
    {
        public NutrientCache(Microsoft.Extensions.Caching.Memory.IMemoryCache cache) : base(cache)
        {
            Key = "nutrient";
        }
    }
}
