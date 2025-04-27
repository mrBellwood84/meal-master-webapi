using Application.DataService;
using Application.DataService.Recipes;
using Domain.Recipes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Recipes
{
    [Route("api/recipe/continent")]
    public class RecipeContinentOrginController : ReadAllOnlyController<RecipeContinentOrgin>
    {
        public RecipeContinentOrginController(IDataServiceReadAllOnly<RecipeContinentOrgin> dataService) 
            : base(dataService) { }
    }
}
