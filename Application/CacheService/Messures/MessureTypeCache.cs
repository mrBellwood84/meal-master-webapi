using Domain.Messures;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Messures
{

    public class MessureTypeCache : CacheService<MessureType>
    {
        //public MessureTypeCache(IMemoryCache cache, string key) : base(cache, key) { }
        public MessureTypeCache(IMemoryCache cache) : base(cache)
        {
        }
    }
}
