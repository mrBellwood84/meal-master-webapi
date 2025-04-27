using Application.DataService;
using Domain.Nutrients;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Nutritions
{
    [Route("api/nutrient/type")]
    public class NutrientTypeController : ReadAllOnlyController<NutrientType>
    {
        public NutrientTypeController(IDataServiceReadAllOnly<NutrientType> dataService) 
            : base(dataService) { }
    }
}
