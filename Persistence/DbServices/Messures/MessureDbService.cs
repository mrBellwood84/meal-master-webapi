using Domain.Messures;
using Microsoft.Extensions.Configuration;
using Persistence.DbServices;

namespace Persistence.DbService.Messures
{
    public class MessureDbService : DbServiceReadOnly<Messure>
    {
        public MessureDbService(IConfiguration config) : base(config)
        {
            Query = "CALL MessureSelectAll()";
        }
    }
}
