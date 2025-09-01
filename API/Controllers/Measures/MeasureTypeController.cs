using Application.DataService.Interfaces;
using Domain.Measures;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Measures
{
    [Route("api/measure/type")]
    [ApiController]
    public class MeasureTypeController : BaseReadOnlyDisabled<MeasureType>
    {
        public MeasureTypeController(IDataServiceReadOnly<MeasureType> dataService)
            : base(dataService) { }
    }
}
