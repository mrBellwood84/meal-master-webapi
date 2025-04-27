using Domain.Nutrients;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Nutrients
{
    public class NutrientTypeCache : CacheService<NutrientType>
    {
        //public NutrientTypeCache(IMemoryCache cache, string key) : base(cache, key) { }
        public NutrientTypeCache(IMemoryCache cache) : base(cache)
        {
        }
    }
}
