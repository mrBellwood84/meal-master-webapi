using Domain.Measures;
using Microsoft.Extensions.Configuration;
using Persistence.DbServices;

namespace Persistence.DbService.Measures
{
    /// <summary>
    /// Provides database access functionality for retrieving <see cref="Measure"/> entities in a read-only manner.
    /// </summary>
    public class MeasureDbService : DbServiceReadOnly<Measure>
    {
        public MeasureDbService(IConfiguration config) : base(config)
        {
            Query = "CALL MeasureSelectAll()";
        }
    }
}
