
using Application.CacheService;
using Application.DataService.Messures;
using Persistence.DbService;

namespace Application.DataService
{
    public class DataService : IDataService
    {
        public MessureDataService Messure { get; set; }
        public MessureTypeDataService MessureType { get; set; }

        public DataService(ICacheService cache, IDbService dbSevice)
        {
            Messure = new MessureDataService(cache.Messure, dbSevice.Messure);
            MessureType = new MessureTypeDataService(cache.MessureType, dbSevice.MessureType);
        }
    }
}
