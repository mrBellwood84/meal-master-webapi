using Application.CacheService.Interfaces;
using Domain.Recipes;
using Persistence.DbServices.Interfaces;

namespace Application.DataService.Recipes
{
    public class RecipeTypeDataService : BaseDataServiceReadOnly<RecipeType>
    {
        public RecipeTypeDataService(
            ICacheService<RecipeType> cacheService,
            IDbServiceReadOnly<RecipeType> dbService)
            : base(cacheService, dbService) { }
    }
}
