using Application.CacheService;
using Domain.Ingredients;
using Persistence.DbServices.Ingredients;

namespace Application.DataService.Ingredients
{
    public class IngredientDataService : IIngredientDataService
    {
        private readonly ICacheService<Ingredient> _cache;
        private readonly IIngredientDbService _dbService;

        public IngredientDataService(ICacheService<Ingredient> cache, IIngredientDbService dbService)
        {
            _cache = cache;
            _dbService = dbService;
        }

        public async Task<List<Ingredient>> GetAllAsync()
        {
            var cachedData = _cache.Get();
            if (cachedData != null) return cachedData;

            var data = await _dbService.GetAllAsync();
            _cache.Set(data);

            return data;
        }

        public async Task<Ingredient> GetOneByIdAsync(string Id)
        {
            var data = await _dbService.GetOneByIdAsync(Id);
            return data;
        }
    }
}
