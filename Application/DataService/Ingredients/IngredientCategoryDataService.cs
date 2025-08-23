using Application.CacheService.Interfaces;
using Domain.Ingredients;
using Persistence.DbServices.Interfaces;

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
