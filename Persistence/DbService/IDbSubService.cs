using Domain.Messures;

namespace Persistence.DbService
{
    public interface IDbSubService<TModel>
    {
        Task<List<TModel>> GetAllAsync();

    }
}