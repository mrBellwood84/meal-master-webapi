using Application.DataService;
using Domain.Recipes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Recipes
{
    [Route("api/recipe/category")]
    public class RecipeCategoryController : ReadAllOnlyController<RecipeCategory>
    {
        public RecipeCategoryController(IDataServiceReadAllOnly<RecipeCategory> dataService) 
            : base(dataService) { }
    }
}
