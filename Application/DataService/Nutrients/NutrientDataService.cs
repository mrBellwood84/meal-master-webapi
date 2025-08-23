using Application.CacheService.Interfaces;
using Domain.Nutrients;
using Persistence.DbServices.Interfaces;

namespace Application.DataService.Nutrients
{
    public class NutrientDataService : BaseDataServiceReadOnly<Nutrient>
    {
        public NutrientDataService(
            ICacheService<Nutrient> cacheService,
            IDbServiceReadOnly<Nutrient> dbService)
            : base(cacheService, dbService) { }
    }
}
