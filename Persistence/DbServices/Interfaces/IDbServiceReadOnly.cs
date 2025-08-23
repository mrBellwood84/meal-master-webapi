namespace Persistence.DbServices.Interfaces
{
    public interface IDbServiceReadOnly<TModel>
    {
        Task<List<TModel>> GetAllAsync();
    }
}