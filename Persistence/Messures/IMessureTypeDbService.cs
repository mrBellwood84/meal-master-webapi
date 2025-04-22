using Domain.Messures;

namespace Persistence.Messures
{
    public interface IMessureTypeDbService
    {
        Task<List<MessureType>> GetAll();
    }
}