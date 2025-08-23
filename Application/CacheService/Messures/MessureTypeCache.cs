using Domain.Messures;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Messures
{
    public class MessureTypeCache : BaseCacheService<MessureType>
    {
        public MessureTypeCache(IMemoryCache cache) : base(cache)
        {
            Key = "messuretype";
        }
    }
}
