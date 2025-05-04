using Application.CacheService;
using Domain.Messures;
using Persistence.DbService;

namespace Application.DataService.Messures
{
    public class MessureDataService : BaseDataServiceReadOnly<Messure>
    {
        public MessureDataService(
            ICacheService<Messure> cahceService, 
            IDbServiceReadOnly<Messure> dbService) 
            : base(cahceService, dbService) { }
    }
}
