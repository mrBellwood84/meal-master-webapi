using Dapper;
using Domain.Ingredients;
using Domain.Measures;
using Domain.Misc;
using Domain.Nutrients;
using Microsoft.Extensions.Configuration;
using Persistence.DbService;
using Persistence.DbServices.Ingredients.Interfaces;

namespace Persistence.DbServices.Ingredients
{
    public class IngredientDbService : DbConnection, IIngredientDbService
    {
        public IngredientDbService(IConfiguration config) : base(config) { }

        public async Task<List<Ingredient>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var query = "CALL IngredientSelectAll ()";

            var result = await conn.QueryAsync<Ingredient>(query, new[]
            {
                typeof(Ingredient),
                typeof(IngredientCategory),
                typeof(IngredientMeasure),
                typeof(Measure),
                typeof(MeasureType),
                typeof(IngredientNutrient),
                typeof(Nutrient),
                typeof(Measure),
                typeof(MeasureType),
                typeof(NutrientType),
                typeof(Source),
            }, objects =>
            {
                var ingredient = objects[0] as Ingredient;
                var categories = objects[1] as IngredientCategory;
                var ingredientMeasure = objects[2] as IngredientMeasure;
                var measureIngredientMeasure = objects[3] as Measure;
                var measureTypeIngredientMeasure = objects[4] as MeasureType;
                var ingredientNutrient = objects[5] as IngredientNutrient;
                var nutrient = objects[6] as Nutrient;
                var nutrientMeasure = objects[7] as Measure;
                var nutrientMeasureType = objects[8] as MeasureType;
                var nutrientType = objects[9] as NutrientType;
                var source = objects[10] as Source;

                ingredient.Categories.Add(categories);
                ingredient.Measures.Add(ingredientMeasure);
                ingredientMeasure.Measure = measureIngredientMeasure;
                measureIngredientMeasure.Type = measureTypeIngredientMeasure;
                ingredient.Nutrients.Add(ingredientNutrient);
                ingredientNutrient.Nutrient = nutrient;
                nutrient.Measure = nutrientMeasure;
                nutrientMeasure.Type = nutrientMeasureType;
                nutrient.Type = nutrientType;
                ingredient.NutrientSource = source;

                return ingredient;
            },
            splitOn: "id");

            var grouped = result.GroupBy(x => x.Id).Select(g =>
            {
                var item = g.First();
                item.Categories = g.Select(i => i.Categories.Single()).DistinctBy(x => x.Id).ToList();
                item.Measures = g.Select(i => i.Measures.Single()).DistinctBy(x => x.Id).ToList();
                item.Nutrients = g.Select(i => i.Nutrients.Single()).DistinctBy(x => x.Id).ToList();
                return item;
            });

            return grouped.ToList();
        }

        public async Task<Ingredient> GetOneByIdAsync(string Id)
        {
            using var conn = CreateConnection();
            var query = "CALL IngredientSelectOneById (@Id)";
            var result = await conn.QueryAsync<Ingredient>(query, new[]
            {
                typeof(Ingredient),
                typeof(IngredientCategory),
                typeof(IngredientMeasure),
                typeof(Measure),
                typeof(MeasureType),
                typeof(IngredientNutrient),
                typeof(Nutrient),
                typeof(Measure),
                typeof(MeasureType),
                typeof(NutrientType),
                typeof(Source),
            }, objects =>
            {
                var ingredient = objects[0] as Ingredient;
                var categories = objects[1] as IngredientCategory;
                var ingredientMeasure = objects[2] as IngredientMeasure;
                var measureIngredientMeasure = objects[3] as Measure;
                var measureTypeIngredientMeasure = objects[4] as MeasureType;
                var ingredientNutrient = objects[5] as IngredientNutrient;
                var nutrient = objects[6] as Nutrient;
                var nutrientMeasure = objects[7] as Measure;
                var nutrientMeasureType = objects[8] as MeasureType;
                var nutrientType = objects[9] as NutrientType;
                var source = objects[10] as Source;

                ingredient.Categories.Add(categories);
                ingredient.Measures.Add(ingredientMeasure);
                ingredientMeasure.Measure = measureIngredientMeasure;
                measureIngredientMeasure.Type = measureTypeIngredientMeasure;
                ingredient.Nutrients.Add(ingredientNutrient);
                ingredientNutrient.Nutrient = nutrient;
                nutrient.Measure = nutrientMeasure;
                nutrientMeasure.Type = nutrientMeasureType;
                nutrient.Type = nutrientType;
                ingredient.NutrientSource = source;
                return ingredient;
            },
            new { Id },
            splitOn: "id");

            var grouped = result.GroupBy(x => x.Id).Select(g =>
            {
                var item = g.First();
                item.Categories = g.Select(i => i.Categories.Single()).DistinctBy(x => x.Id).ToList();
                item.Measures = g.Select(i => i.Measures.Single()).DistinctBy(x => x.Id).ToList();
                item.Nutrients = g.Select(i => i.Nutrients.Single()).DistinctBy(x => x.Id).ToList();
                return item;
            }).FirstOrDefault();

            return grouped;
        }
    }
}
