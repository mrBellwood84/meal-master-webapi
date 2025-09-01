using Application.CacheService.Interfaces;
using Domain.Measures;
using Persistence.DbServices.Interfaces;

namespace Application.DataService.Measures
{
    public class MeasureDataService : BaseDataServiceReadOnly<Measure>
    {
        public MeasureDataService(
            ICacheService<Measure> cahceService,
            IDbServiceReadOnly<Measure> dbService)
            : base(cahceService, dbService) { }
    }
}
