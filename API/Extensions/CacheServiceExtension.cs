using Application.CacheService;
using Application.CacheService.Ingredients;
using Application.CacheService.Messures;
using Application.CacheService.Nutrients;
using Application.CacheService.Recipes;
using Domain.Ingredients;
using Domain.Messures;
using Domain.Nutrients;
using Domain.Recipes;
using Microsoft.Extensions.Caching.Memory;

namespace API.Extensions
{
    public static class CacheServiceExtension
    {
        public static IServiceCollection AddCacheServices(this IServiceCollection services)
        {
            services.AddSingleton<IMemoryCache, MemoryCache>();

            services.AddTransient<ICacheService<IngredientCategory>, IngredientCategoryCache>();
            services.AddTransient<ICacheService<Messure>, MessureCache>();
            services.AddTransient<ICacheService<NutrientType>, NutrientTypeCache>();
            services.AddTransient<ICacheService<RecipeCategory>, RecipeCategoryCache>();
            services.AddTransient<ICacheService<RecipeType>, RecipeTypeCache>();

            services.AddTransient<ICacheServiceCollection, CacheServiceCollection>();

            return services;
        }
    }
}
