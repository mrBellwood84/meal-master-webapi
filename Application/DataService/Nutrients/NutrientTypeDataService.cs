using Application.CacheService;
using Domain.Nutrients;
using Persistence.DbService;

namespace Application.DataService.Nutrients
{
    public class NutrientTypeDataService : DataServiceReadAllOnly<NutrientType>
    {
        public NutrientTypeDataService(
            ICacheService<NutrientType> cahceService, 
            IDbServiceReadAllOnly<NutrientType> dbService) 
            : base(cahceService, dbService) { }
    }
}
