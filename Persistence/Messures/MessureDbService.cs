using Dapper;
using Domain.Messures;
using Persistence.DbService;
using System.Security.Cryptography.X509Certificates;


namespace Persistence.Messures
{
    public class MessureDbService : BaseDbService, IMessureDbService
    {
        public MessureDbService(IDbConnection connection) : base(connection)
        {
        }

        public async Task<List<Messure>> GetAll()
        {
            using var conn = _connection.CreateConnection();

            var sql = "SELECT m.id, fullname, shortname, relativesize, m.messuretypeid, mt.id, type FROM messure AS m JOIN messuretype AS mt ON m.messuretypeid = mt.id";
            var result = await conn.QueryAsync<Messure, MessureType, Messure>(sql, (m, mt) =>
            {
                m.Type = mt;
                return m;
            }, splitOn: "MessureTypeId");

            return result.ToList();
        }
    }
}
