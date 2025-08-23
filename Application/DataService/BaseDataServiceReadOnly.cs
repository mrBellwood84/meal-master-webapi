using Application.CacheService.Interfaces;
using Application.DataService.Interfaces;
using Persistence.DbServices.Interfaces;

namespace Application.DataService
{
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
