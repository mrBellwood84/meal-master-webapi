namespace Persistence.DbServices.Interfaces
{
    /// <summary>
    /// Defines a read-only service for retrieving database entities of type <typeparamref name="TModel"/>.
    /// </summary>
    /// <typeparam name="TModel">The type of the database entity managed by the service.</typeparam>
    public interface IDbServiceReadOnly<TModel>
    {
        Task<List<TModel>> GetAllAsync();
    }
}