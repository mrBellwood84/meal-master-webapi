using Application.CacheService;
using Domain.Messures;
using Persistence.DbService.Messures;

namespace Application.DataService.Messures
{
    public class MessureDataService : IDataSubService<Messure>
    {
        private readonly ICacheSubService<Messure> _cache;
        private readonly MessureDbService _dbService;

        public MessureDataService(ICacheSubService<Messure> cache, MessureDbService dbService)
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
