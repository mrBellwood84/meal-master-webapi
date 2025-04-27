using Application.CacheService;
using Persistence.DbService;

namespace Application.DataService
{
    /// <summary>
    /// Base class for cached data services that only serve lists of data.
    /// Db data is usually static or rarerly added or changed.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public class DataServiceReadAllOnly<TModel> : IDataServiceReadAllOnly<TModel>
    {
        private readonly ICacheService<TModel> _cacheService;

        private readonly IDbServiceReadAllOnly<TModel> _dbService;

        public DataServiceReadAllOnly(ICacheService<TModel> cahceService, IDbServiceReadAllOnly<TModel> dbService)
        {
            _cacheService = cahceService;
            _dbService = dbService;
        }

        public async Task<List<TModel>> GetAllAsync()
        {
            var cachedData = _cacheService.Get();
            if (cachedData != null) return cachedData;

            var data = await _dbService.GetAllAsync();
            _cacheService.Set(data);

            return data;
        }
    }
}
