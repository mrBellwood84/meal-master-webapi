using Application.CacheService.Interfaces;
using Domain.Recipes;
using Persistence.DbServices.Interfaces;

namespace Application.DataService.Recipes
{
    public class RecipeCategoryDataService : BaseDataServiceReadOnly<RecipeCategory>
    {
        public RecipeCategoryDataService(
            ICacheService<RecipeCategory> cacheService,
            IDbServiceReadOnly<RecipeCategory> dbService)
            : base(cacheService, dbService) { }
    }
}
