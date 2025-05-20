using Domain.Ingredients;
using Domain.Messures;
using Persistence.DbService;
using Persistence.DbService.Ingredients;
using Persistence.DbService.Messures;
using Persistence.DbServices.Ingredients;

namespace API.Extensions
{
    public static class DbServiceExtension
    {
        public static IServiceCollection AddDbServices(this IServiceCollection services)
        {
            // Read only db services
            services.AddTransient<IDbServiceReadOnly<IngredientCategory>, IngredientCategoryDbService>();
            services.AddTransient<IDbServiceReadOnly<Messure>, MessureDbService>();

            services.AddTransient<IDbServiceReadOnlyCollection, DbServiceReadOnlyCollection>();

            // Extended Readonly Db Services
            services.AddTransient<IIngredientDbService, IngredientDbService>();

            return services;
        }
    }
}
