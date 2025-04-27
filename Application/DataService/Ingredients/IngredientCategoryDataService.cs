using Application.CacheService;
using Domain.Ingredients;
using Persistence.DbService;

namespace Application.DataService.Ingredients
{
    public class IngredientCategoryDataService : DataServiceReadAllOnly<IngredientCategory>
    {
        public IngredientCategoryDataService(
            ICacheService<IngredientCategory> cacheService, 
            IDbServiceReadAllOnly<IngredientCategory> dbService ) 
            : base(cacheService, dbService) { }
    }
}
