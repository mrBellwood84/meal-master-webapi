using Application.CacheService.Interfaces;
using Application.DataService.Ingredients.Interfaces;
using Domain.Ingredients;
using Domain.Ingredients.DTOs;
using Persistence.DbServices.Ingredients.Interfaces;

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

        public async Task UpdateNamesAsync(IngredientUpdateNameDTO dto)
        {
            await _dbService.UpdateNamesAsync(dto.Id, dto.Name, dto.NamePlural);
            _cache.Clear();
        }

        public async Task AddIngredientCategoryAsync(IngredientCategoryUpdateDTO dto)
        {
            await _dbService.AddCategoryAsync(dto.IngredientId, dto.CategoryId);
            _cache.Clear();
        }

        public async Task RemoveIngredientCategoryAsync(IngredientCategoryUpdateDTO dto)
        {
            await _dbService.RemoveCategoryAsync(dto.IngredientId, dto.CategoryId);
            _cache.Clear();
        }

        public async Task AddIngredientMessureAsync(IngredientMessureUpdateDTO dto)
        {
            await _dbService.AddIngredientMessureAsync(dto.Id, dto.IngredientId, dto.MessureId, dto.Quantity);
            _cache.Clear();
        }

        public async Task EditIngredientMessureAsync(IngredientMessureUpdateDTO dto)
        {
            await _dbService.EditIngredientMessureAsync(dto.Id, dto.Quantity);
            _cache.Clear();
        }

        public async Task RemoveIngredientMessureAsync(string Id)
        {
            await _dbService.RemoveIngredientMessureAsync(Id);
            _cache.Clear();
        }


    }
}
