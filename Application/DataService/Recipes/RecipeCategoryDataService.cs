using Application.CacheService;
using Domain.Recipes;
using Persistence.DbService;

namespace Application.DataService.Recipes
{
    public class RecipeCategoryDataService : BaseDataServiceReadOnly<RecipeCategory>
    {
        public RecipeCategoryDataService(
            ICacheService<RecipeCategory> cahceService, 
            IDbServiceReadOnly<RecipeCategory> dbService) 
            : base(cahceService, dbService) { }
    }
}
