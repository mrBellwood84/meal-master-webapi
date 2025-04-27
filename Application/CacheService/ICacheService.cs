
namespace Application.CacheService
{
    public interface ICacheService<TModel>
    {
        string Key { get; set; }

        void Clear();
        List<TModel>? Get();
        void Set(List<TModel> data);
    }
}