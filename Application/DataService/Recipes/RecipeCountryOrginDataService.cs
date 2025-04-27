using Application.CacheService;
using Domain.Recipes;
using Persistence.DbService;

namespace Application.DataService.Recipes
{
    public class RecipeCountryOrginDataService : DataServiceReadAllOnly<RecipeCountryOrgin>
    {
        public RecipeCountryOrginDataService(
            ICacheService<RecipeCountryOrgin> cahceService, 
            IDbServiceReadAllOnly<RecipeCountryOrgin> dbService) 
            : base(cahceService, dbService) { }
    }
}
