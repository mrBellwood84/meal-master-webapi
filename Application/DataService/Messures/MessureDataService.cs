using Application.CacheService.Interfaces;
using Domain.Messures;
using Persistence.DbServices.Interfaces;

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
