using Application.DataService.Interfaces;
using Domain.Nutrients;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Nutrients
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutrientController : BaseReadOnlyController<Nutrient>
    {
        public NutrientController(IDataServiceReadOnly<Nutrient> dataService)
            : base(dataService) { }
    }
}
