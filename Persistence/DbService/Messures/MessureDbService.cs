using Dapper;
using Domain.Messures;
using Microsoft.Extensions.Configuration;
using Persistence.Exceptions;
using Persistence.QueryModels;

namespace Persistence.DbService.Messures
{
    public class MessureDbService : DbConnection, IDbQuery<Messure, EmptyModel>
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
        public Task<Messure> GetByIdAsync(string id)
        {
            throw new NoDatabaseActionException();
        }

        public Task<List<Messure>> QueryAsync(EmptyModel queryData)
        {
            throw new NoDatabaseActionException();
        }
    }
}
