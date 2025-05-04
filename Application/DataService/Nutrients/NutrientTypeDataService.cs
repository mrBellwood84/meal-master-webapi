using Application.CacheService;
using Domain.Nutrients;
using Persistence.DbService;

namespace Application.DataService.Nutrients
{
    public class NutrientTypeDataService : BaseDataServiceReadOnly<NutrientType>
    {
        public NutrientTypeDataService(
            ICacheService<NutrientType> cahceService, 
            IDbServiceReadOnly<NutrientType> dbService) 
            : base(cahceService, dbService) { }
    }
}
