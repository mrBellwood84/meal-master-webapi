using Application.CacheService;
using Application.CacheService.Ingredients;
using Application.CacheService.Messures;
using Domain.Ingredients;
using Domain.Messures;
using Microsoft.Extensions.Caching.Memory;

namespace API.Extensions
{
    public static class CacheServiceExtension
    {
        public static IServiceCollection AddCacheServices(this IServiceCollection services)
        {
            services.AddSingleton<IMemoryCache, MemoryCache>();

            services.AddTransient<ICacheService<Ingredient>, IngredientCache>();
            services.AddTransient<ICacheService<IngredientCategory>, IngredientCategoryCache>();
            services.AddTransient<ICacheService<Messure>, MessureCache>();

            services.AddTransient<ICacheServiceCollection, CacheServiceCollection>();

            return services;
        }
    }
}
