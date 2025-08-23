using Domain.Misc;

namespace Application.CacheService.Misc
{
    public class SourceTypeCache :BaseCacheService<SourceType>
    {
        public SourceTypeCache(Microsoft.Extensions.Caching.Memory.IMemoryCache cache) : base(cache)
        {
            Key = "sourcetype";
        }
    }
}
