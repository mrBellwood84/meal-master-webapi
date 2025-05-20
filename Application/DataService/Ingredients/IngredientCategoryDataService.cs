using Application.CacheService;
using Domain.Ingredients;
using Persistence.DbService;

namespace Application.DataService.Ingredients
{
    public class IngredientCategoryDataService : BaseDataServiceReadOnly<IngredientCategory>
    {
        public IngredientCategoryDataService(
            ICacheService<IngredientCategory> cacheService,
            IDbServiceReadOnly<IngredientCategory> dbService)
            : base(cacheService, dbService) { }
    }
}
