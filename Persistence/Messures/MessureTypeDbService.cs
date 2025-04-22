using Dapper;
using Domain.Messures;
using Persistence.DbService;

namespace Persistence.Messures
{
    public class MessureTypeDbService : BaseDbService, IMessureTypeDbService
    {
        public MessureTypeDbService(IDbConnection connection) : base(connection)
        {
        }

        public async Task<List<MessureType>> GetAll()
        {
            using var conn = _connection.CreateConnection();

            var query = "SELECT * FROM messuretype";
            var result = (await conn.QueryAsync<MessureType>(query)).ToList();

            return result;
        }
    }
}
