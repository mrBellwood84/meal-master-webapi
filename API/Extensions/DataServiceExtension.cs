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
            services.AddScoped<IDataServiceReadAllOnly<IngredientCategory>, IngredientCategoryDataService>();

            services.AddScoped<IDataServiceReadAllOnly<Messure>, MessureDataService>();
            services.AddScoped<IDataServiceReadAllOnly<MessureType>, MessureTypeDataService>();

            services.AddScoped<IDataServiceReadAllOnly<NutrientType>, NutrientTypeDataService>();

            services.AddScoped<IDataServiceReadAllOnly<RecipeCategory>, RecipeCategoryDataService>();
            services.AddScoped<IDataServiceReadAllOnly<RecipeContinentOrgin>, RecipeContinentOrginDataService>();
            services.AddScoped<IDataServiceReadAllOnly<RecipeCountryOrgin>, RecipeCountryOrginDataService>();

            return services;
        }
    }
}
