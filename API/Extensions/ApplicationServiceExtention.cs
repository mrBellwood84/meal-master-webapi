using Application.CacheService;
using Persistence.DbService;

namespace API.Extensions
{
    public static class ApplicationServiceExtention
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<ICacheService, CacheService>();
            services.AddTransient<IDbService, DbService>();
            return services;
        }
    }
}
