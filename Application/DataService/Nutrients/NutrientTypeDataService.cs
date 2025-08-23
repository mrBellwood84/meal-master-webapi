using Application.CacheService.Interfaces;
using Domain.Nutrients;
using Persistence.DbServices.Interfaces;

namespace Application.DataService.Nutrients
{
    public class NutrientTypeDataService : BaseDataServiceReadOnly<NutrientType>
    {
        public NutrientTypeDataService(
            ICacheService<NutrientType> cacheService,
            IDbServiceReadOnly<NutrientType> dbService)
            : base(cacheService, dbService) { }
    }
}
