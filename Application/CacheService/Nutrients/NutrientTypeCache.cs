using Domain.Nutrients;

namespace Application.CacheService.Nutrients
{
    public class NutrientTypeCache : BaseCacheService<NutrientType>
    {
        public NutrientTypeCache(Microsoft.Extensions.Caching.Memory.IMemoryCache cache) : base(cache)
        {
            Key = "nutrienttype";
        }
    }
}
