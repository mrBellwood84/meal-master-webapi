using Application.CacheService.Messures;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService
{
    public class CacheService : ICacheService
    {

        private readonly string _messureKey = "messure";
        private readonly string _messureTypeKey = "messureType";

        public MessureCache Messure { get; set; }
        public MessureTypeCache MessureType { get; set; }


        public CacheService(IMemoryCache memoryCache)
        {
            Messure = new MessureCache(memoryCache, _messureKey);
            MessureType = new MessureTypeCache(memoryCache, _messureTypeKey);
        }

    }
}
