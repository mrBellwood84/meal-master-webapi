using Domain.Messures;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Messures
{
    public class MessureCache : CacheService<Messure>
    {

        //public MessureCache(IMemoryCache cache, string key) : base(cache, key) { }
        public MessureCache(IMemoryCache cache) : base(cache)
        {
        }
    }
}
