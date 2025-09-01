using Application.DataService.Interfaces;
using Domain.Measures;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Measuers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasureController : BaseReadOnlyController<Measure>
    {
        public MeasureController(IDataServiceReadOnly<Measure> dataService)
            : base(dataService) { }
    }
}
