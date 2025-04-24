using Application.CacheService.Messures;

namespace Application.CacheService
{
    public interface ICacheService
    {
        MessureCache MessureCache { get; set; }
        MessureTypeCache MessureTypeCache { get; set; }
    }
}