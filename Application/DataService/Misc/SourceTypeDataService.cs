using Application.CacheService.Interfaces;
using Domain.Misc;
using Persistence.DbServices.Interfaces;

namespace Application.DataService.Misc
{
    public class SourceTypeDataService : BaseDataServiceReadOnly<SourceType>
    {
        public SourceTypeDataService(
            ICacheService<SourceType> cacheService, 
            IDbServiceReadOnly<SourceType> dbService) 
            : base(cacheService, dbService) { }
    }
}
