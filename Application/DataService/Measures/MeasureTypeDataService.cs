using Application.CacheService.Interfaces;
using Domain.Measures;
using Persistence.DbServices.Interfaces;

namespace Application.DataService.Measures
{
    public class MeasureTypeDataService : BaseDataServiceReadOnly<MeasureType>
    {
        public MeasureTypeDataService(
            ICacheService<MeasureType> cahceService,
            IDbServiceReadOnly<MeasureType> dbService)
            : base(cahceService, dbService) { }
    }
}
