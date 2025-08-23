using Dapper;
using Microsoft.Extensions.Configuration;
using Persistence.DbService;
using Persistence.DbServices.Interfaces;

namespace Persistence.DbServices
{
    /// <summary>
    /// Provides a read-only database service for querying data of type <typeparamref name="TModel"/>.
    /// </summary>
    /// <remarks>This class is designed for scenarios where read-only access to a database is required. It
    /// allows querying all records of the specified model type using the configured query. The query must be set before
    /// calling <see cref="GetAllAsync"/>; otherwise, an exception will be thrown.</remarks>
    /// <typeparam name="TModel">The type of the model representing the database records.</typeparam>
    public class DbServiceReadOnly<TModel> : DbConnection, IDbServiceReadOnly<TModel>
    {
        /// <summary>
        /// Gets the query string associated with the current operation.
        /// </summary>
        internal string Query { get; init; } = string.Empty;

        public DbServiceReadOnly(IConfiguration config) : base(config) { }

        /// <summary>
        /// Retrieves all records matching the specified query asynchronously.
        /// </summary>
        /// name="TModel"/>. If no records match the query, the returned list will be empty.</returns>
        /// <exception cref="MissingFieldException">Thrown if the <c>Query</c> property is null or empty.</exception>
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
