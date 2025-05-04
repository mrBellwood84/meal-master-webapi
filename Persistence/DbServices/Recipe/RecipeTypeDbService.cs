using Dapper;
using Domain.Recipes;
using Microsoft.Extensions.Configuration;
using Persistence.DbService;

namespace Persistence.DbServices.Recipe
{
    public class RecipeTypeDbService : DbConnection, IDbServiceReadOnly<RecipeType>
    {
        public RecipeTypeDbService(IConfiguration config) : base(config) { }

        public async Task<List<RecipeType>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL RecipeTypeSelectAll ()";
            var result = await conn.QueryAsync<RecipeType>(query);
            return result.ToList();
        }
    }
}
