using Domain.Measures;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Measures
{
    public class MeasureTypeCache : BaseCacheService<MeasureType>
    {
        public MeasureTypeCache(IMemoryCache cache) : base(cache)
        {
            Key = "measuretype";
        }
    }
}
