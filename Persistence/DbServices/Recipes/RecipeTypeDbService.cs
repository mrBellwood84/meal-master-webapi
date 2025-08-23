using Domain.Recipes;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbServices.Recipes
{
    /// <summary>
    /// Provides read-only database access for recipe types.
    /// </summary>
    public class RecipeTypeDbService : DbServiceReadOnly<RecipeType>
    {
        public RecipeTypeDbService(IConfiguration config) : base(config)
        {
            Query = "CALL RecipeTypeSelectAll()";
        }
    }
}
