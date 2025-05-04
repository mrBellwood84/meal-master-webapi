using Application.CacheService;
using Domain.Recipes;
using Persistence.DbService;

namespace Application.DataService.Recipes
{
    public class RecipeTypeDataService : BaseDataServiceReadOnly<RecipeType>
    {
        public RecipeTypeDataService(
            ICacheService<RecipeType> cahceService, 
            IDbServiceReadOnly<RecipeType> dbService) 
            : base(cahceService, dbService) { }
    }
}
