using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService
{
    public class CacheService<TModel> : ICacheService<TModel>
    {
        private readonly int _timeout = 300;

        private readonly IMemoryCache _cache;

        public string Key { get; set; } = string.Empty;

        public CacheService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void Set(List<TModel> data) => _cache.Set(data, Key, CreateOptions());

        public List<TModel>? Get() => _cache.Get<List<TModel>>(Key);

        public void Clear() => _cache.Remove(Key);

        private MemoryCacheEntryOptions CreateOptions()
        {
            return new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(_timeout));
        }
    }
}
