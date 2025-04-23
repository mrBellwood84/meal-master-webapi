using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Persistence.DbService
{
    public class DbConnection
    {
        private readonly IConfiguration _config;

        public DbConnection(IConfiguration config)
        {
            _config = config;
        }

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(_config.GetConnectionString("DefaultConnection"));
        }
    }
}
