using Application.CacheService.Messures;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService
{
    public class CacheService : ICacheService
    {

        private readonly string _messureKey = "messure";
        private readonly string _messureTypeKey = "messureType";

        public MessureCache MessureCache { get; set; }
        public MessureTypeCache MessureTypeCache { get; set; }


        public CacheService(IMemoryCache memoryCache)
        {
            MessureCache = new MessureCache(memoryCache, _messureKey);
            MessureTypeCache = new MessureTypeCache(memoryCache, _messureTypeKey);
        }

    }
}
