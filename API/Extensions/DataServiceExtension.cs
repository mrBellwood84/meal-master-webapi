using Application.DataService;
using Application.DataService.Ingredients;
using Application.DataService.Ingredients.Interfaces;
using Application.DataService.Interfaces;
using Application.DataService.Messures;
using Application.DataService.Misc;
using Application.DataService.Nutrients;
using Application.DataService.Recipes;
using Domain.Ingredients;
using Domain.Messures;
using Domain.Misc;
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
            services.AddScoped<IDataServiceReadOnly<Messure>, MessureDataService>();
            services.AddScoped<IDataServiceReadOnly<MessureType>, MessureTypeDataService>();
            services.AddScoped<IDataServiceReadOnly<Nutrient>, NutrientDataService>();
            services.AddScoped<IDataServiceReadOnly<NutrientType>, NutrientTypeDataService>();
            services.AddScoped<IDataServiceReadOnly<RecipeCategory>, RecipeCategoryDataService>();
            services.AddScoped<IDataServiceReadOnly<RecipeType>, RecipeTypeDataService>();
            services.AddScoped<IDataServiceReadOnly<SourceType>, SourceTypeDataService>();

            // ReadOnly Collection Data Services
            services.AddScoped<IDataServiceReadOnlyCollection, DataServiceReadOnlyCollection>();

            // Full Data Services
            services.AddScoped<IIngredientDataService, IngredientDataService>();

            return services;
        }
    }
}
