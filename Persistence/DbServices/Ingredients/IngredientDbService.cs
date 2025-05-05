using Dapper;
using Domain.Ingredients;
using Domain.Messures;
using Domain.Misc;
using Domain.Nutrients;
using Microsoft.Extensions.Configuration;
using Persistence.DbService;
using System.Net.Http.Headers;

namespace Persistence.DbServices.Ingredients
{
    public class IngredientDbService : DbConnection, IIngredientDbService
    {
        public IngredientDbService(IConfiguration config) : base(config) { }

        public async Task<List<Ingredient>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL IngredientSelectAll ()";

            var result = await conn.QueryAsync<Ingredient, Messure, IngredientCategory, NutrientIngredient, Source, Ingredient>(
                query,
                (i, m, ic, ni, s) =>
                {
                    i.Messure = m;
                    i.Categories.Add(ic);
                    i.Nutrients.Add(ni);
                    i.NutrientSource = s;
                    return i;
                },
                splitOn: "Id");

            var grouped = result.GroupBy(x => x.Id).Select(g =>
            {
                var item = g.First();
                item.Categories = g.Select(i => i.Categories.Single()).DistinctBy(x => x.Id).ToList();
                item.Nutrients = g.Select(i => i.Nutrients.Single()).DistinctBy(x => x.Id).ToList();
                return item;
            });

            return grouped.ToList();
        }

        public async Task<Ingredient> GetOneByIdAsync(string Id)
        {
            using var conn = CreateConnection();
            var query = "CALL IngredientSelectSingleById ( @Id )";

            var result = await conn.QueryAsync<Ingredient, Messure, IngredientCategory, NutrientIngredient, Source, Ingredient>(
                query,
                (i, m, ic, ni, s) =>
                {
                    i.Messure = m;
                    i.Categories.Add(ic);
                    i.Nutrients.Add(ni);
                    i.NutrientSource = s;
                    return i;
                },
                new { Id },
                splitOn: "Id");

            var grouped = result.GroupBy(x => x.Id).Select(g =>
            {
                var item = g.First();
                item.Categories = g.Select(i => i.Categories.Single()).DistinctBy(x => x.Id).ToList();
                item.Nutrients = g.Select(i => i.Nutrients.Single()).DistinctBy(x => x.Id).ToList();
                return item;
            }).ToList();

            if (grouped.Count()  > 0) return grouped.First();
            return null;
        }
    }
}
