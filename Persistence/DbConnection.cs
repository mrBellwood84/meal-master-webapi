using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Persistence.DbService
{
    public class DbConnection : IDbConnection
    {
        private readonly string _connectionString;

        public DbConnection(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
