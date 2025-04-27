using Application.DataService;
using Domain.Ingredients;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Ingredients
{
    [Route("api/ingredient/category")]
    public class IngredientCategoryController : ReadAllOnlyController<IngredientCategory>
    {
        public IngredientCategoryController(IDataServiceReadAllOnly<IngredientCategory> dataService) 
            : base(dataService) { }
    }
}
