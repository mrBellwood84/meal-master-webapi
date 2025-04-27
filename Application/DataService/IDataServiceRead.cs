namespace Application.DataService
{
    public interface IDataServiceRead<TModel, TQueryDto>
    {
        Task<List<TModel>> GetAllAsync();
        Task<TModel> GetSingleByIdAsync(string id);
        Task<List<TModel>> GetByQueryAsync(TQueryDto values);
    }
}
