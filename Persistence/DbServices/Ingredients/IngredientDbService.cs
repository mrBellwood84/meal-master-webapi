using Dapper;
using Domain.Ingredients;
using Domain.Misc;
using Microsoft.Extensions.Configuration;
using Persistence.DbService;
using Persistence.DbServices.Ingredients.Interfaces;

namespace Persistence.DbServices.Ingredients
{
    /// <summary>
    /// Provides database operations for managing ingredients, including retrieval, updates, and associations with
    /// categories, measures, and nutrients.
    /// </summary>
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

        public async Task UpdateNamesAsync(string Id, string Name, string NamePlural)
        {
            using var conn = CreateConnection();
            var command = "CALL UpdateIngredientNames(@Id, @Name, @NamePlural)";
            var result = await conn.ExecuteAsync(command, new { Id, Name, NamePlural });
        }

        public async Task AddCategoryAsync(string IngredientId, string CategoryId)
        {
            using var conn = CreateConnection();
            var command = "CALL IngredientAddCategory(@IngredientId, @CategoryId)";
            var result = await conn.ExecuteAsync(command, new { IngredientId, CategoryId });
        }

        public async Task RemoveCategoryAsync(string IngredientId, string CategoryId)
        {
            using var conn = CreateConnection();
            var command = "CALL IngredientRemoveCategory(@IngredientId, @CategoryId)";
            var result = await conn.ExecuteAsync(command, new { IngredientId, CategoryId });
        }

        public async Task AddIngredientMessureAsync(string Id, string IngredientId, string MessureId, float Quantity)
        {
            using var conn = CreateConnection();
            var command = "CALL IngredientAddMessure(@Id, @IngredientId, @MessureId, @Quantity)";
            var result = await conn.ExecuteAsync(command, new { Id, IngredientId, MessureId, Quantity });
        }

        public async Task EditIngredientMessureAsync(string Id, float Quantity)
        {
            using var conn = CreateConnection();
            var command = "CALL IngredientEditMessure (@Id, @Quantity)";
            var result = await conn.ExecuteAsync(command, new { Id, Quantity });
        }

        public async Task RemoveIngredientMessureAsync(string Id)
        {
            using var conn = CreateConnection();
            var command = "CALL IngredientRemoveMessure (@Id)";
            var result = await conn.ExecuteAsync(command, new { Id });
        }
    }
}
