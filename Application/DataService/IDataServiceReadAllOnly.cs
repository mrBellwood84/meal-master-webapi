
namespace Application.DataService
{
    public interface IDataServiceReadAllOnly<TModel>
    {
        Task<List<TModel>> GetAllAsync();
    }
}