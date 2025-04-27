using Domain.Ingredients;
using Domain.Messures;
using Domain.Nutrients;
using Domain.Recipes;
using Persistence.DbService;
using Persistence.DbService.Ingredients;
using Persistence.DbService.Messures;
using Persistence.DbService.Nutrients;
using Persistence.DbService.Recipe;

namespace API.Extensions
{
    public static class DbServiceExtension
    {
        public static IServiceCollection AddDbServices(this IServiceCollection services)
        {
            services.AddTransient<IDbServiceReadAllOnly<IngredientCategory>, IngredientCategoryDbService>();

            services.AddTransient<IDbServiceReadAllOnly<Messure>, MessureDbService>();
            services.AddTransient<IDbServiceReadAllOnly<MessureType>, MessureTypeDbService>();

            services.AddTransient<IDbServiceReadAllOnly<NutrientType>, NutrientTypeDbService>();

            services.AddTransient<IDbServiceReadAllOnly<RecipeCategory>, RecipeCategoryDbService>();
            services.AddTransient<IDbServiceReadAllOnly<RecipeContinentOrgin>,RecipeContinentOrginDbService>();
            services.AddTransient<IDbServiceReadAllOnly<RecipeCountryOrgin>, RecipeCountryOrginDbService>();

            return services;
        }
    }
}
