using Dapper;
using Domain.Ingredients;
using Domain.Messures;
using Domain.Misc;
using Domain.Nutrients;
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
            var ingredientDict = new Dictionary<string, Ingredient>();
            var categories = new List<string>();

            var result = await conn.QueryAsync<Ingredient, Messure, IngredientCategory, NutrientIngredient, Source, Ingredient>(
                query,
                (i, m, ic, ni, s) =>
                {
                    var ic_key = i.Id + ic.Id;
                    bool has_ic = false;

                    if (ingredientDict.TryGetValue(i.Id, out var existIngred)) i = existIngred;
                    else ingredientDict.Add(i.Id, i);

                    if (categories.Contains(ic_key)) has_ic = true;
                    else categories.Add(ic_key);

                    i.Messure = m;
                    if (!has_ic) i.Categories.Add(ic);
                    i.Nutrients.Add(ni);
                    i.NutrientSource = s;
                    return i;
                },
                splitOn: "Id");
            return result.ToList();
        }

        public async Task<Ingredient> GetOneByIdAsync(string Id)
        {
            using var conn = CreateConnection();
            var query = "CALL IngredientSelectSingleById ( @Id )";
            var ingredientDict = new Dictionary<string, Ingredient>();
            var categories = new List<string>();

            var result = await conn.QueryAsync<Ingredient, Messure, IngredientCategory, NutrientIngredient, Source, Ingredient>(
                query,
                (i, m, ic, ni, s) =>
                {
                    var ic_key = i.Id + ic.Id;
                    bool has_ic = false;

                    if (ingredientDict.TryGetValue(i.Id, out var existIngred)) i = existIngred;
                    else ingredientDict.Add(i.Id, i);

                    if (categories.Contains(ic_key)) has_ic = true;
                    else categories.Add(ic_key);

                    i.Messure = m;
                    if (!has_ic) i.Categories.Add(ic);
                    i.Nutrients.Add(ni);
                    i.NutrientSource = s;
                    return i;
                },
                new { Id },
                splitOn: "Id");
            if (result.Count() > 0) return result.First();
            return null;


        }
    }
}
