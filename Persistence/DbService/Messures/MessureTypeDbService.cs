using Dapper;
using Domain.Messures;
using Microsoft.Extensions.Configuration;
using Persistence.Exceptions;
using Persistence.QueryModels;

namespace Persistence.DbService.Messures
{
    public class MessureTypeDbService : DbConnection, IDbQuery<MessureType, EmptyModel>
    {
        public MessureTypeDbService(IConfiguration config) : base(config) { }

        public async Task<List<MessureType>> GetAllAsync()
        {
            using var conn = CreateConnection();

            var query = "CALL MessureTypeSelectAll()";
            var result = (await conn.QueryAsync<MessureType>(query)).ToList();

            return result;
        }

        public Task<MessureType> GetByIdAsync(string id)
        {
            throw new NoDatabaseActionException();
        }

        public Task<List<MessureType>> QueryAsync(EmptyModel queryData)
        {
            throw new NoDatabaseActionException();
        }
    }
}
 