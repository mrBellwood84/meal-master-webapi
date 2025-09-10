using Dapper;
using Domain.Measures;
using Microsoft.Extensions.Configuration;
using Persistence.DbServices.Interfaces;

namespace Persistence.DbService.Measures
{
    /// <summary>
    /// Provides database access functionality for retrieving <see cref="Measure"/> entities in a read-only manner.
    /// </summary>
    public class MeasureDbService : DbConnection, IDbServiceReadOnly<Measure>

    {
        public MeasureDbService(IConfiguration config) : base(config) { }

        public async Task<List<Measure>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL MeasureSelectAll()";


            var result = await conn.QueryAsync<Measure, MeasureType, Measure>(query, (messure, type) =>
            {
                messure.Type = type;
                return messure;
            }, splitOn: "Id");

            return result.ToList();

        }
    }
}
