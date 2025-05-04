using Application.DataService;
using Application.DataService.Ingredients;
using Application.DataService.Messures;
using Application.DataService.Nutrients;
using Application.DataService.Recipes;
using Domain.Ingredients;
using Domain.Messures;
using Domain.Nutrients;
using Domain.Recipes;

namespace API.Extensions
{
    public static class DataServiceExtension
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            // read only data services
            services.AddScoped<IDataServiceReadOnly<IngredientCategory>, IngredientCategoryDataService>();
            services.AddScoped<IDataServiceReadOnly<Messure>, MessureDataService>();
            services.AddScoped<IDataServiceReadOnly<NutrientType>, NutrientTypeDataService>();
            services.AddScoped<IDataServiceReadOnly<RecipeCategory>, RecipeCategoryDataService>();
            services.AddScoped<IDataServiceReadOnly<RecipeType>, RecipeTypeDataService>();

            services.AddScoped<IDataServiceReadOnlyCollection, DataServiceReadOnlyCollection>();



            return services;
        }
    }
}
