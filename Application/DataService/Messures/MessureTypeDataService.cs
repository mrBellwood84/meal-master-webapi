using Application.CacheService;
using Domain.Messures;
using Persistence.DbService;
using Persistence.DbService.Messures;

namespace Application.DataService.Messures
{
    public class MessureTypeDataService : IDataSubService<MessureType>
    {
        private readonly CacheSubService<MessureType> _cache;
        private readonly MessureTypeDbService _dbService;

        public MessureTypeDataService(CacheSubService<MessureType> cache, MessureTypeDbService dbService)
        {
            _cache = cache;
            _dbService = dbService;
        }

        public async Task<List<MessureType>> GetAllAsync()
        {
            var cachedData = _cache.Get();
            if (cachedData != null) return cachedData;

            var data = await _dbService.GetAllAsync();
            _cache.Set(data);
            return data;
        }
    }
}
