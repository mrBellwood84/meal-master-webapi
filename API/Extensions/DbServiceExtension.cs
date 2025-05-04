using Domain.Ingredients;
using Domain.Messures;
using Domain.Nutrients;
using Domain.Recipes;
using Persistence.DbService;
using Persistence.DbService.Ingredients;
using Persistence.DbService.Messures;
using Persistence.DbService.Nutrients;
using Persistence.DbService.Recipe;
using Persistence.DbServices.Recipe;

namespace API.Extensions
{
    public static class DbServiceExtension
    {
        public static IServiceCollection AddDbServices(this IServiceCollection services)
        {
            // Read only db services
            services.AddTransient<IDbServiceReadOnly<IngredientCategory>, IngredientCategoryDbService>();
            services.AddTransient<IDbServiceReadOnly<Messure>, MessureDbService>();
            services.AddTransient<IDbServiceReadOnly<NutrientType>, NutrientTypeDbService>();
            services.AddTransient<IDbServiceReadOnly<RecipeCategory>, RecipeCategoryDbService>();
            services.AddTransient<IDbServiceReadOnly<RecipeType>, RecipeTypeDbService>();

            services.AddTransient<IDbServiceReadOnlyCollection, DbServiceReadOnlyCollection>();

            return services;
        }
    }
}
