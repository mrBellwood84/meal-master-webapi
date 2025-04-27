namespace Application.DataService
{
    public interface IDataServiceWrite<TCreateDto, TUpdateDto>
    {
        Task Create(TCreateDto dto);
        Task Update(TUpdateDto dto);
        Task Delete(string id);
    }
}
