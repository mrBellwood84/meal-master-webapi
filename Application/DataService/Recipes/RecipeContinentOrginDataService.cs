using Application.CacheService;
using Domain.Recipes;
using Persistence.DbService;

namespace Application.DataService.Recipes
{
    public class RecipeContinentOrginDataService : DataServiceReadAllOnly<RecipeContinentOrgin>
    {
        public RecipeContinentOrginDataService(
            ICacheService<RecipeContinentOrgin> cahceService, 
            IDbServiceReadAllOnly<RecipeContinentOrgin> dbService) 
            : base(cahceService, dbService) { }
    }
}
