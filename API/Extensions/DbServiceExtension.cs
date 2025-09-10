using Domain.Ingredients;
using Domain.Measures;
using Domain.Nutrients;
using Domain.Recipes;
using Persistence.DbService;
using Persistence.DbService.Ingredients;
using Persistence.DbService.Measures;
using Persistence.DbServices.Ingredients;
using Persistence.DbServices.Ingredients.Interfaces;
using Persistence.DbServices.Interfaces;
using Persistence.DbServices.Measures;
using Persistence.DbServices.Nutrients;
using Persistence.DbServices.Recipes;

namespace API.Extensions
{
    /// <summary>
    /// Provides extension methods for registering database-related services in an <see cref="IServiceCollection"/>.
    /// </summary>
    /// <remarks>This class contains methods to simplify the registration of database service dependencies in
    /// the application's dependency injection container. Use the <see cref="AddDbServices(IServiceCollection)"/> method
    /// to register all required database services.</remarks>
    public static class DbServiceExtension
    {
        public static IServiceCollection AddDbServices(this IServiceCollection services)
        {
            // Register read-only database services for various entities
            services.AddTransient<IDbServiceReadOnly<IngredientCategory>, IngredientCategoryDbService>();
            services.AddTransient<IDbServiceReadOnly<Measure>, MeasureDbService>();
            services.AddTransient<IDbServiceReadOnly<MeasureType>, MeasureTypeDbService>();
            services.AddTransient<IDbServiceReadOnly<Nutrient>, NutrientDbService>();
            services.AddTransient<IDbServiceReadOnly<NutrientType>, NutrientTypeDbService>();
            services.AddTransient<IDbServiceReadOnly<RecipeType>, RecipeTypeDbService >();

            // Register a collection of read-only database services
            services.AddTransient<IDbServiceReadOnlyCollection, DbServiceReadOnlyCollection>();

            // Register database services 
            services.AddTransient<IIngredientDbService, IngredientDbService>();

            return services;
        }
    }
}
