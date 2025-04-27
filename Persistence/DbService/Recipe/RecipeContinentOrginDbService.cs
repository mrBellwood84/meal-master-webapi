using Dapper;
using Domain.Recipes;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbService.Recipe
{
    public class RecipeContinentOrginDbService : DbConnection, IDbServiceReadAllOnly<RecipeContinentOrgin>
    {
        public RecipeContinentOrginDbService(IConfiguration config) : base(config) { }

        public async Task<List<RecipeContinentOrgin>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL RecipeContinentOrginSelectAll ()";
            var result = await conn.QueryAsync<RecipeContinentOrgin>(query);

            return result.ToList();
        }
    }
}
