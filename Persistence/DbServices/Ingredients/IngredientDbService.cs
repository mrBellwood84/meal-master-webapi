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

            var result = await conn.QueryAsync<Ingredient, IngredientMeasure, IngredientCategory, IngredientNutrient, Source, Ingredient>(
                query,
                (i, im, ic, ni, s) =>
                {
                    i.Measures.Add(im);
                    i.Categories.Add(ic);
                    i.Nutrients.Add(ni);
                    i.NutrientSource = s;
                    return i;
                },
                splitOn: "Id");

            var grouped = result.GroupBy(x => x.Id).Select(g =>
            {
                var item = g.First();
                item.Measures = g.Select(i => i.Measures.Single()).DistinctBy(x => x.Id).ToList();
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

            var result = await conn.QueryAsync<Ingredient, IngredientMeasure, IngredientCategory, IngredientNutrient, Source, Ingredient>(
                query,
                (i, im, ic, ni, s) =>
                {
                    i.Measures.Add(im);
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
                item.Measures = g.Select(i => i.Measures.Single()).DistinctBy(x => x.Id).ToList();
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

        public async Task AddIngredientMeasureAsync(string Id, string IngredientId, string MeasureId, float Quantity)
        {
            using var conn = CreateConnection();
            var command = "CALL IngredientAddMeasure(@Id, @IngredientId, @MeasureId, @Quantity)";
            var result = await conn.ExecuteAsync(command, new { Id, IngredientId, MeasureId, Quantity });
        }

        public async Task EditIngredientMeasureAsync(string Id, float Quantity)
        {
            using var conn = CreateConnection();
            var command = "CALL IngredientEditMeasure (@Id, @Quantity)";
            var result = await conn.ExecuteAsync(command, new { Id, Quantity });
        }

        public async Task RemoveIngredientMeasureAsync(string Id)
        {
            using var conn = CreateConnection();
            var command = "CALL IngredientRemoveMeasure (@Id)";
            var result = await conn.ExecuteAsync(command, new { Id });
        }
    }
}
