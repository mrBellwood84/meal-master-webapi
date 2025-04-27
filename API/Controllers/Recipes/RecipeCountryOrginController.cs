using Application.DataService;
using Domain.Recipes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Recipes
{
    [Route("api/recipe/country")]
    public class RecipeCountryOrginController : ReadAllOnlyController<RecipeCountryOrgin>
    {
        public RecipeCountryOrginController(IDataServiceReadAllOnly<RecipeCountryOrgin> dataService) 
            : base(dataService) { }
    }
}
