using Domain.Nutrients;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbServices.Nutrients
{
    /// <summary>
    /// Provides database access functionality for retrieving nutrient type data.
    /// </summary>
    public class NutrientTypeDbService : DbServiceReadOnly<NutrientType>
    {
        public NutrientTypeDbService(IConfiguration config) : base(config)
        {
            Query = "CALL NutrientTypeSelectAll()";
        }
    }
}
