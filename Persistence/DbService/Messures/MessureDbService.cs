using Dapper;
using Domain.Messures;
using Domain.Misc;
using Microsoft.Extensions.Configuration;
using Persistence.Exceptions;

namespace Persistence.DbService.Messures
{
    public class MessureDbService : DbConnection, IDbServiceReadAllOnly<Messure>
    {
        public MessureDbService(IConfiguration config) : base(config) { }

        public async Task<List<Messure>> GetAllAsync()
        {
            using var conn = CreateConnection();

            var sql = "CALL MessureSelectAll ()";
            var result = await conn.QueryAsync<Messure, MessureType, Messure>(sql, (m, mt) =>
            {
                m.MessureType = mt;
                return m;
            }, splitOn: "MessureTypeId");

            return result.ToList();
        }
    }
}
