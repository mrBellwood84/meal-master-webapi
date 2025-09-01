using Application.CacheService;
using Application.CacheService.Ingredients;
using Application.CacheService.Interfaces;
using Application.CacheService.Measures;
using Application.CacheService.Misc;
using Application.CacheService.Nutrients;
using Application.CacheService.Recipes;
using Domain.Ingredients;
using Domain.Measures;
using Domain.Misc;
using Domain.Nutrients;
using Domain.Recipes;
using Microsoft.Extensions.Caching.Memory;

namespace API.Extensions
{
    public static class CacheServiceExtension
    {
        public static IServiceCollection AddCacheServices(this IServiceCollection services)
        {
            // Register MemoryCache as a singleton service
            services.AddSingleton<IMemoryCache, MemoryCache>();

            // Register cache services for various entities
            services.AddTransient<ICacheService<Ingredient>, IngredientCache>();
            services.AddTransient<ICacheService<IngredientCategory>, IngredientCategoryCache>();
            services.AddTransient<ICacheService<Measure>, MeasureCache>();
            services.AddTransient<ICacheService<MeasureType>, MeasureTypeCache>();
            services.AddTransient<ICacheService<Nutrient>, NutrientCache>();
            services.AddTransient<ICacheService<NutrientType>, NutrientTypeCache>();
            services.AddTransient<ICacheService<RecipeCategory>, RecipeCategoryCache>();
            services.AddTransient<ICacheService<RecipeType>, RecipeTypeCache>();
            services.AddTransient<ICacheService<SourceType>, SourceTypeCache>();

            // Register a collection of cache services
            services.AddTransient<ICacheServiceCollection, CacheServiceCollection>();

            return services;
        }
    }
}
