using Domain.Messures;
using Microsoft.Extensions.Configuration;
using Persistence.DbServices;

namespace Persistence.DbService.Messures
{
    /// <summary>
    /// Provides database access functionality for retrieving <see cref="Messure"/> entities in a read-only manner.
    /// </summary>
    public class MessureDbService : DbServiceReadOnly<Messure>
    {
        public MessureDbService(IConfiguration config) : base(config)
        {
            Query = "CALL MessureSelectAll()";
        }
    }
}
