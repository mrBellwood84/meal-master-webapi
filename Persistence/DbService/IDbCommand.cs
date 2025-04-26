namespace Persistence.DbService
{
    public interface IDbCrudService<TQueryValues, TCreate, TUpdate>
    {
        Task CreateAsync(TCreate data);
        Task UpdateAsync(TUpdate data);
        Task DeleteAsync(string id);
    }
}