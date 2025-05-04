using Dapper;
using Domain.Nutrients;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbService.Nutrients
{
    public class NutrientTypeDbService : DbConnection, IDbServiceReadOnly<NutrientType>
    {
        public NutrientTypeDbService(IConfiguration config) : base(config) { }

        public async Task<List<NutrientType>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL NutrientTypeSelectAll ()";
            var result = await conn.QueryAsync<NutrientType>(query);
            return result.ToList();
        }
    }
}
