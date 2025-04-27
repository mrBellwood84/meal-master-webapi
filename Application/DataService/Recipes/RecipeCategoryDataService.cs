using Application.CacheService;
using Domain.Recipes;
using Persistence.DbService;

namespace Application.DataService.Recipes
{
    public class RecipeCategoryDataService : DataServiceReadAllOnly<RecipeCategory>
    {
        public RecipeCategoryDataService(
            ICacheService<RecipeCategory> cahceService, 
            IDbServiceReadAllOnly<RecipeCategory> dbService) 
            : base(cahceService, dbService) { }
    }
}
