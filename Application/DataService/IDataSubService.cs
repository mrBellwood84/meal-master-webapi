namespace Application.DataService
{
    public interface IDataSubService<TModel>
    {
        Task<List<TModel>> GetAllAsync();
    }
}