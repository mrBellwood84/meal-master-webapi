namespace Persistence.DbService
{
    public interface IDbServiceReadOnly<TModel>
    {
        Task<List<TModel>> GetAllAsync();
    }
}