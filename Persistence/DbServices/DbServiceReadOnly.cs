using Dapper;
using Microsoft.Extensions.Configuration;
using Persistence.DbService;
using Persistence.DbServices.Interfaces;

namespace Persistence.DbServices
{
    public class DbServiceReadOnly<TModel> : DbConnection, IDbServiceReadOnly<TModel>
    {
        internal string Query { get; init; } = string.Empty;

        public DbServiceReadOnly(IConfiguration config) : base(config) { }

        public async Task<List<TModel>> GetAllAsync()
        {
            if (string.IsNullOrEmpty(Query))
                throw new MissingFieldException("Query is not set.");

            using var conn = CreateConnection();
            var result = await conn.QueryAsync<TModel>(Query);
            return result as List<TModel>;
        }
    }
}
