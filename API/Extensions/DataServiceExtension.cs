using Application.DataService;
using Application.DataService.Ingredients;
using Application.DataService.Ingredients.Interfaces;
using Application.DataService.Interfaces;
using Application.DataService.Measures;
using Application.DataService.Nutrients;
using Application.DataService.Recipes;
using Application.DataService.Recipes.Interfaces;
using Domain.Ingredients;
using Domain.Measures;
using Domain.Nutrients;
using Domain.Recipes;

namespace API.Extensions
{
    public static class DataServiceExtension
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            // ReadOnly Data Services
            services.AddScoped<IDataServiceReadOnly<IngredientCategory>, IngredientCategoryDataService>();
            services.AddScoped<IDataServiceReadOnly<Measure>, MeasureDataService>();
            services.AddScoped<IDataServiceReadOnly<MeasureType>, MeasureTypeDataService>();
            services.AddScoped<IDataServiceReadOnly<Nutrient>, NutrientDataService>();
            services.AddScoped<IDataServiceReadOnly<NutrientType>, NutrientTypeDataService>();
            services.AddScoped<IDataServiceReadOnly<RecipeType>, RecipeTypeDataService>();

            // ReadOnly Collection Data Services
            services.AddScoped<IDataServiceReadOnlyCollection, DataServiceReadOnlyCollection>();

            // Full Data Services
            services.AddScoped<IIngredientDataService, IngredientDataService>();
            services.AddScoped<IRecipeDataService, RecipeDataService>();

            return services;
        }
    }
}
