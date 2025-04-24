using Microsoft.Extensions.Caching.Memory;

namespace Application.CacheService
{
    public class BaseCasheSubService
    {
        private readonly int _timeout = 300;

        internal MemoryCacheEntryOptions CreateOptions()
        {
            return new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(_timeout));
        }
    }
}
