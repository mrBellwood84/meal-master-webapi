using Persistence.DbService;

namespace Persistence
{
    public class BaseDbService
    {
        internal readonly IDbConnection _connection;

        public BaseDbService(IDbConnection connection)
        {
            _connection = connection;
        }
    }
}
