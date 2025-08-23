using Domain.Ingredients;
using Microsoft.Extensions.Configuration;
using Persistence.DbServices;

namespace Persistence.DbService.Ingredients
{
    public class IngredientCategoryDbService : DbServiceReadOnly<IngredientCategory>
    {
        public IngredientCategoryDbService(IConfiguration config) : base(config)
        {
            Query = "CALL IngredientCategorySelectAll()";
        }
    }
}
