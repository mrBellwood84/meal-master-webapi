using Domain.Messures;
using Persistence.QueryModels;

namespace Persistence.DbService
{
    public interface IDbQuery<TModel, TQuery>
    {
        Task<List<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(string id);
        Task<List<TModel>> QueryAsync(TQuery queryData);
    }
}