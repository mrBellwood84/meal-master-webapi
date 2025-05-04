using Dapper;
using Domain.Messures;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbService.Messures
{
    public class MessureDbService : DbConnection, IDbServiceReadOnly<Messure>
    {
        public MessureDbService(IConfiguration config) : base(config) { }

        public async Task<List<Messure>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL MessureSelectAll ()";
            var result = await conn.QueryAsync<Messure>(query);
            return result as List<Messure>;
        }
    }
}
