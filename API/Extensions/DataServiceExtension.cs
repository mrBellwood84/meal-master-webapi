using Application.DataService;
using Application.DataService.Ingredients;
using Application.DataService.Messures;
using Domain.Ingredients;
using Domain.Messures;

namespace API.Extensions
{
    public static class DataServiceExtension
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            // read only data services
            services.AddScoped<IDataServiceReadOnly<IngredientCategory>, IngredientCategoryDataService>();
            services.AddScoped<IDataServiceReadOnly<Messure>, MessureDataService>();

            services.AddScoped<IDataServiceReadOnlyCollection, DataServiceReadOnlyCollection>();

            // extended data services
            services.AddScoped<IIngredientDataService, IngredientDataService>();



            return services;
        }
    }
}
