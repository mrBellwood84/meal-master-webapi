using Application.CacheService;
using Domain.Messures;
using Persistence.DbService;

namespace Application.DataService.Messures
{
    public class MessureDataService : IDataSubService<Messure>
    {
        private readonly ICacheSubService<Messure> _cache;
        private readonly IDbSubService<Messure> _dbService;

        public MessureDataService(ICacheSubService<Messure> cache, IDbSubService<Messure> dbService)
        {
            _cache = cache;
            _dbService = dbService;
        }

        public async Task<List<Messure>> GetAllAsync()
        {
            var cachedData = _cache.Get();
            if (cachedData != null) return cachedData;

            var data = await _dbService.GetAllAsync();
            _cache.Set(data);
            
            return data;
        }
    }
}
