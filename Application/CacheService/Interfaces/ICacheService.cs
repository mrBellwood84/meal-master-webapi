namespace Application.CacheService.Interfaces
{
    public interface ICacheService<TModel>
    {
        string Key { get; }

        void Clear();
        List<TModel>? Get();
        void Set(List<TModel> data);
    }
}