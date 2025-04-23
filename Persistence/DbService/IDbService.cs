using Persistence.DbService.Messures;

namespace Persistence.DbService
{
    public interface IDbService
    {
        MessureDbService MessureDbService { get; set; }
        MessureTypeDbService MessureTypeDbService { get; set; }
    }
}