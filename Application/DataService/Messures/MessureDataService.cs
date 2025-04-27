using Application.CacheService;
using Domain.Messures;
using Persistence.DbService;

namespace Application.DataService.Messures
{
    public class MessureDataService : DataServiceReadAllOnly<Messure>
    {
        public MessureDataService(
            ICacheService<Messure> cahceService, 
            IDbServiceReadAllOnly<Messure> dbService) 
            : base(cahceService, dbService) { }
    }
}
