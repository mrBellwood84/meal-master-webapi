using Domain.Messures;

namespace Persistence.Messures
{
    public interface IMessureDbService
    {
        Task<List<Messure>> GetAll();
    }
}