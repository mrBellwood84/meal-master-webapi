using Application.CacheService;
using Domain.Messures;
using Persistence.DbService;

namespace Application.DataService.Messures
{
    public class MessureTypeDataService : DataServiceReadAllOnly<MessureType>
    {
        public MessureTypeDataService(
            ICacheService<MessureType> cahceService, 
            IDbServiceReadAllOnly<MessureType> dbService) 
            : base(cahceService, dbService) { }
    }
}

