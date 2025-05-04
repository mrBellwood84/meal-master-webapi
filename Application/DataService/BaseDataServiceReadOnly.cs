using Application.CacheService;
using Persistence.DbService;

namespace Application.DataService
{
    /// <summary>
    /// Base class for cached data services that only serve lists of data.
    /// Db data is usually static or rarerly added or changed.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public class BaseDataServiceReadOnly<TModel> : IDataServiceReadOnly<TModel>
    {
        private readonly ICacheService<TModel> _cacheService;

        private readonly IDbServiceReadOnly<TModel> _dbService;

        public BaseDataServiceReadOnly(ICacheService<TModel> cahceService, IDbServiceReadOnly<TModel> dbService)
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
