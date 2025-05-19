using Dapper;
using Domain.Ingredients;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbService.Ingredients
{
    public class IngredientCategoryDbService : DbConnection, IDbServiceReadOnly<IngredientCategory>
    {
        public IngredientCategoryDbService(IConfiguration config) : base(config) { }

        public async Task<List<IngredientCategory>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL IngredientCategorySelectAll()";
            var result = await conn.QueryAsync<IngredientCategory>(query);
            return result.ToList();
        }
    }
}
