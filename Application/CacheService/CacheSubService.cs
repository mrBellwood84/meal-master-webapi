using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService
{
    public class CacheSubService<TModel>
    {
        private readonly int _timeout = 300;

        private readonly IMemoryCache _cache;
        private readonly string _key;

        public CacheSubService(IMemoryCache cache, string key)
        {
            _cache = cache;
            _key = key;
        }

        public void Set(List<TModel> data) => _cache.Set(_key, data, CreateOptions());

        public List<TModel>? Get() => _cache.Get<List<TModel>>(_key);

        public void Clear() => _cache.Remove(_key);

        private MemoryCacheEntryOptions CreateOptions()
        {
            return new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(_timeout));
        }
    }
}
