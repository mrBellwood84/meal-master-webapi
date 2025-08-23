using Application.DataService;
using Application.DataService.Ingredients;
using Application.DataService.Ingredients.Interfaces;
using Application.DataService.Interfaces;
using Application.DataService.Messures;
using Domain.Ingredients;
using Domain.Messures;

namespace API.Extensions
{
    public static class DataServiceExtension
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<IDataServiceReadOnly<IngredientCategory>, IngredientCategoryDataService>();
            services.AddScoped<IDataServiceReadOnly<Messure>, MessureDataService>();
            services.AddScoped<IDataServiceReadOnly<MessureType>, MessureTypeDataService>();

            services.AddScoped<IDataServiceReadOnlyCollection, DataServiceReadOnlyCollection>();

            services.AddScoped<IIngredientDataService, IngredientDataService>();

            return services;
        }
    }
}
