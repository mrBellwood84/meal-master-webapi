using Microsoft.Extensions.Configuration;
using Persistence.DbService.Messures;

namespace Persistence.DbService
{
    public class DbService : IDbService
    {
        public MessureDbService MessureDbService { get; set; }
        public MessureTypeDbService MessureTypeDbService { get; set; }

        public DbService(IConfiguration config)
        {
            MessureDbService = new MessureDbService(config);
            MessureTypeDbService  = new MessureTypeDbService(config);
        }
    }
}
