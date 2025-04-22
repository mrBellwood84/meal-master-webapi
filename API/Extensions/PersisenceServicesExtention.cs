using Persistence.DbService;
using Persistence.Messures;

namespace API.Extensions
{
    public static class PersisenceServicesExtention
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddSingleton<IDbConnection, DbConnection>();

            services.AddTransient<IMessureDbService, MessureDbService>();
            services.AddTransient<IMessureTypeDbService, MessureTypeDbService>();

            return services;
        }
    }
}
