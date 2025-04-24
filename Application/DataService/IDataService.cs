using Application.DataService.Messures;

namespace Application.DataService
{
    public interface IDataService
    {
        MessureDataService Messure { get; set; }
        MessureTypeDataService MessureType { get; set; }
    }
}