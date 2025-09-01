using Domain.Measures;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbServices.Measures
{
    /// <summary>
    /// Provides database access functionality for retrieving measurement type data.
    /// </summary>
    public class MeasureTypeDbService : DbServiceReadOnly<MeasureType>
    {
        public MeasureTypeDbService(IConfiguration config) : base(config)
        {
            Query = "CALL MeasureTypeSelectAll()";
        }
    }
}

