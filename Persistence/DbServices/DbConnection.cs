using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Persistence.DbService
{
    /// <summary>
    /// Represents a utility for managing database connections using configuration settings.
    /// </summary>
    /// <remarks>This class provides functionality to create database connections using connection strings
    /// defined in the application's configuration. It is designed to simplify the process of initializing database
    /// connections by abstracting the retrieval of connection strings.</remarks>
    public class DbConnection
    {
        private readonly IConfiguration _config;

        public DbConnection(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Creates and returns a new MySQL database connection using the configured connection string.
        /// </summary>
        /// <returns>A <see cref="MySqlConnection"/> instance initialized with the connection string. The caller is responsible
        /// for opening, using, and disposing of the connection.</returns>
        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(_config.GetConnectionString("DefaultConnection"));
        }
    }
}
