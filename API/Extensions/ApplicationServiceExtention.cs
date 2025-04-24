using Application.CacheService;
using Application.DataService;
using Persistence.DbService;

namespace API.Extensions
{
    public static class ApplicationServiceExtention
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<ICacheService, CacheService>();
            services.AddTransient<IDbService, DbService>();
            services.AddScoped<IDataService, DataService>();
            return services;
        }
    }
}
