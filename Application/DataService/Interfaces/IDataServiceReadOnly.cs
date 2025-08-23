namespace Application.DataService.Interfaces
{
    public interface IDataServiceReadOnly<TModel>
    {
        Task<List<TModel>> GetAllAsync();
    }
}