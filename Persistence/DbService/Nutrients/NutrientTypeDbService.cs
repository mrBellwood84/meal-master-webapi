using Dapper;
using Domain.Messures;
using Domain.Misc;
using Domain.Nutrients;
using Microsoft.Extensions.Configuration;
using Persistence.Exceptions;

namespace Persistence.DbService.Nutrients
{
    public class NutrientTypeDbService : DbConnection, IDbServiceReadAllOnly<NutrientType>
    {
        public NutrientTypeDbService(IConfiguration config) : base(config) { }

        public async Task<List<NutrientType>> GetAllAsync()
        {
            using var conn = CreateConnection();

            var sql = "CALL NutrientTypeSelectAll";
            var result = await conn.QueryAsync<NutrientType, Messure, MessureType, NutrientType>(sql, (nt, m, mt) =>
            {
                nt.Messure = m;
                m.MessureType = mt;
                return nt;
            }, splitOn: "Id");

            return result.ToList();
        }
    }
}
