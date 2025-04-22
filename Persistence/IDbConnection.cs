using MySql.Data.MySqlClient;

namespace Persistence.DbService
{
    public interface IDbConnection
    {
        MySqlConnection CreateConnection();
    }
}