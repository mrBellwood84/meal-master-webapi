using Domain.Messures;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Messures
{
    public class MessureCache : BaseCacheService<Messure>
    {
        public MessureCache(IMemoryCache cache) : base(cache)
        {
            Key = "messure";
        }
    }
}
