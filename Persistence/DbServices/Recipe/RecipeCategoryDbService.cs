using Dapper;
using Domain.Recipes;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbService.Recipe
{
    public class RecipeCategoryDbService : DbConnection, IDbServiceReadOnly<RecipeCategory>
    {
        public RecipeCategoryDbService(IConfiguration config) : base(config) { }

        public async Task<List<RecipeCategory>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL RecipeCategorySelectAll ()";
            var result = await conn.QueryAsync<RecipeCategory>(query);
            return result.ToList();
        }
    }
}
