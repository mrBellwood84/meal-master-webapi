using Domain.Messures;

namespace Application.CacheService
{
    public interface ICacheSubService<TModel>
    {
        List<TModel>? Get();
        void Set(List<TModel> messures);
    }
}