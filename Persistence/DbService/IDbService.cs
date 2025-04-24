using Persistence.DbService.Messures;

namespace Persistence.DbService
{
    public interface IDbService
    {
        MessureDbService Messure { get; set; }
        MessureTypeDbService MessureType { get; set; }
    }
}