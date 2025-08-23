using Domain.Ingredients;
using Domain.Messures;
using Persistence.DbService;
using Persistence.DbService.Ingredients;
using Persistence.DbService.Messures;
using Persistence.DbServices.Ingredients;
using Persistence.DbServices.Ingredients.Interfaces;
using Persistence.DbServices.Interfaces;
using Persistence.DbServices.Messures;

namespace API.Extensions
{
    public static class DbServiceExtension
    {
        public static IServiceCollection AddDbServices(this IServiceCollection services)
        {
            services.AddTransient<IDbServiceReadOnly<IngredientCategory>, IngredientCategoryDbService>();
            services.AddTransient<IDbServiceReadOnly<Messure>, MessureDbService>();
            services.AddTransient<IDbServiceReadOnly<MessureType>, MessureTypeDbService>();

            services.AddTransient<IDbServiceReadOnlyCollection, DbServiceReadOnlyCollection>();

            services.AddTransient<IIngredientDbService, IngredientDbService>();

            return services;
        }
    }
}
