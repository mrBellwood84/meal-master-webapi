using Application.DataService.Interfaces;
using Domain.Recipes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Recipes
{
    [Route("api/recipe/category")]
    [ApiController]
    public class RecipeCategoryController : BaseReadOnlyController<RecipeCategory>
    {
        public RecipeCategoryController(IDataServiceReadOnly<RecipeCategory> dataService)
            : base(dataService) { }
    }
}
