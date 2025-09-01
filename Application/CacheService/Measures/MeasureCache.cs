using Domain.Measures;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Measures
{
    public class MeasureCache : BaseCacheService<Measure>
    {
        public MeasureCache(IMemoryCache cache) : base(cache)
        {
            Key = "measure";
        }
    }
}
