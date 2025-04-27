using Dapper;
using Domain.Recipes;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbService.Recipe
{
    public class RecipeCountryOrginDbService : DbConnection, IDbServiceReadAllOnly<RecipeCountryOrgin>
    {
        public RecipeCountryOrginDbService(IConfiguration config) : base(config) { }

        public async Task<List<RecipeCountryOrgin>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL RecipeCountryOrginSelectAll ()";
            var result = await conn.QueryAsync<RecipeCountryOrgin>(query);
            
            return result.ToList();
        }
    }
}
