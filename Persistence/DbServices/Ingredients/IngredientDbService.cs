using Dapper;
using Domain.Ingredients;
using Domain.Misc;
using Microsoft.Extensions.Configuration;
using Persistence.DbService;

namespace Persistence.DbServices.Ingredients
{
    public class IngredientDbService : DbConnection, IIngredientDbService
    {
        public IngredientDbService(IConfiguration config) : base(config) { }

        public async Task<List<Ingredient>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL IngredientSelectAll ()";

            var result = await conn.QueryAsync<Ingredient, IngredientMessure, IngredientCategory, IngredientNutrient, Source, Ingredient>(
                query,
                (i, im, ic, ni, s) =>
                {
                    i.Messures.Add(im);
                    i.Categories.Add(ic);
                    i.Nutrients.Add(ni);
                    i.NutrientSource = s;
                    return i;
                },
                splitOn: "Id");

            var grouped = result.GroupBy(x => x.Id).Select(g =>
            {
                var item = g.First();
                item.Messures = g.Select(i => i.Messures.Single()).DistinctBy(x => x.Id).ToList();
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

            var result = await conn.QueryAsync<Ingredient, IngredientMessure, IngredientCategory, IngredientNutrient, Source, Ingredient>(
                query,
                (i, im, ic, ni, s) =>
                {
                    i.Messures.Add(im);
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
                item.Messures = g.Select(i => i.Messures.Single()).DistinctBy(x => x.Id).ToList();
                item.Categories = g.Select(i => i.Categories.Single()).DistinctBy(x => x.Id).ToList();
                item.Nutrients = g.Select(i => i.Nutrients.Single()).DistinctBy(x => x.Id).ToList();
                return item;
            }).ToList();

            if (grouped.Count()  > 0) return grouped.First();
            return null;
        }
    }
}
