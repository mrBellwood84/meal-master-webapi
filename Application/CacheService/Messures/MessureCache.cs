using Domain.Messures;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Messures
{
    public class MessureCache : CacheSubService<Messure>
    {
        public MessureCache(IMemoryCache cache, string key) : base(cache, key) { }
    }
}
