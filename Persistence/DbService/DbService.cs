using Microsoft.Extensions.Configuration;
using Persistence.DbService.Messures;

namespace Persistence.DbService
{
    public class DbService : IDbService
    {
        public MessureDbService Messure { get; set; }
        public MessureTypeDbService MessureType{ get; set; }

        public DbService(IConfiguration config)
        {
            Messure = new MessureDbService(config);
            MessureType  = new MessureTypeDbService(config);
        }
    }
}
