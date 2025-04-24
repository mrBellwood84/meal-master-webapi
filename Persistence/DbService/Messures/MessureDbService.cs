using Dapper;
using Domain.Messures;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbService.Messures
{
    public class MessureDbService : DbConnection, IDbSubService<Messure>
    {
        public MessureDbService(IConfiguration config) : base(config) { }

        public async Task<List<Messure>> GetAllAsync()
        {
            using var conn = CreateConnection();

            var sql = "CALL MessureSelectAll ()";
            var result = await conn.QueryAsync<Messure, MessureType, Messure>(sql, (m, mt) =>
            {
                m.Type = mt;
                return m;
            }, splitOn: "MessureTypeId");

            return result.ToList();
        }
    }
}
