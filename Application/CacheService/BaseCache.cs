using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService
{
    public class BaseCache
    {
        private readonly int _timeout;

        internal MemoryCacheEntryOptions CreateOptions()
        {
            return new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(_timeout));
        }
    }
}
