using Domain.Ingredients;

namespace Persistence.DbService
{
    public interface IDbServiceReadAllOnly<TModel>
    {
        Task<List<TModel>> GetAllAsync();
    }
}