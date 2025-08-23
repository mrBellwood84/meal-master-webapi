using Application.DataService.Interfaces;
using Domain.Ingredients;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Ingredients
{
    [Route("api/ingredient/category")]
    [ApiController]
    public class IngredientCategoryController : BaseReadOnlyController<IngredientCategory>
    {
        public IngredientCategoryController(IDataServiceReadOnly<IngredientCategory> dataService)
            : base(dataService) { }
    }
}
