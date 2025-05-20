namespace Application.DataService
{
    public interface IDataServiceReadOnly<TModel>
    {
        Task<List<TModel>> GetAllAsync();
    }
}