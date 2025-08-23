using Domain.Recipes;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbServices.Recipes
{
    /// <summary>
    /// Provides database access functionality for retrieving recipe category data.
    /// </summary>
    public class RecipeCategoryDbService : DbServiceReadOnly<RecipeCategory>
    {
        public RecipeCategoryDbService(IConfiguration config) : base(config)
        {
            Query = "CALL RecipeCategorySelectAll()";
        }
    }
}
