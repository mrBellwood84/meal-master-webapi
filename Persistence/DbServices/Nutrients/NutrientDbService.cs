using Domain.Nutrients;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbServices.Nutrients
{
    /// <summary>
    /// Provides read-only access to nutrient data from the database.
    /// </summary>
    public class NutrientDbService : DbServiceReadOnly<Nutrient>
    {
        public NutrientDbService(IConfiguration config) : base(config)
        {
            Query = "CALL NutrientSelectAll()";
        }
    }
}
