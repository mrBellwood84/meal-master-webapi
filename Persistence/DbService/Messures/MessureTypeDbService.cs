using Dapper;
using Domain.Messures;
using Domain.Misc;
using Microsoft.Extensions.Configuration;
using Persistence.Exceptions;

namespace Persistence.DbService.Messures
{
    public class MessureTypeDbService : DbConnection, IDbServiceReadAllOnly<MessureType>
    {
        public MessureTypeDbService(IConfiguration config) : base(config) { }

        public async Task<List<MessureType>> GetAllAsync()
        {
            using var conn = CreateConnection();

            var query = "CALL MessureTypeSelectAll()";
            var result = await conn.QueryAsync<MessureType>(query);

            return result.ToList();
        }
    }
}
 