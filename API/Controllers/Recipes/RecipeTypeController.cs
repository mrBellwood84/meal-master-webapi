using Application.DataService.Interfaces;
using Domain.Recipes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Recipes
{
    [Route("api/recipe/type")]
    [ApiController]
    public class RecipeTypeController : BaseReadOnlyController<RecipeType>
    {
        public RecipeTypeController(IDataServiceReadOnly<RecipeType> dataService)
            : base(dataService) { }
    }
}
