using Domain.Messures;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Messures
{
    public class MessureTypeCache : BaseCasheSubService, ICacheSubService<MessureType>
    {
        private readonly IMemoryCache _cache;
        private readonly string _key;

        public MessureTypeCache(IMemoryCache cache, string key)
        {
            _cache = cache;
            _key = key;
        }

        public void Set(List<MessureType> messureTypes)
        {
            var options = CreateOptions();
            _cache.Set(_key, messureTypes, options);
        }

        public List<MessureType>? Get()
        {
            var result = _cache.Get<List<MessureType>>(_key);
            return result;
        }

        public void Clear()
        {
            _cache.Remove(_key);
        }
    }
}
