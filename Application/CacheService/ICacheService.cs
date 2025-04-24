using Application.CacheService.Messures;

namespace Application.CacheService
{
    public interface ICacheService
    {
        MessureCache Messure { get; set; }
        MessureTypeCache MessureType { get; set; }
    }
}