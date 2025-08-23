using Application.CacheService.Interfaces;
using Domain.Messures;
using Persistence.DbServices.Interfaces;

namespace Application.DataService.Messures
{
    public class MessureTypeDataService : BaseDataServiceReadOnly<MessureType>
    {
        public MessureTypeDataService(
            ICacheService<MessureType> cahceService,
            IDbServiceReadOnly<MessureType> dbService)
            : base(cahceService, dbService) { }
    }
}
