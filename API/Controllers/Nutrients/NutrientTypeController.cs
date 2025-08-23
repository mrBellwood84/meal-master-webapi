using Application.DataService.Interfaces;
using Domain.Nutrients;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Nutrients
{
    [Route("api/nutrient/type")]
    [ApiController]
    public class NutrientTypeController : BaseReadOnlyDisabled<NutrientType>
    {
        public NutrientTypeController(IDataServiceReadOnly<NutrientType> dataService)
            : base(dataService) { }
    }
}
