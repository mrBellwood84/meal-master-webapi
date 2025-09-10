using Dapper;
using Domain.Recipes.DTOs;
using Microsoft.Extensions.Configuration;
using Persistence.DbService;

namespace Persistence.DbServices.Recipes
{
    public class RecipeDbService : DbConnection
    {
        public RecipeDbService(IConfiguration config) : base(config) { }

        public async Task<List<RecipeMinimalDataDTO>> GetAllMinimalDataAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL RecipeSelectAllMinimalData ()";
            var result = await conn.QueryAsync<RecipeMinimalDataDTO>(query);
            return result.ToList();
        }
    }
}
