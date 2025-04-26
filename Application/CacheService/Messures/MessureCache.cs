using Domain.Messures;
using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService.Messures
{
    public class MessureCache : BaseCasheSubService, ICacheSubService<Messure>
    {
        private readonly IMemoryCache _cache;
        private readonly string _key;

        public MessureCache(IMemoryCache cache, string key)
        {
            _cache = cache;
            _key = key;
        }

        public void Set(List<Messure> messures)
        {
            var options = CreateOptions();
            _cache.Set(_key, messures, options);
        }

        public List<Messure>? Get()
        {
            var result = _cache.Get<List<Messure>>(_key);
            return result;
        }

        public void Clear()
        {
            _cache.Remove(_key);
        }

    }
}
